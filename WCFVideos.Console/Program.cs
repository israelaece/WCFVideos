using System;
using System.ServiceModel;

namespace WCFVideos.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WCFVideos.Proxy.GestorDeCreditoClient proxy =
                new WCFVideos.Proxy.GestorDeCreditoClient(new InstanceContext(new CallbackManager()), "NetTcpBinding_IGestorDeCredito"))
            {
                System.Console.WriteLine(proxy.RecuperarQuantidadeDeRecursoDisponivel());
            }
        }
    }

    class CallbackManager : WCFVideos.Proxy.IGestorDeCreditoCallback
    {
        #region IGestorDeCreditoCallback Members

        public void PropostaAnalisada(WCFVideos.Proxy.Proposta proposta)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginPropostaAnalisada(WCFVideos.Proxy.Proposta proposta, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndPropostaAnalisada(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}