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

            Console.ReadKey();
        }
        static void BasicOperation (int a, int b, char operateur)
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
                    resultat =  a - b;
                    Console.WriteLine(a + " - " + b + " = " + resultat + " ");
                    break;
                case '+':
                    resultat =  a + b;
                    Console.WriteLine(a + " + " + b + " = " + resultat + " ");
                    break;
                default:              
                    Console.WriteLine(a + " " + operateur + " " + b + " = Opération Invalide .");
                    break;     
            }

        }
        
             





              


    }
} 
