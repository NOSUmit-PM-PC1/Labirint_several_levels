using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLabirint : Form
    {
        int[,] arrayLab;
        public FormLabirint()
        {
            InitializeComponent();
        }

        void drawLabirint()
        {
            for (int i = 0; i < arrayLab.GetLength(0); i++)
            {
                for (int j = 0; j < arrayLab.GetLength(1); j++)
                {
                    if (arrayLab[i,j] == 1)
                        dataGridViewLab.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
            
        }

        void loadDataGrid(int level)
        {
            StreamReader file = new StreamReader("level"+ level.ToString() +".txt");
            int n = Convert.ToInt32(file.ReadLine());
            arrayLab = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = file.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arrayLab[i, j] = Convert.ToInt32(temp[j]);
                }
            }
            file.Close();

            dataGridViewLab.Columns.Clear();
            dataGridViewLab.Rows.Clear();
            // добавили n столбцов
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[n];
            for (int i = 0; i < n; i++)
            {
                columns[i] = new DataGridViewTextBoxColumn();
                columns[i].Width = 60;
            }
            dataGridViewLab.Columns.AddRange(columns);

            // делаем красиво)
            dataGridViewLab.RowTemplate.Height = 60;
            dataGridViewLab.RowHeadersVisible = false;
            dataGridViewLab.ColumnHeadersVisible = false;

            // добавили n строк
            dataGridViewLab.Rows.Add(n);

            // установить размер DataGrid
            dataGridViewLab.Width = n * 60 + 50;
            dataGridViewLab.Height = n * 60 + 50;

            drawLabirint();
        }

        private void FormLabirint_Load(object sender, EventArgs e)
        {
            loadDataGrid(1);
        }

        private void ComboBoxLevels_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(ComboBoxLevels.Text);
            int level = Convert.ToInt32(ComboBoxLevels.Text.Split()[1]);
            loadDataGrid(level);
        }
    }
}
