using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PX3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        async void Register2_Clicked(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(rName.Text))
            {
                await DisplayAlert("Advertencia", "Los campo no pueden estar vacios", "OK");
                await Navigation.PushAsync(new Register());
            }
            
            if (string.IsNullOrEmpty(rEmail.Text))
            {
                await DisplayAlert("Advertencia", "Los campo no pueden estar vacios", "OK");
                 Navigation.PushAsync(new Register());

            }
            
            if (string.IsNullOrEmpty(rPw.Text))
            {
                await DisplayAlert("Advertencia", "Los campo no pueden estar vacios", "OK");
                 Navigation.PushAsync(new Register());
            }
            

            if (string.IsNullOrEmpty(rCPw.Text))
            {
                await DisplayAlert("Advertencia", "Los campo no pueden estar vacios", "OK");
                 Navigation.PushAsync(new Register());
            }
           
            

      
            if (String.ReferenceEquals (rPw.Text, rCPw.Text))
            {
                await Navigation.PushAsync(new MDPage());
            }
            else
            {
                await DisplayAlert("Advertencia", "los campos deben ser iguales", "Ok");
            }


            string[] box = { rName.Text, rEmail.Text, rPw.Text, rCPw.Text };
            foreach (string k in box)
            {
                if (!string.IsNullOrEmpty(rName.Text + rCPw.Text + rEmail.Text + rPw.Text))
                {
                    await Navigation.PushAsync(new MDPage());
                }
            }

        }
    }
}