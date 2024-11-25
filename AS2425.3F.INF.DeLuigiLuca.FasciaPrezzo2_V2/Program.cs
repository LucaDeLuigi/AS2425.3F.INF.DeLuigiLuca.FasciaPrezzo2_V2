namespace AS2425._3F.INF.DeLuigiLuca.FasciaPrezzo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luca De Luigi; 3F; 22/11/2024; FasciaPrezzo2");

            /* DO WHILE e FOR (Post Condizionali):
             * Un ciclo post condizionale esegue prima delle istruzioni e poi verifica una condizione.
             * Se essa si verifica falsa esce dal ciclo sennò continua rieseguendo le istruzioni iniziali.
             * 
             * WHILE (Pre Condizionale):
             * Un ciclo pre condizionale verifica prima una condizione ed in caso entra nel ciclo eseguendo le istruzioni all'interno di esso.
             * Se essa si verifica falsa esce dal ciclo sennò continua rieseguendo le istruzioni iniziali.
            */

            // Dichiarazione
            double spesa;

            // Inizializzazione massimo e minimo
            double max = 0;
            double min = 0;

            // Inizializzazione accomulatori spese totali delle fascie
            double primaFascia = 0;
            double secondaFascia = 0;
            double terzaFascia = 0;
            double quartaFascia = 0;

            // Contatori dei prodotti delle fascie
            int numProd = 0;
            int numProdPrima = 0;
            int numProdSeconda = 0;
            int numProdTerza = 0;
            int numProdQuarta = 0;

            Random r = new Random();
            spesa = r.Next(0, 301);
            Console.WriteLine(spesa);
            while (spesa != 0)
            {
                if (spesa > max)
                {
                    max = spesa;
                }

                if (spesa < min)    // Non ho capito come si trova il numero minore.
                {
                    min = spesa;
                }

                if (spesa > 0 && spesa <= 50)
                {
                    numProd += 1;
                    numProdPrima += 1;
                    Console.WriteLine($"Il prodotto numero {numProd} e' nella prima fascia");
                    primaFascia += spesa;
                }
                else if (spesa >= 51 && spesa <= 100)
                {
                    numProd += 1;
                    numProdSeconda += 1;
                    Console.WriteLine($"Il prodotto numero {numProd} e' nella seconda fascia");
                    secondaFascia += spesa;
                }
                else if (spesa >= 101 && spesa <= 150)
                {
                    numProd += 1;
                    numProdTerza += 1;
                    Console.WriteLine($"Il prodotto numero {numProd} e' nella terza fascia");
                    terzaFascia += spesa;
                }
                else if (spesa >= 151)
                {
                    numProd += 1;
                    numProdQuarta += 1;
                    Console.WriteLine($"Il prodotto numero {numProd} e' nella quarta fascia");
                    quartaFascia += spesa;
                }
                spesa = r.Next(0, 301);
                Console.WriteLine(spesa);
            };

            Console.WriteLine($"La spesa media della prima fascia e' {primaFascia / numProdPrima}, la seconda e' {secondaFascia / numProdSeconda}, la terza {terzaFascia / numProdTerza} e la quarta {quartaFascia / numProdQuarta}.");
            Console.WriteLine($"La spesa massima e' stata {max}, mentre la minima {min}.");
        }
    }
}
