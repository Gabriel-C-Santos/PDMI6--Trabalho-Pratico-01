namespace AplicaçãoTeste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkButtonClicked(object sender, EventArgs e)
        {
            string id = entryID.Text;
            string password = entryPass.Text;

            if (id == "admin" && password == "senha@dmin")
            {
                DisplayAlert("Login", "Logou com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login não autorizado!", "OK");
            }
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            entryID.Text = string.Empty;
            entryPass.Text = string.Empty;
            entryID.Focus();
        }

        private void OnCreditsButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Autores: Gabriel Coutinho dos Santos, Leonardo Pinto Teixeira", "OK");
        }
    }
}
