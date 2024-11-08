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

            PyramidConstruction(5, false);

            Factorial(10);
            Console.WriteLine();
            Console.WriteLine(Factorialr(10));

            int[]tableau = new int[]{ 1, -5, 10, 3, 0, 4, 2, -7 };
            Console.WriteLine(LinearSearch(tableau, 4));
      




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

            else if (heure == 12)
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
        static void PyramidConstruction(int n, bool isSmooth)
        {
            int nblock = 2 * n + 1;
            int c = (int)((2 * n + 1) / 2);

            for (int j = 0; j <= n; j++)
            {

                int bd = c + j;
                int bg = c - j;
                for (int k = 0; k <= bd; k++)
                {
                    if (k < bg)
                    {

                        Console.Write(" ");
                    }

                    else
                    {

                        if (isSmooth == true)
                        {
                            Console.Write("+");
                        }
                        else if (isSmooth == false && j % 2 != 0)
                        {
                            Console.Write("-");
                        }
                        else if (isSmooth == false && j % 2 == 0)
                        {
                            Console.Write("+");
                        }

                    }

                }
                Console.Write("\n");
            }

        }
        static void Factorial(int n)
        {
            int j = 1;

            for (int i = n; i > 1; i--)
            {
                j = (j * i);

                
            }
            Console.Write(j + " ");
        }
        static int Factorialr(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }

            return Factorialr(n - 1) * n;

        }
        static int LinearSearch(int[] tableau, int valeur)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                {
                    return i;
                }
            }

            return -1;
        }
        static int BinarySearch(int[] tableau, int valeur)
        {
            

           // for (int i = 0; i < tableau.Length; i++)

            {int m = tableau.Length / 2;
                int bg = 0;
                int bd = tableau.Length;

                
                While (m == valeur)
                {
                    return i;
                }
                if (m<valeur)
                {
                    bg = m;
                    bd = tableau.Length - bg;
                    m = tableau.Length / 2;

                }

                if (m>valeur)
                {
                    bd = m;
                    m = tableau.Length / 2;



                }



               
            Bd
           if valeur > bd
                bd = M


            //}

        }



    }
