using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda
{
	public partial class MainPage : ContentPage
	{
        List<Amigo> amigos;
		public MainPage()
		{
			InitializeComponent();
            amigos = new List<Amigo>();
            btnAgregar.Clicked += BtnAgregar_Clicked;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstAgenda.ItemsSource = null;
            lstAgenda.ItemsSource = amigos;
        }

        private void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Detalle(amigos));
        }
    }
}
