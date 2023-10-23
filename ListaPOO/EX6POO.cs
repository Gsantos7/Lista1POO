using System;

internal class Program
{
    static void Main(string[] args)
    {
        Quilometros conversao1;
        conversao1 = new Quilometros();

        Console.Write("Insira a quantidade de Milhas Marítimas: ");
        conversao1.setMilha(double.Parse(Console.ReadLine()));

        conversao1.calcular();

        Console.WriteLine("");

        Console.WriteLine("{0} Milhas Marítimas Equivalem a {1} Quilômetros",
            conversao1.getMilha(), conversao1.getKm());
    }
}


internal class Quilometros
{
    private double milha;
    private double km;

    public void setMilha(double p)
    {
        milha = p;
    }

    public double getMilha()
    {
        return milha;
    }

    public double getKm()
    {
        return km;
    }

    public void calcular()
    {
        km = (milha * 1852)/1000;
    }
}