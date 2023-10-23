using System;

internal class Program
{
    static void Main(string[] args)
    {
        Triangulo formato;
        formato = new Triangulo();

        Console.Write("Digite o 1º Valor: ");
        formato.setV1(double.Parse(Console.ReadLine()));

        Console.Write("Digite o 2º Valor: ");
        formato.setV2(double.Parse(Console.ReadLine()));

        Console.Write("Digite o 3º Valor: ");
        formato.setV3(double.Parse(Console.ReadLine()));

        formato.calcular();

        Console.WriteLine("");

        Console.WriteLine("{0}", formato.getClassificacao());
    }
}

internal class Triangulo
{
    private double v1;
    private double v2;
    private double v3;
    private string classificacao;

    public void setV1(double p)
    {
        v1 = p;
    }
    public void setV2(double p)
    {
        v2 = p;
    }
    public void setV3(double p)
    {
        v3 = p;
    }

    public double getV1()
    {
        return v1;
    }
    public double getV2()
    {
        return v2;
    }
    public double getV3()
    {
        return v3;
    }
    public string getClassificacao()
    {
        return classificacao;
    }
    public void calcular()
    {
        v1 = Math.Pow(v1, 2);
        v2 = Math.Pow(v2, 2);
        v3 = Math.Pow(v3, 2);

        if ((v1 + v2) == v3)
        {
            classificacao = "Formam um Triângulo Retângulo";
        }
        else
        {
            if ((v2 + v3) == v1)
            {
                classificacao = "Formam um Triângulo Retângulo";
            }
            else
            {
                if ((v1 + v3) == v2)
                {
                    classificacao = "Formam um Triângulo Retângulo";
                }
                else
                {
                    classificacao = "Não Formam um Triângulo Retângulo";
                }
            }
        }
    }
}