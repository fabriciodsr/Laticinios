﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace View.CRelatorioAluno {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRelatorioAluno.ICRelatorioAluno")]
    public interface ICRelatorioAluno {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRelatorioAluno/GerarRelatorioID", ReplyAction="http://tempuri.org/ICRelatorioAluno/GerarRelatorioIDResponse")]
        Model.ALUNO[] GerarRelatorioID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRelatorioAluno/GerarRelatorioID", ReplyAction="http://tempuri.org/ICRelatorioAluno/GerarRelatorioIDResponse")]
        System.Threading.Tasks.Task<Model.ALUNO[]> GerarRelatorioIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRelatorioAluno/GerarRelatorioNome", ReplyAction="http://tempuri.org/ICRelatorioAluno/GerarRelatorioNomeResponse")]
        Model.ALUNO[] GerarRelatorioNome();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRelatorioAluno/GerarRelatorioNome", ReplyAction="http://tempuri.org/ICRelatorioAluno/GerarRelatorioNomeResponse")]
        System.Threading.Tasks.Task<Model.ALUNO[]> GerarRelatorioNomeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRelatorioAlunoChannel : View.CRelatorioAluno.ICRelatorioAluno, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRelatorioAlunoClient : System.ServiceModel.ClientBase<View.CRelatorioAluno.ICRelatorioAluno>, View.CRelatorioAluno.ICRelatorioAluno {
        
        public CRelatorioAlunoClient() {
        }
        
        public CRelatorioAlunoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRelatorioAlunoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRelatorioAlunoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRelatorioAlunoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Model.ALUNO[] GerarRelatorioID() {
            return base.Channel.GerarRelatorioID();
        }
        
        public System.Threading.Tasks.Task<Model.ALUNO[]> GerarRelatorioIDAsync() {
            return base.Channel.GerarRelatorioIDAsync();
        }
        
        public Model.ALUNO[] GerarRelatorioNome() {
            return base.Channel.GerarRelatorioNome();
        }
        
        public System.Threading.Tasks.Task<Model.ALUNO[]> GerarRelatorioNomeAsync() {
            return base.Channel.GerarRelatorioNomeAsync();
        }
    }
}
