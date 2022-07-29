namespace DZ_Matrix_T_C
{
    partial class MainWondow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MatrixViev = new System.Windows.Forms.TextBox();
            this.HeightNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HightMx = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.ListBox();
            this.WidthMX = new System.Windows.Forms.Label();
            this.WidthNew = new System.Windows.Forms.TextBox();
            this.operStart = new System.Windows.Forms.Button();
            this.CreateM = new System.Windows.Forms.Button();
            this.ElemValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelecW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectH = new System.Windows.Forms.TextBox();
            this.EnterElem = new System.Windows.Forms.Button();
            this.ImportFile = new System.Windows.Forms.Button();
            this.ExportFile = new System.Windows.Forms.Button();
            this.NumberMatrix = new System.Windows.Forms.TextBox();
            this.Operand1 = new System.Windows.Forms.Button();
            this.Operand2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вывод  Матрицы";
            // 
            // MatrixViev
            // 
            this.MatrixViev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixViev.Location = new System.Drawing.Point(19, 196);
            this.MatrixViev.Multiline = true;
            this.MatrixViev.Name = "MatrixViev";
            this.MatrixViev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MatrixViev.Size = new System.Drawing.Size(703, 295);
            this.MatrixViev.TabIndex = 1;
            // 
            // HeightNew
            // 
            this.HeightNew.Location = new System.Drawing.Point(18, 85);
            this.HeightNew.Name = "HeightNew";
            this.HeightNew.Size = new System.Drawing.Size(39, 20);
            this.HeightNew.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Матрица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Матрица 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Матрица 2";
            // 
            // HightMx
            // 
            this.HightMx.AutoSize = true;
            this.HightMx.Location = new System.Drawing.Point(15, 67);
            this.HightMx.Name = "HightMx";
            this.HightMx.Size = new System.Drawing.Size(45, 13);
            this.HightMx.TabIndex = 9;
            this.HightMx.Text = "Высота";
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Operation.FormattingEnabled = true;
            this.Operation.ItemHeight = 25;
            this.Operation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.Operation.Location = new System.Drawing.Point(601, 62);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(40, 29);
            this.Operation.TabIndex = 10;
            // 
            // WidthMX
            // 
            this.WidthMX.AutoSize = true;
            this.WidthMX.Location = new System.Drawing.Point(96, 67);
            this.WidthMX.Name = "WidthMX";
            this.WidthMX.Size = new System.Drawing.Size(46, 13);
            this.WidthMX.TabIndex = 12;
            this.WidthMX.Text = "Ширина";
            // 
            // WidthNew
            // 
            this.WidthNew.Location = new System.Drawing.Point(99, 85);
            this.WidthNew.Name = "WidthNew";
            this.WidthNew.Size = new System.Drawing.Size(39, 20);
            this.WidthNew.TabIndex = 11;
            // 
            // operStart
            // 
            this.operStart.Location = new System.Drawing.Point(647, 28);
            this.operStart.Name = "operStart";
            this.operStart.Size = new System.Drawing.Size(75, 93);
            this.operStart.TabIndex = 13;
            this.operStart.Text = "Вычислить";
            this.operStart.UseVisualStyleBackColor = true;
            this.operStart.Click += new System.EventHandler(this.operStart_Click);
            // 
            // CreateM
            // 
            this.CreateM.Location = new System.Drawing.Point(169, 28);
            this.CreateM.Name = "CreateM";
            this.CreateM.Size = new System.Drawing.Size(75, 93);
            this.CreateM.TabIndex = 14;
            this.CreateM.Text = "Создать Матрицу";
            this.CreateM.UseVisualStyleBackColor = true;
            this.CreateM.Click += new System.EventHandler(this.CreateM_Click);
            // 
            // ElemValue
            // 
            this.ElemValue.Location = new System.Drawing.Point(312, 35);
            this.ElemValue.Name = "ElemValue";
            this.ElemValue.Size = new System.Drawing.Size(100, 20);
            this.ElemValue.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Значение элемента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ширина";
            // 
            // SelecW
            // 
            this.SelecW.Location = new System.Drawing.Point(373, 85);
            this.SelecW.Name = "SelecW";
            this.SelecW.Size = new System.Drawing.Size(39, 20);
            this.SelecW.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Высота";
            // 
            // SelectH
            // 
            this.SelectH.Location = new System.Drawing.Point(312, 85);
            this.SelectH.Name = "SelectH";
            this.SelectH.Size = new System.Drawing.Size(39, 20);
            this.SelectH.TabIndex = 18;
            // 
            // EnterElem
            // 
            this.EnterElem.Location = new System.Drawing.Point(431, 28);
            this.EnterElem.Name = "EnterElem";
            this.EnterElem.Size = new System.Drawing.Size(75, 93);
            this.EnterElem.TabIndex = 22;
            this.EnterElem.Text = "Задать значение";
            this.EnterElem.UseVisualStyleBackColor = true;
            this.EnterElem.Click += new System.EventHandler(this.EnterElem_Click);
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(303, 148);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(203, 23);
            this.ImportFile.TabIndex = 23;
            this.ImportFile.Text = "Загрузить Матрицу из Файла";
            this.ImportFile.UseVisualStyleBackColor = true;
            this.ImportFile.Click += new System.EventHandler(this.ImportFile_Click);
            // 
            // ExportFile
            // 
            this.ExportFile.Location = new System.Drawing.Point(519, 148);
            this.ExportFile.Name = "ExportFile";
            this.ExportFile.Size = new System.Drawing.Size(203, 23);
            this.ExportFile.TabIndex = 24;
            this.ExportFile.Text = "Сохранить Матрицу в Файл";
            this.ExportFile.UseVisualStyleBackColor = true;
            this.ExportFile.Click += new System.EventHandler(this.ExportFile_Click);
            // 
            // NumberMatrix
            // 
            this.NumberMatrix.Location = new System.Drawing.Point(19, 34);
            this.NumberMatrix.Name = "NumberMatrix";
            this.NumberMatrix.ReadOnly = true;
            this.NumberMatrix.Size = new System.Drawing.Size(100, 20);
            this.NumberMatrix.TabIndex = 27;
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(538, 29);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(75, 23);
            this.Operand1.TabIndex = 28;
            this.Operand1.Text = "Поместить";
            this.Operand1.UseVisualStyleBackColor = true;
            this.Operand1.Click += new System.EventHandler(this.Operand1_Click);
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(538, 97);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(75, 23);
            this.Operand2.TabIndex = 29;
            this.Operand2.Text = "Поместить";
            this.Operand2.UseVisualStyleBackColor = true;
            this.Operand2.Click += new System.EventHandler(this.Operand2_Click);
            // 
            // MainWondow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 503);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.NumberMatrix);
            this.Controls.Add(this.ExportFile);
            this.Controls.Add(this.ImportFile);
            this.Controls.Add(this.EnterElem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SelecW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SelectH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ElemValue);
            this.Controls.Add(this.CreateM);
            this.Controls.Add(this.operStart);
            this.Controls.Add(this.WidthMX);
            this.Controls.Add(this.WidthNew);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.HightMx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeightNew);
            this.Controls.Add(this.MatrixViev);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(755, 542);
            this.MinimumSize = new System.Drawing.Size(755, 39);
            this.Name = "MainWondow";
            this.Text = "Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MatrixViev;
        private System.Windows.Forms.TextBox HeightNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HightMx;
        public System.Windows.Forms.ListBox Operation;
        private System.Windows.Forms.Label WidthMX;
        private System.Windows.Forms.TextBox WidthNew;
        private System.Windows.Forms.Button operStart;
        private System.Windows.Forms.Button CreateM;
        private System.Windows.Forms.TextBox ElemValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SelecW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SelectH;
        private System.Windows.Forms.Button EnterElem;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.Button ExportFile;
        private System.Windows.Forms.TextBox NumberMatrix;
        private System.Windows.Forms.Button Operand1;
        private System.Windows.Forms.Button Operand2;
    }
}

