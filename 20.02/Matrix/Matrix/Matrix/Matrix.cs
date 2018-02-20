using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        int[] ac = { 8, 21, 5, 9, 7, 4, 23, 1, 9, 5, 21, 8 };
        Random random;
        int[,] a;
        public int N { get;  }
        public int M { get;  }
        private Matrix() { }
        public Matrix(int n, int m)
        {
            random = new Random();
            N = n;
            M = m;
            a = new int[N,M];
        }
        public void setMatrixCons()
        {
            for (int i = 0, k = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i,j] = ac[k++];
        }

        public void printMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        public int getNumber(int index1,int index2)
        {
            return a[index1, index2];
        }



    }
}
