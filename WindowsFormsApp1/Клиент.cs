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
    public partial class Клиент : Form
    {
        public Клиент()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main._123DataSet.Tables[2].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                
                main._123DataSet.Tables[2].Rows.Add(nRow);
                main.клиентTableAdapter.Update(main._123DataSet.Клиент);
                main._123DataSet.Tables[2].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
        }
    }
}
