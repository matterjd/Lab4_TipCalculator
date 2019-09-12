using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BestEver
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        decimal billAmt = 0;
        decimal tipAmt = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {            
            billAmt = Decimal.Parse( bill.Text);
            decimal baseBillAmt = billAmt;
            tipAmt = Decimal.Parse(tip.Text);
            Math.Round(billAmt, 2);
            Math.Round(tipAmt, 2);
            Math.Round(baseBillAmt, 2);

            if (tipAmt >= 1)
            {
                tipAmt = tipAmt / 100;
            }
                       
            billAmt += (billAmt * tipAmt);
            this.ouput.Text =  "Tip Amount: " + "\t$" + (baseBillAmt * tipAmt);
            this.ouput.Text += "\r\n" + "Bill Amount: " + "\t$" + billAmt.ToString();

        }

    }
}
