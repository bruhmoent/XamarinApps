using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public string gatunek = "";
        public MainPage()
        {
            InitializeComponent();

            List<String> lista = new List<String>();
            lista.Add("Pies");
            lista.Add("Kot");
            lista.Add("Świnka Morska");

            listView1.ItemsSource = lista;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Slider s = (Slider)sender;
            value.Text = ((int)s.Value).ToString();

        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string s = listView1.SelectedItem as string;


            switch (s)
            {
                case "Kot":
                    Wiek.Maximum = 20;
                    break;
                case "Pies":
                    Wiek.Maximum = 18;
                    break;
                case "Świnka Morska":
                    Wiek.Maximum = 9;
                    break;
                default:
                    Wiek.Maximum = 20;
                    break;
            }

            gatunek = s;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Zapisana Wizyta", ImieNazw.Text + ", " + gatunek + ", " + CelWizity.Text + ", " +  Czas.Text, "OK");
        }
    }
}
