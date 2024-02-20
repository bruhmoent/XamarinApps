using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void oblicz_Clicked(object sender, EventArgs e)
        {
            int a_v = int.Parse(a.Text);
            int b_v = int.Parse(b.Text);
            int c_v = int.Parse(c.Text);

            int final = a_v + b_v + c_v;
            Wynik.Text = final.ToString();
        }
    }
}
