namespace MatrixForms
{
    partial class MatrixForms
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
            this.dataGridMatrix = new System.Windows.Forms.DataGridView();
            this.labelrows = new System.Windows.Forms.Label();
            this.labelcols = new System.Windows.Forms.Label();
            this.krow = new System.Windows.Forms.TextBox();
            this.kcol = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.DobElemRowWithoutNegElem = new System.Windows.Forms.Label();
            this.NumMaxRow = new System.Windows.Forms.Label();
            this.KNotNullRow = new System.Windows.Forms.Label();
            this.MaxElement = new System.Windows.Forms.Label();
            this.kPozElem = new System.Windows.Forms.Label();
            this.KNullCol = new System.Windows.Forms.Label();
            this.labelKNullCol = new System.Windows.Forms.Label();
            this.labelKNotNullRow = new System.Windows.Forms.Label();
            this.labelDobElemRowWithoutNegElem = new System.Windows.Forms.Label();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.labelNumMaxRow = new System.Windows.Forms.Label();
            this.labelkPozElem = new System.Windows.Forms.Label();
            this.labelSumElemColWithNegElem = new System.Windows.Forms.Label();
            this.labelSumMax = new System.Windows.Forms.Label();
            this.labelMatrixTransp = new System.Windows.Forms.Label();
            this.labelSumElemColWithoutNegElem = new System.Windows.Forms.Label();
            this.labelSumMinAbs = new System.Windows.Forms.Label();
            this.SumMinAbs = new System.Windows.Forms.Label();
            this.SumMax = new System.Windows.Forms.Label();
            this.SumElemColWithoutNegElem = new System.Windows.Forms.Label();
            this.SumElemColWithNegElem = new System.Windows.Forms.Label();
            this.matrixTransp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMatrix
            // 
            this.dataGridMatrix.AllowUserToAddRows = false;
            this.dataGridMatrix.AllowUserToDeleteRows = false;
            this.dataGridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix.Location = new System.Drawing.Point(15, 59);
            this.dataGridMatrix.Name = "dataGridMatrix";
            this.dataGridMatrix.Size = new System.Drawing.Size(773, 191);
            this.dataGridMatrix.TabIndex = 0;
            this.dataGridMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMatrix_CellContentClick);
            // 
            // labelrows
            // 
            this.labelrows.AutoSize = true;
            this.labelrows.Location = new System.Drawing.Point(12, 21);
            this.labelrows.Name = "labelrows";
            this.labelrows.Size = new System.Drawing.Size(131, 13);
            this.labelrows.TabIndex = 1;
            this.labelrows.Text = "Введіть кількість рядків:";
            this.labelrows.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelcols
            // 
            this.labelcols.AutoSize = true;
            this.labelcols.Location = new System.Drawing.Point(232, 21);
            this.labelcols.Name = "labelcols";
            this.labelcols.Size = new System.Drawing.Size(142, 13);
            this.labelcols.TabIndex = 2;
            this.labelcols.Text = "Введіть кількість стовпців:";
            // 
            // krow
            // 
            this.krow.Location = new System.Drawing.Point(149, 18);
            this.krow.Name = "krow";
            this.krow.Size = new System.Drawing.Size(48, 20);
            this.krow.TabIndex = 3;
            // 
            // kcol
            // 
            this.kcol.Location = new System.Drawing.Point(380, 18);
            this.kcol.Name = "kcol";
            this.kcol.Size = new System.Drawing.Size(48, 20);
            this.kcol.TabIndex = 4;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(465, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(55, 31);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Зчитати";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(341, 256);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(87, 30);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Обрахувати";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DobElemRowWithoutNegElem
            // 
            this.DobElemRowWithoutNegElem.AutoSize = true;
            this.DobElemRowWithoutNegElem.Location = new System.Drawing.Point(295, 408);
            this.DobElemRowWithoutNegElem.Name = "DobElemRowWithoutNegElem";
            this.DobElemRowWithoutNegElem.Size = new System.Drawing.Size(13, 13);
            this.DobElemRowWithoutNegElem.TabIndex = 15;
            this.DobElemRowWithoutNegElem.Text = "6";
            this.DobElemRowWithoutNegElem.Visible = false;
            // 
            // NumMaxRow
            // 
            this.NumMaxRow.AutoSize = true;
            this.NumMaxRow.Location = new System.Drawing.Point(289, 386);
            this.NumMaxRow.Name = "NumMaxRow";
            this.NumMaxRow.Size = new System.Drawing.Size(13, 13);
            this.NumMaxRow.TabIndex = 16;
            this.NumMaxRow.Text = "5";
            this.NumMaxRow.Visible = false;
            // 
            // KNotNullRow
            // 
            this.KNotNullRow.AutoSize = true;
            this.KNotNullRow.Location = new System.Drawing.Point(206, 341);
            this.KNotNullRow.Name = "KNotNullRow";
            this.KNotNullRow.Size = new System.Drawing.Size(13, 13);
            this.KNotNullRow.TabIndex = 17;
            this.KNotNullRow.Text = "3";
            this.KNotNullRow.Visible = false;
            // 
            // MaxElement
            // 
            this.MaxElement.AutoSize = true;
            this.MaxElement.Location = new System.Drawing.Point(300, 320);
            this.MaxElement.Name = "MaxElement";
            this.MaxElement.Size = new System.Drawing.Size(13, 13);
            this.MaxElement.TabIndex = 18;
            this.MaxElement.Text = "2";
            this.MaxElement.Visible = false;
            // 
            // kPozElem
            // 
            this.kPozElem.AutoSize = true;
            this.kPozElem.Location = new System.Drawing.Point(173, 298);
            this.kPozElem.Name = "kPozElem";
            this.kPozElem.Size = new System.Drawing.Size(13, 13);
            this.kPozElem.TabIndex = 19;
            this.kPozElem.Text = "1";
            this.kPozElem.Visible = false;
            this.kPozElem.Click += new System.EventHandler(this.SumNegativesElements_Click);
            // 
            // KNullCol
            // 
            this.KNullCol.AutoSize = true;
            this.KNullCol.Location = new System.Drawing.Point(233, 363);
            this.KNullCol.Name = "KNullCol";
            this.KNullCol.Size = new System.Drawing.Size(13, 13);
            this.KNullCol.TabIndex = 14;
            this.KNullCol.Text = "4";
            this.KNullCol.Visible = false;
            // 
            // labelKNullCol
            // 
            this.labelKNullCol.AutoSize = true;
            this.labelKNullCol.Location = new System.Drawing.Point(12, 363);
            this.labelKNullCol.Name = "labelKNullCol";
            this.labelKNullCol.Size = new System.Drawing.Size(215, 13);
            this.labelKNullCol.TabIndex = 11;
            this.labelKNullCol.Text = "Кількість стовпців у яких є хоча б один 0:";
            this.labelKNullCol.Visible = false;
            // 
            // labelKNotNullRow
            // 
            this.labelKNotNullRow.AutoSize = true;
            this.labelKNotNullRow.Location = new System.Drawing.Point(12, 341);
            this.labelKNotNullRow.Name = "labelKNotNullRow";
            this.labelKNotNullRow.Size = new System.Drawing.Size(188, 13);
            this.labelKNotNullRow.TabIndex = 8;
            this.labelKNotNullRow.Text = "Кількість рядків у яких немає нулів:";
            this.labelKNotNullRow.Visible = false;
            // 
            // labelDobElemRowWithoutNegElem
            // 
            this.labelDobElemRowWithoutNegElem.AutoSize = true;
            this.labelDobElemRowWithoutNegElem.Location = new System.Drawing.Point(12, 408);
            this.labelDobElemRowWithoutNegElem.Name = "labelDobElemRowWithoutNegElem";
            this.labelDobElemRowWithoutNegElem.Size = new System.Drawing.Size(277, 13);
            this.labelDobElemRowWithoutNegElem.TabIndex = 12;
            this.labelDobElemRowWithoutNegElem.Text = "Добуток елементів рядків без негативних елементів:";
            this.labelDobElemRowWithoutNegElem.Visible = false;
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(12, 320);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(282, 13);
            this.labelMaxElement.TabIndex = 13;
            this.labelMaxElement.Text = "Максимальне з чисел, що зустрічаєтья більше 1 разу:";
            this.labelMaxElement.Visible = false;
            // 
            // labelNumMaxRow
            // 
            this.labelNumMaxRow.AutoSize = true;
            this.labelNumMaxRow.Location = new System.Drawing.Point(12, 386);
            this.labelNumMaxRow.Name = "labelNumMaxRow";
            this.labelNumMaxRow.Size = new System.Drawing.Size(271, 13);
            this.labelNumMaxRow.TabIndex = 9;
            this.labelNumMaxRow.Text = "Номер рядка з найбільшою к-стю однакових рядків:";
            this.labelNumMaxRow.Visible = false;
            // 
            // labelkPozElem
            // 
            this.labelkPozElem.AutoSize = true;
            this.labelkPozElem.Location = new System.Drawing.Point(12, 298);
            this.labelkPozElem.Name = "labelkPozElem";
            this.labelkPozElem.Size = new System.Drawing.Size(155, 13);
            this.labelkPozElem.TabIndex = 10;
            this.labelkPozElem.Text = "Кількість додатніх елементів:";
            this.labelkPozElem.Visible = false;
            // 
            // labelSumElemColWithNegElem
            // 
            this.labelSumElemColWithNegElem.AutoSize = true;
            this.labelSumElemColWithNegElem.Location = new System.Drawing.Point(12, 497);
            this.labelSumElemColWithNegElem.Name = "labelSumElemColWithNegElem";
            this.labelSumElemColWithNegElem.Size = new System.Drawing.Size(271, 13);
            this.labelSumElemColWithNegElem.TabIndex = 9;
            this.labelSumElemColWithNegElem.Text = "Номер рядка з найбільшою к-стю однакових рядків:";
            this.labelSumElemColWithNegElem.Visible = false;
            // 
            // labelSumMax
            // 
            this.labelSumMax.AutoSize = true;
            this.labelSumMax.Location = new System.Drawing.Point(12, 431);
            this.labelSumMax.Name = "labelSumMax";
            this.labelSumMax.Size = new System.Drawing.Size(333, 13);
            this.labelSumMax.TabIndex = 13;
            this.labelSumMax.Text = "Знаходження найбільшої суми по паралелям головної діагоналі:";
            this.labelSumMax.Visible = false;
            // 
            // labelMatrixTransp
            // 
            this.labelMatrixTransp.AutoSize = true;
            this.labelMatrixTransp.Location = new System.Drawing.Point(12, 519);
            this.labelMatrixTransp.Name = "labelMatrixTransp";
            this.labelMatrixTransp.Size = new System.Drawing.Size(135, 13);
            this.labelMatrixTransp.TabIndex = 12;
            this.labelMatrixTransp.Text = "Транспонована матриця:";
            this.labelMatrixTransp.Visible = false;
            // 
            // labelSumElemColWithoutNegElem
            // 
            this.labelSumElemColWithoutNegElem.AutoSize = true;
            this.labelSumElemColWithoutNegElem.Location = new System.Drawing.Point(12, 452);
            this.labelSumElemColWithoutNegElem.Name = "labelSumElemColWithoutNegElem";
            this.labelSumElemColWithoutNegElem.Size = new System.Drawing.Size(271, 13);
            this.labelSumElemColWithoutNegElem.TabIndex = 8;
            this.labelSumElemColWithoutNegElem.Text = "Сума елементів стовпців без негативних елементів:";
            this.labelSumElemColWithoutNegElem.Visible = false;
            // 
            // labelSumMinAbs
            // 
            this.labelSumMinAbs.AutoSize = true;
            this.labelSumMinAbs.Location = new System.Drawing.Point(12, 474);
            this.labelSumMinAbs.Name = "labelSumMinAbs";
            this.labelSumMinAbs.Size = new System.Drawing.Size(268, 13);
            this.labelSumMinAbs.TabIndex = 11;
            this.labelSumMinAbs.Text = "Сума елементів стовпців з негативним елементом:";
            this.labelSumMinAbs.Visible = false;
            // 
            // SumMinAbs
            // 
            this.SumMinAbs.AutoSize = true;
            this.SumMinAbs.Location = new System.Drawing.Point(286, 474);
            this.SumMinAbs.Name = "SumMinAbs";
            this.SumMinAbs.Size = new System.Drawing.Size(13, 13);
            this.SumMinAbs.TabIndex = 14;
            this.SumMinAbs.Text = "4";
            this.SumMinAbs.Visible = false;
            // 
            // SumMax
            // 
            this.SumMax.AutoSize = true;
            this.SumMax.Location = new System.Drawing.Point(351, 431);
            this.SumMax.Name = "SumMax";
            this.SumMax.Size = new System.Drawing.Size(13, 13);
            this.SumMax.TabIndex = 18;
            this.SumMax.Text = "2";
            this.SumMax.Visible = false;
            // 
            // SumElemColWithoutNegElem
            // 
            this.SumElemColWithoutNegElem.AutoSize = true;
            this.SumElemColWithoutNegElem.Location = new System.Drawing.Point(289, 452);
            this.SumElemColWithoutNegElem.Name = "SumElemColWithoutNegElem";
            this.SumElemColWithoutNegElem.Size = new System.Drawing.Size(13, 13);
            this.SumElemColWithoutNegElem.TabIndex = 17;
            this.SumElemColWithoutNegElem.Text = "3";
            this.SumElemColWithoutNegElem.Visible = false;
            // 
            // SumElemColWithNegElem
            // 
            this.SumElemColWithNegElem.AutoSize = true;
            this.SumElemColWithNegElem.Location = new System.Drawing.Point(289, 497);
            this.SumElemColWithNegElem.Name = "SumElemColWithNegElem";
            this.SumElemColWithNegElem.Size = new System.Drawing.Size(13, 13);
            this.SumElemColWithNegElem.TabIndex = 16;
            this.SumElemColWithNegElem.Text = "5";
            this.SumElemColWithNegElem.Visible = false;
            // 
            // matrixTransp
            // 
            this.matrixTransp.AllowUserToAddRows = false;
            this.matrixTransp.AllowUserToDeleteRows = false;
            this.matrixTransp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTransp.Location = new System.Drawing.Point(12, 535);
            this.matrixTransp.Name = "matrixTransp";
            this.matrixTransp.Size = new System.Drawing.Size(773, 191);
            this.matrixTransp.TabIndex = 0;
            this.matrixTransp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMatrix_CellContentClick);
            // 
            // MatrixForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.DobElemRowWithoutNegElem);
            this.Controls.Add(this.SumElemColWithNegElem);
            this.Controls.Add(this.NumMaxRow);
            this.Controls.Add(this.SumElemColWithoutNegElem);
            this.Controls.Add(this.KNotNullRow);
            this.Controls.Add(this.SumMax);
            this.Controls.Add(this.MaxElement);
            this.Controls.Add(this.kPozElem);
            this.Controls.Add(this.SumMinAbs);
            this.Controls.Add(this.KNullCol);
            this.Controls.Add(this.labelSumMinAbs);
            this.Controls.Add(this.labelKNullCol);
            this.Controls.Add(this.labelSumElemColWithoutNegElem);
            this.Controls.Add(this.labelKNotNullRow);
            this.Controls.Add(this.labelMatrixTransp);
            this.Controls.Add(this.labelDobElemRowWithoutNegElem);
            this.Controls.Add(this.labelSumMax);
            this.Controls.Add(this.labelSumElemColWithNegElem);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.labelNumMaxRow);
            this.Controls.Add(this.labelkPozElem);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.kcol);
            this.Controls.Add(this.krow);
            this.Controls.Add(this.labelcols);
            this.Controls.Add(this.labelrows);
            this.Controls.Add(this.matrixTransp);
            this.Controls.Add(this.dataGridMatrix);
            this.Name = "MatrixForms";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MatrixForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMatrix;
        private System.Windows.Forms.Label labelrows;
        private System.Windows.Forms.Label labelcols;
        private System.Windows.Forms.TextBox krow;
        private System.Windows.Forms.TextBox kcol;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label DobElemRowWithoutNegElem;
        private System.Windows.Forms.Label NumMaxRow;
        private System.Windows.Forms.Label KNotNullRow;
        private System.Windows.Forms.Label MaxElement;
        private System.Windows.Forms.Label kPozElem;
        private System.Windows.Forms.Label KNullCol;
        private System.Windows.Forms.Label labelKNullCol;
        private System.Windows.Forms.Label labelKNotNullRow;
        private System.Windows.Forms.Label labelDobElemRowWithoutNegElem;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Label labelNumMaxRow;
        private System.Windows.Forms.Label labelkPozElem;
        private System.Windows.Forms.Label labelSumElemColWithNegElem;
        private System.Windows.Forms.Label labelSumMax;
        private System.Windows.Forms.Label labelMatrixTransp;
        private System.Windows.Forms.Label labelSumElemColWithoutNegElem;
        private System.Windows.Forms.Label labelSumMinAbs;
        private System.Windows.Forms.Label SumMinAbs;
        private System.Windows.Forms.Label SumMax;
        private System.Windows.Forms.Label SumElemColWithoutNegElem;
        private System.Windows.Forms.Label SumElemColWithNegElem;
        private System.Windows.Forms.DataGridView matrixTransp;
    }
}

