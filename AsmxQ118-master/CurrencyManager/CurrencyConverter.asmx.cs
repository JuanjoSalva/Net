using System;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace CurrencyManager
{
    /// <summary>
    /// Summary description for CurrencyConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CurrencyConverter : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json, XmlSerializeString = false)]
        public void GetExchangeRate(string currencyType)
        {
            double currencyRate;
            switch (currencyType)
            {
                case "USD":
                    currencyRate = 0.23;
                    break;
                case "EUR":
                    currencyRate = 0.72;
                    break;
                default:
                    currencyRate = 0.1;
                    break;
            }
            Rate rate = new Rate();
            rate.CurrencyType = currencyType;
            rate.CurrencyRate = currencyRate;

            List<Rate> response = new List<Rate>();
            response.Add(rate);

            JavaScriptSerializer js = new JavaScriptSerializer();

            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            //return response;
            Context.Response.Write(js.Serialize(response));
            //return js.Serialize(response);
            //return response;
        }
    }
    public class Rate
    {
        public string CurrencyType { get; set; }
        public double CurrencyRate { get; set; }
    }
}
