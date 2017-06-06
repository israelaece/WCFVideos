using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace WCFVideos.WebUI
{
    public partial class Propostas : System.Web.UI.Page, ServicoDeGestaoDeCredito.IGestorDeCreditoCallback
    {
        private ServicoDeGestaoDeCredito.GestorDeCreditoClient _proxy;
        private List<ServicoDeGestaoDeCredito.Proposta> _propostas;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.AddOnPreRenderCompleteAsync(Iniciar, Finalizar);
        }

        private IAsyncResult Iniciar(object sender, EventArgs args, AsyncCallback callback, object state)
        {
            _proxy = new ServicoDeGestaoDeCredito.GestorDeCreditoClient(new InstanceContext(this), "NetTcpBinding_IGestorDeCredito");
            return _proxy.BeginRecuperarPropostas(ServicoDeGestaoDeCredito.Status.Aprovada, callback, state);
        }

        private void Finalizar(IAsyncResult result)
        {
            ServicoDeGestaoDeCredito.Proposta[] temp =
                _proxy.EndRecuperarPropostas(result);

            _propostas = new List<ServicoDeGestaoDeCredito.Proposta>(temp);
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            this.RelacaoDePropostas.DataSource = _propostas;
            this.RelacaoDePropostas.DataBind();
        }

        #region IGestorDeCreditoCallback Members

        public void PropostaAnalisada(WCFVideos.WebUI.ServicoDeGestaoDeCredito.Proposta proposta)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginPropostaAnalisada(WCFVideos.WebUI.ServicoDeGestaoDeCredito.Proposta proposta, AsyncCallback callback, object asyncState)
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