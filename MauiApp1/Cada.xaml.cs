namespace MauiApp1;

public partial class Cada : ContentPage
{
	public Cada()
	{
		InitializeComponent();
	}

    private void Salvar_Clicked(object sender, EventArgs e)
    {
		string nome = EntryNome.Text;
		int idade = int.Parse(EntryIdade.Text);

		Pessoa p = new Pessoa();
		p.nome = nome;
		p.idade = idade;

		Pessoa.pessoas.Add(p);
        Shell.Current.GoToAsync("//Listagem");

		Console.WriteLine(sender);

    }
}