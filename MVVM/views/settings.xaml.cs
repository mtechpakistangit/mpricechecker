namespace M_PriceCheker.MVVM.views;

public partial class settings : ContentPage
{
	public settings()
	{
		InitializeComponent();
	}

    private void btnSetting_Clicked(object sender, EventArgs e)
    {

    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());

    }

    private void btnUpload_Clicked(object sender, EventArgs e)
    {

    }
}