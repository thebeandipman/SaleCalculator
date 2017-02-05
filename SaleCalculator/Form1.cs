using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleCalculator
{
    public partial class mainWindow : Form
    {

        decimal offer = 0;
        decimal closing = 0;
        decimal totalprofit = 0;

        decimal mortgage = 0;
        decimal creditDebt = 0;
        decimal totalDebt = 0;

        decimal result = 0;
        DataGridView Results;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            inputClosing.Text = string.Empty;
            inputSalePrice.Text = string.Empty;
            resultProfit.Text = string.Empty;
            inputMortgage.Text = string.Empty;
            inputDebt.Text = string.Empty;
            resultDebt.Text = string.Empty;
            resultFinal.Text = string.Empty;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if((inputClosing.Text == string.Empty) || (inputSalePrice.Text == string.Empty) || (inputMortgage.Text == string.Empty) || (inputDebt.Text == string.Empty))
            {
                System.Windows.Forms.MessageBox.Show("All fields must be filled.");
                return;
            }
            try
            {
                offer = Convert.ToDecimal(inputSalePrice.Text);
                closing = Convert.ToDecimal(inputClosing.Text);
                totalprofit = offer - closing;
                this.resultProfit.Text = Convert.ToString(totalprofit);


                mortgage = Convert.ToDecimal(inputMortgage.Text);
                creditDebt = Convert.ToDecimal(inputDebt.Text);
                totalDebt = mortgage + creditDebt;
                this.resultDebt.Text = Convert.ToString(totalDebt);

                result = totalprofit - totalDebt;
                this.resultFinal.Text = Convert.ToString(result);

                Results.AddR
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("All fields must be numeric.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
