using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray {
    class Program {
        static void Main(string[] args) {
            int total = 10;
            int[] arr = new int[total];

            String aux;

            for (int i = 0; i < total; i++) {
                Console.Write("\nIntroduce numeros: ");
                aux = Console.ReadLine();
                arr[i] = int.Parse(aux);
            }

            for (int i = 0; i < total; i++) {
                Console.Write("[" + arr[i] + "]");
            }

            int menor = arr[total - 1];

            for (int i = 0; i < total; i++) {
                if (arr[i] < menor) {
                    menor = arr[i];
                }
            }
            Console.WriteLine("\n\nEl numero menor en el array fue: " + menor);
            Console.ReadLine();
        }
    }
}

