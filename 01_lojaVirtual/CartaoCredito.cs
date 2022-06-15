namespace _01_lojaVirtual
{
    internal class CartaoCredito : Pagamento
    {
        public CartaoCredito(decimal valorPagamento, DateOnly dataPagamento) : base(valorPagamento, dataPagamento)
        {
            this.valorPagamento *= 1.04M;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Dados de Pagamento com Cartão de Crédito");
            base.Imprimir();
        }
    }
}
