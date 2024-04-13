using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_4
{
    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("¡Error! No se puede dividir por cero.");
                return double.NaN;
            }
            else
            {
                return num1 / num2;
            }
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public double Potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }

        public double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        public double Logaritmo(double num, double baseLog)
        {
            return Math.Log(num, baseLog);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadoraBasica = new Calculadora();
            calculadoraBasica.Marca = "Casio";
            calculadoraBasica.Serie = "123456";

            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "Casio";
            calculadoraCientifica.Serie = "789012";

            Console.WriteLine("Ejemplos de uso de la Calculadora:");
            Console.WriteLine("Suma: " + calculadoraBasica.Sumar(10, 5));
            Console.WriteLine("Resta: " + calculadoraBasica.Restar(10, 5));
            Console.WriteLine("Multiplicación: " + calculadoraBasica.Multiplicar(10, 5));
            Console.WriteLine("División: " + calculadoraBasica.Dividir(10, 5));

            Console.WriteLine("\nEjemplos de uso de la Calculadora Científica:");
            Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(2, 3));
            Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(16));
            Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(10, 3));
            Console.WriteLine("Logaritmo base 10: " + calculadoraCientifica.Logaritmo(100, 10));
            Console.ReadLine();
        }
    }

}