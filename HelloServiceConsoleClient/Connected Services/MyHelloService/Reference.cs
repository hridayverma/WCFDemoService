﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloServiceConsoleClient.MyHelloService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyHelloService.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Addition", ReplyAction="http://tempuri.org/IHelloService/AdditionResponse")]
        int Addition(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Addition", ReplyAction="http://tempuri.org/IHelloService/AdditionResponse")]
        System.Threading.Tasks.Task<int> AdditionAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Message", ReplyAction="http://tempuri.org/IHelloService/MessageResponse")]
        string Message(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Message", ReplyAction="http://tempuri.org/IHelloService/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : HelloServiceConsoleClient.MyHelloService.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<HelloServiceConsoleClient.MyHelloService.IHelloService>, HelloServiceConsoleClient.MyHelloService.IHelloService {
        
        public HelloServiceClient() {
        }
        
        public HelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int Addition(int x, int y) {
            return base.Channel.Addition(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AdditionAsync(int x, int y) {
            return base.Channel.AdditionAsync(x, y);
        }
        
        public string Message(string msg) {
            return base.Channel.Message(msg);
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync(string msg) {
            return base.Channel.MessageAsync(msg);
        }
    }
}
