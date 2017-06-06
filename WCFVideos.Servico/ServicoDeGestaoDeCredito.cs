using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using WCFVideos.Contratos;

namespace WCFVides.Servico
{
    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ServicoDeGestaoDeCredito : IGestorDeCredito
    {
        private decimal _recursoDisponivel = 25000.0M;
        private List<Proposta> _propostas = new List<Proposta>();
        private ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        public decimal RecuperarQuantidadeDeRecursoDisponivel()
        {
            _lock.EnterReadLock();
            try
            {
                //if (_recursoDisponivel < 30000)
                //    throw new RecursoIndisponivelException("Nao ha recurso disponivel");

                return _recursoDisponivel;
            }
            catch (RecursoIndisponivelException ex)
            {
                DetalhesDoErro detalhes = new DetalhesDoErro();
                detalhes.Data = DateTime.Now;
                detalhes.Mensagem = ex.Message;

                throw new FaultException<DetalhesDoErro>(detalhes);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public void AnalisarProposta(Proposta proposta)
        {
            Thread.Sleep(3000); //simula a analise da proposta

            Emprestimo emprestimo = proposta.Emprestimo;
            Cliente cliente = proposta.Cliente;

            if ((emprestimo.Valor * emprestimo.TaxaDeJuros) / emprestimo.QuantidadeDeParcelas > (cliente.Salario * 0.3M))
                proposta.Status = Status.Rejeitada;
            else
                proposta.Status = Status.Aprovada;

            IGestorDeCreditoCallback callback =
                OperationContext.Current.GetCallbackChannel<IGestorDeCreditoCallback>();

            callback.PropostaAnalisada(proposta);
        }

        public void EfetivarProposta(Proposta proposta)
        {
            _lock.EnterWriteLock();
            try
            {
                this._recursoDisponivel -= proposta.Emprestimo.Valor;
            }
            finally
            {
                _lock.ExitWriteLock();
            }

            this._propostas.Add(proposta);
        }

        public Proposta[] RecuperarPropostas(Status status)
        {
            Thread.Sleep(2000);

            //throw new Exception("algum outro erro");

            return this._propostas.ToArray();
        }
    }
}