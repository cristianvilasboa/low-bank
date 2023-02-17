using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowbank.Windows
{
    internal class Account
    {
        private readonly int _id;
        private readonly string _name;
        private decimal amount;
        private string cpf;
        private string email;
        private string telefone;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public decimal Amount { get { return amount; } }
        public string Cpf { get { return cpf; } }
        public string Email { get { return email; } }
        public string Telefone { get { return telefone; } }

        public Account(int id, string name, decimal amount,string cpf , string email, string telefone)
        {
            this._id = id;
            this._name = name;
            this.amount = amount;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
        }

        public static Account Parse(string texto)
        {
            string[] informacoes = texto.Split(',', 6);

            int conta = Convert.ToInt32(informacoes[0]);
            string nome = informacoes[1];
            string cpf = informacoes[2];
            string email = informacoes[3];
            string telefone = informacoes[4];

            decimal saldo = informacoes[5].ConvertDecimalString();

            // Transformar string em Account
            Account novaConta = new Account(conta, nome, saldo, cpf, telefone, email);

            return novaConta;
        }

    }
}
