using System;
using System.Linq;

namespace Projet_Marwan_Kaouachi
{
    static class cc // Classe console color faite maison (inutile aux exercices c'est juste pour le fun et faire plus beau)
    {
        #region ConsoleColor
        /*
         * J'assigne de façon manuelle les constante des couleurs a des codes de formatage pour la console
         * En espérant que ca ne gène pas, c'est un petit plus et perso je trouve ça plus esthétique
         */
        public const string end = "\x1b[0m"; // Balise fermante de la modification de police et de couleur

        public const string bold = "\x1b[1m"; // Balise gras
        public const string rod = "\x1b[2m"; // Balise "désactivé" 
        public const string ita = "\x1b[3m"; // Balise italique
        public const string under = "\x1b[4m"; // Balise souligner
        public const string inver = "\x1b[7m"; // Balise "upside down"
        public const string disab = "\x1b[9m"; // Balise rayé

        public const string black = "\x1b[30m"; // Balise police noir
        public const string bgBlack = "\x1b[40m"; // Balise fond noir
        public const string red = "\x1b[31m"; // Balise police rouge
        public const string bgRed = "\x1b[41m"; // Balise fond rouge
        public const string green = "\x1b[32m"; // Balise police vert
        public const string bgGreen = "\x1b[42m"; // Balise fond vert
        public const string yellow = "\x1b[33m"; // Balise police jaune
        public const string bgYellow = "\x1b[43m"; // Balise fond jaune
        public const string blue = "\x1b[34m"; // Balise police bleu
        public const string bgBlue = "\x1b[44m"; // Balise fond bleu
        public const string purple = "\x1b[35m"; // Balise police violet
        public const string bgPurple = "\x1b[45m"; // Balise fond violet
        public const string cyan = "\x1b[36m"; // Balise police cyan
        public const string bgCyan = "\x1b[46m"; // Balise fond cyan
        public const string white = "\x1b[37m"; // Balise police blanche
        public const string bgWhite = "\x1b[47m"; // Balise fond blanche

        public const string lightPurple = "\x1b[38;2;129;10;209m";
        public const string bgLightPurple = "\x1b[48;2;129;10;209m";

        public const string warnFlag = bgRed + "[ ! ]" + end;
        public const string wrongFlag = bgYellow + "[ ? ]" + end;
        public const string infoFlag = bgBlue + "[ i ]" + end;

        public const string closeConsole = infoFlag + " Au revoir et à bientôt !";
        public const string badVal = wrongFlag + " Il semble que vous n'avez pas saisis une valeur conforme.";

        /*
         Traduit depuis un fichier .js que j'ai fais pour un projet personnel (https://pastebin.com/nLVM6aR6) 
         Je sais que C# embarque la fonction ConsoleColor mais elle fonctionne différement selon les version alors je préfère utiliser Les codes d'escape ANSI, de plus ca me fait un peu d'entraineent
         */
        #endregion ConsoleColor

        public const string retourZero = infoFlag + " Utilisez " + cyan + "0" + end + " pour quitter et revenir au menu précédent"; // Pour ne pas avoir à la retapper partout
    }
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Console.WindowHeight + " x " + Console.WindowWidth);
            Console.SetWindowSize(120, 32);                 // Je redimentionne la fenêtre au démarage pour qu'elle soit adapté a l'affichage complet de mes menus
            Console.Title = "Projet Info C# Marwan K.";     // Je change ici le titre de ma page juste pour faire plus beau que de voir le chemin d'accès d'execution à chaques fois

            #region ASCII
            /*Console.WriteLine(@"     _                _ _           _   _               ____   ___ ____  _           ____   ___ ____  ____  
    / \   _ __  _ __ | (_) ___ __ _| |_(_) ___  _ __   |___ \ / _ \___ \/ |         |___ \ / _ \___ \|___ \ 
   / _ \ | '_ \| '_ \| | |/ __/ _` | __| |/ _ \| '_ \    __) | | | |__) | |  _____    __) | | | |__) | __) |
  / ___ \| |_) | |_) | | | (_| (_| | |_| | (_) | | | |  / __/| |_| / __/| | |_____|  / __/| |_| / __/ / __/ 
 /_/   \_\ .__/| .__/|_|_|\___\__,_|\__|_|\___/|_| |_| |_____|\___/_____|_|         |_____|\___/_____|_____|
         |_|   |_|                                                                                          
                  by Marwan Kaouachi                                                                        ");*/
            // @"" signifie que la string gardera la mise en forme d'origine



            /*Console.WriteLine(@$"{cc.cyan}╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗{cc.end}   
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}      _                _ _           _   _               ____   ___ ____  _           ____   ___ ____  ____   {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}     / \   _ __  _ __ | (_) ___ __ _| |_(_) ___  _ __   |___ \ / _ \___ \/ |         |___ \ / _ \___ \|___ \  {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}    / _ \ | '_ \| '_ \| | |/ __/ _` | __| |/ _ \| '_ \    __) | | | |__) | |  _____    __) | | | |__) | __) | {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}   / ___ \| |_) | |_) | | | (_| (_| | |_| | (_) | | | |  / __/| |_| / __/| | |_____|  / __/| |_| / __/ / __/  {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}  /_/   \_\ .__/| .__/|_|_|\___\__,_|\__|_|\___/|_| |_| |_____|\___/_____|_|         |_____|\___/_____|_____| {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}          |_|   |_|                                                                                           {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}                     {cc.end}{cc.cyan}┌────────────────────┐{cc.bgWhite}                                                                   {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}╚═════════════════════┤{cc.end}{cc.bgLightPurple} by Marwan Kaouachi {cc.end}{cc.cyan}├═══════════════════════════════════════════════════════════════════╝{cc.end} 
                      {cc.cyan}└────────────────────┘ {cc.end}");*/

            Console.WriteLine(@$"{cc.cyan}╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════╗{cc.end}   
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}     _                _ _           _   _               ____   ___ ____  _           ____   ___ ____  ____   {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}    / \   _ __  _ __ | (_) ___ __ _| |_(_) ___  _ __   |___ \ / _ \___ \/ |         |___ \ / _ \___ \|___ \  {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}   / _ \ | '_ \| '_ \| | |/ __/ _` | __| |/ _ \| '_ \    __) | | | |__) | |  _____    __) | | | |__) | __) | {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}  / ___ \| |_) | |_) | | | (_| (_| | |_| | (_) | | | |  / __/| |_| / __/| | |_____|  / __/| |_| / __/ / __/  {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite} /_/   \_\ .__/| .__/|_|_|\___\__,_|\__|_|\___/|_| |_| |_____|\___/_____|_|         |_____|\___/_____|_____| {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}║{cc.end}{cc.black}{cc.bgWhite}         |_|   |_|                                                                                           {cc.end}{cc.cyan}║{cc.end}
{cc.cyan}╚═════════════════════╦════════════════════╦══════════════════════════════════════════════════════════════════╝{cc.end} 
                      {cc.cyan}║{cc.end}{cc.bgLightPurple} by Marwan Kaouachi {cc.end}{cc.cyan}║{cc.end}
                      {cc.cyan}╚════════════════════╝ {cc.end}");

            #endregion ASCII

            #region Menu Principal
            int choix;
            do
            {
                Console.WriteLine("╔═══╦══════════╦═════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ 1 ║ Partie A ║ Cette partie est un ensemble d'exercice faits pour s'amuser entre les calculs et le codage. ║");
                Console.WriteLine("╠═══╬══════════╬═════════════════════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 2 ║ Partie B ║ Cette partie se concentre plus sur des exercices de travail de la logique du codage.        ║");
                Console.WriteLine("╠═══╬══════════╬═════════════════════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 3 ║ Partie C ║ Cette dernière partie est une partie innovation, a nous de jouer !                          ║");
                Console.WriteLine("╠═══╬═════════╦╩═════════════════════════════════════╦═══════════════════════════════════════════════════════╝");
                Console.WriteLine("║ 0 ║ Quitter ║ Quitte le programme de façon propre. ║");
                Console.WriteLine("╚═══╩═════════╩══════════════════════════════════════╝");

                Console.WriteLine($"\n{cc.under}Bienvenue dans mon programme, par où voulez-vous commencer ?{cc.end}");
                choix = DemandeNombre();
            }
            while (choix <= 0 && choix > 4);
            #endregion Menu Principal

            #region Traitement
            switch (choix)
            {
                case 0: // Si l'entrée de l'utilisateur est 0
                    string wantsToQuit;
                    do
                    {
                        Console.WriteLine(cc.infoFlag + " Êtes vous sur de vouloir quitter ? (oui/non)");
                        wantsToQuit = Console.ReadLine();

                        if (wantsToQuit == "non")
                        {
                            Console.Clear();
                            Main();
                            break;
                        }
                        else if (wantsToQuit == "oui")
                            Console.WriteLine($"Au revoir {cc.cyan}:3{cc.end}");
                        break;
                    } while (wantsToQuit != "oui" || wantsToQuit != "non"); // Vérification avant la sortie du programme

                    Environment.Exit(0); // Je termine le programme avec le code 0 qui signifie sans erreurs.
                    break;

                case 1:
                    Console.Clear();
                    MenuA();
                    break;

                case 2:
                    Console.Clear();
                    MenuB();
                    break;

                case 3:
                    Console.Clear();
                    MenuC();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    Main();
                    break;

            }
            #endregion Traitement

        }

        #region Outils
        static void Retour()
        {
            Console.WriteLine("\nAppuyez sur une touche pour continuer ...");
            Console.ReadKey();
            Console.Clear();
        }
        static int DemandeNombre()
        {
            int? choix; // Déclaration de la variable de choix qui doit être une variable int
            uint ch;
            do
            {
                try
                {
                    choix = Convert.ToInt32(Console.ReadLine()); // Je vérifie que le nombre est bien entier ici
                    ch = Convert.ToUInt32(choix); // Je vérifie qu'il est bien positif ici, si il ne l'est pas : passage par le catch et retour en haut du module
                }
                catch
                {
                    Console.WriteLine($"{cc.warnFlag} Attention la saisie doit être {cc.red}uniquement{cc.end} en nombre entier positif !");
                    choix = -22;
                }
            } while (choix < 0); // Si le choix n'est quand même pas un int la méthode recommence
            return (int)choix;
        }
        static bool Premier(int nombre)
        {
            bool Premier = true;
            if (nombre == 1 || nombre == 0)
            {
                Premier = false;
            }
            else if (nombre == 2)
            {
                Premier = true;
            }
            else
            {
                for (int i = 2; i < nombre; i++)
                {
                    if (nombre % i == 0 && i != nombre)
                    {
                        Premier = false;
                    }
                }
            }
            return Premier;
        }
        static int PremierSuperieur(int prem)
        {
            bool p;
            do
            {
                p = Premier(prem + 1);
                prem++;
            } while (p == false);
            return prem;
        }
        static bool VerifDate(int jour, int mois, int annee)
        {
            bool valide = true;

            if (jour < 1 || jour > 31 || mois < 1 || mois > 12 || annee < 0)
                valide = false;

            if (Bissextile(annee) == true && mois == 2 && jour > 28)
                valide = false;
            else if (Bissextile(annee) == false && mois == 2 && jour > 29)
                valide = false;

            return valide;
        }
        static bool Bissextile(int annee)
        {
            bool bis;

            if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
                bis = true;
            else
                bis = false;

            return bis;
        }
        static int[] DemandeDate()
        {
            string saisie;
            string[] datum;
            int n, jour, mois, annee;
            int[] TableauDate;
            do
            {
                Console.WriteLine("\nSaisissez la date : (Sous la forme jj mm (aa)aa ou bien jj/mm/(aa)aa)");

                saisie = Console.ReadLine();
                datum = saisie.Split(' ', '/');

                try
                {
                    n = Convert.ToInt32(saisie);
                    if (n == 0 && saisie.Length <= 1)                                               // Si l'utilisateur ne saisis qu'un 0 il est renvoyé au menu
                        Retour(); Console.Clear(); MenuB();

                }
                catch { }

                try
                {
                    jour = Convert.ToInt32(datum[0]); // Je vérifie dans ces try catch que l'utilisateur n'as pas saisies de caractères incorects ou mal formatté la date */*
                    mois = Convert.ToInt32(datum[1]);
                    annee = Convert.ToInt32(datum[2]);
                }
                catch
                {
                    Console.WriteLine($"{cc.warnFlag} Le format de la date doit être {cc.bgRed}jj mm (aa)aa{cc.end} ou bien {cc.bgRed}jj/mm/(aa)aa{cc.end}");
                    DemandeDate();
                }

                jour = Convert.ToInt32(datum[0]); // Si le try a fonctionné j'execute le même code pour mettre les valeurs dans les variables
                mois = Convert.ToInt32(datum[1]);
                annee = Convert.ToInt32(datum[2]);

                TableauDate = new int[] { jour, mois, annee }; // Je stock la date dans un tableau pour la sortir de mon module en une seule variable

                if (VerifDate(jour, mois, annee) == false)
                    Console.WriteLine(cc.badVal);

            } while (VerifDate(jour, mois, annee) == false);

            return TableauDate;
        }
        #endregion Outils

        #region Menus
        static void MenuA()
        {
            int? choixA;

            //Console.Clear();
            Console.WriteLine(@$"
╔═════════════════════════════════════╗
║  __  __                       _     ║
║ |  \/  | ___ _ __  _   _     / \    ║
║ | |\/| |/ _ \ '_ \| | | |   / _ \   ║
║ | |  | |  __/ | | | |_| |  / ___ \  ║  
║ |_|  |_|\___|_| |_|\__,_| /_/   \_\ ║
║                                     ║
╠═════════════════════════════════════╩═════════════════════╗
║{cc.retourZero} ║   
╚═══════════════════════════════════════════════════════════╝");

            Console.WriteLine("\n╔═══╦═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 1 ║ Vérifier si un nombre est Premier                           ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 2 ║ Afficher la liste des nombres Premiers entre 2 bornes       ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 3 ║ Affiche le premier nombre Premier supérieur                 ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 4 ║ Décomposer un nombre en produit de facteurs premiers        ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 5 ║ Palindrome ? Pas palindrome ! Palindrome ? Pas palindrome ! ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 6 ║ Affichage personnalisé                                      ║");
            Console.WriteLine("╚═══╩═════════════════════════════════════════════════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez un exercice parmis ceux ci-dessus :{cc.end}");
            choixA = DemandeNombre();

            switch (choixA)
            {
                case 0:
                    Console.Clear();
                    Main();
                    break;
                case 1:
                    Console.Clear();
                    AEX1();
                    break;
                case 2:
                    Console.Clear();
                    AEX2();
                    break;
                case 3:
                    Console.Clear();
                    AEX3();
                    break;
                case 4:
                    Console.Clear();
                    AEX4();
                    break;
                case 5:
                    Console.Clear();
                    AEX5();
                    break;
                case 6:
                    Console.Clear();
                    AEX6();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    MenuA();
                    break;
            }

        } // Penser à regrouper les cw pour L'optimisation générale
        static void MenuB()
        {
            int? choixB;

            Console.WriteLine(@$"
╔═══════════════════════════════════╗
║  __  __                    ____   ║  
║ |  \/  | ___ _ __  _   _  | __ )  ║  
║ | |\/| |/ _ \ '_ \| | | | |  _ \  ║
║ | |  | |  __/ | | | |_| | | |_) | ║
║ |_|  |_|\___|_| |_|\__,_| |____/  ║
║                                   ║
╠═══════════════════════════════════╩═══════════════════════╗
║{cc.retourZero} ║
╚═══════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n╔═══╦═════════════════════════════════════════╗");
            Console.WriteLine("║ 1 ║ Calcul de la date du lendemain          ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════╣");
            Console.WriteLine("║ 2 ║ Calcul du nombre de jours entre 2 dates ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════╣");
            Console.WriteLine("║ 3 ║ Vérifier si une date est bissextile     ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════╣");
            Console.WriteLine("║ 4 ║ Calculer la date de pâques              ║");
            Console.WriteLine("╠═══╬═════════════════════════════════════════╣");
            Console.WriteLine("║ 5 ║ Afficher le calendrier d'une année      ║");
            Console.WriteLine("╚═══╩═════════════════════════════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez un exercice parmis ceux ci-dessus :{cc.end}");
            choixB = DemandeNombre();

            switch (choixB)
            {
                case 0:
                    Console.Clear();
                    Main();
                    break;

                case 1:
                    Console.Clear();
                    BEX1();
                    break;
                case 2:
                    Console.Clear();
                    BEX2();
                    break;
                case 3:
                    Console.Clear();
                    BEX3();
                    break;
                case 4:
                    Console.Clear();
                    BEX4();
                    break;
                case 5:
                    Console.Clear();
                    BEX5();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    MenuB();
                    break;
            }

        }
        static void MenuC()
        {
            Calculator();
            /*int? choixC;

            Console.WriteLine($@"
╔═══════════════════════════════════╗
║  __  __                     ____  ║
║ |  \/  | ___ _ __  _   _   / ___| ║
║ | |\/| |/ _ \ '_ \| | | | | |     ║
║ | |  | |  __/ | | | |_| | | |___  ║
║ |_|  |_|\___|_| |_|\__,_|  \____| ║
║                                   ║
╠═══════════════════════════════════╩═══════════════════════╗
║{cc.retourZero} ║
╚═══════════════════════════════════════════════════════════╝");

            Console.WriteLine("\n╔═══╦═══════╦═════════════════════════════════════════╗");
            Console.WriteLine("║ 1 ║ Ncode ║ Menu d'encodage de chaîne de caractère  ║");
            Console.WriteLine("╠═══╬═══════╬═════════════════════════════════════════╣");
            Console.WriteLine("║ 2 ║ Dcode ║ Menu de décodage de chaîne de caractère ║");
            Console.WriteLine("╚═══╩═══════╩═════════════════════════════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez un menu parmis ceux ci-dessus :{cc.end}");
            choixC = DemandeNombre();

            switch (choixC)
            {
                case 0:
                    Console.Clear();
                    Main();
                    break;

                case 1:
                    Console.Clear();
                    //Ncode();
                    break;
                case 2:
                    Console.Clear();
                    //Dcode();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    MenuB();
                    break;*/
        }
        #endregion Menus

        #region Partie_A
        static void AEX1()
        {
            Console.WriteLine(@$"╔════════════════╗
║  _______  ___  ║
║ | ____\ \/ / | ║
║ |  _|  \  /| | ║
║ | |___ /  \| | ║
║ |_____/_/\_\_| ║
║     ┌──────────┴───────────────────────┐
╚═════┤ Vérifie si un nombre est Premier │             
┌─────┴──────────────────────────────────┴─────────────────┐
│{cc.retourZero}│
└──────────────────────────────────────────────────────────┘
");
            Console.WriteLine("\nSaisissez un nombre pour vérifier si il est Premier ou non:");
            int nombre;
            do
            {
                nombre = DemandeNombre();
                if (nombre == 0)
                    break;

                if (Premier(nombre) == true)
                {
                    Console.WriteLine(nombre + " est bien un nombre Premier.");
                }
                else if (Premier(nombre) == false)
                {
                    Console.WriteLine(nombre + " n'est pas un nombre Premier.");
                }
                else
                {
                    Console.WriteLine(cc.warnFlag + "wtf c'est problématique la ?");
                }

            } while (nombre != 0);

            Retour();
            MenuA();
        }
        static void AEX2()
        {
            Console.WriteLine(@$"╔════════════════════╗
║  _______  ______   ║
║ | ____\ \/ /___ \  ║
║ |  _|  \  /  __) | ║
║ | |___ /  \ / __/  ║
║ |_____/_/\_\_____| ║
║     ┌──────────────┴────────────────────────┐
╚═════┤ Affiche la liste des nombres Premiers │             
┌─────┴───────────────────────────────────────┴─────────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘
");
            int mini;
            int maxi;

            do
            {
                Console.WriteLine("Saisissez une borne minimale pour débuter la liste des nombres Premiers : (0 pour quitter)");
                mini = DemandeNombre();
                Console.WriteLine("Saisissez une borne maximale pour finir la liste des nombre Premiers : (Encore 0 pour quitter)");
                maxi = DemandeNombre();

                if (mini == 0 && maxi == 0)
                    break;

                if (mini > maxi)
                {
                    int z = mini;
                    mini = maxi;
                    maxi = z; // transfert de valeur pour avoir maxi > mini
                }

                string liste = "";
                int cpt = 0;

                for (int i = mini; i <= maxi; i++)
                {
                    bool prem = Premier(i); // Le programme vérifie tous les nombres entre mini et maxi, si ils sont Premier ils seront traité dans la suite de la boucle

                    if (prem == true)
                    {
                        liste += i.ToString(); // J'ajoute le nombre Premier dans la liste ici en convertissant sa valeur en string avant
                        cpt += 1; // Compte le nombre de nombres Premiers

                        if (i < maxi && prem == true)
                        {
                            liste += " ; "; // Et je vérifie qu'il ne soit pas égal à la borne supérieur pour ajouter le ; dans le but de ne pas avoir un ; qui traine tout seul à la fin 
                        }
                    }
                }

                Console.WriteLine($"Entre {cc.cyan}{mini}{cc.end} et {cc.cyan}{maxi}{cc.end} il y a {cc.cyan}{cpt}{cc.end} nombres Premiers.\nEn voici la liste : {cc.cyan}{liste.TrimEnd(' ', ';')}{cc.end}.\n"); // liste.TrimEnd() retire des caractères un à un en partant de la fin de la chaine (ici il retire "; " de ma chaine liste
            } while (mini != 0 || maxi != 0);

            Retour();
            MenuA();
        }
        static void AEX3()
        {
            Console.WriteLine(@$"╔════════════════════╗
║  _______  _______  ║
║ | ____\ \/ /___ /  ║
║ |  _|  \  /  |_ \  ║ 
║ | |___ /  \ ___) | ║
║ |_____/_/\_\____/  ║
║     ┌──────────────┴──────────────────────┐
╚═════┤ Affiche le nombre premier supérieur │             
┌─────┴─────────────────────────────────────┴───────────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘
       

");

            int nombre;
            do
            {
                Console.WriteLine("Saisissez un nombre pour afficher le nombre Premier supérieur à celui-ci:");
                nombre = DemandeNombre();
                int i = nombre;

                if (nombre == 0)
                    break;

                do
                {
                    i++;
                } while (Premier(i) != true);

                Console.WriteLine($"Le premier nombre Premier au dessus de {cc.cyan}{nombre}{cc.end} est {cc.cyan}{i}{cc.end}.\n");
            } while (nombre != 0);

            Retour();
            MenuA();
        }
        static void AEX4()
        {
            Console.WriteLine(@$"╔═════════════════════╗
║  _______  ___  _    ║
║ | ____\ \/ / || |   ║
║ |  _|  \  /| || |_  ║
║ | |___ /  \|__   _| ║
║ |_____/_/\_\  |_|   ║
║     ┌───────────────┴──────────────────────────┐
╚═════┤ Décompose en produit de facteurs premier │  
┌─────┴──────────────────────────────────────────┴──────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘
");
            int nombre, n;
            bool z;

            do
            {
                int prem = 2, cpt;
                string ligne = "";

                Console.WriteLine("Saisissez un nombre à décomposer en produit de facteurs premiers:");

                n = nombre = DemandeNombre();

                z = n != 0;

                #region Essai_1
                /*do
                {
                    while (nombre%prem != 0)
                    {
                        n /= prem;
                        cpt += 1;
                    }

                    if (cpt == 1)
                    {
                        ligne += prem;
                    } else
                    {
                        ligne += prem + "^" + cpt;
                    }

                    int nb = nombre + 1;

                    do
                    {
                        prem += 1;
                    } while(Premier(nb) == true);

                } while (nombre != 1);*/
                #endregion Essai_1
                #region Essai_2
                /*do
                {
                    while (n % prem == 0)
                    {
                        n /= prem;
                        cpt += 1;
                    }

                    if (cpt == 1)
                    {
                        ligne += prem.ToString();
                    }
                    else
                    {
                        ligne += prem.ToString() + "^" + cpt;
                    }
                    if (n > 1)
                    {
                        ligne += " * ";
                    }

                    do
                    {
                        s = Premier(prem + 1);
                        prem += 1;
                    } while (s != true);

                } while (n > 1);*/
                #endregion Essai_2
                if (z == true)
                {
                    do
                    {
                        cpt = 0;
                        while (n % prem == 0)
                        {
                            n /= prem;
                            cpt++;

                            //Console.WriteLine("facteur trouvé " + prem); // Pour voir le détail retirer ces commentaires
                            //Console.WriteLine(cpt);
                        }

                        if (cpt == 1)
                        {
                            ligne += prem.ToString();
                        }
                        else if (cpt > 1)
                        {
                            ligne += prem.ToString() + "^" + cpt;
                        }

                        if (n > 1 && cpt > 0)
                        {
                            ligne += " * ";
                        }

                        prem = PremierSuperieur(prem);

                    } while (n != 1);
                    Console.WriteLine($"Après décomposition : {cc.cyan}{nombre}{cc.end} = {cc.cyan}{ligne}{cc.end}");
                }

            } while (z != false);

            Retour();
            MenuA();
        }
        static void AEX5()
        {
            Console.WriteLine(@$"╔════════════════════╗
║  _______  ______   ║
║ | ____\ \/ / ___|  ║
║ |  _|  \  /|___ \  ║
║ | |___ /  \ ___) | ║
║ |_____/_/\_\____/  ║
║     ┌──────────────┴────────────────┐
╚═════┤ Palindrome ? Pas palindrome ? │  
┌─────┴───────────────────────────────┴─────────────────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘
");
            Console.WriteLine("\n╔═══╦═════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║ 1 ║ Affichage des nombres palindromes inférieur à {cc.green}1000{cc.end}                  ║");
            Console.WriteLine("╠═══╬═══════╦═════════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║ 2 ║ {cc.green}Bonus{cc.end} ║ Affichage des nombres {cc.cyan}premiers{cc.end} palindromes inférieur à {cc.green}1000{cc.end} ║");
            Console.WriteLine("╠═══╬═══════╬═════════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║ 3 ║ {cc.green}Bonus{cc.end} ║ Vérification si un nombre lambda est palindrome ou non      ║");
            Console.WriteLine("╚═══╩═══════╩═════════════════════════════════════════════════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez une option parmis celles ci-dessus :{cc.end}");
            int choixAEX5 = DemandeNombre();

            switch (choixAEX5)
            {
                case 0:
                    Retour();
                    MenuA();
                    break;
                case 1:
                    string liste = Palindrome(1000);
                    Console.WriteLine("\n" + liste);
                    Retour();
                    AEX5();
                    break;
                case 2:
                    string listeBonus = PalindromeBonus(1000);
                    Console.WriteLine("\n" + listeBonus);
                    Retour();
                    AEX5();
                    break;
                case 3:
                    int n;
                    do
                    {
                        Console.WriteLine("\nSaisissez le nombre à tester :");
                        n = DemandeNombre();
                        if (n == 0)
                            break;
                        if (n.ToString().SequenceEqual(n.ToString().Reverse()))
                            Console.WriteLine($"{cc.cyan}{n}{cc.end} {cc.green}est bien{cc.end} un nombre palindrome");
                        else
                            Console.WriteLine($"{cc.cyan}{n}{cc.end} {cc.red}n'est pas{cc.end} un nombre palindrome");
                    } while (n != 0);

                    Retour();
                    AEX5();
                    break;
                default:
                    Console.WriteLine($"{cc.warnFlag} {cc.red}Choix impossible{cc.end} Veuillez réessayer en vous assurant de saisir un {cc.under}nombre{cc.end} entre {cc.green}0{cc.end} et {cc.green}2{cc.end} inclus.");
                    Retour();
                    AEX5();
                    break;
            }

            static string Palindrome(int n)                                                     //Pour chaques caractère composant ma string je la compare a son inverse 
            {
                string liste = "";
                for (int i = 0; i < n; i++)
                {
                    if (i.ToString().SequenceEqual(i.ToString().Reverse()))
                    {
                        liste += i.ToString() + " ; ";
                    }
                }
                liste = liste.Substring(0, liste.Length - 3);
                return liste;
            }
            static string PalindromeBonus(int n)
            {
                string liste = "";
                for (int i = 0; i < n; i++)
                {
                    if (Premier(i) == true)
                    {
                        if (i.ToString().SequenceEqual(i.ToString().Reverse()))
                        {
                            liste += i.ToString() + " ; ";
                        }
                    }

                }
                liste = liste.Substring(0, liste.Length - 3);
                return liste;
            }
        }
        static void AEX6()
        {
            Console.WriteLine(@$"╔═══════════════════╗
║  _______  ____    ║
║ | ____\ \/ / /_   ║
║ |  _|  \  / '_ \  ║
║ | |___ /  \ (_) | ║
║ |_____/_/\_\___/  ║
║     ┌─────────────┴───────────┐
╚═════┤  Affichage personnalisé │  
┌─────┴─────────────────────────┴───────────────────────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘");

            Console.WriteLine("\n╔═══╦══════════════════╗");
            Console.WriteLine("║ 1 ║ Carré plein      ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 2 ║ Rectangle Plein  ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 3 ║ Carré Creux      ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 4 ║ Rectangle Creux  ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 5 ║ Damier           ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 6 ║ Triangle         ║");
            Console.WriteLine("╠═══╬══════════════════╣");
            Console.WriteLine("║ 7 ║ Triangle inversé ║");
            Console.WriteLine("╚═══╩══════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez une option parmis celles ci-dessus :{cc.end}");
            int choixAEX6 = DemandeNombre();
            int taille;
            char carac;
            switch (choixAEX6)
            {
                case 0:
                    Retour();
                    MenuA();
                    break;
                case 1:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la taille de votre carré :");
                    taille = DemandeNombre();

                    QuadrilaterePlein(taille, taille, carac);
                    Retour();
                    AEX6();
                    break;

                case 2:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la taille de votre rectangle (longueur puis largeur):");
                    int Longueur = DemandeNombre();
                    int Largeur = DemandeNombre();

                    QuadrilaterePlein(Longueur, Largeur, carac);
                    Retour();
                    AEX6();
                    break;
                case 3:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la taille de votre carré\n");
                    taille = DemandeNombre();

                    QuadrilatereCreux(taille, taille, carac);
                    Retour();
                    AEX6();
                    break;
                case 4:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la taille de votre rectangle (longueur puis largeur)\n");
                    Longueur = DemandeNombre();
                    Largeur = DemandeNombre();

                    QuadrilatereCreux(Longueur, Largeur, carac);
                    Retour();
                    AEX6();
                    break;
                case 5:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la taille de votre damier :");
                    taille = DemandeNombre();

                    Damier(taille, carac);
                    Retour();
                    AEX6();
                    break;

                case 6:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la hauteur de la pyramide\n");
                    taille = DemandeNombre();

                    Triangle(taille, carac);
                    Retour();
                    AEX6();
                    break;

                case 7:
                    Console.WriteLine("Quel caractère voulez vous utiliser ? \n(il est conseillé d'utiliser des caractères tels que '#', '*', '$' pour que le programme soit le plus beau possible)");
                    carac = Convert.ToChar(Console.Read());

                    Console.WriteLine("Saisissez la hauteur de la pyramide\n");
                    taille = DemandeNombre();

                    TriangleInverse(taille, carac);
                    Retour();
                    AEX6();
                    break;


                default:
                    Console.WriteLine($"{cc.warnFlag} {cc.red}Choix impossible{cc.end} Veuillez réessayer en vous assurant de saisir un {cc.under}nombre{cc.end} entre {cc.green}0{cc.end} et {cc.green}3{cc.end} inclus.");
                    Retour();
                    AEX6();
                    break;
            }

            #region Formes
            static void QuadrilaterePlein(int longueur, int largeur, char carac)
            {
                string ligne = "";

                for (int i = 1; i != longueur + 1; i++)
                {
                    ligne += carac.ToString() + " ";
                }


                for (int j = 1; j != largeur + 1; j++)
                {
                    Console.WriteLine(ligne);
                }
                //Console.WriteLine(ligne);
            }
            static void QuadrilatereCreux(int longueur, int largeur, char carac)
            {
                string start = "";
                string space = "";
                string ligne = "";

                for (int i = 1; i != longueur + 1; i++)
                {
                    start += carac.ToString() + " ";
                }
                for (int i = 1; i != longueur - 1; i++)
                {
                    space += "  ";
                }
                ligne += carac.ToString() + space + " " + carac.ToString();

                Console.WriteLine(start);
                for (int j = 0; j != largeur - 2; j++)
                {
                    Console.WriteLine(ligne);
                }
                Console.WriteLine(start);

            }
            static void Damier(int taille, char carac)
            {
                string ligne = "";
                string subligne = "";
                carac = Convert.ToChar(carac);

                for (int i = 0; i != taille; i++)
                {
                    if (i % 2 == 0)
                        ligne += carac;
                    else
                        ligne += "  ";
                }

                for (int i = 2; i != taille + 2; i++)
                {
                    if (i % 2 == 0)
                        subligne += "  ";
                    else
                        subligne += carac;
                }

                for (int j = 1; j != taille; j++)
                {
                    Console.WriteLine(ligne.ToString());
                    Console.WriteLine(subligne.ToString());
                }
            }
            static void Triangle(int n, char carac)
            {

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < n - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(carac.ToString());
                        Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            }
            static void TriangleInverse(int n, char carac)
            {

                for (int i = n; i >= 1; i--)
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < 2 * i; k++)
                    {
                        Console.Write(carac.ToString());
                    }
                    Console.WriteLine();
                }
            }
            #endregion Formes
        }
        #endregion Partie_A

        #region Partie_B
        static void BEX1()
        {
            string saisie;
            string[] datum;
            int n, jour, mois, annee, j, m, a, nextlap = -1;
            bool newlap = false;

            Console.WriteLine(@$"╔════════════════╗
║  _______  ___  ║
║ | ____\ \/ / | ║ 
║ |  _|  \  /| | ║ 
║ | |___ /  \| | ║ 
║ |_____/_/\_\_| ║
║     ┌──────────┴──────────────────┐
╚═════┤ Calcul la date du lendemain │             
┌─────┴─────────────────────────────┴──────────────────────┐
│{cc.retourZero}│
└──────────────────────────────────────────────────────────┘
");

            do
            {
                Console.WriteLine("Saisissez la date dont vous voulez connaître le lendemain : (Sous la forme jj mm aaa ou bien jj/mm/aaaa)");

                saisie = Console.ReadLine();
                datum = saisie.Split(' ', '/');                                                          // Je met dans un tableau tous les éléments qui sont séparé par un espace dans la string saisie

                try
                {
                    n = Convert.ToInt32(saisie);
                    if (n == 0 && saisie.Length <= 1)                                               // Si l'utilisateur ne saisis qu'un 0 il est renvoyé au menu
                        Retour(); Console.Clear(); MenuB();
                }
                catch { }

                try
                {
                    // jour = datum[0]
                    jour = j = Convert.ToInt32(datum[0]);
                    mois = m = Convert.ToInt32(datum[1]);
                    annee = a = Convert.ToInt32(datum[2]);

                    //jour >= 1 && jour <= 31;
                    //Console.WriteLine(datum[0]);

                    if (VerifDate(jour, mois, annee) == false)
                    {
                        Console.Clear();
                        Console.WriteLine(cc.badVal);
                        BEX1();
                    }

                    //Console.WriteLine(VerifDate(jour, mois, annee)); // test

                    #region Lendemain_calcul
                    jour++;

                    if (jour > 28 && mois == 2 && Bissextile(annee) == false)                    // Cas 28 Février
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (jour > 29 && mois == 2 && Bissextile(annee) == true)              // Cas 29 Février
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (mois == 4 || mois == 6 || mois == 9 || mois == 12 && jour == 31)   // Cas des mois à 30 jours
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (jour == 32)                                                        // Autres cas
                    {
                        jour = 1;
                        mois++;
                    }

                    if (mois > 12)
                    {
                        mois = 1;
                        annee++;
                    }
                    #endregion Lendemain_calcul

                    Console.WriteLine($"Le lendemain de {cc.cyan}{j}{cc.end}/{cc.cyan}{m}{cc.end}/{cc.cyan}{a}{cc.end} est le {cc.cyan}{jour}{cc.end}/{cc.cyan}{mois}{cc.end}/{cc.cyan}{annee}{cc.end}.");

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine($"{cc.warnFlag} {cc.bgRed}Pour rappel:{cc.end} {cc.red}Les mois ne contiennent que 31 jours et les années seulement 12 mois.{cc.end}");
                    BEX1();
                }

                if (nextlap == 0)
                {
                    newlap = false;
                }
                else if (nextlap == 1)
                {
                    newlap = true;
                }

            } while (newlap != false);
            Retour();
            MenuB();

        }
        static void BEX2()
        {
            string saisie;
            string[] datum, datum2;
            int n, jour, jour2, j, mois, mois2, m, annee, annee2, a, cpt = 1, nextlap;
            bool newlap = false;

            Console.WriteLine(@$"╔════════════════════╗
║  _______  ______   ║
║ | ____\ \/ /___ \  ║
║ |  _|  \  /  __) | ║
║ | |___ /  \ / __/  ║
║ |_____/_/\_\_____| ║
║     ┌──────────────┴──────────────────────────┐
╚═════┤ Calcul du nombre de jours entre 2 dates │             
┌─────┴─────────────────────────────────────────┴──────────┐
│{cc.retourZero}│
└──────────────────────────────────────────────────────────┘
");

            do
            {
                // Dans cette région je récupère et vérifie la validité des dates
                #region Saisie_dates
                do                                                                                  // Date 1
                {
                    Console.WriteLine("\nSaisissez la première des deux dates dont vous voulez connaître l'écart : (Sous la forme jj mm aaaa ou bien jj/mm/aaaa)");

                    saisie = Console.ReadLine();
                    datum = saisie.Split(' ', '/');

                    try
                    {
                        n = Convert.ToInt32(saisie);
                        if (n == 0 && saisie.Length <= 1)                                               // Si l'utilisateur ne saisis qu'un 0 il est renvoyé au menu
                            Retour(); Console.Clear(); MenuB();

                    }
                    catch { }

                    try
                    {
                        jour = j = Convert.ToInt32(datum[0]); // Je vérifie dans ces try catch que l'utilisateur n'as pas saisies de caractères incorects ou mal formatté la date */*
                        mois = m = Convert.ToInt32(datum[1]);
                        annee = a = Convert.ToInt32(datum[2]);
                    } catch
                    {
                        Console.Clear();
                        Console.WriteLine($"{cc.warnFlag} Le format de la date doit être {cc.bgRed}jj mm (aa)aa{cc.end} ou bien {cc.bgRed}jj/mm/(aa)aa{cc.end}");
                        BEX2();
                    }

                    jour = j = Convert.ToInt32(datum[0]);
                    mois = m = Convert.ToInt32(datum[1]);
                    annee = a = Convert.ToInt32(datum[2]);

                    if (VerifDate(jour, mois, annee) == false)
                        Console.WriteLine($"{cc.badVal}");
                } while (VerifDate(jour, mois, annee) == false);


                do                                                                                  // Date 2
                {
                    Console.WriteLine("\nSaisissez la deuxième date : (Sous la forme jj mm aaaa ou bien jj/mm/aaaa)");

                    saisie = Console.ReadLine();
                    datum2 = saisie.Split(' ', '/');

                    try
                    {
                        jour2 = Convert.ToInt32(datum2[0]); // */* ici aussi
                        mois2 = Convert.ToInt32(datum2[1]);
                        annee2 = Convert.ToInt32(datum2[2]);
                    } catch
                    {
                        Console.Clear();
                        Console.WriteLine($"{cc.warnFlag} Le format de la date doit être {cc.bgRed}jj mm (aa)aa{cc.end} ou bien {cc.bgRed}jj/mm/(aa)aa{cc.end}");
                        BEX2();
                    }

                    jour2 = Convert.ToInt32(datum2[0]);
                    mois2 = Convert.ToInt32(datum2[1]);
                    annee2 = Convert.ToInt32(datum2[2]);
                    if (VerifDate(jour2, mois2, annee2) == false)
                        Console.WriteLine($"{cc.badVal}");
                } while (VerifDate(jour2, mois2, annee2) == false);
                #endregion Saisie_dates

                // Dans cette région je vérifie que les dates sont dans le bon ordre et si ce n'est pas le cas je les mets dans le bon ordre
                #region Ordre_dates
                if (annee > annee2)
                {
                    n = annee;                                                                      // Recyclage, je réutilise n (inutile si on arrive ici dans le code) pour ne pas de déclarer d'autre variable
                    annee = annee2;
                    annee2 = n;

                    n = mois;
                    mois = mois2;
                    mois2 = n;

                    n = jour;
                    jour = jour2;
                    jour2 = n;

                    Console.WriteLine("Vous n'avez pas mis les dates dans le bon ordre mais pas de soucis je gère ca, j'ai remis les années dans le bons sens.");
                } else if (mois > mois2 && annee >= annee2)
                {
                    n = annee;
                    annee = annee2;
                    annee2 = n;

                    n = mois;
                    mois = mois2;
                    mois2 = n;

                    n = jour;
                    jour = jour2;
                    jour2 = n;

                    Console.WriteLine("Vous n'avez pas mis les dates dans le bon ordre mais pas de soucis je gère ca, j'ai remis les mois dans le bons sens.");
                } else if (jour > jour2 && mois >= mois2 && annee >= annee2)
                {
                    n = annee;
                    annee = annee2;
                    annee2 = n;

                    n = mois;
                    mois = mois2;
                    mois2 = n;

                    n = jour;
                    jour = jour2;
                    jour2 = n;
                }
                #endregion Ordre_date                                                                       

                // Dans cette région je fais le travail demandé de façon manuelle donc sans structure qui facilite le travaille
                #region Algo_manuel
                do
                {
                    jour++;
                    cpt += 1;

                    if (jour > 28 && mois == 2 && Bissextile(annee) == false)                    // Cas 28 Février
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (jour > 29 && mois == 2 && Bissextile(annee) == true)               // Cas 29 Février
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (jour == 31 && mois == 4 || jour == 31 && mois == 6 || jour == 31 && mois == 9 || jour == 31 && mois == 12)   // Cas des mois à 30 jours // Erreur idiote j'ai oublié les "|| jour == 31 &&"
                    {
                        jour = 1;
                        mois++;
                    }
                    else if (jour == 32)                                                        // Autres cas
                    {
                        jour = 1;
                        mois++;
                    }

                    if (mois > 12)
                    {
                        mois = 1;
                        annee++;
                    }
                } while (jour != jour2 || mois != mois2 || annee != annee2);
                #endregion Algo_manuel

                //Dans cette région je fais le travail demandé à l'aide des structures (en 6 lignes contre 34 lignes au dessus)
                #region Algo_auto
                DateTime date1 = new DateTime(annee, mois, jour);
                DateTime date2 = new DateTime(annee2, mois2, jour2);


                TimeSpan T = date2 - date1;
                #endregion Algo_auto

                Console.WriteLine($"Entre le {j}/{m}/{a} et le {jour2}/{mois2}/{annee2}, il y a exactement {cc.cyan}{cpt - 1/*T.TotalDays - 1*/}{cc.end} jours.");
                Console.WriteLine("\nVoulez vous recommencer(1) ou quitter(0) ?");
                nextlap = Convert.ToInt32(Console.ReadLine());
                cpt = 1; // Je réinitialise le compteur pour le prochain tour

                if (nextlap == 0)
                {
                    newlap = false;
                }
                else if (nextlap == 1)
                {
                    newlap = true;
                }


            } while (newlap != false);

            Retour();
            MenuB();
        }
        static void BEX3()
        {
            Console.WriteLine(@$"╔════════════════════╗
║  _______  _______  ║
║ | ____\ \/ /___ /  ║
║ |  _|  \  /  |_ \  ║
║ | |___ /  \ ___) | ║
║ |_____/_/\_\____/  ║
║     ┌──────────────┴───────────────────────┐
╚═════┤ Vérifier si une année est bissextile │             
┌─────┴──────────────────────────────────────┴─────────────┐
│{cc.retourZero}│
└──────────────────────────────────────────────────────────┘
");
            Console.WriteLine("Saisissez l'année que vous voulez tester :");
            int jour, mois, annee;
            do
            {
                int[] saisie = DemandeDate();                                                                       // Récupération et assignation de chaque partie de la date socké dans le tableau renvoyé par DemandeDate();
                jour = saisie[0];                                                                                   // 
                mois = saisie[1];
                annee = saisie[2];

                if (Bissextile(annee) == true)                                                                      // Traitement de l'année
                {
                    Console.WriteLine($"{cc.cyan}{annee}{cc.end} {cc.green}est bien{cc.end} une année bissextile");
                } else
                {
                    Console.WriteLine($"{cc.cyan}{annee}{cc.end} {cc.red}n'est pas{cc.end} une année bissextile");
                }
            } while (jour != 0 || mois != 0 || annee != 0);
            Retour();
            MenuB();
        }
        static void BEX4()
        {
            Console.WriteLine(@$"╔═════════════════════╗
║  _______  ___  _    ║
║ | ____\ \/ / || |   ║
║ |  _|  \  /| || |_  ║
║ | |___ /  \|__   _| ║
║ |_____/_/\_\  |_|   ║
║     ┌───────────────┴────────────┐
╚═════┤ Calculer la date de Pâques │             
┌─────┴────────────────────────────┴───────────────────────┐
│{cc.retourZero}│
└──────────────────────────────────────────────────────────┘
");

            Console.WriteLine("╔═══╦══════════════════════╗");
            Console.WriteLine("║ 1 ║ Algorithme de Gauss  ║");
            Console.WriteLine("╠═══╬══════════════════════╣");
            Console.WriteLine("║ 2 ║ Algorithme de Meeus  ║");
            Console.WriteLine("╠═══╬══════════════════════╣");
            Console.WriteLine("║ 3 ║ Algorithme de Conway ║");
            Console.WriteLine("╚═══╩══════════════════════╝");

            Console.WriteLine($"\n{cc.under}Choisissez l'algorithme que vous souhaitez tester :{cc.end}");
            int choixBEX4 = DemandeNombre();

            switch (choixBEX4)
            {
                case 0:
                    Retour();//Console.Clear();
                    MenuB();
                    break;
                case 1:
                    Console.Clear();
                    AlgoGauss();
                    break;
                case 2:
                    Console.Clear();
                    AlgoMeeus();
                    break;
                case 3:
                    Console.Clear();
                    AlgoConway();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    BEX4();
                    break;
            }

            #region Algorithmes_pâques
            static void AlgoGauss()
            {
                bool quit = false;

                Console.WriteLine(@$"
╔══════════════════════════════════════════════════════════════════╗
║     _    _                   _         ____                      ║
║    / \  | | __ _  ___     __| | ___   / ___| __ _ _   _ ___ ___  ║
║   / _ \ | |/ _` |/ _ \   / _` |/ _ \ | |  _ / _` | | | / __/ __| ║
║  / ___ \| | (_| | (_) | | (_| |  __/ | |_| | (_| | |_| \__ \__ \ ║
║ /_/   \_\_|\__, |\___/   \__,_|\___|  \____|\__,_|\__,_|___/___/ ║
║            |___/                                                 ║
╠═══════════════════════════════════════════════════════════╦══════╝
║{cc.retourZero} ║
╚═══════════════════════════════════════════════════════════╝
");
                do
                {
                    Console.WriteLine($"{cc.under}Saisissez l'année dont vous voulez calculer la date de Pâques avec l'algorithme de Gauss :{cc.end} (sous la forme aaaa)");
                    uint year; // uint pour que la valeur ne puisse pas être négative

                    do
                    {
                        string saisie = Console.ReadLine();

                        try
                        {
                            year = Convert.ToUInt32(saisie);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.badVal} Veillez à ce que l'année sois {cc.red}entière et positive{cc.end}.");
                            AlgoGauss();                    // Recommence si la conversion échoue
                        }

                        year = Convert.ToUInt32(saisie);
                        if (year == 0)
                        {
                            quit = true;
                            Retour();
                            BEX4();
                        }
                        else if (year < 1583)
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.warnFlag} Le calendrier Grégorien ne commence qu'en 1583, veuillez réessayer"); // Message d'erreur et d'avertissement
                            AlgoGauss();
                        }
                    } while (year < 1583);

                    int annee = Convert.ToInt32(year);

                    int a = annee % 19;         // Écris à l'aide des explications disponible sur Wikipédia : https://fr.wikipedia.org/wiki/Calcul_de_la_date_de_P%C3%A2ques_selon_la_m%C3%A9thode_de_Gauss
                    int b = annee % 4;          // À l'identique parce que je me perdrais si je changeais les variables.                                
                    int c = annee % 7;
                    int k = annee / 100;
                    int p = (13 + 8 * k) / 25;
                    int q = k / 4;
                    int M = (15 - p + k - q) % 30;
                    int N = (4 + k - q) % 7;
                    int d = (19 * a + M) % 30;
                    int e = (2 * b + 4 * c + 6 * d + N) % 7;
                    int H = 22 + d + e;
                    int Q = H - 31;
                    int R = (11 * M + 11) % 30;

                    if (d == 29 && e == 9)
                        Q = 19;
                    if (d == 28 && e == 6 && R < 19)
                        Q = 18;
                    if (H < 32)
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}dimanche {H} mars{cc.end}.");
                    if (H > 32)
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}dimanche {Q} avril{cc.end}.");

                } while (quit != true);
            }
            static void AlgoMeeus()
            {
                bool quit = false;

                Console.WriteLine(@$"
╔═══════════════════════════════════════════════════════════════════╗
║     _    _                   _        __  __                      ║
║    / \  | | __ _  ___     __| | ___  |  \/  | ___  ___ _   _ ___  ║
║   / _ \ | |/ _` |/ _ \   / _` |/ _ \ | |\/| |/ _ \/ _ \ | | / __| ║
║  / ___ \| | (_| | (_) | | (_| |  __/ | |  | |  __/  __/ |_| \__ \ ║
║ /_/   \_\_|\__, |\___/   \__,_|\___| |_|  |_|\___|\___|\__,_|___/ ║
║            |___/                                                  ║
╠═══════════════════════════════════════════════════════════╦═══════╝
║{cc.retourZero} ║
╚═══════════════════════════════════════════════════════════╝
");

                #region Essai_1
                /*do
                {
                    Console.WriteLine($"{cc.under}Saisissez l'année dont vous voulez calculer la date de Pâques avec l'algorithme de Meeus :{cc.end} (sous la forme aaaa)");
                    uint year; // uint pour que la valeur ne puisse pas être négative

                    do
                    {
                        string saisie = Console.ReadLine();

                        try
                        {
                            year = Convert.ToUInt32(saisie);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine(cc.badVal + $" Veillez à ce que l'année sois {cc.red}entière et positive{cc.end}.");              
                            AlgoMeeus();                    // Recommence si la conversion échoue
                        }

                        year = Convert.ToUInt32(saisie);
                        if (year == 0)
                        {
                            quit = true;
                            Retour();
                            BEX4();
                        }
                        else if (year <= 326)
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.warnFlag} Le calendrier Julien ne commence qu'en 326, veuillez réessayer"); // Message d'erreur et d'avertissement
                            AlgoMeeus();
                        }
                    } while (year <= 326);

                    int annee = Convert.ToInt32(year);

                    int A = annee % 19;
                    int B = annee % 17;
                    int C = annee % 4;
                    int D = (19 * A + 15) % 30;
                    int E = (2 * C + 4 * B - D + 34);
                    int G = D + E + 114;
                    int F = G / 31;

                    if (F == 4)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{G + 1} mars{cc.end}.");
                    } else if (F == 3)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{G + 1} mars{cc.end}.");
                    }

                } while (quit != true);*/
                #endregion Essai_1

                do
                {
                    Console.WriteLine($"{cc.under}Saisissez l'année dont vous voulez calculer la date de Pâques avec l'algorithme de Meeus :{cc.end} (sous la forme aaaa)");
                    uint year; // uint pour que la valeur ne puisse pas être négative

                    do
                    {
                        string saisie = Console.ReadLine();

                        try
                        {
                            year = Convert.ToUInt32(saisie);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.badVal} Veillez à ce que l'année sois {cc.red}entière et positive{cc.end}.");
                            AlgoMeeus();                    // Recommence si la conversion échoue
                        }

                        year = Convert.ToUInt32(saisie);
                        if (year == 0)
                        {
                            quit = true;
                            Retour();
                            BEX4();
                        }
                        else if (year < 1583)
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.warnFlag} Le calendrier Grégorien ne commence qu'en 1583, veuillez réessayer"); // Message d'erreur et d'avertissement
                            AlgoMeeus();
                        }
                    } while (year < 1583);

                    int annee = Convert.ToInt32(year);

                    int n = annee % 19;            // Écris à l'aide des explications disponible sur Wikipédia : https://fr.wikipedia.org/wiki/Calcul_de_la_date_de_P%C3%A2ques_selon_la_m%C3%A9thode_de_Meeus
                    int c = annee / 100;
                    int u = annee % 100;
                    int s = c / 4;
                    int t = c % 4;
                    int p = (c + 8) / 25;
                    int q = (c - p + 1) / 3;
                    int e = (19 * n + c - s - q + 15) % 30;
                    int b = u / 4;
                    int d = u % 4;
                    int L = (2 * t + 2 * b - e - d + 32) % 7;
                    int h = (n + 11 * e + 22 * 1) / 451;
                    int m = (e + 1 - 7 * h + 114) / 31;
                    int j = (e + L - 7 * h + 114) % 31;

                    if (m == 4)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{j + 1} avril{cc.end}.");
                    }
                    else if (m == 3)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{j + 1} mars{cc.end}.");
                    }

                } while (quit != true);
                Retour();
                BEX4();
            }
            static void AlgoConway()
            {
                bool quit = false;

                Console.WriteLine(@$"
╔════════════════════════════════════════════════════════════════════════════╗
║     _    _                   _         ____                                ║
║    / \  | | __ _  ___     __| | ___   / ___|___  _ ____      ____ _ _   _  ║
║   / _ \ | |/ _` |/ _ \   / _` |/ _ \ | |   / _ \| '_ \ \ /\ / / _` | | | | ║
║  / ___ \| | (_| | (_) | | (_| |  __/ | |__| (_) | | | \ V  V / (_| | |_| | ║
║ /_/   \_\_|\__, |\___/   \__,_|\___|  \____\___/|_| |_|\_/\_/ \__,_|\__, | ║
║            |___/                                                    |___/  ║
╠═══════════════════════════════════════════════════════════╦════════════════╝
║{cc.retourZero} ║
╚═══════════════════════════════════════════════════════════╝
");

                do
                {
                    Console.WriteLine($"{cc.under}Saisissez l'année dont vous voulez calculer la date de Pâques avec l'algorithme de Meeus :{cc.end} (sous la forme aaaa)");
                    uint year; // uint pour que la valeur ne puisse pas être négative

                    do
                    {
                        string saisie = Console.ReadLine();

                        try
                        {
                            year = Convert.ToUInt32(saisie);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.badVal} Veillez à ce que l'année sois {cc.red}entière et positive{cc.end}.");
                            AlgoMeeus();                    // Recommence si la conversion échoue
                        }

                        year = Convert.ToUInt32(saisie);
                        if (year == 0)
                        {
                            quit = true;
                            Retour();
                            BEX4();
                        }
                        else if (year < 1583)
                        {
                            Console.Clear();
                            Console.WriteLine($"{cc.warnFlag} Le calendrier Grégorien ne commence qu'en 1583, veuillez réessayer"); // Message d'erreur et d'avertissement
                            AlgoMeeus();
                        }
                    } while (year < 1583);

                    int annee = Convert.ToInt32(year);

                    int t = annee % 100;
                    int s = annee / 100;
                    int g = annee % 19;
                    int a = (t / 4);
                    int p = s % 4;
                    int jps = (9 - 2 * p) % 7;
                    int jp = (jps + t + a) % 7;
                    int G = g + 1;
                    int b = (s / 4);
                    int r = 8 * (s + 11) / 25;
                    int C = -s + b + r;
                    int d = (11 * G + C) % 30; d = (d + 30) % 30;
                    int h = (551 - 19 * d + G) / 544;
                    int e = (50 - d - h) % 7;
                    int f = (e + jp) % 7;
                    int R = 57 - d - f - h;

                    if (R > 32)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{R - 31} avril{cc.end}.");
                    }
                    else if (R < 32)
                    {
                        Console.WriteLine($"En {cc.cyan}{annee}{cc.end} la date de Pâques est le {cc.cyan}{R} mars{cc.end}.");
                    }

                } while (quit != true);
                Retour();
                BEX4();

            }
            #endregion Algorithme_pâques
        }
        static void BEX5()
        {
            Console.WriteLine(@$"╔════════════════════╗
║  _______  ______   ║
║ | ____\ \/ / ___|  ║
║ |  _|  \  /|___ \  ║
║ | |___ /  \ ___) | ║
║ |_____/_/\_\____/  ║
║     ┌──────────────┴────────────────┐
╚═════┤ Calendrier complet de l'année │  
┌─────┴───────────────────────────────┴─────────────────────┐
│{cc.retourZero} │
└───────────────────────────────────────────────────────────┘
");

            string saisie;
            uint year, day_week;
            int annee, jour_sem;
            bool quit = false;
            do
            {
                string cote = "\t║  ", aftermonth = "╚══════════════════════════════╝";
                int jour_mois = 0;                                              // Nombre de jours dans le mois (calculé plus bas)
                string sem = $"{cc.under}Lu{cc.end}  {cc.under}Ma{cc.end}  {cc.under}Me{cc.end}  {cc.under}Je{cc.end}  {cc.under}Ve{cc.end}  {cc.under}Sa{cc.end}  {cc.under}Di{cc.end}";

                Console.WriteLine($"{cc.under}Saisissez l'année dont vous voulez voir le calendrier :{cc.end}");

                #region Saisie_année
                do
                {
                    saisie = Console.ReadLine();
                    try
                    {
                        year = Convert.ToUInt32(saisie);                        // Test de conversion de en UInt
                    } catch
                    {
                        Console.Clear();
                        Console.WriteLine($"{cc.badVal} Veillez à ce que l'année sois {cc.red}entière et positive{cc.end}.");
                        BEX5();
                    }
                    //annee = Convert.ToInt32(year);                            // Variable non déclaré dans la boucles
                    annee = Convert.ToInt32(saisie);                            // Conversion réussie dans le try donc je l'assigne ici

                    if (annee == 0)                                             // Si l'utilisateur saisi 0 je le renvoi au menu
                    {
                        quit = true;                                            // Cette valeur sers à savoir si la boucle doit ne pas continuer /*/
                        Retour();
                        MenuB();
                    }
                    else if (annee < 1583)
                    {
                        Console.Clear();
                        Console.WriteLine($"{cc.warnFlag} Le calendrier Grégorien ne commence qu'en 1583, veuillez réessayer"); // Message d'erreur et d'avertissement
                        BEX5();
                    }
                } while (annee < 1583);
                #endregion Saisie_année
                #region Saisie_jour
                do
                {
                    Console.WriteLine($"{cc.under}Indiquez par quel jours l'année commence :{cc.end} (1 : Lundi, 2 : Mardi, 3 : Mercredi, 4 : Jeudi, 5 : Vendredi, 6 : Samedi, 7 : Dimanche)");
                    saisie = Console.ReadLine();

                    try
                    {
                        day_week = Convert.ToUInt32(saisie);
                    } catch
                    {
                        Console.WriteLine($"{cc.badVal} Vous devez saisir un entier compris entre 1 et 7 inclus pour sélectionner un jour ou utiliser 0 pour quitter");
                    }
                    jour_sem = Convert.ToInt32(saisie);

                    if (jour_sem == 0)
                    {
                        quit = true;
                        Retour();
                        MenuB();

                    }
                } while (jour_sem >= 6 && jour_sem <= 0);
                #endregion Saisie_jour
                /*int origLarg = Console.WindowWidth;
                int origHaut = Console.WindowHeight;
                int larg = origLarg - 90; // 120 => 30
                int haut = origHaut + 98;  // 32 => 130

                Console.SetBufferSize(larg, haut);                              // Je voulais changer la taille de lma fenêtre mais c'est plus compliqué que prévu quand le programme est déjà en cours
                Console.SetWindowSize(larg, haut);*/

                Console.Clear();
                Console.WriteLine(@$"╔══════════════════════════════════════════════════╗
║   ____      _                _      _            ║
║  / ___|__ _| | ___ _ __   __| |_ __(_) ___ _ __  ║
║ | |   / _` | |/ _ \ '_ \ / _` | '__| |/ _ \ '__| ║
║ | |__| (_| | |  __/ | | | (_| | |  | |  __/ |    ║
║  \____\__,_|_|\___|_| |_|\__,_|_|  |_|\___|_|    ║
╚══════════════════╦════════╦══════════════════════╝
                   │  {annee}  │
                   └────────┘");

                bool bis = Bissextile(annee);
                int num_mois = 0, num_carac = 0, num_jour = 1;
                string[] titre_mois = { " Janvier  ", " Février  ", "   Mars   ", "  Avril   ", "   Mai    ", "   Juin   ", " Juillet  ", "   Août   ", "Septembre ", " Novembre ", " Décembre " };

                for (int i = 1; i != 12; i++)
                {
                    Console.WriteLine($"\n\n\t╔═════════┤{cc.cyan}{titre_mois[num_mois]}{cc.end}├═════════╗");
                    // Cette ligne me sers a définir la ligne ou sera affiché le titre et va m'être utile pour moduler mon affichage
                    Console.WriteLine($"{cote}{sem}  ║");                       // Affichage de la ligne de des jours de la semaine

                    if (num_mois == 0 || num_mois == 2 || num_mois == 4 || num_mois == 6 || num_mois == 7 || num_mois == 9 || num_mois == 11)     // Mois de 31 jours (-1 a chaques mois car le tableau commence à 0 
                        jour_mois = 31;                                         // Jours par mois : 31 // Le nombre de jours dans les mois concernés

                    else if (num_mois == 3 || num_mois == 5 || num_mois == 8 || num_mois == 10)
                        jour_mois = 30;                                         // Jours par mois : 30

                    else if (num_mois == 1)                                     // Le cas de Février
                        if (bis == true)
                            jour_mois = 29;
                        else
                            jour_mois = 28;

                    Console.Write(cote);                                        // J'éloigne du bord la zone ou je vais écrire
                    num_carac = 0;                                              // Je remet le compteur de caractère à 0 pour pouvoir recommencer à les compter et mettre les retours à ligne ou il faut

                    // Affiche les points avant le début du mois dans la semaine concerné
                    if (jour_sem == 8)                                          // Si le 31 est un dimanche pas besoin de points puisque le 1 sera un lundi
                    {

                    } else
                    {
                        for (int j = 1; j != jour_sem; j++)
                        {
                            Console.Write(" .  ");                              // .Write pour ne pas retourner à la ligne
                            num_carac += 1;                                     // Je compte les caractères pour tout agencer correctement 
                        }
                    }

                    // Écriture des numéro du mois
                    for (num_jour = 1; num_jour <= jour_mois; num_jour++)
                    {
                        if (num_carac >= 7)                                     // Une fois 7 caractère inscrit, la ligne est complète
                        {
                            Console.Write($"║\n{cote}");
                            num_carac = 0;
                        }
                        if (num_jour < 10)
                        {
                            Console.Write($" {num_jour}  ");                    // Les chiffres ne font qu'un caractère donc je leurs met un espace en plus
                            num_carac += 1;
                        } else if (num_jour > 10 && num_jour <= jour_mois)
                        {
                            Console.Write($"{num_jour}  ");
                            num_carac += 1;

                            // Dans ce if je complète les espaces vides après le 31 par des '.'
                            if (num_jour == jour_mois)
                            {
                                switch (num_carac) {
                                    case 0:
                                        for (int k = 0; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 1:
                                        for (int k = 1; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 2:
                                        for (int k = 2; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 3:
                                        for (int k = 3; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 4:
                                        for (int k = 4; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 5:
                                        for (int k = 5; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                    case 6:
                                        for (int k = 6; k <= 6; k++)
                                        {
                                            Console.Write(" .  ");
                                        }
                                        break;
                                        /*case 7:
                                            for (int k = 7; k <= 6; k++)
                                            {
                                                Console.Write(" .  ");
                                            }
                                            break;*/
                                }
                                Console.Write($"║\n\t{aftermonth}");
                            }
                        }
                        jour_sem = num_carac + 1;                               // Grâce à ça je peux réaligner les jours avec les numéros (si le 31 Janvier est un vendredi, le 1 Février s'affiche sous Mardi
                    }

                    num_mois++; // J'incrémente le numéro du mois pour passer au suivant
                }
                Console.WriteLine("");
                Retour();
            } while (quit != true);

            Retour();
            MenuB();
        }
        #endregion Partie_B

        #region Partie_C
        #region ncodedcode
        /*static void Ncode()
        {
            int? choixN;
            Console.WriteLine($@"╔══════════════════════════════╗
    ║  _   _               _       ║
    ║ | \ | | ___ ___   __| | ___  ║
    ║ |  \| |/ __/ _ \ / _` |/ _ \ ║
    ║ | |\  | (_| (_) | (_| |  __/ ║
    ║ |_| \_|\___\___/ \__,_|\___| ║
    ║         ┌────────────────────┴──┐
    ╚═════════┤ Encodage Binaire Hexa │             
    ┌─────────┴───────────────────────┴────────────────────────┐
    │{cc.retourZero}│
    └──────────────────────────────────────────────────────────┘");

            Console.WriteLine("╔═══╦══════════════════════╗");
            Console.WriteLine("║ 1 ║ Algorithme de Gauss  ║");
            Console.WriteLine("╠═══╬══════════════════════╣");
            Console.WriteLine("║ 2 ║ Algorithme de Meeus  ║");
            Console.WriteLine("╠═══╬══════════════════════╣");
            Console.WriteLine("║ 3 ║ Algorithme de Conway ║");
            Console.WriteLine("╚═══╩══════════════════════╝");
        }
        static void Dcode()
        {

        }*/
        #endregion ncodedcode

        static void Calculator()
        {
            string saisie;
            string[] calcul;
            int quit;

            Console.WriteLine($@"{cc.red}╔═════════════════════════════════════════════════╗{cc.end}                     ╔═════════════════════════╗{cc.end}
{cc.red}║{cc.end}   ____      _            _       _              {cc.red}║{cc.end}                     ║ ┌─────────────────────┐ ║{cc.end}
{cc.red}║{cc.end}  / ___|__ _| | ___ _   _| | __ _| |_ ___  _ __  {cc.red}║{cc.end}                     ║ │             -8 * 24 │ ║
{cc.red}║{cc.end} | |   / _` | |/ __| | | | |/ _` | __/ _ \| '__| {cc.red}║{cc.end}                     ║ │ =              -192 │ ║
{cc.red}║{cc.end} | |__| (_| | | (__| |_| | | (_| | || (_) | |    {cc.red}║{cc.end}                     ║ └─────────────────────┘ ║
{cc.red}║{cc.end}  \____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|    {cc.red}║{cc.end}                     ║ ┌─────┬─────┬─────┬───┐ ║
{cc.red}╠═════════════════════════════════════════════════╩───────┐{cc.end}             ║ │  7  │  8  │  9  │ @ │ ║
{cc.red}│{cc.end} (Utilisez {cc.cyan}00{cc.end} pour quitter et revenir au menu principal) {cc.red}│{cc.end}             ║ ├─────┼─────┼─────┼───┤ ║ 
{cc.red}└─────────────────────────────────────────────────────────┘{cc.end}           * ║ │  4  │  5  │  6  │ * │ ║  °
                                                                   * °  ▓░▒─────▒─────▒─────▒───▒░▓  *  *
                                                                    *   ▓░▒░░▒░░▒░░▒░░▒░░▒░░▒░▒░▒░▓ °  * *");
            do
            {

                Console.WriteLine($"{cc.under}Saisissez ci dessous votre calcul :{cc.end} (sous la forme a +|-|*|/ b)");
                saisie = Console.ReadLine();

                try
                {
                    quit = Convert.ToInt32(saisie);                                         // Je vérifie dans ce try catch si l'utilisateur veut quitter ou non
                    if (quit == 00 || saisie  == "00")
                    {
                        Retour();
                        Main();
                        break;
                    } 

                } catch
                {
                    if (saisie == "00")
                    {
                        Retour();
                        Main();
                        break;
                    }
                }

                calcul = saisie.Split(' ');
                //taille = calcul.Length;

                int operateur = Operateur(ref saisie, new char[] { '+', '-', '*', '/' });   // Je défini les opérateurs autrisés par mon module

                if (operateur != -1)
                    Calculator(ref saisie, ref operateur);
                else
                    Console.WriteLine($"{cc.warnFlag} Attention il faut rentrer trois termes comme ceci : a +|-|*|/ b");

                static int Operateur(ref string saisie, char[] O)                               // Ce module servira à trouver les opérateurs dans la chaîne de caractères
                {
                    int i = 0;

                    foreach (char carac in saisie)                                              // Pour chaque caractère dans ma string saisie je vais chercher mes opérateurs
                    {
                        int j = carac.ToString().IndexOfAny(O);                                 // O représente la recherche de { '+', '-', '*', '/' }

                        if (j == 0 && i > 0)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    return i;
                }

                static void Calculator(ref string saisie, ref int oeprateur)
                {
                    float resultat = 0f;
                    string[] cal = new string[3];

                    cal[0] = saisie.Substring(0, oeprateur);
                    cal[1] = saisie[oeprateur].ToString();
                    cal[2] = saisie.Substring(oeprateur + 1);

                    float nombre1;
                    if (float.TryParse(cal[0], out nombre1) == false)                       // Je tente la conversion avec TryParse qui renvoie true ou false
                    {
                        Console.WriteLine($"{cc.warnFlag} Attention le premier membre doit être {cc.red}uniquement{cc.end} en nombre entier !");
                        return;                                                             // Je return directement pour éviter au programe de crash
                    }

                    float nombre2;
                    if (float.TryParse(cal[2], out nombre2) == false)
                    {
                        Console.WriteLine($"{cc.warnFlag} Attention le second membre doit être {cc.red}uniquement{cc.end} en nombre entier !");
                        return;
                    }

                    switch (cal[1])
                    {
                        case "+":
                            resultat = nombre1 + nombre2;
                            break;

                        case "-":
                            resultat = nombre1 - nombre2;
                            break;

                        case "*":
                            resultat = nombre1 * nombre2;
                            break;

                        case "/":
                            if (nombre2 == 0)                                               // On prévoit les cas impossible
                            {
                                Console.WriteLine($"{nombre1} / {nombre2} = Impossible de diviser par 0 !");
                                Retour();
                                MenuC();
                            }
                            else
                                resultat = nombre1 / nombre2;
                            break;
                    }

                    Console.WriteLine($"{nombre1} {cal[1]} {nombre2} = {cc.cyan}{resultat}{cc.end}\n");
                }

            } while (saisie != "00");
            
            
        }
        #endregion Partie_C
    
    }
}
