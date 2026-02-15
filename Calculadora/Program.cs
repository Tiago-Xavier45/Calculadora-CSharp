using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Channels;
while (true)
{
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
        double resultado = PNum - SNum;
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
    Console.WriteLine("Desjea continuar? s/n");
    string continuar = Console.ReadLine();
    if (continuar == "n")
    {
        break;
    }
    
}
 
  