using trabavd;

double valorOriginal = 100.0; //valor pronto.
double taxaAumento = 10.0; //10% de aumento


Console.WriteLine("Informe o valor Original do salário:");
valorOriginal = double.Parse(Console.ReadLine());



AumentoCalculadora calculadora = new AumentoCalculadora();

double aumento = calculadora.CalcularAumento(valorOriginal, taxaAumento);
double novoValor = calculadora.CalcularNovoValor(valorOriginal, aumento);


Console.WriteLine($"Valor Original: R${valorOriginal:F2}");
Console.WriteLine($"Taxa de Aumento: {taxaAumento}%");
Console.WriteLine($"Novo valor: R${novoValor:F2}");

//Trabalho Pedro e Samara
