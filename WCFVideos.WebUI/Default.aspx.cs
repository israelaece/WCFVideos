using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace WCFVideos.WebUI
{
    public partial class _Default : System.Web.UI.Page, ServicoDeGestaoDeCredito.IGestorDeCreditoCallback
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (ServicoDeGestaoDeCredito.GestorDeCreditoClient proxy =
                    new WCFVideos.WebUI.ServicoDeGestaoDeCredito.GestorDeCreditoClient(new InstanceContext(this), "NetTcpBinding_IGestorDeCredito"))
                {
                    this.RecursoDisponivel.Text =
                        proxy.RecuperarQuantidadeDeRecursoDisponivel().ToString("N2");
                }
            }
        }

        protected void NovaProposta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proposta.aspx");
        }

        protected void VisualizarPropostas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Propostas.aspx");
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