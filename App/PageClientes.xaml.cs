using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Plugin.TextToSpeech;

namespace App
{
    public partial class PageClientes : ContentPage
    {
        public PageClientes()
        {
            InitializeComponent();
        }

        public int Num1
        {
            get;
            set;
        }
        public int Num2
        {
            get;
            set;
        }
        public async void CadastrarEvent(object sender, System.EventArgs e)
        {
            await CrossTextToSpeech.Current.Speak("Bom dia Pessoal");

            Num1 = Convert.ToInt32(Numero1.Text);
            Num2 = Convert.ToInt32(Numero2.Text);


            var calc = new Calc();
            calc.Valor1 = 1;
            calc.Valor2 = 2;
            calc.Subtracao();


            var seleced = Picker.SelectedItem;



            var result = calc.Soma(1, 2);


            DisplayAlert("Ok", Soma().ToString(), "Ok");
        }
        public int Soma()
        {
            return Num1 + Num2;
        }
    }
}
