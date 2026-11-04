namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */

        Console.WriteLine("combien de wagon voulez vous cherchez ?");

        int wagontoSearch = Convert.ToInt32(Console.ReadLine());
        int safeNumber = 3;
        int check = 0;
        int searchedWagon = 0;
        int gold = 0;

        Console.WriteLine("vous allez fouiller " + wagontoSearch + " wagons.");

        while (wagontoSearch > check) 
        {
            searchedWagon++;

            int SearchedSafe = 0;
            while (SearchedSafe < safeNumber)
            {
                SearchedSafe++;
                Console.WriteLine("wagon " + searchedWagon + " -Coffre " + SearchedSafe + " inspecte.");
                gold++;
            }           


            check++;
        }

        Console.WriteLine("vous avez fouille " + searchedWagon + " wagons et " + (searchedWagon * safeNumber) + " coffres, vous avez amasse; " + gold + " lingots" );

    }
}