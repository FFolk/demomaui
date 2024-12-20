using demomaui.Viemmodel;

namespace demomaui.pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewmodel();

	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine(uname.Text);
		// System.Diagnostics.Debug.WriteLine(pwd.Text);

		// if (uname.Text == "Folk" && pwd.Text == "11")
		// {
		// 	await Navigation.PushAsync(new ViewPage());
		// }
		// else
		// {
		// 	await DisplayAlert("Error", "username or password incorrect", "ไปใส่ใหม่ไป");
		// }
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine("xxx");
		// await Shell.Current.GoToAsync($"{nameof(ForgetPasswordPage)}?uname={uname.Text}&pwd={pwd.Text}");

		// var logindata = new LoginData
		// {
		// 	Uname = uname.Text,
		// 	Pwd = pwd.Text
		// };
		// var queryParames = new Dictionary<string, object>(){
		// 	{"data", logindata}	
		// };
		// await Shell.Current.GoToAsync($"{nameof(ForgetPasswordPage)}",queryParames);
	}
}

public class LoginData
{
	public string Uname { get; set; } = "";
	public string Pwd { get; set; } = "";
}