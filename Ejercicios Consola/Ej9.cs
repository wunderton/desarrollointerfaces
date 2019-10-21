using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("Escriba un numero: ");
                String a = Console.ReadLine();
                float num1 = int.Parse(a);

                Console.WriteLine("Escriba otro numero: ");
                String b = Console.ReadLine();
                float num2 = int.Parse(b);

                float resultado = num1 / num2;
                Console.Write("Resultado: ");
                Console.WriteLine(resultado);
            }
            catch (Exception e) {
                Console.WriteLine("El caracter introducido no era un numero" + e);
            }
            Console.ReadLine();
        }
    }
}
