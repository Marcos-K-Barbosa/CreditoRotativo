double ValorTotalFaturas, PagamentoMinimo, PagamentoMinimu, TaxaJurosMensais, ValorNãoPago,Juros, IOFMensais, IOFdiario, ValorASerPagoProximoMes, CustoCreditoRotativo;

Console.Clear();

Console.WriteLine ("Valor total da fatura (R$)...: ");
ValorTotalFaturas = Convert.ToDouble (Console.ReadLine()!);

Console.WriteLine("Pagamento mínimo (%).........:");
PagamentoMinimo =Convert.ToDouble (Console.ReadLine()!);

Console.WriteLine("Taxa de juros mensais (%)....:");
TaxaJurosMensais =Convert.ToDouble (Console.ReadLine()!);

PagamentoMinimu = ValorTotalFaturas * PagamentoMinimo/100;

Console.WriteLine ($"Pagamento mínimo: {ValorTotalFaturas} * {PagamentoMinimo/100} = {PagamentoMinimu}");

ValorNãoPago = ValorTotalFaturas - PagamentoMinimu;
Console.WriteLine ($"Valor não pago: {ValorTotalFaturas} - {PagamentoMinimu} = {ValorNãoPago}");

Juros = TaxaJurosMensais/100 * ValorNãoPago;
Console.WriteLine ($"Juros: {TaxaJurosMensais/100} * {ValorNãoPago} = {Juros}");

IOFMensais = ValorNãoPago * 0.0038;
Console.WriteLine ($"IOF mensal: {ValorNãoPago} * 0,0038 = {IOFMensais:n2}");

IOFdiario = ValorNãoPago * 0.00246;
Console.WriteLine($"IOF diario: {ValorNãoPago} * 0,00246 = {IOFdiario :n2}");

ValorASerPagoProximoMes = ValorNãoPago + Juros + IOFMensais + IOFdiario;
Console.WriteLine ($"Valor a pagar na próxima fatura: {ValorNãoPago} + {Juros} + {IOFMensais:n2} + {IOFdiario:n2} = {ValorASerPagoProximoMes:n2}");

CustoCreditoRotativo = Juros + IOFMensais + IOFdiario;
Console.WriteLine ($"Custo do crédito rotativo: {Juros} + {IOFMensais:n2} + {IOFdiario:n2} = {CustoCreditoRotativo:n2}");
