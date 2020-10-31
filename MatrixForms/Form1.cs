using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormsMatrix;

namespace MatrixForms
{
    public partial class MatrixForms : Form
    {
        public MatrixForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = int.Parse(krow.Text);
            int col = int.Parse(kcol.Text);
            ClassMatrixForms.CreatDateGreed(row, col, dataGridMatrix);
        }

        private void dataGridMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MatrixForms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[,] matrix = ClassMatrixForms.CreatMatrix1(dataGridMatrix);
            ClassMatrixForms.WriterGrid(matrix, dataGridMatrix);
            ClassMatrixForms.VisibledLabel(kPozElem);
            ClassMatrixForms.VisibledLabel(MaxElement);
            ClassMatrixForms.VisibledLabel(KNotNullRow);
            ClassMatrixForms.VisibledLabel(KNullCol);
            ClassMatrixForms.VisibledLabel(NumMaxRow);
            ClassMatrixForms.VisibledLabel(DobElemRowWithoutNegElem);
            ClassMatrixForms.VisibledLabel(SumMax);
            ClassMatrixForms.VisibledLabel(SumElemColWithoutNegElem);
            ClassMatrixForms.VisibledLabel(SumMinAbs);
            ClassMatrixForms.VisibledLabel(SumElemColWithNegElem);
            ClassMatrixForms.VisibledLabel(labelkPozElem);
            ClassMatrixForms.VisibledLabel(labelMaxElement);
            ClassMatrixForms.VisibledLabel(labelKNotNullRow);
            ClassMatrixForms.VisibledLabel(labelKNullCol);
            ClassMatrixForms.VisibledLabel(labelNumMaxRow);
            ClassMatrixForms.VisibledLabel(labelDobElemRowWithoutNegElem);
            ClassMatrixForms.VisibledLabel(labelSumMax);
            ClassMatrixForms.VisibledLabel(labelSumElemColWithoutNegElem);
            ClassMatrixForms.VisibledLabel(labelSumMinAbs);
            ClassMatrixForms.VisibledLabel(labelSumElemColWithNegElem);
            ClassMatrixForms.VisibledLabel(labelMatrixTransp);
            ClassMatrixForms.VisibledGrid(matrixTransp);
            int[,] matrixT = ClassMatrixForms.TranspMatrix(matrix);
            ClassMatrixForms.WriterGrid(matrix, dataGridMatrix);
            ClassMatrixForms.KPositiveElements(matrix, kPozElem);
            ClassMatrixForms.MaxElem(matrix, MaxElement);
            ClassMatrixForms.KNotNullRow(matrix, KNotNullRow);
            ClassMatrixForms.KNullCol(matrix, KNullCol);
            ClassMatrixForms.NumMaxRow(matrix, NumMaxRow);
            ClassMatrixForms.DobElemRowWithoutNegElem(matrix, DobElemRowWithoutNegElem);
            ClassMatrixForms.SumMax(matrix, SumMax);
            ClassMatrixForms.SumElemColWithoutNegElem(matrix, SumElemColWithoutNegElem);
            ClassMatrixForms.SumMinAbs(matrix, SumMinAbs);
            ClassMatrixForms.SumElemColWithNegElem(matrix, SumElemColWithNegElem);
            ClassMatrixForms.CreatDateGreed(matrixT.GetLength(0), matrixT.GetLength(1), matrixTransp);
            ClassMatrixForms.WriterGrid(matrixT, matrixTransp);

        }

        private void SumNegativesElements_Click(object sender, EventArgs e)
        {

        }
    }
}
