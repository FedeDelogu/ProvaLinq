using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    internal class Studente
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        
        public int Anno { get; set; }
        public double VotoMedio { get; set; }  
        public string CognomeDocente { get; set; }
        
        public string Nominativo { get => Nome + " " + Cognome; }

        public Studente ()
        {

        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Cognome: {Cognome}\n" +
                $"Iscritto al: {Anno}anno\n" +
                $"Media: {VotoMedio}\n" +
                $"Insegnante di riferimento: Prof.{CognomeDocente}" +
                $"---------------------------------------------------";
                
        }
        public int Eta()
        {
            return 0;
        }
    }
}
