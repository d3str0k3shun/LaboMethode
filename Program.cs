using System.Diagnostics;

namespace DD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random de = new Random();
            string texteMenu = " choisir 1 pour les stats, 2 pour un combat, 3 pour un résumer du dernier combat et 4 pour quitter";
            int choix = 0;
            bool invalide = true;

         

            // Suggestions :

            //  Étape une :utiliser un tableau pour stocker les statistiques des combatants

            // Étape deux : utiliser des méthodes spécifiques pour isoler des bouts de programme
            // Étape trois : construire l'historique en utilisant la concaténation
            // 0 pv, 1 attaque, 2 defence, 3 dommage, 4 dommages suplémentaires

            int lancer = 0;
            int[] statsOrc = new int[5];
            int[] statshumain = new int[5];

            statsOrc[0] = 30;
            statsOrc[1] = de.Next(10, 19);
            statsOrc[2] = 14;
            statsOrc[3] = 10;
            statsOrc[4] = (statsOrc[1] - 9) / 2 + 2;

            statshumain[0] = 30;
            statshumain[1] = de.Next(14, 19);           
            statshumain[2] = 18;            
            statshumain[3] = 8;         
            statshumain[4] = (statshumain[1] - 9) / 2 + 2;

            string afficherStatsHumain = string.Format(" l'humain possède {0} pv, {1} d'attaque, {2} de défence, {3} de dé de dommage et {4} de dommage suplémentaire", statshumain[0], statshumain[1], statshumain[2], statshumain[3], statshumain[4]);
            string afficherStatsOrc = string.Format(" l'orc possède {0} pv, {1} d'attaque, {2} de défence, {3} de dé de dommage et {4} de dommage suplémentaire", statsOrc[0], statsOrc[1], statsOrc[2], statsOrc[3], statsOrc[4]);
            while (invalide)
            {
                choix = choisirmenu(texteMenu, 4);
                if (choix == 1)
                {
                    Console.Clear();
                    Console.WriteLine(afficherStatsHumain);
                    Console.WriteLine(afficherStatsOrc);
                }
                else if (choix == 2)
                {
                    Console.Clear();
                    statshumain[0] = 30;
                    statsOrc[0] = 30;
                    int DebutH = de.Next(1, 21);
                    int DebutO = de.Next(1, 20);

                    if (DebutH >= DebutO)
                    {
                        Console.WriteLine("Le combat commence :");
                        Console.WriteLine("le guerrier commence");
                        while (statshumain[0] > 0 && statsOrc[0] > 0)
                        {
                            Console.WriteLine("l'humin lance un dé et optient un " + lancer);
                            if (lancer >= statsOrc[2])
                            {
                                Console.WriteLine("Le guerrier touche l'orc");
                                lancer = de.Next(1, 9) + statshumain[4];
                                Console.WriteLine("l'humain fait " + lancer + " de dégat a l'orc");
                                statsOrc[0] = statsOrc[0] - lancer;
                                Console.WriteLine("L'orc es rendu a " + statsOrc[0] + "de pv");
                            }
                            else
                            {
                                Console.WriteLine("l'humain rate son coup");
                            }
                            if (statsOrc[0] > 0)
                            {
                                lancer = de.Next(1, 21);
                                Console.WriteLine("l'orc lance un dé et optient un " + lancer + " puisqu'il de bat a deux mains " + lancer + 2);
                                if (lancer * 2 >= statshumain[2])
                                {
                                    Console.WriteLine("L'orc a reussi a toucher le guerrier");
                                    lancer = de.Next(1, 11) + statsOrc[4];
                                    Console.WriteLine("l'orc fait " + lancer + " de dégat a l'humain");
                                    statshumain[0] = statshumain[0] - lancer;
                                    Console.WriteLine("Le guerrier es donc a " + statshumain[0] + "de pv");
                                }
                                else
                                {
                                    Console.WriteLine("l'orc rate son coup");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Le combat commence :");
                        Console.WriteLine("l'orc commence");
                        while (statshumain[0] > 0 && statsOrc[0] > 0)
                        {
                            lancer = de.Next(1, 21);
                            Console.WriteLine("l'orc lance un dé et optient un " + lancer + " puisqu'il de bat a deux mains " + lancer + 2);
                            if (lancer * 2 >= statshumain[2])
                            {
                                Console.WriteLine("L'orc touche le guerrier");
                                lancer = de.Next(1, 11) + statsOrc[4];
                                Console.WriteLine("l'orc fait " + lancer + " de dégat a l'humain");
                                statshumain[0] = statshumain[0] - lancer;
                                Console.WriteLine("Le guerrier es donc a " + statshumain[0] + "de pv");
                            }
                            else
                            {
                                Console.WriteLine("l'orc rate son coup");
                            }
                            if (statshumain[0] > 0)
                            {



                                Console.WriteLine("Le guerrier touche l'orc");
                                lancer = de.Next(1, 9) + statshumain[4];
                                Console.WriteLine("l'humain fait " + lancer + " de dégat a l'orc");
                                statsOrc[0] = statsOrc[0] - lancer;
                                Console.WriteLine("L'orc es rendu a " + statsOrc[0] + "de pv");
                            }
                            else
                            {
                                Console.WriteLine("l'humain rate");
                            }
                        }
                        if (statsOrc[0] < statshumain[0])
                        {
                            Console.WriteLine("l'humain a gagner");
                        }
                        else
                        {
                            Console.WriteLine("l'orc gagne");
                        }
                    }
                }















                else if (choix == 3)
                {



                }
                else if (choix == 4)
                {
                    invalide = false;
                }
                
                Console.WriteLine("appuyez pour continuer");
                Console.ReadLine();
            }
        }



        static int choisirmenu(string texteMenu, int nbChoix)
        {
            bool invalide = true;
            int choix = 0;



            while (invalide)
            {
                Console.Clear();
                Console.WriteLine(texteMenu);
                int.TryParse(Console.ReadLine(), out choix);
                if (choix == 1 || choix == 2 || choix == 3 || choix == 4)
                {
                    invalide = false;
                }



            }
            return choix;
        }
    }
}