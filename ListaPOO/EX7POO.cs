using System;

internal class Program
{
    static void Main(string[] args)
    {
        Reais conversao1;
        conversao1 = new Reais();

        Console.Write("Insira o Valor da Cotação do Dólar:");
        conversao1.setCotacao(double.Parse(Console.ReadLine()));

        Console.Write("Insira um  um Valor em Dólares:");
        conversao1.setDol(double.Parse(Console.ReadLine()));

        conversao1.calcular();

        Console.WriteLine("");

        Console.WriteLine("Resultado em Reais: {0}",conversao1.getReal().ToString("C"));
    }
}

internal class Reais
{

    private double cotacao;
    private double dolar;
    private double real;


    public void setCotacao(double p)
    {
        cotacao = p;
    }
    public void setDol(double p)
    {
        dolar = p;
    }

    public double getCotacao()
    {
        return cotacao;
    }

    public double getDol()
    {
        return dolar;
    }

    public double getReal()
    {
        return real;
    }

    public void calcular()
    {
        real = dolar * cotacao;
    }
}