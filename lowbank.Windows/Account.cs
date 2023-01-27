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

        public int Id { get { return _id; } }
        public decimal Amount { get { return amount; } }

        public Account(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
