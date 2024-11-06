using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Program
    {
        static void Main()
        {
            BasicOperation(3, 4, '+');
            BasicOperation(6, 2, '/');
            BasicOperation(3, 0, '/');
            BasicOperation(6, 9, 'L');

            IntegerDivision(12, 4);
            IntegerDivision(13, 4);
            IntegerDivision(12, 0);

            Console.ReadKey();
        }
        static void BasicOperation(int a, int b, char operateur)
        {
            int resultat;
            //operateur = '/','*','-','+' ;

            switch (operateur)
            {
                case '/':
                    if (b != 0)
                    {
                        resultat = a / b;
                        Console.WriteLine(a + " / " + b + " = " + resultat + " ");
                    }
                    else
                    {
                        Console.WriteLine(a + " / " + b + " = Opération Invalide .");
                    }
                    break;
                case '*':
                    resultat = a * b;
                    Console.WriteLine(a + " * " + b + " = " + resultat + " ");
                    break;
                case '-':
                    resultat = a - b;
                    Console.WriteLine(a + " - " + b + " = " + resultat + " ");
                    break;
                case '+':
                    resultat = a + b;
                    Console.WriteLine(a + " + " + b + " = " + resultat + " ");
                    break;
                default:
                    Console.WriteLine(a + " " + operateur + " " + b + "= Opération Invalide .");

                    break;
            }

        }
        static void IntegerDivision(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("a" + "/" + "b" + "= Opération Invalide .");
            }

            else

            {
                int q = a / b;
                int r = a % b;

                if (r == 0)

                {
                    a = q * b + r;

                    Console.WriteLine(a + " = " + q + " * " + b + " ");
                }

                else
                {
                    a = q * b + r;

                    Console.WriteLine(a + " = " + q + " * " + b + " + " + r + " ");
                }


            }
        }
    }        
} 
