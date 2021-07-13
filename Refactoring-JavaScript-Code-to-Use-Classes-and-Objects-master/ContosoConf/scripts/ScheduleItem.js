import { HtmlTemplate } from './HtmlTemplate.js';
import { parseTimeAsTotalMinutes } from './datetime.js';

export class ScheduleItem {
    constructor(data, localStarStorage) {
        this.id = data.id;
        this.tracks = data.tracks;
        this.localStarStorage = localStarStorage;
        this.scheduleItemTemplate = new HtmlTemplate("schedule-item");
        this.starredClass = "starred",

            this.element = this.scheduleItemTemplate.createElement(data);

        if (localStarStorage.isStarred(this.id)) {
            this.element.classList.add(this.starredClass);
        }

        this.initializeElementClass();
        this.initializeElementPosition(data.start, data.end);
        this.addStarClickEventHandler();
    }


    initializeElementClass() {
        if (this.isInTrack(1) && this.isInTrack(2)) {
            this.element.classList.add("both-tracks");
        } else if (this.isInTrack(1)) {
            this.element.classList.add("track-1");
        } else if (this.isInTrack(2)) {
            this.element.classList.add("track-2");
        }
    }

    initializeElementPosition(start, end) {
        const startTimeInMinutes = parseTimeAsTotalMinutes(start);
        const endTimeInMinutes = parseTimeAsTotalMinutes(end);
        const pixelsPerMinute = 2;
        const conferenceStartTimeInMinutes = 8 * 60 + 30;
        this.element.style.top = pixelsPerMinute * (startTimeInMinutes - conferenceStartTimeInMinutes) + "px";
        this.element.style.height = pixelsPerMinute * (endTimeInMinutes - startTimeInMinutes) + "px";
    }

    addStarClickEventHandler() {
        const starElement = this.element.querySelector(".star");
        starElement.addEventListener("click", this.toggleStar.bind(this), false);
    }

    isInTrack(track) {
        return this.tracks.indexOf(track) >= 0;
    }


    toggleStar() {
        if (this.isStarred()) {
            this.unsetStar();
        } else {
            this.setStar();
        }
    }

    isStarred() {
        return this.element.classList.contains(this.starredClass);
    }

    unsetStar() {
        this.element.classList.remove(this.starredClass);
        this.postStarChange(false);
        this.localStarStorage.removeStar(this.id);
    }

    setStar() {
        this.element.classList.add(this.starredClass);
        this.postStarChange(true);
        this.localStarStorage.addStar(this.id);
    }

    async postStarChange(isStarred) {
        const headers = new Headers({
            "Content-Type": "application/x-www-form-urlencoded"
        })

        const options = {
            method: 'POST',
            headers: headers,
            body: "starred=" + isStarred
        }

        const response = await fetch("/schedule/star/" + this.id, options);

        if (isStarred) {
            if (response.ok) {
                const data = await response.json();
                this.updateStarCount(data.starCount);
                if (data.starCount > 50)
                    alert("This session is very popular! Be sure to arrive early to get a seat.");
            }
        }
    }

    updateStarCount(starCount) {
        const starCountElement = this.element.querySelector(".star-count");
        starCountElement.textContent = starCount.toString();
    }

    show() {
        this.element.style.display = "block";
    }

    hide() {
        this.element.style.display = "none";
    }
}
// SIG // Begin signature block
// SIG // MIIdjAYJKoZIhvcNAQcCoIIdfTCCHXkCAQExCzAJBgUr
// SIG // DgMCGgUAMGcGCisGAQQBgjcCAQSgWTBXMDIGCisGAQQB
// SIG // gjcCAR4wJAIBAQQQEODJBs441BGiowAQS9NQkAIBAAIB
// SIG // AAIBAAIBAAIBADAhMAkGBSsOAwIaBQAEFNU6a9IB/++Y
// SIG // BBQEOWgmek55fdm2oIIYajCCBNowggPCoAMCAQICEzMA
// SIG // AAEEZIjZOXzzlscAAAAAAQQwDQYJKoZIhvcNAQEFBQAw
// SIG // dzELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0
// SIG // b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1p
// SIG // Y3Jvc29mdCBDb3Jwb3JhdGlvbjEhMB8GA1UEAxMYTWlj
// SIG // cm9zb2Z0IFRpbWUtU3RhbXAgUENBMB4XDTE4MDgyMzIw
// SIG // MjAyNFoXDTE5MTEyMzIwMjAyNFowgcoxCzAJBgNVBAYT
// SIG // AlVTMQswCQYDVQQIEwJXQTEQMA4GA1UEBxMHUmVkbW9u
// SIG // ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9u
// SIG // MS0wKwYDVQQLEyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVy
// SIG // YXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRoYWxlcyBU
// SIG // U1MgRVNOOjhENDEtNEJGNy1CM0I3MSUwIwYDVQQDExxN
// SIG // aWNyb3NvZnQgVGltZS1TdGFtcCBzZXJ2aWNlMIIBIjAN
// SIG // BgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtYKvnLt9
// SIG // qahxQlTQQK06Gn4pyBrYoIFu7hoaYBApayHZp6U+CtM9
// SIG // 0v+dD0wvHq1Nay7JoTNqUy+kT0Y7UwaAnkMr3PPVWipg
// SIG // F9PvaBhV0kVTnoJspkvTuttc/8DFLNYSmlyki5uuOnGn
// SIG // 255I/G29CaCgYmB9tQexB2KNVwG+U7bo0zzTFDfGTTNC
// SIG // r7CNkXg/NqOTTwsitiJmmUBhlQCGMFCN3DfZxgs2cSyF
// SIG // P7fX2j2PEvwy6oyT5orw1Zu7+rmHktzrN2A1VNZB/aTX
// SIG // kSQN1BMlu5QZmQvuFUas9PQTDiAUSNunDUVuo13lVkJ+
// SIG // RBpbYmRTwH19TwJ+Po8JtI5DQwIDAQABo4IBCTCCAQUw
// SIG // HQYDVR0OBBYEFBV38d8JK1DmvptUSfd8N7fwERS5MB8G
// SIG // A1UdIwQYMBaAFCM0+NlSRnAK7UD7dvuzK7DDNbMPMFQG
// SIG // A1UdHwRNMEswSaBHoEWGQ2h0dHA6Ly9jcmwubWljcm9z
// SIG // b2Z0LmNvbS9wa2kvY3JsL3Byb2R1Y3RzL01pY3Jvc29m
// SIG // dFRpbWVTdGFtcFBDQS5jcmwwWAYIKwYBBQUHAQEETDBK
// SIG // MEgGCCsGAQUFBzAChjxodHRwOi8vd3d3Lm1pY3Jvc29m
// SIG // dC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdFRpbWVTdGFt
// SIG // cFBDQS5jcnQwEwYDVR0lBAwwCgYIKwYBBQUHAwgwDQYJ
// SIG // KoZIhvcNAQEFBQADggEBACY/+knF9AhvM/eiYr2ZvLlu
// SIG // V36X8KeOxAsZ14chJ2GS7L4JOw2LMApJxBPgkYsmHIRy
// SIG // YHd5Mg+28dliQIr/wzNNpZerMLCDB4TN0O1lV+Ivyvhz
// SIG // 4h0dU0YyuYhPVX72aQHueWSGqkiir5b7Ka9WP1H7mMAl
// SIG // MmSd0eWQhYF5/XStrHm3D4SoC/Orekbqecc/BCd2TuTw
// SIG // dTbta6fkMoaHbogxNWal2XkB8FuBG/YEIR8a5vRo8LVn
// SIG // DGj2FiD/5O+TU0gbwWe0WCILjqGfbP7jqfutbPRXKGZj
// SIG // 9Ow3LpKCALkADovVPvIrhqKzRK5a5m+nKSmjpp8/RZpS
// SIG // a1jpgQ3Wq2wwggX/MIID56ADAgECAhMzAAABA14lHJkf
// SIG // ox64AAAAAAEDMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNV
// SIG // BAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYD
// SIG // VQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQg
// SIG // Q29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBD
// SIG // b2RlIFNpZ25pbmcgUENBIDIwMTEwHhcNMTgwNzEyMjAw
// SIG // ODQ4WhcNMTkwNzI2MjAwODQ4WjB0MQswCQYDVQQGEwJV
// SIG // UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
// SIG // UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
// SIG // cmF0aW9uMR4wHAYDVQQDExVNaWNyb3NvZnQgQ29ycG9y
// SIG // YXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEK
// SIG // AoIBAQDRlHY25oarNv5p+UZ8i4hQy5Bwf7BVqSQdfjnn
// SIG // BZ8PrHuXss5zCvvUmyRcFrU53Rt+M2wR/Dsm85iqXVNr
// SIG // qsPsE7jS789Xf8xly69NLjKxVitONAeJ/mkhvT5E+94S
// SIG // nYW/fHaGfXKxdpth5opkTEbOttU6jHeTd2chnLZaBl5H
// SIG // hvU80QnKDT3NsumhUHjRhIjiATwi/K+WCMxdmcDt66Va
// SIG // mJL1yEBOanOv3uN0etNfRpe84mcod5mswQ4xFo8ADwH+
// SIG // S15UD8rEZT8K46NG2/YsAzoZvmgFFpzmfzS/p4eNZTkm
// SIG // yWPU78XdvSX+/Sj0NIZ5rCrVXzCRO+QUauuxygQjAgMB
// SIG // AAGjggF+MIIBejAfBgNVHSUEGDAWBgorBgEEAYI3TAgB
// SIG // BggrBgEFBQcDAzAdBgNVHQ4EFgQUR77Ay+GmP/1l1jjy
// SIG // A123r3f3QP8wUAYDVR0RBEkwR6RFMEMxKTAnBgNVBAsT
// SIG // IE1pY3Jvc29mdCBPcGVyYXRpb25zIFB1ZXJ0byBSaWNv
// SIG // MRYwFAYDVQQFEw0yMzAwMTIrNDM3OTY1MB8GA1UdIwQY
// SIG // MBaAFEhuZOVQBdOCqhc3NyK1bajKdQKVMFQGA1UdHwRN
// SIG // MEswSaBHoEWGQ2h0dHA6Ly93d3cubWljcm9zb2Z0LmNv
// SIG // bS9wa2lvcHMvY3JsL01pY0NvZFNpZ1BDQTIwMTFfMjAx
// SIG // MS0wNy0wOC5jcmwwYQYIKwYBBQUHAQEEVTBTMFEGCCsG
// SIG // AQUFBzAChkVodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20v
// SIG // cGtpb3BzL2NlcnRzL01pY0NvZFNpZ1BDQTIwMTFfMjAx
// SIG // MS0wNy0wOC5jcnQwDAYDVR0TAQH/BAIwADANBgkqhkiG
// SIG // 9w0BAQsFAAOCAgEAn/XJUw0/DSbsokTYDdGfY5YGSz8e
// SIG // XMUzo6TDbK8fwAG662XsnjMQD6esW9S9kGEX5zHnwya0
// SIG // rPUn00iThoj+EjWRZCLRay07qCwVlCnSN5bmNf8MzsgG
// SIG // FhaeJLHiOfluDnjYDBu2KWAndjQkm925l3XLATutghIW
// SIG // IoCJFYS7mFAgsBcmhkmvzn1FFUM0ls+BXBgs1JPyZ6vi
// SIG // c8g9o838Mh5gHOmwGzD7LLsHLpaEk0UoVFzNlv2g24HY
// SIG // tjDKQ7HzSMCyRhxdXnYqWJ/U7vL0+khMtWGLsIxB6aq4
// SIG // nZD0/2pCD7k+6Q7slPyNgLt44yOneFuybR/5WcF9ttE5
// SIG // yXnggxxgCto9sNHtNr9FB+kbNm7lPTsFA6fUpyUSj+Z2
// SIG // oxOzRVpDMYLa2ISuubAfdfX2HX1RETcn6LU1hHH3V6qu
// SIG // +olxyZjSnlpkdr6Mw30VapHxFPTy2TUxuNty+rR1yIib
// SIG // ar+YRcdmstf/zpKQdeTr5obSyBvbJ8BblW9Jb1hdaSre
// SIG // U0v46Mp79mwV+QMZDxGFqk+av6pX3WDG9XEg9FGomsrp
// SIG // 0es0Rz11+iLsVT9qGTlrEOlaP470I3gwsvKmOMs1jaqY
// SIG // WSRAuDpnpAdfoP7YO0kT+wzh7Qttg1DO8H8+4NkI6Iwh
// SIG // SkHC3uuOW+4Dwx1ubuZUNWZncnwa6lL2IsRyP64wggYH
// SIG // MIID76ADAgECAgphFmg0AAAAAAAcMA0GCSqGSIb3DQEB
// SIG // BQUAMF8xEzARBgoJkiaJk/IsZAEZFgNjb20xGTAXBgoJ
// SIG // kiaJk/IsZAEZFgltaWNyb3NvZnQxLTArBgNVBAMTJE1p
// SIG // Y3Jvc29mdCBSb290IENlcnRpZmljYXRlIEF1dGhvcml0
// SIG // eTAeFw0wNzA0MDMxMjUzMDlaFw0yMTA0MDMxMzAzMDla
// SIG // MHcxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5n
// SIG // dG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
// SIG // aWNyb3NvZnQgQ29ycG9yYXRpb24xITAfBgNVBAMTGE1p
// SIG // Y3Jvc29mdCBUaW1lLVN0YW1wIFBDQTCCASIwDQYJKoZI
// SIG // hvcNAQEBBQADggEPADCCAQoCggEBAJ+hbLHf20iSKnxr
// SIG // LhnhveLjxZlRI1Ctzt0YTiQP7tGn0UytdDAgEesH1VSV
// SIG // FUmUG0KSrphcMCbaAGvoe73siQcP9w4EmPCJzB/LMySH
// SIG // nfL0Zxws/HvniB3q506jocEjU8qN+kXPCdBer9CwQgSi
// SIG // +aZsk2fXKNxGU7CG0OUoRi4nrIZPVVIM5AMs+2qQkDBu
// SIG // h/NZMJ36ftaXs+ghl3740hPzCLdTbVK0RZCfSABKR2YR
// SIG // JylmqJfk0waBSqL5hKcRRxQJgp+E7VV4/gGaHVAIhQAQ
// SIG // MEbtt94jRrvELVSfrx54QTF3zJvfO4OToWECtR0Nsfz3
// SIG // m7IBziJLVP/5BcPCIAsCAwEAAaOCAaswggGnMA8GA1Ud
// SIG // EwEB/wQFMAMBAf8wHQYDVR0OBBYEFCM0+NlSRnAK7UD7
// SIG // dvuzK7DDNbMPMAsGA1UdDwQEAwIBhjAQBgkrBgEEAYI3
// SIG // FQEEAwIBADCBmAYDVR0jBIGQMIGNgBQOrIJgQFYnl+Ul
// SIG // E/wq4QpTlVnkpKFjpGEwXzETMBEGCgmSJomT8ixkARkW
// SIG // A2NvbTEZMBcGCgmSJomT8ixkARkWCW1pY3Jvc29mdDEt
// SIG // MCsGA1UEAxMkTWljcm9zb2Z0IFJvb3QgQ2VydGlmaWNh
// SIG // dGUgQXV0aG9yaXR5ghB5rRahSqClrUxzWPQHEy5lMFAG
// SIG // A1UdHwRJMEcwRaBDoEGGP2h0dHA6Ly9jcmwubWljcm9z
// SIG // b2Z0LmNvbS9wa2kvY3JsL3Byb2R1Y3RzL21pY3Jvc29m
// SIG // dHJvb3RjZXJ0LmNybDBUBggrBgEFBQcBAQRIMEYwRAYI
// SIG // KwYBBQUHMAKGOGh0dHA6Ly93d3cubWljcm9zb2Z0LmNv
// SIG // bS9wa2kvY2VydHMvTWljcm9zb2Z0Um9vdENlcnQuY3J0
// SIG // MBMGA1UdJQQMMAoGCCsGAQUFBwMIMA0GCSqGSIb3DQEB
// SIG // BQUAA4ICAQAQl4rDXANENt3ptK132855UU0BsS50cVtt
// SIG // DBOrzr57j7gu1BKijG1iuFcCy04gE1CZ3XpA4le7r1ia
// SIG // HOEdAYasu3jyi9DsOwHu4r6PCgXIjUji8FMV3U+rkuTn
// SIG // jWrVgMHmlPIGL4UD6ZEqJCJw+/b85HiZLg33B+JwvBhO
// SIG // nY5rCnKVuKE5nGctxVEO6mJcPxaYiyA/4gcaMvnMMUp2
// SIG // MT0rcgvI6nA9/4UKE9/CCmGO8Ne4F+tOi3/FNSteo7/r
// SIG // vH0LQnvUU3Ih7jDKu3hlXFsBFwoUDtLaFJj1PLlmWLMt
// SIG // L+f5hYbMUVbonXCUbKw5TNT2eb+qGHpiKe+imyk0Bnca
// SIG // Ysk9Hm0fgvALxyy7z0Oz5fnsfbXjpKh0NbhOxXEjEiZ2
// SIG // CzxSjHFaRkMUvLOzsE1nyJ9C/4B5IYCeFTBm6EISXhrI
// SIG // niIh0EPpK+m79EjMLNTYMoBMJipIJF9a6lbvpt6Znco6
// SIG // b72BJ3QGEe52Ib+bgsEnVLaxaj2JoXZhtG6hE6a/qkfw
// SIG // Em/9ijJssv7fUciMI8lmvZ0dhxJkAj0tr1mPuOQh5bWw
// SIG // ymO0eFQF1EEuUKyUsKV4q7OglnUa2ZKHE3UiLzKoCG6g
// SIG // W4wlv6DvhMoh1useT8ma7kng9wFlb4kLfchpyOZu6qeX
// SIG // zjEp/w7FW1zYTRuh2Povnj8uVRZryROj/TCCB3owggVi
// SIG // oAMCAQICCmEOkNIAAAAAAAMwDQYJKoZIhvcNAQELBQAw
// SIG // gYgxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5n
// SIG // dG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
// SIG // aWNyb3NvZnQgQ29ycG9yYXRpb24xMjAwBgNVBAMTKU1p
// SIG // Y3Jvc29mdCBSb290IENlcnRpZmljYXRlIEF1dGhvcml0
// SIG // eSAyMDExMB4XDTExMDcwODIwNTkwOVoXDTI2MDcwODIx
// SIG // MDkwOVowfjELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldh
// SIG // c2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNV
// SIG // BAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEoMCYGA1UE
// SIG // AxMfTWljcm9zb2Z0IENvZGUgU2lnbmluZyBQQ0EgMjAx
// SIG // MTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIB
// SIG // AKvw+nIQHC6t2G6qghBNNLrytlghn0IbKmvpWlCquAY4
// SIG // GgRJun/DDB7dN2vGEtgL8DjCmQawyDnVARQxQtOJDXlk
// SIG // h36UYCRsr55JnOloXtLfm1OyCizDr9mpK656Ca/XllnK
// SIG // YBoF6WZ26DJSJhIv56sIUM+zRLdd2MQuA3WraPPLbfM6
// SIG // XKEW9Ea64DhkrG5kNXimoGMPLdNAk/jj3gcN1Vx5pUkp
// SIG // 5w2+oBN3vpQ97/vjK1oQH01WKKJ6cuASOrdJXtjt7UOR
// SIG // g9l7snuGG9k+sYxd6IlPhBryoS9Z5JA7La4zWMW3Pv4y
// SIG // 07MDPbGyr5I4ftKdgCz1TlaRITUlwzluZH9TupwPrRkj
// SIG // hMv0ugOGjfdf8NBSv4yUh7zAIXQlXxgotswnKDglmDlK
// SIG // Ns98sZKuHCOnqWbsYR9q4ShJnV+I4iVd0yFLPlLEtVc/
// SIG // JAPw0XpbL9Uj43BdD1FGd7P4AOG8rAKCX9vAFbO9G9RV
// SIG // S+c5oQ/pI0m8GLhEfEXkwcNyeuBy5yTfv0aZxe/CHFfb
// SIG // g43sTUkwp6uO3+xbn6/83bBm4sGXgXvt1u1L50kppxMo
// SIG // pqd9Z4DmimJ4X7IvhNdXnFy/dygo8e1twyiPLI9AN0/B
// SIG // 4YVEicQJTMXUpUMvdJX3bvh4IFgsE11glZo+TzOE2rCI
// SIG // F96eTvSWsLxGoGyY0uDWiIwLAgMBAAGjggHtMIIB6TAQ
// SIG // BgkrBgEEAYI3FQEEAwIBADAdBgNVHQ4EFgQUSG5k5VAF
// SIG // 04KqFzc3IrVtqMp1ApUwGQYJKwYBBAGCNxQCBAweCgBT
// SIG // AHUAYgBDAEEwCwYDVR0PBAQDAgGGMA8GA1UdEwEB/wQF
// SIG // MAMBAf8wHwYDVR0jBBgwFoAUci06AjGQQ7kUBU7h6qfH
// SIG // MdEjiTQwWgYDVR0fBFMwUTBPoE2gS4ZJaHR0cDovL2Ny
// SIG // bC5taWNyb3NvZnQuY29tL3BraS9jcmwvcHJvZHVjdHMv
// SIG // TWljUm9vQ2VyQXV0MjAxMV8yMDExXzAzXzIyLmNybDBe
// SIG // BggrBgEFBQcBAQRSMFAwTgYIKwYBBQUHMAKGQmh0dHA6
// SIG // Ly93d3cubWljcm9zb2Z0LmNvbS9wa2kvY2VydHMvTWlj
// SIG // Um9vQ2VyQXV0MjAxMV8yMDExXzAzXzIyLmNydDCBnwYD
// SIG // VR0gBIGXMIGUMIGRBgkrBgEEAYI3LgMwgYMwPwYIKwYB
// SIG // BQUHAgEWM2h0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9w
// SIG // a2lvcHMvZG9jcy9wcmltYXJ5Y3BzLmh0bTBABggrBgEF
// SIG // BQcCAjA0HjIgHQBMAGUAZwBhAGwAXwBwAG8AbABpAGMA
// SIG // eQBfAHMAdABhAHQAZQBtAGUAbgB0AC4gHTANBgkqhkiG
// SIG // 9w0BAQsFAAOCAgEAZ/KGpZjgVHkaLtPYdGcimwuWEeFj
// SIG // kplCln3SeQyQwWVfLiw++MNy0W2D/r4/6ArKO79HqaPz
// SIG // adtjvyI1pZddZYSQfYtGUFXYDJJ80hpLHPM8QotS0LD9
// SIG // a+M+By4pm+Y9G6XUtR13lDni6WTJRD14eiPzE32mkHSD
// SIG // jfTLJgJGKsKKELukqQUMm+1o+mgulaAqPyprWEljHwlp
// SIG // blqYluSD9MCP80Yr3vw70L01724lruWvJ+3Q3fMOr5ko
// SIG // l5hNDj0L8giJ1h/DMhji8MUtzluetEk5CsYKwsatruWy
// SIG // 2dsViFFFWDgycScaf7H0J/jeLDogaZiyWYlobm+nt3TD
// SIG // QAUGpgEqKD6CPxNNZgvAs0314Y9/HG8VfUWnduVAKmWj
// SIG // w11SYobDHWM2l4bf2vP48hahmifhzaWX0O5dY0HjWwec
// SIG // hz4GdwbRBrF1HxS+YWG18NzGGwS+30HHDiju3mUv7Jf2
// SIG // oVyW2ADWoUa9WfOXpQlLSBCZgB/QACnFsZulP0V3HjXG
// SIG // 0qKin3p6IvpIlR+r+0cjgPWe+L9rt0uX4ut1eBrs6jeZ
// SIG // eRhL/9azI2h15q/6/IvrC4DqaTuv/DDtBEyO3991bWOR
// SIG // PdGdVk5Pv4BXIqF4ETIheu9BCrE/+6jMpF3BoYibV3FW
// SIG // TkhFwELJm3ZbCoBIa/15n8G9bW1qyVJzEw16UM0xggSO
// SIG // MIIEigIBATCBlTB+MQswCQYDVQQGEwJVUzETMBEGA1UE
// SIG // CBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEe
// SIG // MBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSgw
// SIG // JgYDVQQDEx9NaWNyb3NvZnQgQ29kZSBTaWduaW5nIFBD
// SIG // QSAyMDExAhMzAAABA14lHJkfox64AAAAAAEDMAkGBSsO
// SIG // AwIaBQCggaIwGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcC
// SIG // AQQwHAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUw
// SIG // IwYJKoZIhvcNAQkEMRYEFAn0Ukfj/nlZ9vn6gukhZ1u7
// SIG // cJQ0MEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwBy
// SIG // AG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29m
// SIG // dC5jb20wDQYJKoZIhvcNAQEBBQAEggEAufM4JRvpix64
// SIG // Be78v2gMy5+XXyG5QAcM9dqRli6h7/Gf1AaKPnrHRNWg
// SIG // fKNcoKVuUML2gJIiAIiA2HSdETCOPcoI9FKAHXNldMjy
// SIG // hL8g8suqfEk9z/ufi7EynwsjwjME1cgrRWXhJnlqeo+V
// SIG // grU09sid61f0q5TpGs+XgbDwZ9JXdOI9dTXYRzzKmAs4
// SIG // d3dMXo6MF8VJYCR3J2tt9Ex2hOXa+FrjfSpX/Vgi6Zxq
// SIG // TF0QCXYl0d2Ysm5LFlGmagq6sQrkz409xHztzVwfG+5B
// SIG // wgFRnls3JpvhvfnPKv9n/JRx/KOoZrxU5by5c1CEh3P6
// SIG // QO/sw95lhXe5wI1yFusAS6GCAigwggIkBgkqhkiG9w0B
// SIG // CQYxggIVMIICEQIBATCBjjB3MQswCQYDVQQGEwJVUzET
// SIG // MBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVk
// SIG // bW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0
// SIG // aW9uMSEwHwYDVQQDExhNaWNyb3NvZnQgVGltZS1TdGFt
// SIG // cCBQQ0ECEzMAAAEEZIjZOXzzlscAAAAAAQQwCQYFKw4D
// SIG // AhoFAKBdMBgGCSqGSIb3DQEJAzELBgkqhkiG9w0BBwEw
// SIG // HAYJKoZIhvcNAQkFMQ8XDTE4MTAxNjAzMTIzN1owIwYJ
// SIG // KoZIhvcNAQkEMRYEFNFg2PJgnURatBl7VtHkeMnmHUm2
// SIG // MA0GCSqGSIb3DQEBBQUABIIBACxvSaUWBrKmF2r6kLRi
// SIG // cJhtSXbNs4tOxTESDxVK0Y+geTQQpw1lTY39BejlOnrZ
// SIG // +8i6a8db4vNNrj3JW7c09sHhlyiRch38TqCAWHTMm1tL
// SIG // 23xt3ED+5HGumLHVQspl2eiXm4g14gYF92maxL4hfwdC
// SIG // hLAWQJppjQrdLduqYLo7kE6+TeOr6dPaH/vAO16vgqFF
// SIG // cknBzG2MYOFDZYGlqMCDQXxKohhJl7GYTHcmZHnp3Btc
// SIG // ofVP3GXu3ABIau5HvwvMFvidShn4aX58qbyOQnYQrd4X
// SIG // TTbVds0RhQsO9lkEgnMSM5vBbcmqhbBa7Pktbxjx80vB
// SIG // yJbjm4jfgjpfDdw=
// SIG // End signature block