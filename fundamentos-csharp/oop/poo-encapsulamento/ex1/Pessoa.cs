using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class Pessoa
    {
        private string _name;
        private int _idade;
        public string Name {
            get {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value >= 0)
                {
                    _idade = value;
                }
            }
        }
    }

}
