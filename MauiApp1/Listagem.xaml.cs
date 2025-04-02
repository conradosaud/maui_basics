using System.Diagnostics;

namespace MauiApp1;

public partial class Listagem : ContentPage
{

    List<Pessoa> pessoas = new List<Pessoa>();

    public Listagem()
	{
		InitializeComponent();

		Pessoa p1 = new Pessoa();
		p1.nome = "Conradito";
		p1.idade = 15;

		Pessoa p2 = new Pessoa();
		p2.nome = "Pedrita";
		p2.idade = 20;

		Pessoa p3 = new Pessoa();
		p3.nome = "Juanzito";
		p3.idade = 19;

		pessoas.Add(p1);
		pessoas.Add(p2);
		pessoas.Add(p3);

		Lista.ItemsSource = pessoas;

	}

}