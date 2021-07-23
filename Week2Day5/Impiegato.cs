using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    abstract class Impiegato:Persona
    {
        //L’impiegato è una persona e ha le seguenti caratteristiche:
        //•Settore(Vendite, Amministrazione, Sviluppo) •Calcolo stipendio mensile(metodo) •Lista di skills(opzionale)

        //Costruttori
        public Impiegato() { }
        public Impiegato(string nome, string cognome, string codiceFiscale, EnumSettore settore)
            :base(nome, cognome, codiceFiscale)
        {
            Settore = settore;
        }

        public EnumSettore GetSettore()
        {
            return Settore;
        }

        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\tSettore: {Settore}");
        }

        internal abstract double CalcoloStipendioMensile();
        
        //Dati della classe
        EnumSettore Settore;

    }
    public enum EnumSettore
    {
       Vendite,
       Amministrazione,
       Sviluppo
    }
}
