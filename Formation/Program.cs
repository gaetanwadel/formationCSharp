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

            int[] tableau = new int[] { 1, -5, 10, 3, 0, 4, 2, -7 };
            int[] tableau2 = new int[] { 1, 3, 5, 9, 16, 18, 20 };
            Console.WriteLine(LinearSearch(tableau, 4));
            Console.WriteLine(BinarySearch(tableau2, 9));

            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { -1, -4, 0 };


            Console.WriteLine(BuildingMatrix(a, b));
            DisplayMatrix(BuildingMatrix(a, b));

            int[][] A = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 4, 6 },
                new int[] { -1, 8 }

            };

            int[][] B = new int[][]
            {
                new int[] { -1,5 },
                new int[] {-4,0 },
                new int[] {0,2 }

            };

            Console.WriteLine(Addition(A, B));
            DisplayMatric(Addition(A, B));


            int[][] c = new int[][]
           {
                new int[] { 1, 2 },
                new int[] { 4, 6 },
                new int[] { -1, 8 }

            };

            int[][] d = new int[][]
            {
                new int[] { -1,5 ,0},
                new int[] {-4,0,1 }
  
            };

            Console.WriteLine(Multiplication(c, d));
            DisplayMultiplication(Multiplication(c, d));


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
            int m = tableau.Length / 2;
            int bg = 0;
            int bd = tableau.Length;
            //  for (int i = 0; i < tableau.Length; i++)
            //  

            while (bg < bd)
            {
                if (tableau[m] == valeur)

                {
                    return m;
                }

                else if (tableau[m] < valeur)
                {
                    bg = m;
                    m = (bd - bg) / 2;
                }
                else if (tableau[m] > valeur)
                {
                    bd = m;
                    m = (bd - bg) / 2;
                }
            }
            return -1;
        }
        static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {

            //int[] a = new int[] { 0, 1, 2 };
            //int[] b = new int[] { 0, 1, 2 };

            int[] a = leftVector;
            int[] b = rightVector;
            int[][] matrix = new int[a.Length][];


            for (int i = 0; i < a.Length; i++)
            {
                matrix[i] = new int[b.Length];

                for (int j = 0; j < b.Length; j++)

                {
                    matrix[i][j] = a[i] * b[j];
                }
            }
            return matrix;
        }
        static void DisplayMatrix(int[][] Matrix)
        {
            int a = Matrix.Length;
            int b = Matrix[0].Length;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)

                {
                    Console.Write((Matrix[i][j]) + " ");
                }
                Console.WriteLine();
            }
        }
        static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            int[][] a = leftMatrix;
            int[][] b = rightMatrix;
            int[][] matric = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                matric[i] = new int[b[i].Length];

                for (int j = 0; j < b[i].Length; j++)

                {
                    matric[i][j] = a[i][j] + b[i][j];
                }
            }
            return matric;
        }

        static void DisplayMatric(int[][] Matric)
        {
            int a = Matric.Length;
            int b = Matric[0].Length;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)

                {
                    Console.Write((Matric[i][j]) + " ");
                }
                Console.WriteLine();
            }

        }
        static int[][] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        { 
            int[][] c = leftMatrix;
            int[][] d = rightMatrix;
            int[][] M = new int[c.Length][];

            for (int i = 0; i < c.Length; i++)
            {
                M[i] = new int[d[0].Length];

                for (int j = 0; j < d[0].Length; j++)
                {
                    for (int k = 0; k < c[0].Length; k++)
                    {
                        M[i][j] += c[i][k] * d[k][j];
                    }
                }              
            }
            return M;
        }
        static void DisplayMultiplication(int[][] M)
        {
            int c = M.Length;
            int d = M[0].Length;

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)

                {
                    for (int k = 0; k<d; k++)
                    {
                     
                    }
                   Console.Write((M[i][j]) + " ");
                }
                Console.WriteLine();
            }

        }

    }
}

                
  
            
            
