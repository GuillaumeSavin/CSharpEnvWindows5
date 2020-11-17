using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvWindows5
{
    class Departement
    {
        private String nom;

        public Departement(String _nom)
        {
            this.nom = _nom;
        }

        public String DepartementString
        {
            get
            {
                return nom;
            }
        }
    }
}
