using System;

namespace es_settimana_12_Giorno_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Francesco", "Napoli", 27);
            persona1.GetNome();
            persona1.GetCognome();
            persona1.GetEta();
            Console.WriteLine(persona1.GetDettagli());
            Console.ReadLine();


            Console.WriteLine("Inserisci nome persona:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome persona:");
            string Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci eta' persona:");
            int Eta = Convert.ToInt32(Console.ReadLine());
            Persona persona2 = new Persona(Nome, Cognome, Eta);
            Console.WriteLine(persona2.GetDettagli());
            Console.ReadLine();
        }
    }
}
