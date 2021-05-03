using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class claNomina : Form
    {
        double salary, partialSalary, ars, afp, isr, totalDiscount, monthlyNetSalary, biweeklyNetSalary, surplus,
            firstScale = 34685.00, secondScale = 52027.4167, thirdScale = 72260.25, fixedAmount1 = 2601.33, fixedAmount2 = 6648.00;

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo es permitido introducir números.");
                txtSalary.Text = txtSalary.Text.Remove(txtSalary.Text.Length - 1);
            }
        }

        public claNomina()
        {
            InitializeComponent();
            groupBoxDetail.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Clear();
            groupBoxDetail.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.salary = Convert.ToDouble(txtSalary.Text);

            this.calculateArs();
            this.calculateAfp();
            this.calculateIsr();

            totalDiscount = ars + afp + isr;
            monthlyNetSalary = this.salary - totalDiscount;
            biweeklyNetSalary = monthlyNetSalary / 2;

            labelTotalDiscount.Text = string.Format("{0:C2}", totalDiscount);
            labelMonthlyNetSalary.Text = string.Format("{0:C2}", monthlyNetSalary);
            labelBiweeklyNetSalary.Text = string.Format("{0:C2}", biweeklyNetSalary);

            groupBoxDetail.Visible = true;
        }

        private void calculateArs() {
            ars = this.salary * 0.0304;
            labelArs.Text = string.Format("{0:C2}", ars);
        }

        private void calculateAfp()
        {
            afp = this.salary * 0.0287;
            labelAfp.Text = string.Format("{0:C2}", afp);
        }

        private void calculateIsr()
        {
            partialSalary = this.salary - (afp + ars);

            if (partialSalary > firstScale && partialSalary < secondScale)
            {
                surplus = partialSalary - firstScale;
                isr = surplus * 0.15;
            }
            else if (partialSalary > secondScale && partialSalary < thirdScale)
            {
                surplus = partialSalary - secondScale;
                isr = (surplus * 0.20) + fixedAmount1;
            }
            else if (partialSalary > thirdScale)
            {
                surplus = partialSalary - thirdScale;
                isr = (surplus * 0.25) + fixedAmount2;
            }
            else
            {
                isr = 0.00;
            }

            labelIsr.Text = string.Format("{0:C2}", isr);
        }

    }
}
