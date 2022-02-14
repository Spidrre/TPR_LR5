using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_LR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            alts = new List<string>();
            crits = new List<string>();
            weights = new List<double>();
            f_params = new List<FuncParams>();
            labelQ.Visible = false;
            labelS.Visible = false;
            tbQ.Text = null;
            tbS.Text = null;
            tbQ.Visible = false;
            tbS.Visible = false;
            dataGridView1.Visible = false;

            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        List<string> alts;
        List<string> crits;
        List<double> weights;
        List<FuncParams> f_params;




        private void buttonCrit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbCrit.Text) && !String.IsNullOrEmpty(tbWeight.Text)
                && (cbFunc.SelectedIndex != -1))
            {
                crits.Add(tbCrit.Text);
                weights.Add(Convert.ToDouble(tbWeight.Text));
                rtbCrits.Text += tbCrit.Text + " w=" + tbWeight.Text + "\n";
                f_params.Add(new FuncParams(tbS.Text, cbFunc.SelectedIndex.ToString(), tbQ.Text,cbRev.Checked));
            }
            tbCrit.Text = null;
            tbWeight.Text = null;
            //label6.Text = cbFunc.SelectedItem.ToString();
        }

        private void buttonAlt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAlt.Text))
            {
                alts.Add(tbAlt.Text);
                rtbAlts.Text += tbAlt.Text + "\n";
            }
            tbAlt.Text = null;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        
        private void cbFunc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labelQ.Visible = false;
            labelS.Visible = false;
            tbQ.Visible = false;
            tbS.Visible = false;
            tbS.Text = null;
            tbQ.Text = null;

            if (cbFunc.SelectedIndex == 1)
            {
                labelQ.Visible = true;
                tbQ.Visible = true;
            }
            if (cbFunc.SelectedIndex == 2)
            {
                labelS.Visible = true;
                tbS.Visible = true;
            }
            if (cbFunc.SelectedIndex == 3)
            {
                labelQ.Visible = true;
                tbQ.Visible = true;
                labelS.Visible = true;
                tbS.Visible = true;
            }
            if (cbFunc.SelectedIndex == 4)
            {
                labelQ.Visible = true;
                tbQ.Visible = true;
                labelS.Visible = true;
                tbS.Visible = true;
            }






            this.Activate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.RowCount = alts.Count;
            dataGridView1.ColumnCount = crits.Count;
            for (int i = 0; i < alts.Count; ++i)
                dataGridView1.Rows[i].HeaderCell.Value = alts[i];
            for (int i = 0; i < crits.Count; ++i)
                dataGridView1.Columns[i].HeaderText = crits[i];
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.Rows[0].Cells[0].Selected = false;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this,dataGridView1,alts, crits, weights, f_params);
            f.Show();
        }
        
    }
}
