using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalle : ContentPage
	{
        List<Amigo> listaAmigos;
		public Detalle (List<Amigo> amigos)
		{
			InitializeComponent ();
            btnGuardar.Clicked += BtnGuardar_Clicked;
            listaAmigos = amigos;
		}

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            listaAmigos.Add(new Amigo()
            { Apodo = txbApodo.Text, Email = txbEmail.Text, Nombre = txbNombre.Text, Telefono = txbTelefono.Text });
            Navigation.PopAsync();
        }
    }
}