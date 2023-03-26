﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiplicationWeb.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.MultiplicationService")]
    public interface MultiplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/MultiplyInt", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyIntResponse")]
        int MultiplyInt(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/MultiplyInt", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyIntResponse")]
        System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MultiplicationServiceChannel : MultiplicationWeb.ServiceReference.MultiplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MultiplicationServiceClient : System.ServiceModel.ClientBase<MultiplicationWeb.ServiceReference.MultiplicationService>, MultiplicationWeb.ServiceReference.MultiplicationService {
        
        public MultiplicationServiceClient() {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int MultiplyInt(int a, int b) {
            return base.Channel.MultiplyInt(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b) {
            return base.Channel.MultiplyIntAsync(a, b);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.NewMultiplicationService")]
    public interface NewMultiplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/MultiplyInt", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyIntResponse")]
        int MultiplyInt(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/MultiplyInt", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyIntResponse")]
        System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewMultiplicationService/MultiplyDouble", ReplyAction="http://tempuri.org/NewMultiplicationService/MultiplyDoubleResponse")]
        double MultiplyDouble(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewMultiplicationService/MultiplyDouble", ReplyAction="http://tempuri.org/NewMultiplicationService/MultiplyDoubleResponse")]
        System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NewMultiplicationServiceChannel : MultiplicationWeb.ServiceReference.NewMultiplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewMultiplicationServiceClient : System.ServiceModel.ClientBase<MultiplicationWeb.ServiceReference.NewMultiplicationService>, MultiplicationWeb.ServiceReference.NewMultiplicationService {
        
        public NewMultiplicationServiceClient() {
        }
        
        public NewMultiplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewMultiplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewMultiplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewMultiplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int MultiplyInt(int a, int b) {
            return base.Channel.MultiplyInt(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b) {
            return base.Channel.MultiplyIntAsync(a, b);
        }
        
        public double MultiplyDouble(double a, double b) {
            return base.Channel.MultiplyDouble(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double a, double b) {
            return base.Channel.MultiplyDoubleAsync(a, b);
        }
    }
}
