//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestServiceWeb.SalesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SalesPerson", Namespace="http://schemas.datacontract.org/2004/07/FourthCoffee.DataService.Infrastructure")]
    [System.SerializableAttribute()]
    public partial class SalesPerson : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Area {
            get {
                return this.AreaField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaField, value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalesService.ISalesService")]
    public interface ISalesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetSalesPerson", ReplyAction="http://tempuri.org/ISalesService/GetSalesPersonResponse")]
        TestServiceWeb.SalesService.SalesPerson GetSalesPerson(string emailAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetSalesPerson", ReplyAction="http://tempuri.org/ISalesService/GetSalesPersonResponse")]
        System.Threading.Tasks.Task<TestServiceWeb.SalesService.SalesPerson> GetSalesPersonAsync(string emailAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalesServiceChannel : TestServiceWeb.SalesService.ISalesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesServiceClient : System.ServiceModel.ClientBase<TestServiceWeb.SalesService.ISalesService>, TestServiceWeb.SalesService.ISalesService {
        
        public SalesServiceClient() {
        }
        
        public SalesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestServiceWeb.SalesService.SalesPerson GetSalesPerson(string emailAddress) {
            return base.Channel.GetSalesPerson(emailAddress);
        }
        
        public System.Threading.Tasks.Task<TestServiceWeb.SalesService.SalesPerson> GetSalesPersonAsync(string emailAddress) {
            return base.Channel.GetSalesPersonAsync(emailAddress);
        }
    }
}
