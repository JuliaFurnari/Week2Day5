using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    class Stagista:Impiegato
    {
        //Lo Stagista è un impiegato ma ha anche: •Durata dello stage(in mesi.Esempio: 3)
        //•Calcolo stipendio: lo stipendio mensile dello stagista è 600 €.

        //Costruttori
        public Stagista() { }
        public Stagista(string nome, string cognome, string codiceFiscale, EnumSettore settore, int durataStage)
              : base(nome, cognome, codiceFiscale, settore)
        {
           DurataStage=durataStage;
        }

        internal override double CalcoloStipendioMensile()
        {
            double stipendio = 600;
            
            return stipendio;
        }

        public List<Stagista> ListaStagisti()
        {
            List<Stagista> listaStagisti = new List<Stagista>();
            listaStagisti.Add(new Stagista("Manuel", "Locatelli", "GRGCHL16A24B345R", EnumSettore.Amministrazione, 6));
            listaStagisti.Add(new Stagista("Nicolò", "Barella", "GRGCHL16A24B345R", EnumSettore.Amministrazione, 6));
            listaStagisti.Add(new Stagista("Marco", "Verratti", "GRGCHL16A24B345R", EnumSettore.Vendite, 4));
            listaStagisti.Add(new Stagista("Matteo", "Pessina", "GRGCHL16A24B345R", EnumSettore.Vendite, 4));
            listaStagisti.Add(new Stagista("Lorenzo", "Pellegrini", "GRGCHL16A24B345R", EnumSettore.Sviluppo, 3));
            listaStagisti.Add(new Stagista("Vincenzo", "Grifo", "GRGCHL16A24B345R", EnumSettore.Sviluppo, 3));

            return listaStagisti;
        }

        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\tSipendio Mensile: {CalcoloStipendioMensile()}");
        }

        //Dati della classe

        public int DurataStage;
       
    }
}
