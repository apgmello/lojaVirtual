using _01_lojaVirtual;

string produto;
int opcao;
decimal valorPagamento;
DateOnly dataPagamento;
Pagamento pagamento = null;


Console.Write("Digite o produto: ");
produto = Console.ReadLine();

Console.Write("Digite o valor: ");
decimal.TryParse(Console.ReadLine(), out valorPagamento);

Console.Write("Digite a data de pagamento: ");
DateOnly.TryParse(Console.ReadLine(), out dataPagamento);

Console.Write("Qual a forma de pagamento\n" +
    "(1) Cartão de Crédito\n" +
    "(2) Boleto\n" +
    "(3) Cartão de Débito\n" +
    "Opção: ");
int.TryParse(Console.ReadLine(), out opcao);

Console.WriteLine("-----------------------");
switch (opcao)
{
    case 1:
        pagamento = new CartaoCredito(valorPagamento, dataPagamento);
        break;

    case 2:
        pagamento = new Boleto(valorPagamento, dataPagamento);
        break;

    case 3:
        pagamento = new CartaoDebito(valorPagamento, dataPagamento);
        break;
}

Pedido pedido = new Pedido(produto, pagamento);
pedido.Imprimir();