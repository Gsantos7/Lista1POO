using System;

 internal class Program
 {
     static void Main(string[] args)
     {
         Quadrado area1;
         area1 = new Quadrado();

         Console.Write("Insira o Valor da Areasta do Quadrado: ");
         area1.setAresta(double.Parse(Console.ReadLine()));


         area1.calcular();

         Console.WriteLine("");

         Console.WriteLine("A Área do Quadrado de Aresta {0} é {1}",
             area1.getAresta(), area1.getArea());
     }
 }


internal class Quadrado
{
    private double aresta;
    private double area;

    public void setAresta(double p)
    {
        aresta = p;
    }

    public double getAresta()
    {
        return aresta;
    }

    public double getArea()
    {
        return area;
    }

    public void calcular()
    {
        area = aresta * aresta;
    }
}