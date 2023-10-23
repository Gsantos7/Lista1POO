using System;

internal class Program
{
    static void Main(string[] args)
    {
        Quadrado area1;
        area1 = new Quadrado();

        Console.Write("Insira o Valor da Diagonal do Quadrado: ");
        area1.setDiagonal(double.Parse(Console.ReadLine()));

        area1.calcular();

        Console.WriteLine("");

        Console.WriteLine("A área do quadrado de diagonal {0}m é {1}",
            area1.getDiagonal(), area1.getArea());
    }
}


internal class Quadrado
{
    private double diagonal;
    private double area;

    public void setDiagonal(double p)
    {
        diagonal = p;
    }

    public double getDiagonal()
    {
        return diagonal;
    }

    public double getArea()
    {
        return area;
    }

    public void calcular()
    {

        area = Math.Pow(diagonal / Math.Sqrt(2), 2);

    }

}

