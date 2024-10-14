using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECForedrag
{
    class Foredrag : Lokale
    {
        public int AntalElever { get; set; }
        private string Information { get; set; }
        private  Lære Lære { get; set; }
    // lære fra person???

    public Foredrag(string navn, string information, Lære lære) : base(lære.Fag)
    {
            AntalElever = 0;
            Information = information;
            Lære = lære;
    }
    public void StartedFordrag()
        {
            Console.WriteLine("Foredrag er started: ");
            Console.WriteLine($"Navn: {Navn} ");
            Console.WriteLine($"Lærer: {Lære.Navn}");
            Console.WriteLine($"Information:{Information}");
        }

    /*
    public void AngivForeDragInformation(int AntalElever, string Information, string LæreNavn)
    {

    }
    /*
    public void StartEtFordrag()
    {
        Console.WriteLine("Max antal Elever som kan tilmeldes " + AntalElever + " Information " + Information + " Lærens navn" + LæreNavn);
    }
    */


}
}
