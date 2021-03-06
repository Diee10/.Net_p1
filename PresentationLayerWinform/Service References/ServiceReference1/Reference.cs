﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayerWinform.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.IServiceEmployees")]
    public interface IServiceEmployees {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/AddEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/AddEmployeeResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.FullTimeEmployee))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.PartTimeEmployee))]
        void AddEmployee(Shared.Entities.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/AddEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(Shared.Entities.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/DeleteEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/DeleteEmployeeResponse")]
        void DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/DeleteEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task DeleteEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/UpdateEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/UpdateEmployeeResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.FullTimeEmployee))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.PartTimeEmployee))]
        void UpdateEmployee(Shared.Entities.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/UpdateEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task UpdateEmployeeAsync(Shared.Entities.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetAllEmployees", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetAllEmployeesResponse")]
        Shared.Entities.Employee[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetAllEmployees", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<Shared.Entities.Employee[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetEmployeeResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.FullTimeEmployee))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Shared.Entities.PartTimeEmployee))]
        Shared.Entities.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetEmployee", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/GetEmployeeResponse")]
        System.Threading.Tasks.Task<Shared.Entities.Employee> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/CalcPartTimeEmployeeSalar" +
            "y", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/CalcPartTimeEmployeeSalar" +
            "yResponse")]
        double CalcPartTimeEmployeeSalary(int idEmployee, int hours);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IServiceEmployees/CalcPartTimeEmployeeSalar" +
            "y", ReplyAction="http://Microsoft.ServiceModel.Samples/IServiceEmployees/CalcPartTimeEmployeeSalar" +
            "yResponse")]
        System.Threading.Tasks.Task<double> CalcPartTimeEmployeeSalaryAsync(int idEmployee, int hours);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceEmployeesChannel : PresentationLayerWinform.ServiceReference1.IServiceEmployees, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEmployeesClient : System.ServiceModel.ClientBase<PresentationLayerWinform.ServiceReference1.IServiceEmployees>, PresentationLayerWinform.ServiceReference1.IServiceEmployees {
        
        public ServiceEmployeesClient() {
        }
        
        public ServiceEmployeesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEmployeesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEmployeesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEmployeesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddEmployee(Shared.Entities.Employee emp) {
            base.Channel.AddEmployee(emp);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(Shared.Entities.Employee emp) {
            return base.Channel.AddEmployeeAsync(emp);
        }
        
        public void DeleteEmployee(int id) {
            base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
        
        public void UpdateEmployee(Shared.Entities.Employee emp) {
            base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task UpdateEmployeeAsync(Shared.Entities.Employee emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
        
        public Shared.Entities.Employee[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<Shared.Entities.Employee[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public Shared.Entities.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<Shared.Entities.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours) {
            return base.Channel.CalcPartTimeEmployeeSalary(idEmployee, hours);
        }
        
        public System.Threading.Tasks.Task<double> CalcPartTimeEmployeeSalaryAsync(int idEmployee, int hours) {
            return base.Channel.CalcPartTimeEmployeeSalaryAsync(idEmployee, hours);
        }
    }
}
