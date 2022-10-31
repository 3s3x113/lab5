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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._123DataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this._123DataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this._123DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this._123DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this._123DataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._123DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this._123DataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            заказTableAdapter.Update(_123DataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm fm = new AddForm();
            fm.Owner = this;
            fm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Заказ zk = new Заказ();
            zk.Owner = this;
            zk.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            поставщикTableAdapter.Update(_123DataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Сотрудники st = new Сотрудники();
            st.Owner = this;
            st.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Update(_123DataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Товар tv = new Товар();
            tv.Owner = this;
            tv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            товарTableAdapter.Update(_123DataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Поиск_заказ pz = new Поиск_заказ();
            pz.Owner = this;
            pz.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Поиск_поставщик pk = new Поиск_поставщик();
            pk.Owner = this;
            pk.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Поиск_сотрудники sp = new Поиск_сотрудники();
            sp.Owner = this;
            sp.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Поиск_товара pt = new Поиск_товара();
            pt.Owner = this;
            pt.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            заказTableAdapter.Update(_123DataSet);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.ShowDialog();
        }
    }
}

