using System;
using System.ServiceModel;
using System.Windows.Forms;
using WCFVideos.WinUI.ServiceDeGestaoDeCredito;

namespace WCFVideos.WinUI
{
    public partial class Principal : Form, IGestorDeCreditoCallback
    {
        private ServiceDeGestaoDeCredito.GestorDeCreditoClient _proxy;

        public Principal()
        {
            InitializeComponent();

            this._proxy = new ServiceDeGestaoDeCredito.GestorDeCreditoClient(new InstanceContext(this), "NetTcpBinding_IGestorDeCredito");
            this._proxy.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);
        }

        void InnerChannel_Faulted(object sender, EventArgs e)
        {
            this._proxy.Abort();

            this._proxy = new ServiceDeGestaoDeCredito.GestorDeCreditoClient(new InstanceContext(this), "NetTcpBinding_IGestorDeCredito");
            this._proxy.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                this.TotalDeRecurso.Text =
                    this._proxy.RecuperarQuantidadeDeRecursoDisponivel().ToString("N2");
            }
            catch (FaultException<ServiceDeGestaoDeCredito.DetalhesDoErro> ex)
            {
                MessageBox.Show(ex.Detail.Mensagem);
            }
            catch
            {
                MessageBox.Show("Deu algum problema");
            }
        }

        private void CriarNovaProposta_Click(object sender, EventArgs e)
        {
            new Proposta().ShowDialog();
        }

        private void VisualizarPropostas_Click(object sender, EventArgs e)
        {
            new Propostas().Show();
        }

        #region IGestorDeCreditoCallback Members

        public void PropostaAnalisada(WCFVideos.WinUI.ServiceDeGestaoDeCredito.Proposta proposta)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginPropostaAnalisada(WCFVideos.WinUI.ServiceDeGestaoDeCredito.Proposta proposta, AsyncCallback callback, object asyncState)
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