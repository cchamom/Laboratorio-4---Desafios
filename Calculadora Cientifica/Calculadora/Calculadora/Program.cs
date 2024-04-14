using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            int n3 = 17;
            int n4 = 3;

            Console.WriteLine("CALCULADORA BASICA");
            Console.WriteLine();
            Calculadora Calc = new Calculadora("Casio", "fx-899");
            double total = Calc.Sumar(n1, n2);
            Console.WriteLine("El resultado de la suma es: " + total);

            double diferencia = Calc.Restar(n1, n2);
            Console.WriteLine("El resultado de la resta es: " + diferencia);

            double multiplicar = Calc.Multiplicacion(n1, n2);
            Console.WriteLine("El resultado de la multiplicacion es: " + multiplicar);

            double division = Calc.Division(n1, n2);
            Console.WriteLine("El resultado de la division es: " + division);
            Console.WriteLine("");

            Console.WriteLine("CALCULADORA CIENTIFICA");
            Console.WriteLine();
            CalculadoraCientifica cientifica = new CalculadoraCientifica("hep", "7");
            double potencia = cientifica.Potencias(n1, n2);
            Console.WriteLine("La potencia del numero es: " + potencia);

            double Raiz = cientifica.RaizCuadrada(n1);
            Console.WriteLine("La raiz cuadrada es: " + Raiz);

            int modulo = cientifica.Modulo(n3, n4);
            Console.WriteLine("El modulo del numero es: " + modulo);

            double logaritmo = cientifica.Logaritmo(n1, n2);
            Console.WriteLine("El logaritmo del numero es: " + logaritmo);

            MostrarTipo(Calc);
            MostrarTipo(cientifica);

            Console.ReadLine();
        }

        public static void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora.Tipo());
        }
    }
}



