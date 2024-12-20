namespace demomaui.pages;

// [QueryProperty(nameof(Username), "uname")]
// [QueryProperty(nameof(Password), "pwd")]

// [QueryProperty(nameof(LoignObject), "data")]
public partial class ForgetPasswordPage : ContentPage
{
	//Attributes
	// string username = "";
	// string password = "";
	// public string Username { get; set; }
	// public string Password { get; set; }

	// public LoginData LoignObject { get; set; }
	public ForgetPasswordPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
	private void Button_Clicked2(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine($"Username :{Username}");
		// System.Diagnostics.Debug.WriteLine($"Password :{Password}");
		// System.Diagnostics.Debug.WriteLine($"Username :{LoignObject.Uname}");
		// System.Diagnostics.Debug.WriteLine($"Password :{LoignObject.Pwd}");
	}
}