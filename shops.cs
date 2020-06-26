using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEX
{

    public partial class shops : Form
    {
        ShoppingList Mainlist = new ShoppingList();

        public shops(string text)
        {
            
            InitializeComponent();
            Shopstr.Text = null;
            Shopstr.AppendText(text);
        }

        private void Exitshops_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainscreen MainScreen = new Mainscreen();
            MainScreen.Show();
        }

        private void Shopstr_TextChanged(object sender, EventArgs e)
        {

        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            long num = long.Parse(numbox.Text);
            Mainlist.RemovePurchase(num);
            

        }
    }
}
