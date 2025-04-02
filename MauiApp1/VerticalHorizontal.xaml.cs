namespace MauiApp1;

public partial class VerticalHorizontal : ContentPage
{
	public VerticalHorizontal()
	{
		InitializeComponent();
	}

    private void Comprar_Clicked(object sender, EventArgs e)
    {
		LabelComprar.IsVisible = true;
    }
}