using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC-Lecture-System
{
    class Elev: Person
    {
     public List<Foredrag> ForedragListe { get; set; }

        public Elev(string navn, int alder) : base(navn, alder) {
        

           ForedragListe= new List<Foredrag>();
        
        }
       public void TilMeldFordrag(Foredrag foredrag)
        {
            if (!ForedragListe.Contains(foredrag)){
                ForedragListe.Add(foredrag);
                foredrag.AntalElever++;
            }
        }
    }
}
