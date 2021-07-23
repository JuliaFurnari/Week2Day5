using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    class Manager:Impiegato
    {
        //Il manager è un impiegato ma ha anche: •Ore di straordinario(nel mese) •Stipendio di base (mensile)
        //•Calcolo stipendio: lo stipendio mensile del manager è dato da: Stipendio Base + (Ore di straordinario * 10).

        //Costruttori
        public Manager() { }
        public Manager(string nome, string cognome, string codiceFiscale, EnumSettore settore, int oreStraordinario , double stipendioBase)
              : base(nome, cognome, codiceFiscale, settore)
        {
            OreStraordinario = oreStraordinario;
            StipendioBase = stipendioBase;
        }

        internal override double CalcoloStipendioMensile()
        {
            double stipendio = 0;
            stipendio = OreStraordinario*10 + StipendioBase;
            return stipendio;
        }

        public List<Manager> ListaManagers()
        {
            List<Manager> listaManagers = new List<Manager>();
            listaManagers.Add(new Manager("Mauro", "Rossi", "GRGCHL16A24B345R", EnumSettore.Amministrazione, 6, 3000));
            listaManagers.Add(new Manager("Tommaso", "Bianchi", "GRGCHL16A24B345R", EnumSettore.Vendite, 10, 3500));
            listaManagers.Add(new Manager("Alessandro", "Rossi", "GRGCHL16A24B345R", EnumSettore.Sviluppo, 15, 4000));
            return listaManagers;
        }

        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\tSipendio Mensile: {CalcoloStipendioMensile()}");
        }
        //Dati della classe

        public int OreStraordinario;
        public double StipendioBase;
    }
}
