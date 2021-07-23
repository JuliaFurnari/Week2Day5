using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    class Persona
    {
       // Persona ha le seguenti caratteristiche: •Nome •Cognome •Codice Fiscale
       
        //Costruttori

        public Persona() { }
        public Persona(string nome, string cognome, string codiceFiscale) {
            Nome = nome;
            Cognome = cognome;
            if (codiceFiscale.Length == 16) CodiceFiscale = codiceFiscale;
            else Console.WriteLine("Il codice fiscale contiene 16 caratteri.");
        }

        //Metodi
        public virtual void PrintInfo()
        {
            Console.Write($"Nome: {Nome}" + $"\tCognome: {Cognome}");
        }

        //Dati della classe
        public string Nome;
        public string Cognome;
        public string CodiceFiscale;

    }
}
