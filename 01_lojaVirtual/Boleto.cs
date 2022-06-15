namespace _01_lojaVirtual
{
    internal class Boleto : Pagamento
    {
        private long codigoBarra;
        private const string banco = "Safra";
        private const string agencia = "0071";

        public Boleto(decimal valorPagamento, DateOnly dataPagamento) : base(valorPagamento, dataPagamento)
        {
            this.codigoBarra = new Random().NextInt64(100000000000000000,999999999999999999);
        }

        public override void Imprimir()
        {
            Console.WriteLine("Dados do boleto");
            Console.WriteLine($"Banco: {banco}");
            Console.WriteLine($"Agência: {agencia}");
            Console.WriteLine($"Código de Barras: {codigoBarra}");
            base.Imprimir();
        }
    }
}
