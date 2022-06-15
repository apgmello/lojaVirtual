namespace _01_lojaVirtual
{
    internal class CartaoDebito : Pagamento
    {
        public CartaoDebito(decimal valorPagamento, DateOnly dataPagamento) : base(valorPagamento, dataPagamento)
        {
            this.valorPagamento *= 1.02M;
        }
        public override void Imprimir()
        {
            Console.WriteLine("Dados de Pagamento com Cartão de Débito");
            base.Imprimir();
        }
    }
}
