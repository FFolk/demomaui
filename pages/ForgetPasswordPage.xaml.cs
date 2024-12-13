namespace demomaui.pages;

public partial class ForgetPasswordPage : ContentPage
{
	public ForgetPasswordPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}