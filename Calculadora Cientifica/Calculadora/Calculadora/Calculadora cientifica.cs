using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacion(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Division(double n1, double n2)
        {
            return n1 / n2;
        }

        public virtual string Tipo()
        {
            return "Calculadora basica";
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencias(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double RaizCuadrada(double n1)
        {
            return Math.Sqrt(n1);
        }

        public int Modulo(int n3, int n4)
        {
            return n3 % n4;
        }

        public double Logaritmo(double n1, double n2)
        {
            return Math.Log10(n1);
        }

        public override string Tipo()
        {
            return "Cientifica";
        }
    }
}


