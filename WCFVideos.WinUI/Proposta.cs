using System;
using System.ServiceModel;
using System.Windows.Forms;
using GestorDeCredito = WCFVideos.WinUI.ServiceDeGestaoDeCredito;

namespace WCFVideos.WinUI
{
    public partial class Proposta : Form, GestorDeCredito.IGestorDeCreditoCallback
    {
        private GestorDeCredito.GestorDeCreditoClient _proxy;

        public Proposta()
        {
            InitializeComponent();

            this._proxy =
                new GestorDeCredito.GestorDeCreditoClient(
                    new InstanceContext(this), "NetTcpBinding_IGestorDeCredito");
        }

        private void Proposta_Load(object sender, EventArgs e)
        {
            this.Data.Text = string.Format("Data: {0:dd/MM/yyyy}", DateTime.Now);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnalisarProposta_Click(object sender, EventArgs e)
        {
            GestorDeCredito.Proposta novaProposta = new GestorDeCredito.Proposta();
            novaProposta.Data = DateTime.Now;
            novaProposta.Numero = 1;
            novaProposta.Status = GestorDeCredito.Status.EmAnalise;

            GestorDeCredito.Cliente cliente = new GestorDeCredito.Cliente();
            cliente.Nome = this.Nome.Text;
            cliente.Empresa = this.Empresa.Text;
            cliente.Idade = Convert.ToInt32(this.Idade.Text);
            cliente.Salario = Convert.ToDecimal(this.Salario.Text);
            novaProposta.Cliente = cliente;

            GestorDeCredito.Emprestimo emprestimo = new GestorDeCredito.Emprestimo();
            emprestimo.QuantidadeDeParcelas = Convert.ToInt32(this.QuantidadeDeParcelas.Text);
            emprestimo.TaxaDeJuros = Convert.ToDecimal(this.TaxaDeJuros.Text);
            emprestimo.Valor = Convert.ToDecimal(this.Valor.Text);
            novaProposta.Emprestimo = emprestimo;

            this._proxy.AnalisarProposta(novaProposta);
        }

        #region IGestorDeCreditoCallback Members

        public void PropostaAnalisada(GestorDeCredito.Proposta proposta)
        {
            if (proposta.Status == GestorDeCredito.Status.Aprovada)
            {
                if (MessageBox.Show("Proposta Aprovada.\n\nDeseja efetivar a proposta?", "Proposta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this._proxy.EfetivarProposta(proposta);
                }
            }
            else
            {
                MessageBox.Show("Proposta não Aprovada");
            }
        }

        public IAsyncResult BeginPropostaAnalisada(GestorDeCredito.Proposta proposta, AsyncCallback callback, object asyncState)
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