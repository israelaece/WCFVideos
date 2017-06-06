using System;
using System.ServiceModel;

namespace WCFVideos.Contratos
{
    [ServiceContract(CallbackContract = typeof(IGestorDeCreditoCallback))]
    public interface IGestorDeCredito
    {
        [OperationContract]
        [FaultContract(typeof(DetalhesDoErro))]
        decimal RecuperarQuantidadeDeRecursoDisponivel();

        [OperationContract(IsOneWay = true)]
        void AnalisarProposta(Proposta proposta);

        [OperationContract(IsOneWay = true)]
        void EfetivarProposta(Proposta proposta);

        [OperationContract]
        Proposta[] RecuperarPropostas(Status status);
    }
}