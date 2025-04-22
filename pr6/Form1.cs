using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace pr6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

    private void btnCalculate_Click(object sender, EventArgs e)
    {
            if (string.IsNullOrEmpty(tbX1.Text) || string.IsNullOrEmpty(tbX2.Text))
            {
                tbY.Text = "Не введено дані";                                // пусто
                tbAdditionalResult.Text = "Не введено дані";
                return;
            }

            if (!double.TryParse(tbX1.Text, out double x1) || !double.TryParse(tbX2.Text, out double x2))
            {
                tbY.Text = "Некоректні дані";
                tbAdditionalResult.Text = "Некоректні дані";
                return;                                                      //фівбіов дані
            }
            
            double y = x1 * x2;                                              //експ
            tbY.Text = y.ToString("E");


            if (x1 > x2)                                                     //><
            {
                tbAdditionalResult.Text = x1.ToString();
            }
            else if (x2 > x1)
            {
                tbAdditionalResult.Text = x2.ToString();
            }
            else
            {
                tbAdditionalResult.Text = "Числа рівні";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Clear();
            tbX2.Clear();
            tbY.Clear();
            tbAdditionalResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
