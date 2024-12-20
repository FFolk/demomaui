namespace demomaui.pages;

public partial class ForgetPasswordPage : ContentPage
{
	//Attributes
	// string username = "";
	// string password = "";

	public string Username { get; set; }
	public string Parssword { get; set; }

	public ForgetPasswordPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}