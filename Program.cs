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
        int WagontoSearch = Convert.ToInt32(Console.ReadLine());
        int SafeNumber = 3;
        int Check = 0;
        int SearchedWagon = 0;
        int Gold = 0;
        Console.WriteLine("vous allez fouille " + WagontoSearch + " wagons.");
        while (WagontoSearch > Check);
        {
            SearchedWagon++;

            int SearchedSafe = 0;
            do
            {
                SearchedSafe++;
                Console.WriteLine("wagon " + SearchedWagon + " -Coffre " + SearchedSafe + " inspecte.");
                Gold++;
            } while (SearchedSafe < SafeNumber);            


            Check++;
        }

        Console.WriteLine("vous avez fouille " + SearchedWagon + " et " + SearchedWagon * SafeNumber + " coffre, vous avez amasse; " + Gold);

    }
}