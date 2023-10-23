using System;

internal class Program
{
    static void Main(string[] args)
    {
        PesoIdeal peso1;
        peso1 = new PesoIdeal();

        Console.Write("Insira o Peso: ");
        peso1.setPeso(double.Parse(Console.ReadLine()));

        Console.Write("Insira a Altura: ");
        peso1.setAltura(double.Parse(Console.ReadLine()));

        peso1.calcular();

        Console.WriteLine("");

        Console.WriteLine("{0}", peso1.getClassificacao()); 
    }
}

internal class PesoIdeal
{
    private double peso;
    private double altura;
    private double relacao;
    private string classificacao;

    public void setPeso(double p)
    {
        peso = p;
    }
    public void setAltura(double p)
    {
        altura = p;
    }
    public double getPeso()
    {
        return peso;
    }
    public double setAltura()
    {
        return altura;
    }
    public string getClassificacao()
    {
        return classificacao;
    }
    public void calcular()
    {
        relacao = peso / Math.Pow(altura,2);

        if (relacao < 20)
        {
           classificacao = "Abaixo do Peso";
        }
        else
        {
            if (relacao < 25)
            {
                classificacao = "Peso Ideal";
            }
            else
            {
                classificacao = "Acima do Peso";
            }
        }
    }
}