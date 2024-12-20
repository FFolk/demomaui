using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using demomaui.pages;

namespace demomaui.Viemmodel;

public partial class LoginViewmodel : ObservableObject
{
    [ObservableProperty]
    string username = "";
    
    [ObservableProperty]
    string password = "";

    [ObservableProperty]
    string router = nameof(RegisterPage);


    [RelayCommand]
    void Login()
    {
        System.Diagnostics.Debug.WriteLine("xxx");
        System.Diagnostics.Debug.WriteLine($"Username : {Username}");
        System.Diagnostics.Debug.WriteLine($"Password : {Password}");
    }

    //Task => Future in Flutte
    [RelayCommand]
    async Task GotoPage(string page)
    {
        await Shell.Current.GoToAsync(page);
        System.Diagnostics.Debug.WriteLine("Register Page");
    }
}
