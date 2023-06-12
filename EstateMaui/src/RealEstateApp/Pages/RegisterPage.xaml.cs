using RealEstateApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void BtnRegister_OnClicked(object sender, EventArgs e)
    {
        var response = await ApiService.RegisterUser(EntFullName.Text, EntEmail.Text, EntPassword.Text, EntPhone.Text);
        if (response)
        {
            await DisplayAlert("", "Your account has been created", "Alright");
            await Navigation.PushModalAsync(new LoginPage());
        }
        else
        {
            await DisplayAlert("", "Oops something went wrong", "Cancel");
        }
    }

    private async void TapLogin_OnTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPage());
    }
}