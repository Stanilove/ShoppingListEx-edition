using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjectEX
{
    public partial class Mainscreen : Form 
    {
        ShoppingList Mainlist = new ShoppingList();
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void Buybutton_Click(object sender, EventArgs e)
        {
            string name = namestr.Text;
            long cost = long.Parse(coststr.Text);
            DateTime date = DateTime.ParseExact(datestr.Text, "dd MM yyyy", new CultureInfo("ru-Ru") );
            string comment = commentstr.Text;
            Mainlist.AddPurchase(name, comment, cost, date); 
        }
        private void Delbutton_Click(object sender, EventArgs e)
        {
            

        }
        private void Shopbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string text = "";
            Mainlist.PurchaseList.ForEach(O => text += O.toString());
            shops Shops = new shops(text);
            Shops.Show();

        }
        private void Totalbutton_Click(object sender, EventArgs e)
        {
           

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
