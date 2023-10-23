using System;

internal class Program
{
    static void Main(string[] args)
    {
        Maior Valores1;
        Valores1 = new Maior();

        Console.Write("Insira o 1º Valor: ");
        Valores1.setV1(double.Parse(Console.ReadLine()));

        Console.Write("Insira o 2º Valor: ");
        Valores1.setV2(double.Parse(Console.ReadLine()));

        Valores1.calcular();

        Console.WriteLine("");

        Console.WriteLine("{0}", Valores1.getMaiorigual());
    }
}

internal class Maior
{
    private double v1;
    private double v2;
    private string maiorigual;


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

    public string getMaiorigual()
    {
        return maiorigual;
    }

    public void calcular()
    {
        if (v1 == v2)
        {
           maiorigual="Valores Idênticos";
        }
        else
        {
            if (v1 > v2)
            {
                maiorigual = "O 1º Valor é o Maior";
            }
            else
            {
                maiorigual = "O 2º Valor é o Maior"; 
            }
        }
    }
}