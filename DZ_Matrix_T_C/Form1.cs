using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Matrix_T_C
{
   
    public partial class MainWondow : Form
    {
        static int matrixID = 0;
        static Matrix matrixSave = new Matrix();
        static Matrix matrixSave1 = new Matrix();
        static Matrix matrixSave2 = new Matrix();
        public MainWondow()
        {
            InitializeComponent();
            
        }

        private void CreateM_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix a = new Matrix(Convert.ToInt32(HeightNew.Text), Convert.ToInt32(WidthNew.Text),matrixID.ToString());
                matrixID++;
                DialogResult dres = MessageBox.Show("Заполнить матрицу случайными числами от 0 до 10 ?", "Заполнение матрицы",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dres == DialogResult.Yes) {
                    a.RandomElem();
                }
               MatrixViev.Text = a.ToString();
               
               NumberMatrix.Text = a.MatrixName.ToString();
                
               matrixSave = a;
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message.ToString(),"Введены не числа");
            }
        }

        private void EnterElem_Click(object sender, EventArgs e)
        {
            try
            {
                matrixSave.SetElements(Convert.ToInt32(ElemValue.Text), Convert.ToInt32(SelectH.Text), Convert.ToInt32(SelecW.Text));
                MatrixViev.Text = matrixSave.ToString();
                int h = Convert.ToInt32(SelectH.Text), w = Convert.ToInt32(SelecW.Text);
                if(h < matrixSave.Hight && w < matrixSave.Width)
                {
                    if (h < matrixSave.Hight)
                    {
                        SelectH.Text = (h + 1).ToString();
                        h++;
                        if (h == matrixSave.Hight)
                        {
                            SelectH.Text = (h = 0).ToString();
                            w++;
                            SelecW.Text = w.ToString();
                            
                        }
                    }
                }
                if (w == matrixSave.Width)
                    SelecW.Text = (w = 0).ToString();
            }
            catch(FormatException er)
            {
                MessageBox.Show(er.Message,"Ошибка!!!!");
            }
        }

        private void ExportFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog();
            
            
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                saveF.RestoreDirectory = true;
                FileStream fs = new FileStream(Path.GetFullPath(saveF.FileName), FileMode.Create);
               
                byte[] input = Encoding.Default.GetBytes(matrixSave.Hight.ToString()+"\r\n"+MatrixViev.Text.ToString());
                fs.Write(input, 0, input.Length); ;
                fs.Close(); 
            }
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openF = new OpenFileDialog();

            DialogResult res = openF.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fs = new StreamReader(openF.FileName);
                MatrixViev.Text = fs.ReadToEnd();

                fs.Close();
            }
        }

        //private void ImportFile_Click(object sender, EventArgs e)
        //{

        //    OpenFileDialog openF = new OpenFileDialog();

        //    //DialogResult res = openF.ShowDialog();
        //    //if (res == DialogResult.OK)
        //    //{
        //    //    var fs = new StreamReader(openF.FileName);
        //    //    MatrixViev.Text = fs.ReadToEnd();
        //    //    OpenFileDialog openF = new OpenFileDialog();

        //    DialogResult res = openF.ShowDialog();
        //    if (res == DialogResult.OK)
        //    {
        //        var fs = new StreamReader(openF.FileName);
        //        string mx1 = fs.ReadToEnd();
        //        string[] mmx1 = mx1.Split(' ', '\n');

        //        for (int i = 1; i < matrixSave.Hight; i++)
        //        {
        //            for (int j = 1; j < matrixSave.Width; j++)
        //            {
        //                matrixSave.MatrixOb[i, j] = Convert.ToInt32(mmx1[j+i]);
        //            }
        //        }
        //        fs.Close();
        //        MatrixViev.Text = matrixSave.ToString();
        //    }
        //    //fs.Close();
        //}


        private void operStart_Click(object sender, EventArgs e)
        {
            
            if (Operation.Text == "+")
            {
                MatrixViev.Text = (matrixSave = matrixSave1.Sum(matrixSave2)).ToString();
                
            }
            if (Operation.Text == "-")
            {
                MatrixViev.Text = (matrixSave = matrixSave1.Raznost(matrixSave2)).ToString();
               
            }
            Operand1.Text = "Загрузить";
            Operand2.Text = "Загрузить";


        }

        private void Operand1_Click(object sender, EventArgs e)
        {
           matrixSave1 = new Matrix(matrixSave.Hight, matrixSave.Width);
           for(int i = 0; i < matrixSave1.Hight; i++)
            {
               for(int j = 0; j < matrixSave1.Width; j++)
                {
                    matrixSave1.MatrixOb[i, j] = matrixSave.MatrixOb[i, j];
                }
            }
            Operand1.Text = "ok";
        }

        private void Operand2_Click(object sender, EventArgs e)
        {
            matrixSave2 = new Matrix(matrixSave.Hight, matrixSave.Width);
            for (int i = 0; i < matrixSave2.Hight; i++)
            {
                for (int j = 0; j < matrixSave2.Width; j++)
                {
                    matrixSave2.MatrixOb[i, j] = matrixSave.MatrixOb[i, j];
                }
            }
            Operand2.Text = "ok";
        }
    }
}
