namespace lowbank.Windows
{
    public partial class Form1 : Form
    {
        List<Account> accounts;

        public Form1()
        {
            InitializeComponent();
            Account contaDoCristian = new Account(123, "Cristian");
            Account contaDoFelipe = new Account(456, "Felipe");
            Account contaDoGuilherme = new Account(789, "Guilherme");

            accounts = new List<Account>();

            accounts.Add(contaDoCristian);
            accounts.Add(contaDoFelipe);
            accounts.Add(contaDoGuilherme);

        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            string numeroConta = accountTextBox.Text;

            int id =  Convert.ToInt32(numeroConta);

            for (int i = 0; i < accounts.Count; i++)
            {
                Account contaAtual = accounts[i];
                if (contaAtual.Id == id)
                {
                    amountLabel.Text = "Saldo em conta: R$ " + contaAtual.Amount;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}