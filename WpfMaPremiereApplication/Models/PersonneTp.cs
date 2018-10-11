using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMaPremiereApplication.Models
{
    public class PersonneTp
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Prenom { get; set; }

        //List<PersonneTp> ListeDePersonne = new List<PersonneTp>();

        //public void AjouterPersonne(PersonneTp personneCree)
        //{
        //    //ListeDePersonne.Add(personneCree);
        //}
    
    public PersonneTp ()
    {
        Nom = "";
        Prenom = "";
    }
        

    }
    
}
