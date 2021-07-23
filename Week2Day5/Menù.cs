using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5
{
    

    class Menù
    {
        internal static void Start()
        {
            Console.WriteLine("Benvenuto!");

            char scelta;

            do
            {
                Console.WriteLine("Premi 1 per visualizzare tutti gli impiegati.");
                Console.WriteLine("Premi 2 per visualizzare gli impiegati di un determinato settore.");
                Console.WriteLine("Premi 3 per inserire un nuovo impiegato.");
                Console.WriteLine("Premi 4 per eliminare un impiegato.");
                Console.WriteLine("Premi Q per uscire");

                scelta = Console.ReadKey().KeyChar;

                switch (scelta)
                {
                    case '1':
                        //Visualizza tutti i dipendenti;
                        VisualizzaDipendenti();
                        Console.WriteLine();
                        break;
                    case '2':
                        //Visualizza i dipendenti di un settore
                     
                        VisualizzaDipendentiSettore();
                        Console.WriteLine();
                        break;
                    case '3':
                        //Inserisci un impiegato
                        InserisciImpiegato();
                        Console.WriteLine();
                        break;
                    case '4':
                        //Elimina un impiegato
                        EliminaImpiegato();
                        Console.WriteLine();
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("\nScelta non disponibile");
                        break;
                }
            }
            while (!(scelta == 'Q'));


        }

       

        private static void EliminaImpiegato()
        {
            //Inserire il codice fiscale del nuovo impiegato da console;
            //Controllo se esiste quell'impiegato nella lista;
            //Ps:Ovviamente devo cambiare i codici fiscali nelle liste che per 
            //comodità ho inserito tutti uguali
            //Se esiste lo elimino
        }

        private static void InserisciImpiegato()
        {
            //Inserire il codice fiscale del nuovo impiegato da console;
            //Controllo se esiste quell'impiegato nella lista;
            //Se esiste do errore altrimento lo aggiungo;
        }
        private static void VisualizzaDipendentiSettore()
        {
            
            List<Impiegato> listaImpiegati = ListaImpiegati();
            
            EnumSettore settore = GetSettore();
            foreach (Impiegato imp in listaImpiegati)
            {
                if (imp.GetSettore() == settore)
                {
                    imp.PrintInfo();
                    Console.WriteLine("\n***************");
                }
            }

        }     

            
        

            public static List<Impiegato> ListaImpiegati()
            {


                List<Impiegato> listaImpiegati = new List<Impiegato>();
                Tecnico t = new Tecnico();
                List<Tecnico> listaTecnici = t.ListaTecnico();
                Stagista s = new Stagista();
                List<Stagista> listaStagisti = s.ListaStagisti();
                Manager m = new Manager();
                List<Manager> listaManagers = m.ListaManagers();

                listaImpiegati.AddRange(listaTecnici);
                listaImpiegati.AddRange(listaStagisti);
                listaImpiegati.AddRange(listaManagers);
                return listaImpiegati;

            }
            private static void VisualizzaDipendenti()
            {
                Console.WriteLine("Elenco degli impiegati:");

                List<Impiegato> listaImpiegati = ListaImpiegati();

                foreach (Impiegato m1 in listaImpiegati)
                {
                    m1.PrintInfo();
                    Console.WriteLine("\n***************");
                }


            }
            public static EnumSettore GetSettore()
            {
                Console.WriteLine("");
                Console.WriteLine($"Premi {(int)EnumSettore.Amministrazione} per scegliere {EnumSettore.Amministrazione}");
                Console.WriteLine($"Premi {(int)EnumSettore.Sviluppo} per scegliere {EnumSettore.Sviluppo}");
                Console.WriteLine($"Premi {(int)EnumSettore.Vendite} per scegliere {EnumSettore.Vendite}");


                int g;
                while (!int.TryParse(Console.ReadLine(), out g) || g < 0 || g > 2)
                {
                    Console.WriteLine("Scelta non corretta, riprova");
                }

                return (EnumSettore)g;
            }
        }
    
    }
