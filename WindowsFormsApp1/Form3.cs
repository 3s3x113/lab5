using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this._123DataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this._123DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this._123DataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Учет_товара". При необходимости она может быть перемещена или удалена.
            this.учет_товараTableAdapter.Fill(this._123DataSet.Учет_товара);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            поиск_учета_товара st = new поиск_учета_товара();
            st.Owner = this;
            st.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            учет_товараTableAdapter.Update(_123DataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addform3 fm3 = new addform3();
            fm3.Owner = this;
            fm3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            поиск_поставщика pp = new поиск_поставщика();
            pp.Owner = this;
            pp.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            поставщикTableAdapter.Update(_123DataSet);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            поставщики pp1 = new поставщики();
            pp1.Owner = this;
            pp1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Поиск_товар tt = new Поиск_товар();
            tt.Owner = this;
            tt.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Товары t = new Товары();
            t.Owner = this;
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            товарTableAdapter.Update(_123DataSet);

        }
    }
}
