using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Matrix_T_C
{
    internal class Matrix
    {
        
        public int Hight { get; set; }
        public int Width { get; set; }

        public int[,] MatrixOb = null;

        public string MatrixName { get; set; }

        public Matrix(int hight = 1, int width = 1, string matrixName = "Default" )
        {
            Hight = hight;
            Width = width;
            MatrixOb = new int[hight, width];
            MatrixName = matrixName;
        }
        public void SetElements(int elem = 0, int height = 0, int width = 0)
        {
            try 
            {   
                MatrixOb[height, width] = elem;
                
            }
            catch(ArgumentOutOfRangeException de) 
            {
                throw de;
            }
        }
        public string GetElements(int elem = 0, int height = 0, int width = 0)
        {
            try
            {
                return MatrixOb[height, width].ToString();
            }
            catch (ArgumentOutOfRangeException de)
            {
                throw de;
            }
        }

        public void RandomElem()
        {
            Random rand = new Random();
            for (int i = 0; i < Hight; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    MatrixOb[i, j] = rand.Next(0, 10);
                }
            }
        }
        public Matrix Sum (Matrix a)
        {
            Matrix Sum = new Matrix(Hight,Width);
            for (int i = 0; i < Hight; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Sum.MatrixOb[i,j] = MatrixOb[i,j] + a.MatrixOb[i,j];
                }
            }
            return Sum;
        }
        public Matrix Raznost(Matrix a)
        {
            Matrix Razn = new Matrix(Hight, Width);
            for (int i = 0; i < Hight; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Razn.MatrixOb[i, j] = MatrixOb[i, j] - a.MatrixOb[i, j];
                }
            }
            return Razn;
        }
        public override string ToString()
        {
            StringBuilder Mstr = new StringBuilder();
            for (int i = 0; i < Hight; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    Mstr.Append(MatrixOb[i, j].ToString() + " ");
                }
                Mstr.Append("\r\n");
            }
            return Mstr.ToString();
        }

    }
}
