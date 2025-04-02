using System.Diagnostics;

namespace MauiApp1;

public partial class Listagem : ContentPage
{

	public Listagem()
	{
		InitializeComponent();

		Pessoa p1 = new Pessoa();
		p1.nome = "Conradito";
		p1.idade = 15;
		p1.id = 0;

		Pessoa p2 = new Pessoa();
		p2.idade = 20;
		p2.nome = "Pedrita";
		p2.id = 1;

		Pessoa p3 = new Pessoa();
		p3.nome = "Juanzito";
		p3.idade = 19;
		p3.id = 2;

		Pessoa.pessoas.Add(p1);
		Pessoa.pessoas.Add(p2);
		Pessoa.pessoas.Add(p3);

		Lista.ItemsSource = Pessoa.pessoas;

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		Lista.ItemsSource = null;
        Lista.ItemsSource = Pessoa.pessoas;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Button button = (Button)sender;
		int id = (int)button.CommandParameter;

		bool confirma = await DisplayAlert("Excluir usuário", "Tem certeza que deseja excluir?", "Sim", "Não");
		if(confirma == true)
		{
			Pessoa.pessoas.RemoveAt(id);
			Lista.ItemsSource = null;
			Lista.ItemsSource = Pessoa.pessoas;
		}

    }
}