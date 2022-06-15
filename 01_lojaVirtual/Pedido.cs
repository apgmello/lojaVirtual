namespace _01_lojaVirtual
{
    internal class Pedido
    {
        private string produto;
        private Pagamento pagamento;

        public Pedido(string produto, Pagamento pagamento)
        {
            this.produto = produto;
            this.pagamento = pagamento;
        }

        internal void Imprimir()
        {
            Console.WriteLine($"Produto: {produto}");
            pagamento.Imprimir();
        }
    }
}
