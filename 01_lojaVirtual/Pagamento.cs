namespace _01_lojaVirtual
{
    internal abstract class Pagamento
    {
        public decimal valorPagamento;
        public DateOnly dataPagamento;

        public Pagamento(decimal valorPagamento, DateOnly dataPagamento)
        {
            this.valorPagamento = valorPagamento;
            this.dataPagamento = dataPagamento;
        }
        public virtual void Imprimir()
        {
            Console.WriteLine($"Valor: {valorPagamento}");
            Console.WriteLine($"Data de pagamento: {dataPagamento}");
        }
    }
}
