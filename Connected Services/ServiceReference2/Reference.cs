﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteExamen.ServiceReference2 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarAuthors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarAuthors", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarTitleauthor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarTitleauthor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarTitleauthor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarTitleauthorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAuthors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AgregarAuthors(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAuthors", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AgregarAuthorsAsync(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AgregarEmployee(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AgregarEmployeeAsync(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarTitleauthor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AgregarTitleauthor(string au_id, string title_id, int au_ord, int royaltyper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarTitleauthor", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AgregarTitleauthorAsync(string au_id, string title_id, int au_ord, int royaltyper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarAuthors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EliminarAuthors(string au_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarAuthors", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarAuthorsAsync(string au_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EliminarEmployee(string emp_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarEmployeeAsync(string emp_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarTitleauthor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EliminarTitleauthor(string au_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarTitleauthor", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarTitleauthorAsync(string au_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarAuthors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarAuthors(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarAuthors", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAuthorsAsync(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarEmployee(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarEmployeeAsync(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarTitleauthor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarTitleauthor(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarTitleauthor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarTitleauthorAsync(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarAuthors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ActualizarAuthors(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarAuthors", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ActualizarAuthorsAsync(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ActualizarEmployee(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ActualizarEmployeeAsync(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarTitleauthor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ActualizarTitleauthor(string au_id, string title_id, int au_ord, int royaltyper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarTitleauthor", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ActualizarTitleauthorAsync(string au_id, string title_id, int au_ord, int royaltyper);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ClienteExamen.ServiceReference2.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ClienteExamen.ServiceReference2.WebService1Soap>, ClienteExamen.ServiceReference2.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ListarAuthors() {
            return base.Channel.ListarAuthors();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAuthorsAsync() {
            return base.Channel.ListarAuthorsAsync();
        }
        
        public System.Data.DataSet ListarEmployee() {
            return base.Channel.ListarEmployee();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarEmployeeAsync() {
            return base.Channel.ListarEmployeeAsync();
        }
        
        public System.Data.DataSet ListarTitleauthor() {
            return base.Channel.ListarTitleauthor();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarTitleauthorAsync() {
            return base.Channel.ListarTitleauthorAsync();
        }
        
        public bool AgregarAuthors(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract) {
            return base.Channel.AgregarAuthors(au_id, au_lname, au_fname, phone, address, city, state, zip, contract);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarAuthorsAsync(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract) {
            return base.Channel.AgregarAuthorsAsync(au_id, au_lname, au_fname, phone, address, city, state, zip, contract);
        }
        
        public bool AgregarEmployee(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date) {
            return base.Channel.AgregarEmployee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarEmployeeAsync(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date) {
            return base.Channel.AgregarEmployeeAsync(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date);
        }
        
        public bool AgregarTitleauthor(string au_id, string title_id, int au_ord, int royaltyper) {
            return base.Channel.AgregarTitleauthor(au_id, title_id, au_ord, royaltyper);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarTitleauthorAsync(string au_id, string title_id, int au_ord, int royaltyper) {
            return base.Channel.AgregarTitleauthorAsync(au_id, title_id, au_ord, royaltyper);
        }
        
        public bool EliminarAuthors(string au_id) {
            return base.Channel.EliminarAuthors(au_id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAuthorsAsync(string au_id) {
            return base.Channel.EliminarAuthorsAsync(au_id);
        }
        
        public bool EliminarEmployee(string emp_id) {
            return base.Channel.EliminarEmployee(emp_id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarEmployeeAsync(string emp_id) {
            return base.Channel.EliminarEmployeeAsync(emp_id);
        }
        
        public bool EliminarTitleauthor(string au_id) {
            return base.Channel.EliminarTitleauthor(au_id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarTitleauthorAsync(string au_id) {
            return base.Channel.EliminarTitleauthorAsync(au_id);
        }
        
        public System.Data.DataSet BuscarAuthors(string texto, string criterio) {
            return base.Channel.BuscarAuthors(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAuthorsAsync(string texto, string criterio) {
            return base.Channel.BuscarAuthorsAsync(texto, criterio);
        }
        
        public System.Data.DataSet BuscarEmployee(string texto, string criterio) {
            return base.Channel.BuscarEmployee(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarEmployeeAsync(string texto, string criterio) {
            return base.Channel.BuscarEmployeeAsync(texto, criterio);
        }
        
        public System.Data.DataSet BuscarTitleauthor(string texto, string criterio) {
            return base.Channel.BuscarTitleauthor(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarTitleauthorAsync(string texto, string criterio) {
            return base.Channel.BuscarTitleauthorAsync(texto, criterio);
        }
        
        public bool ActualizarAuthors(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract) {
            return base.Channel.ActualizarAuthors(au_id, au_lname, au_fname, phone, address, city, state, zip, contract);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarAuthorsAsync(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, int zip, string contract) {
            return base.Channel.ActualizarAuthorsAsync(au_id, au_lname, au_fname, phone, address, city, state, zip, contract);
        }
        
        public bool ActualizarEmployee(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date) {
            return base.Channel.ActualizarEmployee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarEmployeeAsync(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, System.DateTime hire_date) {
            return base.Channel.ActualizarEmployeeAsync(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date);
        }
        
        public bool ActualizarTitleauthor(string au_id, string title_id, int au_ord, int royaltyper) {
            return base.Channel.ActualizarTitleauthor(au_id, title_id, au_ord, royaltyper);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarTitleauthorAsync(string au_id, string title_id, int au_ord, int royaltyper) {
            return base.Channel.ActualizarTitleauthorAsync(au_id, title_id, au_ord, royaltyper);
        }
    }
}
