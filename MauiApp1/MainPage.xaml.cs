namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Entrar_Clicked(object sender, EventArgs e)
        {
            
            string nome = inputNome.Text;
            string senha = inputSenha.Text;

            if(nome == "conrado" && senha == "123")
            {
                DisplayAlert("Sucesso!", "Usuário autenticado com sucesso", "Fechar");
            }
            else
            {
                DisplayAlert("Erro", "Email ou senha incorretos", "Fechar");
            }

        }
    }

}
