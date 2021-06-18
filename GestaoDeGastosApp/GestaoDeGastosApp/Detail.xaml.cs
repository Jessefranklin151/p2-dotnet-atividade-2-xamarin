using GestaoDeGastosApp.Data;
using GestaoDeGastosApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestaoDeGastosApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        private Gasto gasto;

        public Detail(Gasto gasto)
        {
            InitializeComponent();
            this.gasto = gasto;

            Title = "Descrição da Compra";
            lblDesc.Text = gasto.Descricao;
            lblPreco.Text = gasto.Preco.ToString();

        }

        private async void Button_Voltar_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Remover_Clicked(object sender, System.EventArgs e)
        {
            Database.gastos.Remove(this.gasto);
            await Navigation.PopAsync();
        }

    }
}