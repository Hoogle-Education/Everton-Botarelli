using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_e_Terceirizados.entities {
    public class Terceirizado : Funcionario {



        public override bool Equals(object? obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string? ToString() {
            return base.ToString();
        }
    }
}
