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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this._123DataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this._123DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._123DataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Продажа_товара". При необходимости она может быть перемещена или удалена.
            this.продажа_товараTableAdapter.Fill(this._123DataSet.Продажа_товара);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Поиск_продажа_товара ppt = new Поиск_продажа_товара();
            ppt.Owner = this;
            ppt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            продажа p123 = new продажа();
            p123.Owner = this;
            p123.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Поиск_клиента pk132 = new Поиск_клиента();
            pk132.Owner = this;
            pk132.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            продажа_товараTableAdapter.Update(_123DataSet);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            клиентTableAdapter.Update(_123DataSet);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            товар4 t4 = new товар4();
            t4.Owner = this;
            t4.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            товарTableAdapter.Update(_123DataSet);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Клиент kk = new Клиент();
            kk.Owner = this;
            kk.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            товаар tta = new товаар();
            tta.Owner = this;
            tta.ShowDialog();
        }
    }
}
