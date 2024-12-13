using demomaui.pages;

namespace demomaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ForgetPasswordPage), typeof(ForgetPasswordPage));
	}
}
