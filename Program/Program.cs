using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECLectureSystem.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lære lærer = new Lære("Lærer Mads", 35, "Matematik");

            Foredrag foredrag1 = lærer.OpretFordrag("Introduktion til algebra");
            Foredrag fordrag2 = lærer.OpretFordrag("Geometri i praksis");

            Elev elev1 = new Elev("Elev1, Peter", 5);
            Elev elev2 = new Elev("Elev2, Hansen", 20);

            elev1.TilMeldFordrag(foredrag1);
            elev2.TilMeldFordrag(fordrag2);

            lærer.StartForedrag(foredrag1);

          
                    

            



           





        }
    }
}
