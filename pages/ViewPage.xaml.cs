namespace demomaui.pages;

public partial class ViewPage : ContentPage
{
	public ViewPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine("!!!!");
		// DisplayAlert("Alert","สวัสดี","cancel");
		await Navigation.PopAsync();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		
    }
}