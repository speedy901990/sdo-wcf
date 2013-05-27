﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewStudentLame", ReplyAction="http://tempuri.org/IService1/AddNewStudentLameResponse")]
        string AddNewStudentLame(string _name, string _surn, bool batman, string _mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewStudentLame", ReplyAction="http://tempuri.org/IService1/AddNewStudentLameResponse")]
        System.Threading.Tasks.Task<string> AddNewStudentLameAsync(string _name, string _surn, bool batman, string _mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TerriblyRetrieveDatabase", ReplyAction="http://tempuri.org/IService1/TerriblyRetrieveDatabaseResponse")]
        string TerriblyRetrieveDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TerriblyRetrieveDatabase", ReplyAction="http://tempuri.org/IService1/TerriblyRetrieveDatabaseResponse")]
        System.Threading.Tasks.Task<string> TerriblyRetrieveDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetData", ReplyAction="http://tempuri.org/IService1/SetDataResponse")]
        string SetData(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetData", ReplyAction="http://tempuri.org/IService1/SetDataResponse")]
        System.Threading.Tasks.Task<string> SetDataAsync(string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int id) {
            return base.Channel.GetData(id);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int id) {
            return base.Channel.GetDataAsync(id);
        }
        
        public string AddNewStudentLame(string _name, string _surn, bool batman, string _mail) {
            return base.Channel.AddNewStudentLame(_name, _surn, batman, _mail);
        }
        
        public System.Threading.Tasks.Task<string> AddNewStudentLameAsync(string _name, string _surn, bool batman, string _mail) {
            return base.Channel.AddNewStudentLameAsync(_name, _surn, batman, _mail);
        }
        
        public string TerriblyRetrieveDatabase() {
            return base.Channel.TerriblyRetrieveDatabase();
        }
        
        public System.Threading.Tasks.Task<string> TerriblyRetrieveDatabaseAsync() {
            return base.Channel.TerriblyRetrieveDatabaseAsync();
        }
        
        public string SetData(string data) {
            return base.Channel.SetData(data);
        }
        
        public System.Threading.Tasks.Task<string> SetDataAsync(string data) {
            return base.Channel.SetDataAsync(data);
        }
    }
}
