namespace lowbank.Windows
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string dir = @"C:\CrisCode\LowBank\low-bank\lowbank.Windows\data.csv";

            string[] linhas = File.ReadAllLines(dir);

            // Loop para ler cada linha

            for (int i = 1; i < linhas.Length; i++)
            {
                string linhaAtual = linhas[i];

                // Adicionar nova conta na lista "Accounts"

                accounts.Add(Account.Parse(linhaAtual));
            }
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            string numeroConta = accountTextBox.Text;

            int id =  Convert.ToInt32(numeroConta);

            for (int i = 0; i < accounts.Count; i++)
            {
                Account contaAtual = accounts[i];
                bool contaPesquisada = contaAtual.Id == id;

                if (contaPesquisada)
                {
                    textBoxConta.Text = $"{contaAtual.Id}";
                    textBoxNome.Text = contaAtual.Name;
                    textBoxCpf.Text = contaAtual.Cpf;
                    textBoxEmail.Text = contaAtual.Email;
                    textBoxTelefone.Text = contaAtual.Telefone;
                    textBoxSaldo.Text = $"R$ {contaAtual.Amount}";

                    amountLabel.Text = $"{contaAtual.Name} seu saldo em conta é de R$ {contaAtual.Amount}";
                    break;
                }
            }
        }

        private void accountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            amountLabel.Text = string.Empty;

            char caracterPressionado = e.KeyChar;
            bool ehNumero =  int.TryParse(caracterPressionado.ToString(), out int numeroConta);

            if (ehNumero || '\b' == caracterPressionado)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }           
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

    }
}