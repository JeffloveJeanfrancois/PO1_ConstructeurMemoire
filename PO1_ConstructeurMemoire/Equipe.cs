using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_ConstructeurMemoire
{
    public class Equipe
    {
        private string nom;
        private string ville;
      public Equipe(string nom, string ville)
        {
            nom = nom;
            Equipe = Equipe;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Ville { get => ville; set => ville = value; }

        public override string? ToString()
        {
            return nom + " de " + ville;
        }

    }
}
