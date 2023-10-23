using System;

internal class Program
{
    static void Main(string[] args)
    {
        Maior Valores1;
        Valores1 = new Maior();

        Console.Write("Insira o 1º Valor: ");
        Valores1.setV1(double.Parse(Console.ReadLine()));

        Console.Write("Insira o 2º Valor (diferente do primeiro): ");
        Valores1.setV2(double.Parse(Console.ReadLine()));

        Valores1.calcular();

        Console.WriteLine("");

        Console.WriteLine("O Maior Valor é {0}", Valores1.getMaior());
    }
}

internal class Maior
{
    private double v1;
    private double v2;
    private double maior;


    public void setV1(double p)
    {
        v1 = p;
    }
    public void setV2(double p)
    {
        v2 = p;
    }

    public double getV1()
    {
        return v1;
    }

    public double getV2()
    {
        return v2;
    }

    public double getMaior()
    {
        return maior;
    }

    public void calcular()
    {
        if (v1 > v2)
        {
            maior = v1;
        }
        else
        {
            maior = v2;
        }
    }
}