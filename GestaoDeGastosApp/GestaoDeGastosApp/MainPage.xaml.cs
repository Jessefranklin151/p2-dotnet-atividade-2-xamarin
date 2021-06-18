using System;
using GestaoDeGastosApp.Data;
using GestaoDeGastosApp.Models;
using Xamarin.Forms;

namespace GestaoDeGastosApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Gestão de Compras";

            Database.gastos.Add(new Gasto(289.00m, "Fire TV Stick"));
            Database.gastos.Add(new Gasto(509.48m, "Controle Sem Fio Xbox - Carbon Black"));
            Gastos.ItemsSource = Database.gastos;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var precoString = entPreco.Text;
            var desc = entDesc.Text;
            decimal preco;

             if (string.IsNullOrEmpty(precoString))
            {
                DisplayAlert("Erro", "Preço Requerido", "Ok");
            }
            else if (!decimal.TryParse(precoString, out preco))
            {
                DisplayAlert("Erro", "Preço Inválido", "Ok");
            }
            else if (string.IsNullOrEmpty(desc))
            {
                DisplayAlert("Erro", "Descrição Requerida", "Ok");
            }
            else
            {
                Database.gastos.Add(new Gasto(preco, desc));
            }
        }

        private async void Gastos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Gasto gasto = (Gasto) e.SelectedItem;
            Detail detail = new Detail(gasto);
            await Navigation.PushAsync(detail);
        }
    }
}
