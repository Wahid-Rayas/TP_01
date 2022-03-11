using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01
{
    internal class Personne
    {
        private string _prenom;
        private string _nom;
        private DateTime _date;
        
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (value != _prenom)
                {
                    _prenom = value;  
                }
            }
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (value != _nom)
                {
                    _nom = value;
                }
            }
        }

        

    }
}
