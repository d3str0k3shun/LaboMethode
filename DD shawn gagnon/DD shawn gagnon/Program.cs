namespace DD_shawn_gagnon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            bool invalide = true;
            Random de = new Random();
            string texteMenu = "Choisir 1 pour les stats, 2 pour un combat, 3 pour un resumer du dernier combat et 4 pour quitter";
            Console.WriteLine(texteMenu);
            int.TryParse(Console.ReadLine(), out choix);
            


            int[] statsOrc = new int[5];
            int[] statsSoldat = new int[5];

            statsOrc[0] = 30;
            statsOrc[1] = de.Next(10, 19);
            statsOrc[2] = 14;
            statsOrc[3] = 10;
            statsOrc[4] = 2;

            statsSoldat[0] = 30;
            statsSoldat[1] = de.Next(14,19);
            statsSoldat[2] = 18;
            statsSoldat[3] = 8;
            statsSoldat[4] = 2;

            while (invalide)
            {
                choix = choixMenu(texteMenu, 4);
                if (choix == 1)
                {

                }
                else if (choix == 2)
                {

                }
                else if (choix == 3)
                {

                }
                else if (choix == 4)
                {

                }
            }

            choix = choixMenu(texteMenu, 4);
            Console.WriteLine(choix);
        }
        static int choixMenu(string texteMenu, int nbchoix)
        {
            
            int choix = 0;
            return choix;
        }
        static int afficherStats(int[] stats , string nom)
        {
            int choix = 0;
            Console.WriteLine(nom);
            return choix;
            
        }
        
    }
}
