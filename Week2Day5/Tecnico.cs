using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    class Tecnico:Impiegato
    {
       // Il Tecnico è un Tecnico ma ha anche: •Paga Oraria •Ore Lavorate •Calcolo stipendio;
       // lo stipendio mensile del tecnico è dato da: Ore Lavorate * Paga Orari

        //Costruttori
        public Tecnico() { }
        public Tecnico(string nome, string cognome, string codiceFiscale, EnumSettore settore, float pagaOraria, int oreLavorate)
              :base(nome, cognome, codiceFiscale, settore)
        {
            PagaOraria = pagaOraria;
            OreLavorate = oreLavorate;
        }

        internal override double CalcoloStipendioMensile()
        {
            double stipendio=0;
            stipendio = OreLavorate * PagaOraria;
            return stipendio;
        }

        public  List<Tecnico> ListaTecnico()
        {
            List<Tecnico> listaTecnico = new List<Tecnico>();
            listaTecnico.Add(new Tecnico("Giorgio", "Chiellini", "GRGCHL16A24B345R", EnumSettore.Amministrazione, 7, 168));
            listaTecnico.Add(new Tecnico("Leonardo", "Bonucci", "GRGCHL16A24B345R", EnumSettore.Amministrazione, 7, 168));
            listaTecnico.Add(new Tecnico("Emerson", "Palmieri", "GRGCHL16A24B345R", EnumSettore.Vendite, 7.5f, 150));
            listaTecnico.Add(new Tecnico("Leonardo", "Spinazzola", "GRGCHL16A24B345R", EnumSettore.Vendite, 7.5f, 150));
            listaTecnico.Add(new Tecnico("Giovanni", "Di Lorenzo", "GRGCHL16A24B345R", EnumSettore.Sviluppo, 8, 170));
            listaTecnico.Add(new Tecnico("Gianluca", "Mancini", "GRGCHL16A24B345R", EnumSettore.Sviluppo, 8, 170));
            return listaTecnico;
        }

        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\tSipendio Mensile: {CalcoloStipendioMensile()}");
        }

        //Dati della classe

        public float PagaOraria;
        public int OreLavorate;

    }
}
