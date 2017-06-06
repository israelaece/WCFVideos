using System;
using System.Windows.Forms;
using GestorDeCredito = WCFVideos.WinUI.ServiceDeGestaoDeCredito;

namespace WCFVideos.WinUI
{
    public partial class Propostas : Form, GestorDeCredito.IGestorDeCreditoCallback
    {
        private GestorDeCredito.GestorDeCreditoClient _proxy;

        public Propostas()
        {
            InitializeComponent();

            this._proxy =
                new GestorDeCredito.GestorDeCreditoClient(
                    new System.ServiceModel.InstanceContext(this),
                    "NetTcpBinding_IGestorDeCredito");
        }

        private void Propostas_Load(object sender, EventArgs e)
        {
            this.SetupDataGridView();
            this.ResgatarPropostas();
        }

        private void SetupDataGridView()
        {
            this.RelacaoDePropostas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RelacaoDePropostas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.RelacaoDePropostas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RelacaoDePropostas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.RelacaoDePropostas.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ResgatarPropostas()
        {
            //síncrono
            //GestorDeCredito.Proposta[] propostas = this._proxy.RecuperarPropostas(GestorDeCredito.Status.Aprovada);
            //this.CarregarPropostas(propostas);

            //APM - Modelo Programação Assíncrona
            //this._proxy.BeginRecuperarPropostas(GestorDeCredito.Status.Aprovada, new AsyncCallback(ProcessoFinalizado), null);

            this._proxy.RecuperarPropostasCompleted += new EventHandler<WCFVideos.WinUI.ServiceDeGestaoDeCredito.RecuperarPropostasCompletedEventArgs>(_proxy_RecuperarPropostasCompleted);
            this._proxy.RecuperarPropostasAsync(GestorDeCredito.Status.Aprovada);
        }

        void _proxy_RecuperarPropostasCompleted(object sender, GestorDeCredito.RecuperarPropostasCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Algum erro ocorreu na operacao");
            }
            else
            {
                this.CarregarPropostas(e.Result);
            }
        }

        //APM
        //private void ProcessoFinalizado(IAsyncResult result)
        //{
        //    GestorDeCredito.Proposta[] propostas = this._proxy.EndRecuperarPropostas(result);
        //    this.CarregarPropostas(propostas);
        //}

        private void CarregarPropostas(GestorDeCredito.Proposta[] propostas)
        {
            foreach (GestorDeCredito.Proposta p in propostas)
            {
                this.RelacaoDePropostas.Rows.Add(
                    new object[] 
                    {
                        p.Data,
                        p.Emprestimo.Valor,
                        p.Emprestimo.QuantidadeDeParcelas,
                        p.Emprestimo.TaxaDeJuros,
                        p.Cliente.Nome,
                        p.Cliente.Salario
                    });
            }
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