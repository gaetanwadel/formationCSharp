using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percolation
{
    public class Percolation
    {
        private readonly bool[,] _open;
        private readonly bool[,] _full;
        private readonly int _size;
        private bool _percolate;

        public Percolation(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), size, "Taille de la grille négative ou nulle.");
            }

            _open = new bool[size, size];
            _full = new bool[size, size];
            _size = size;
        }

        public bool IsOpen(int i, int j)
        {
            if (_open[i, j] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFull(int i, int j)
        {
            if (_open[i, j] == true && _full[i, j] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Percolate()
        {
            for (int i = 0; i > _size; i++)
            {
                for (int j = 0; j > _size; j++)
                {
                    if (IsFull(i, j) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public List<KeyValuePair<int, int>> CloseNeighbors(int i, int j)
        {
            List<KeyValuePair<int, int>> neighbor = new List<KeyValuePair<int, int>>();
            if (i - 1 >= 0)
            {
            neighbor.Add(new KeyValuePair<int, int>((i - 1),j ));
            }
            if (j - 1 >= 0)
            {
            neighbor.Add(new KeyValuePair<int, int>(i ,(j-1)));
            }
            if (i + 1 < _size)
            {
             neighbor.Add(new KeyValuePair<int, int>((i+1), (j )));
            }
            if (j + 1 < _size)
            {
            neighbor.Add(new KeyValuePair<int, int>((i), (j+1)));
            }
            return neighbor;

        }

        public void Open(int i, int j)
        {

        }
    }
}
