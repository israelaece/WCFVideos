using System;
using System.ServiceModel;

namespace WCFVideos.Contratos
{
    public interface IGestorDeCreditoCallback
    {
        [OperationContract(IsOneWay = true)]
        void PropostaAnalisada(Proposta proposta);
    }
}