﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://schemas.datacontract.org/2004/07/WCFVideos.Contratos", ClrNamespace = "WCFVideos.Proxy")]

namespace WCFVideos.Proxy
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Proposta", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Proposta : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private WCFVideos.Proxy.Cliente ClienteField;

        private System.DateTime DataField;

        private WCFVideos.Proxy.Emprestimo EmprestimoField;

        private int NumeroField;

        private WCFVideos.Proxy.Status StatusField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFVideos.Proxy.Cliente Cliente
        {
            get
            {
                return this.ClienteField;
            }
            set
            {
                this.ClienteField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFVideos.Proxy.Emprestimo Emprestimo
        {
            get
            {
                return this.EmprestimoField;
            }
            set
            {
                this.EmprestimoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero
        {
            get
            {
                return this.NumeroField;
            }
            set
            {
                this.NumeroField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFVideos.Proxy.Status Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Cliente", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string EmpresaField;

        private int IdadeField;

        private string NomeField;

        private decimal SalarioField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Empresa
        {
            get
            {
                return this.EmpresaField;
            }
            set
            {
                this.EmpresaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Idade
        {
            get
            {
                return this.IdadeField;
            }
            set
            {
                this.IdadeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salario
        {
            get
            {
                return this.SalarioField;
            }
            set
            {
                this.SalarioField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Emprestimo", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Emprestimo : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int QuantidadeDeParcelasField;

        private decimal TaxaDeJurosField;

        private decimal ValorField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeDeParcelas
        {
            get
            {
                return this.QuantidadeDeParcelasField;
            }
            set
            {
                this.QuantidadeDeParcelasField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TaxaDeJuros
        {
            get
            {
                return this.TaxaDeJurosField;
            }
            set
            {
                this.TaxaDeJurosField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Valor
        {
            get
            {
                return this.ValorField;
            }
            set
            {
                this.ValorField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Status", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public enum Status : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aprovada = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejeitada = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmAnalise = 2,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DetalhesDoErro", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class DetalhesDoErro : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime DataField;

        private string MensagemField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                this.MensagemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IGestorDeCredito", CallbackContract = typeof(IGestorDeCreditoCallback))]
    public interface IGestorDeCredito
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivel", ReplyAction = "http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivelRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFVideos.Proxy.DetalhesDoErro), Action = "http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivelDetalhe" +
            "sDoErroFault", Name = "DetalhesDoErro", Namespace = "http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
        decimal RecuperarQuantidadeDeRecursoDisponivel();

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivel", ReplyAction = "http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivelRespons" +
            "e")]
        System.IAsyncResult BeginRecuperarQuantidadeDeRecursoDisponivel(System.AsyncCallback callback, object asyncState);

        decimal EndRecuperarQuantidadeDeRecursoDisponivel(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IGestorDeCredito/AnalisarProposta")]
        void AnalisarProposta(WCFVideos.Proxy.Proposta proposta);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/IGestorDeCredito/AnalisarProposta")]
        System.IAsyncResult BeginAnalisarProposta(WCFVideos.Proxy.Proposta proposta, System.AsyncCallback callback, object asyncState);

        void EndAnalisarProposta(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IGestorDeCredito/EfetivarProposta")]
        void EfetivarProposta(WCFVideos.Proxy.Proposta proposta);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/IGestorDeCredito/EfetivarProposta")]
        System.IAsyncResult BeginEfetivarProposta(WCFVideos.Proxy.Proposta proposta, System.AsyncCallback callback, object asyncState);

        void EndEfetivarProposta(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGestorDeCredito/RecuperarPropostas", ReplyAction = "http://tempuri.org/IGestorDeCredito/RecuperarPropostasResponse")]
        WCFVideos.Proxy.Proposta[] RecuperarPropostas(WCFVideos.Proxy.Status status);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/IGestorDeCredito/RecuperarPropostas", ReplyAction = "http://tempuri.org/IGestorDeCredito/RecuperarPropostasResponse")]
        System.IAsyncResult BeginRecuperarPropostas(WCFVideos.Proxy.Status status, System.AsyncCallback callback, object asyncState);

        WCFVideos.Proxy.Proposta[] EndRecuperarPropostas(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IGestorDeCreditoCallback
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IGestorDeCredito/PropostaAnalisada")]
        void PropostaAnalisada(WCFVideos.Proxy.Proposta proposta);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/IGestorDeCredito/PropostaAnalisada")]
        System.IAsyncResult BeginPropostaAnalisada(WCFVideos.Proxy.Proposta proposta, System.AsyncCallback callback, object asyncState);

        void EndPropostaAnalisada(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IGestorDeCreditoChannel : IGestorDeCredito, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GestorDeCreditoClient : System.ServiceModel.DuplexClientBase<IGestorDeCredito>, IGestorDeCredito
    {

        public GestorDeCreditoClient(System.ServiceModel.InstanceContext callbackInstance) :
            base(callbackInstance)
        {
        }

        public GestorDeCreditoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
            base(callbackInstance, endpointConfigurationName)
        {
        }

        public GestorDeCreditoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public GestorDeCreditoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public GestorDeCreditoClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, binding, remoteAddress)
        {
        }

        public decimal RecuperarQuantidadeDeRecursoDisponivel()
        {
            return base.Channel.RecuperarQuantidadeDeRecursoDisponivel();
        }

        public System.IAsyncResult BeginRecuperarQuantidadeDeRecursoDisponivel(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRecuperarQuantidadeDeRecursoDisponivel(callback, asyncState);
        }

        public decimal EndRecuperarQuantidadeDeRecursoDisponivel(System.IAsyncResult result)
        {
            return base.Channel.EndRecuperarQuantidadeDeRecursoDisponivel(result);
        }

        public void AnalisarProposta(WCFVideos.Proxy.Proposta proposta)
        {
            base.Channel.AnalisarProposta(proposta);
        }

        public System.IAsyncResult BeginAnalisarProposta(WCFVideos.Proxy.Proposta proposta, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginAnalisarProposta(proposta, callback, asyncState);
        }

        public void EndAnalisarProposta(System.IAsyncResult result)
        {
            base.Channel.EndAnalisarProposta(result);
        }

        public void EfetivarProposta(WCFVideos.Proxy.Proposta proposta)
        {
            base.Channel.EfetivarProposta(proposta);
        }

        public System.IAsyncResult BeginEfetivarProposta(WCFVideos.Proxy.Proposta proposta, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginEfetivarProposta(proposta, callback, asyncState);
        }

        public void EndEfetivarProposta(System.IAsyncResult result)
        {
            base.Channel.EndEfetivarProposta(result);
        }

        public WCFVideos.Proxy.Proposta[] RecuperarPropostas(WCFVideos.Proxy.Status status)
        {
            return base.Channel.RecuperarPropostas(status);
        }

        public System.IAsyncResult BeginRecuperarPropostas(WCFVideos.Proxy.Status status, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRecuperarPropostas(status, callback, asyncState);
        }

        public WCFVideos.Proxy.Proposta[] EndRecuperarPropostas(System.IAsyncResult result)
        {
            return base.Channel.EndRecuperarPropostas(result);
        }
    }
}