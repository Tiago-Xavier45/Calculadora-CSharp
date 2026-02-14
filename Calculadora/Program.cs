Console.WriteLine($"Escolha a operação desejada + - / * %");
string operacao = Console.ReadLine();

Console.WriteLine("Escolha primiero Número");
Double PNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escolha segundo Número");
Double SNum = Convert.ToDouble(Console.ReadLine());

if (operacao == "+")
{
    double resultado = PNum + SNum;
    Console.WriteLine(resultado);
}
else if (operacao == "-")
{
    double resultado = PNum- SNum;
    Console.WriteLine(resultado);
}
else if (operacao == "/")
{
    double resultado = PNum / SNum;
    Console.WriteLine(resultado);
}
else if (operacao == "*")
{
    double resultado = PNum * SNum;
    Console.WriteLine(resultado);
}
else if (operacao == "%")
{
    double resultado = PNum % SNum;
    Console.WriteLine(resultado);
}

Console.WriteLine("Operação finalizada");