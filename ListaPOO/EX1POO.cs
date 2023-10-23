using System;

 internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo area1;
            area1 = new Retangulo();

            Console.Write("Insira o Valor da Base do Retângulo: ");
            area1.setB(double.Parse(Console.ReadLine()));

            Console.Write("Insira o Valor da Altura do Retângulo: ");
            area1.setH(double.Parse(Console.ReadLine()));

            area1.calcular();

            Console.WriteLine("");

            Console.WriteLine("A Área do Retângulo de Base {0} e Altura {1} é {2}",
                area1.getB(), area1.getH(), area1.getArea());
        }
    }


internal class Retangulo
    {
        private double b;
        private double h;
        private double area;

        public void setB(double p)
        {
            b = p;
        }
        public void setH(double p)
        {
            h = p;
        }
        public double getB()
        {
            return b;
        }
        public double getH()
        {
            return h;
        }

        public double getArea()
        {
            return area;
        }
        public void calcular()
        {
            area = b * h;
        }
    }

