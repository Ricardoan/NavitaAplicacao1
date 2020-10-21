using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[3];          
            int aux ;
            int[] vet3 = new int[9];
            string aux2, posicao = "";
            int  k =0;
            bool ok = false;
            string verificar = "1";
            int x = 0;

            Console.WriteLine("Entre com o numero");           
            aux2 = Console.ReadLine();

            while (ok == false)
            {                
                if ((verificar != null) && (verificar != "") && (x < aux2.Length))
                {
                    verificar = aux2.Substring(x, 1);
                    posicao = verificar;
                    vet3[x] = int.Parse(posicao);
                    x++;
                }
                else
                {
                    ok = true;
                }
            }
          
            int j = 0;
            int[] vet2 = new int[x];
            for (int i = 0; i < vet3.Length; i++)
            {
                j = i + 1;
                for (j = i + 1; j < vet3.Length; j++)
                {
                    if (vet3[i] < vet3[j])
                    {
                        aux = vet3[i];
                        vet3[i] = vet3[j];
                        vet3[j] = aux;
                    }
                }

            }
            for (int i = 0; i < x; i++)// para remover os zeros finais do vetor
            {
                vet2[i] = vet3[i];
            }
               
                Console.WriteLine("O maior número da família de N eh:");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write("{0}", vet2[i]);
            }

            Console.Read();
        }
    }
}
