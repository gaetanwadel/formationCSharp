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

            Pow(2, 3);
            Pow(5, -6);

            GoodDay(16);

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
        static void Pow(int a, int b)
        {
            int resultat;

            if (b < 0)
            {
                Console.WriteLine(" Opération Invalide .");


            }

            else
            {
                resultat = (int)Math.Pow(a, b);
                Console.WriteLine(a + " ^ " + b + " = " + resultat + " ");

            }
        }
        static void GoodDay(int heure)
        {
     

            if (00 <= heure && heure < 06)
            {

                Console.WriteLine(" Il est " + heure + ' ' + 'H' + ',' + " Merveilleuse Nuit!");

            }

            else if (06 <= heure && heure < 12)
            {

                Console.WriteLine(" Il est " + heure + ' ' + 'H' + ',' + " Bonne Matinée!");

            }

            else if ( heure == 12 )
            {

                Console.WriteLine(" Il est " + heure + ' ' + 'H' + ',' + " Bon midi!");
            }

            else if (13 < heure && heure < 18)
            {
                Console.WriteLine(" Il est " + heure + ' ' + 'H' + ',' + " Profitez de votre après-midi!");
            }

            else if (heure >= 18)
            {
                Console.WriteLine(" Il est " + heure + ' ' + 'H' + ',' + " Passez une bonne soirée!");
            }

        }
          
    }
    
} 
