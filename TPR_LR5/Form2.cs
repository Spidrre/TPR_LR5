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
    public partial class Form2 : Form
    {
        Form1 kek;
        DataGridView elems;
        List<string> alts;
        List<string> crits;
        List<double> weights;
        List<FuncParams> f_params;
        public List<Color> colors;
        public List<double> fplus;
        public List<double> fminus;

        public Form2(Form1 k, DataGridView _a, List<string> _alts, List<string> _crits, List<double> _weights, List<FuncParams> _f_params)
        {
            InitializeComponent();
            elems = _a;
            alts = _alts;
            crits = _crits;
            weights = _weights;
            f_params = _f_params;
            fplus = new List<double>();
            fminus = new List<double>();
            kek = k;

            colors = new List<Color>();
            colors.Add(Color.Orange);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Black);
            colors.Add(Color.Crimson);
            colors.Add(Color.Brown);
            colors.Add(Color.BlueViolet);

            dgvDif.DefaultCellStyle.ForeColor = Color.White;
            dgvFunc.DefaultCellStyle.ForeColor = Color.White;
            //dgvFinal.DefaultCellStyle.ForeColor = Color.White;
            
            label1.Text += "Разница\n";
            for (int i =0; i<crits.Count; ++i)
            {
                label1.Text += crits[i].ToString() + " - " + colors[i].Name + "; ";
            }
            label2.Text += "Значения функций предпочтения\n";
            for (int i = 0; i < crits.Count; ++i)
            {
                label2.Text += crits[i].ToString() + " - "  +  kek.cbFunc.Items[f_params[i].name].ToString() +"; ";
            }
            label1.Location = new Point(12, 5);
            label2.Location = new Point(634, 5);

            fillDgvs();
        }

        public void fillDgvs()
        {
            dgvDif.RowCount = alts.Count * crits.Count;
            dgvDif.ColumnCount = alts.Count;
            dgvFunc.RowCount = alts.Count * crits.Count;
            dgvFunc.ColumnCount = alts.Count;
            for (int i= 0; i< alts.Count; ++i)
            {
                dgvDif.Columns[i].HeaderText = alts[i];
                dgvFunc.Columns[i].HeaderText = alts[i];
            }
            for (int i = 0; i < crits.Count; ++i)
            {
                for (int j = 0; j < alts.Count; ++j)
                {
                    dgvDif.Rows[j+ alts.Count * i].HeaderCell.Value = alts[j];
                    dgvDif.Rows[j + alts.Count * i].DefaultCellStyle.BackColor = colors[i];
                    dgvFunc.Rows[j + alts.Count * i].HeaderCell.Value = alts[j];
                    dgvFunc.Rows[j + alts.Count * i].DefaultCellStyle.BackColor = colors[i];
                    for (int k = 0; k < alts.Count; ++k)
                    {
                        dgvDif[k, j + alts.Count * i].Value = Convert.ToDouble(elems[i,j].Value) - Convert.ToDouble(elems[i, k].Value);
                        dgvFunc[k, j + alts.Count * i].Value = predp(i,Convert.ToDouble(elems[i, j].Value) - Convert.ToDouble(elems[i, k].Value));
                        if (k == j)
                            dgvFunc[k, j + alts.Count * i].Value = 0.0;
                    }
                }
                
            }





            dgvFunc.Rows[0].Cells[0].Selected = false;
            dgvFunc.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvFunc.AutoResizeColumnHeadersHeight();
            dgvDif.Rows[0].Cells[0].Selected = false;
            dgvDif.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvDif.AutoResizeColumnHeadersHeight();



            dgvFinal.ColumnCount = alts.Count+1;
            dgvFinal.RowCount = alts.Count+1;
            for (int i = 0; i < alts.Count; ++i)
            {
                dgvFinal.Columns[i].HeaderText = "П(ai," + alts[i]+")";
                dgvFinal.Rows[i].HeaderCell.Value = "П(" + alts[i] + ",aj)";
            }
            dgvFinal.Columns[alts.Count].HeaderText = "Ф+";
            dgvFinal.Rows[alts.Count].HeaderCell.Value = "Ф-";


            double tmppl = 0.0;
            for (int i = 0; i < alts.Count; ++i)
            {
                tmppl = 0.0;
                for (int j = 0; j < alts.Count; ++j)
                {
                    
                    double sum = 0.0;
                    for (int k = 0; k < crits.Count; ++k)
                    {
                        sum += Convert.ToDouble(dgvFunc[j, i + alts.Count * k].Value) * weights[k];
                    }
                    dgvFinal[j, i].Value = sum;
                    tmppl += sum;
                    

                }
                fplus.Add(tmppl);
                dgvFinal[alts.Count, i].Value = tmppl;

            }

            for (int i = 0; i < alts.Count; ++i)
            {
                tmppl = 0.0;
                for (int j = 0; j < alts.Count; ++j)
                {
                    tmppl += Convert.ToDouble(dgvFinal[i, j].Value);


                }
                fminus.Add(tmppl);
                dgvFinal[i, alts.Count].Value = tmppl;

            }

            dgvFinal.Rows[0].Cells[0].Selected = false;
            dgvFinal.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvFinal.AutoResizeColumnHeadersHeight();


            List<Tuple<string, double>> res = new List<Tuple<string, double>>();
            for (int i = 0; i < alts.Count; ++i)
            {

                res.Add(Tuple.Create(alts[i], (fplus[i] - fminus[i])));
                rtbFinal.Text += "Ф(" + alts[i].ToString() + ") = Ф+(" + alts[i].ToString() + ") - Ф-(" + alts[i].ToString() + ") = " + fplus[i].ToString() + " - " + fminus[i].ToString() + " = " + (fplus[i] - fminus[i]).ToString() + "\n";
            }
            res.Sort((a, b) => b.Item2.CompareTo(a.Item2));
            rtbFinal.Text += "Answer is:\n";
            int h = 1;
            foreach (Tuple<string, double> a in res)
            {
                rtbFinal.Text += h.ToString() + ") " + a.Item1.ToString() + "  " + a.Item2.ToString() + "\n";
                h++;
            }
        }


        public double predp(int ind, double d)
        {

            double k = -1.0;

            if (f_params[ind].name == 0)
                k = def_func(d, f_params[ind]);
            else if (f_params[ind].name == 1)
                k = u_func(d, f_params[ind]);
            else if (f_params[ind].name == 2)
                k = v_func(d, f_params[ind]);
            else if (f_params[ind].name == 3)
                k = level_func(d, f_params[ind]);
            else if (f_params[ind].name == 4)
                k = v_porog_func(d, f_params[ind]);
            else if (f_params[ind].name == 5)
                k = hauss_func(d, f_params[ind]);

            if (f_params[ind].rev)
                k = Math.Abs(1 - k);
            return k;
        }

        public double def_func(double d, FuncParams par)
        {
            if (d <= 0)
                return 0.0;
            else return 1.0;
        }

        public double u_func(double d, FuncParams par)
        {
            if (d <= par.q)
                return 0.0;
            else return 1.0;
        }

        public double v_func(double d, FuncParams par)
        {
            if (d <= 0)
                return 0.0;
            else if (d <= par.s)
                return (d / par.s);
            else return 1.0;
        }

        public double level_func(double d, FuncParams par)
        {
            if (d <= par.q)
                return 0.0;
            else if (d <= par.s)
                return 0.5;
            else return 1.0;
        }

        public double v_porog_func(double d, FuncParams par)
        {
            if (d <= par.q)
                return 0.0;
            else if (d <= par.s)
                return ((d-par.q)/(par.s-par.q));
            else return 1.0;
        }
        public double hauss_func(double d, FuncParams par)
        {
            if (d <= 0)
                return 0.0;
            else return (1-Math.Exp(-(d*d)/(2*(d*d/4))));
        }
    }
}
