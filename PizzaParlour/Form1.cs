using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        //Global variables for price
        const double PIE_PRICE = 7.00;
        const double TOPPING_PRICE = 1.25;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // takes the input from the textbox and puts it into a variable
            int toppingNumber;
            toppingNumber = Convert.ToInt16(inputBox.Text);

            // calculates the price
            Double totalPrice = TOPPING_PRICE * toppingNumber + PIE_PRICE;
            
            //displays price
            outputLabel.Text = "Your Total Is: "+ totalPrice.ToString("C");

        }
    }
}
