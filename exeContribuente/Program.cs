using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeContribuente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contribuente contribuente = new Contribuente();
            contribuente.Start();
        }



        public class Contribuente
        {
            public string Nome
            { get; set; }

            public string Cognome
            { get; set; }
            public string DataNascita
            { get; set; }
            public string CodiceFiscale
            { get; set; }

            public string Sesso
            { get; set; }

            public string ComuneResidenza
            { get; set; }

            public decimal RedditoAnnuale
            { get; set; }


            public void Start()
            {
                Console.WriteLine("====Inserisci i tuoi dati=====");
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Nome = nome;
                Console.WriteLine("Cognome");
                string cognome = Console.ReadLine();
                Cognome = cognome;
                Console.WriteLine("data di Nascita");
                string dataNascita = Console.ReadLine();
                DataNascita = dataNascita;
                Console.WriteLine("Codice Fiscale");
                string codiceFiscale = Console.ReadLine();
                CodiceFiscale = codiceFiscale;
                Console.WriteLine("sesso");
                string sesso = Console.ReadLine();
                Sesso = sesso;
                Console.WriteLine("comune di residenza");
                string comuneDiResidenza= Console.ReadLine();
                ComuneResidenza= comuneDiResidenza;
                Console.WriteLine("reddito dichiarato");
                decimal redditoDichiarato = decimal.Parse(Console.ReadLine());
                RedditoAnnuale = redditoDichiarato;
               
                Stampa();
                


            }
            public void Stampa()
            {
                Console.WriteLine("====================================");
                Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE");
                Console.WriteLine($"Contribuente:{Nome}" + "  " + $"{Cognome}");
                Console.WriteLine($"data di nascita:{DataNascita}");
                Console.WriteLine($"codice fiscale:{CodiceFiscale}");
                Console.WriteLine($"sesso( {Sesso})");
                Console.WriteLine($"comunde di residenza:{ComuneResidenza}");
                Console.WriteLine($"reddito annuale:{RedditoAnnuale}"); 
                CalcolaImposta();
               
                Console.ReadLine();
                
            }
            public void CalcolaImposta()
            {
                decimal impostaValore = 0;
               
                if (RedditoAnnuale <=15000)
                {
                   impostaValore = RedditoAnnuale / 100 * 23;

                    Console.WriteLine($"IMPOSTA DA VERSARE:{impostaValore}");
                    Console.WriteLine("====================================");
                    Console.ReadLine();
                  

                }
                else if ((RedditoAnnuale >=15001) && (RedditoAnnuale <=28000))
                {
                    impostaValore = RedditoAnnuale / 100 * 27;
                    Console.WriteLine($"IMPOSTA DA VERSARE:{impostaValore}");   
               
                    Console.WriteLine("====================================");
                    Console.ReadLine();
                }
                else if ((RedditoAnnuale >= 28001) && (RedditoAnnuale <= 55000))
                {
                    impostaValore = RedditoAnnuale / 100 * 38;
                    Console.WriteLine($"IMPOSTA DA VERSARE:{impostaValore}");
                 
                    Console.WriteLine("====================================");
                    Console.ReadLine();
                }
                else if((RedditoAnnuale>=55001)&&(RedditoAnnuale <= 75000))
                {
                    impostaValore = RedditoAnnuale / 100 * 41;
                    Console.WriteLine($"IMPOSTA DA VERSARE:{impostaValore}");
                    Console.ReadLine();
                    Console.WriteLine("====================================");
                }
                else if ((RedditoAnnuale >= 75001))
                {
                    impostaValore = RedditoAnnuale / 100 * 41;
                    Console.WriteLine($"IMPOSTA DA VERSARE:{impostaValore}");
                 
                    Console.WriteLine("====================================");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("errore");
                   
                }
               
            }
        }
    }
}
    

        
    



           
    

