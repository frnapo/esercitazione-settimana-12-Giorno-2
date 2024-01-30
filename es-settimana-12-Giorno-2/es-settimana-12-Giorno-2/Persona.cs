using System;

namespace es_settimana_12_Giorno_2
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Persona(string Nome, string Cognome, int Eta)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
        }

        public void GetNome()
        {
            Console.WriteLine("Il nome della persona e': " + Nome);
        }

        public void GetCognome()
        {
            Console.WriteLine("Il cognome della persona e': " + Cognome);
        }

        public void GetEta()
        {
            Console.WriteLine("L'eta' della persona e': " + Eta + " anni.");
        }

        public string GetDettagli()
        {
            string messaggio = Nome + ". " + Cognome + ". " + Eta + " anni.";
            return messaggio;
        }

    }
}
