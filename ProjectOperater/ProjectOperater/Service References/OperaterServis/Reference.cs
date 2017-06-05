﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOperater.OperaterServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ListaDeo", Namespace="http://schemas.datacontract.org/2004/07/", ItemName="Deo")]
    [System.SerializableAttribute()]
    public class ListaDeo : System.Collections.Generic.List<ProjectLibrary.Deo> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OperaterServis.IOperaterServis", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IOperaterServis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/Login", ReplyAction="http://tempuri.org/IOperaterServis/LoginResponse")]
        bool Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/Login", ReplyAction="http://tempuri.org/IOperaterServis/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/proveriLogin", ReplyAction="http://tempuri.org/IOperaterServis/proveriLoginResponse")]
        bool proveriLogin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/proveriLogin", ReplyAction="http://tempuri.org/IOperaterServis/proveriLoginResponse")]
        System.Threading.Tasks.Task<bool> proveriLoginAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/SumaTroskovaNaAutuZaKorisnika", ReplyAction="http://tempuri.org/IOperaterServis/SumaTroskovaNaAutuZaKorisnikaResponse")]
        double SumaTroskovaNaAutuZaKorisnika();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/SumaTroskovaNaAutuZaKorisnika", ReplyAction="http://tempuri.org/IOperaterServis/SumaTroskovaNaAutuZaKorisnikaResponse")]
        System.Threading.Tasks.Task<double> SumaTroskovaNaAutuZaKorisnikaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/StatusPopravkiNaAutu", ReplyAction="http://tempuri.org/IOperaterServis/StatusPopravkiNaAutuResponse")]
        ProjectLibrary.status[] StatusPopravkiNaAutu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/StatusPopravkiNaAutu", ReplyAction="http://tempuri.org/IOperaterServis/StatusPopravkiNaAutuResponse")]
        System.Threading.Tasks.Task<ProjectLibrary.status[]> StatusPopravkiNaAutuAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PovuciDelove", ReplyAction="http://tempuri.org/IOperaterServis/PovuciDeloveResponse")]
        ProjectOperater.OperaterServis.ListaDeo PovuciDelove();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PovuciDelove", ReplyAction="http://tempuri.org/IOperaterServis/PovuciDeloveResponse")]
        System.Threading.Tasks.Task<ProjectOperater.OperaterServis.ListaDeo> PovuciDeloveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PromeniCenuZaIDOdDeo", ReplyAction="http://tempuri.org/IOperaterServis/PromeniCenuZaIDOdDeoResponse")]
        bool PromeniCenuZaIDOdDeo(int ID, double Cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PromeniCenuZaIDOdDeo", ReplyAction="http://tempuri.org/IOperaterServis/PromeniCenuZaIDOdDeoResponse")]
        System.Threading.Tasks.Task<bool> PromeniCenuZaIDOdDeoAsync(int ID, double Cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PovuciKorisnike", ReplyAction="http://tempuri.org/IOperaterServis/PovuciKorisnikeResponse")]
        ProjectOperater.OperaterServis.ListaDeo PovuciKorisnike();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaterServis/PovuciKorisnike", ReplyAction="http://tempuri.org/IOperaterServis/PovuciKorisnikeResponse")]
        System.Threading.Tasks.Task<ProjectOperater.OperaterServis.ListaDeo> PovuciKorisnikeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperaterServisChannel : ProjectOperater.OperaterServis.IOperaterServis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OperaterServisClient : System.ServiceModel.ClientBase<ProjectOperater.OperaterServis.IOperaterServis>, ProjectOperater.OperaterServis.IOperaterServis {
        
        public OperaterServisClient() {
        }
        
        public OperaterServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperaterServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperaterServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperaterServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public bool proveriLogin() {
            return base.Channel.proveriLogin();
        }
        
        public System.Threading.Tasks.Task<bool> proveriLoginAsync() {
            return base.Channel.proveriLoginAsync();
        }
        
        public double SumaTroskovaNaAutuZaKorisnika() {
            return base.Channel.SumaTroskovaNaAutuZaKorisnika();
        }
        
        public System.Threading.Tasks.Task<double> SumaTroskovaNaAutuZaKorisnikaAsync() {
            return base.Channel.SumaTroskovaNaAutuZaKorisnikaAsync();
        }
        
        public ProjectLibrary.status[] StatusPopravkiNaAutu() {
            return base.Channel.StatusPopravkiNaAutu();
        }
        
        public System.Threading.Tasks.Task<ProjectLibrary.status[]> StatusPopravkiNaAutuAsync() {
            return base.Channel.StatusPopravkiNaAutuAsync();
        }
        
        public ProjectOperater.OperaterServis.ListaDeo PovuciDelove() {
            return base.Channel.PovuciDelove();
        }
        
        public System.Threading.Tasks.Task<ProjectOperater.OperaterServis.ListaDeo> PovuciDeloveAsync() {
            return base.Channel.PovuciDeloveAsync();
        }
        
        public bool PromeniCenuZaIDOdDeo(int ID, double Cena) {
            return base.Channel.PromeniCenuZaIDOdDeo(ID, Cena);
        }
        
        public System.Threading.Tasks.Task<bool> PromeniCenuZaIDOdDeoAsync(int ID, double Cena) {
            return base.Channel.PromeniCenuZaIDOdDeoAsync(ID, Cena);
        }
        
        public ProjectOperater.OperaterServis.ListaDeo PovuciKorisnike() {
            return base.Channel.PovuciKorisnike();
        }
        
        public System.Threading.Tasks.Task<ProjectOperater.OperaterServis.ListaDeo> PovuciKorisnikeAsync() {
            return base.Channel.PovuciKorisnikeAsync();
        }
    }
}
