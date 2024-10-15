using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC-Lecture-System
{
    class Lære : Person
    {
      

        // skal bruge alder variabler fra person
        // skal bruge navn variabler fra person

        public string Fag { get; set; } // hvad input foredrag kommer til at handle om
        public List<Foredrag> ForedragsListe { get; set; }

        public Lære(string navn, int alder, string fag) : base (navn, alder)
        {
            Fag = fag;
            ForedragsListe = new List<Foredrag>();
        } 

        public Foredrag OpretFordrag(string information)
        {
            Foredrag foredrag = new Foredrag(Fag, information, this);
            ForedragsListe.Add(foredrag);
            return foredrag;
        }
        public void StartForedrag(Foredrag foredrag)
        {
            foredrag.StartedFordrag();
        }

       

        

        
       

   

    }
}
