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
    public partial class товаар : Form
    {
        public товаар()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main._123DataSet.Tables[7].NewRow();
                int rc = main.dataGridView3.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                


                main._123DataSet.Tables[7].Rows.Add(nRow);
                main.товарTableAdapter.Update(main._123DataSet.Товар);
                main._123DataSet.Tables[7].AcceptChanges();
                main.dataGridView3.Refresh();
                textBox1.Text = "";
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
