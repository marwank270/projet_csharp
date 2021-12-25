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

        public const string warnFlag = bgRed + "[ ! ]" + end;
        public const string wrongFlag = bgYellow + "[ ? ]" + end;
        public const string infoFlag = bgBlue + "[ i ]" + end;

        public const string closeConsole = infoFlag + " Au revoir et à bientôt !";
        public const string badVal = wrongFlag + " Il semble que vous n'avez pas saisis une valeur conforme.";

        /*
         Traduit depuis un fichier .js sue j'ai fais pour un projet personnel (https://pastebin.com/nLVM6aR6) 
         Je sais que C# embarque la fonction ConsoleColor mais elle fonctionne différement selon les version alors je préfère utiliser Les codes d'escape ANSI, de plus ca me fait un peu d'entraineent
         */
        #endregion ConsoleColor
    }
    class Program
    {
        static void Main()
        {  

            #region ASCII
            Console.WriteLine(@"     _                _ _           _   _               ____   ___ ____  _           ____   ___ ____  ____  
    / \   _ __  _ __ | (_) ___ __ _| |_(_) ___  _ __   |___ \ / _ \___ \/ |         |___ \ / _ \___ \|___ \ 
   / _ \ | '_ \| '_ \| | |/ __/ _` | __| |/ _ \| '_ \    __) | | | |__) | |  _____    __) | | | |__) | __) |
  / ___ \| |_) | |_) | | | (_| (_| | |_| | (_) | | | |  / __/| |_| / __/| | |_____|  / __/| |_| / __/ / __/ 
 /_/   \_\ .__/| .__/|_|_|\___\__,_|\__|_|\___/|_| |_| |_____|\___/_____|_|         |_____|\___/_____|_____|
         |_|   |_|                                                                                          
                  by Marwan Kaouachi                                                                        ");
            // @"" signifie que la string gardera la mise en forme d'origine

            #endregion ASCII
            #region Menu Principal
            int choix;
            do
            {
                Console.WriteLine($"\n1 : Partie A - Cette partie est un ensemble d'AEXercice faits pour s'amuser entre les calculs et le codage.\n2 : Partie B - Cette partie se concentre plus sur des AEXercice de travail de la logique du codage.\n3 : Partie C - Cette dernière partie est une partie innovation, a nous de jouer !\n\n0 : Quitter le programme.");

                Console.WriteLine("\nBienvenue dans mon programme, veuillez choisir une Partie a tester.");
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
            do
            {
                try
                {
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(cc.warnFlag + $" Attention la saisie doit être {cc.red}uniquement{cc.end} en nombre entier !");
                    choix = -22;
                }
            } while (choix < 0 || choix is int == false); // Si le choix n'est quand même pas un int la méthode recommence
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
        static bool VerifDate(int jour, int mois, int annee)
        {
            bool valide = true;

            if (jour < 1 || jour > 31 || mois < 1 || mois > 12 || annee < 0)
                valide = false;

            if (Bissextile(annee) == true && mois == 2 && jour > 28)
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
        #endregion Outils

        #region Menus
        static void MenuA()
        {
            int? choixA;

            //Console.Clear();
            Console.WriteLine(@"  __  __                       _    
 |  \/  | ___ _ __  _   _     / \   
 | |\/| |/ _ \ '_ \| | | |   / _ \  
 | |  | |  __/ | | | |_| |  / ___ \ 
 |_|  |_|\___|_| |_|\__,_| /_/   \_\
         by Marwan Kaouachi         ");
            Console.WriteLine($"\n{cc.infoFlag} Utilisez 0 pour revenir au menu précédent.");
            Console.WriteLine("\n1 : Vérifier si un nombre est Premier\n2 : Afficher la liste des nombres Premiers entre 2 bornes\n3 : Affiche le premier nombrPremier supérieur\n4 : Décomposer un nombre en produit de facteurs premiers\n5 : Palindrome ? Pas palindrome ! Palindrome ? Pas palindrome !\n6 : Affichage personnalisé");
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

        } // Penser à changer les cw pour mettre des info flag à part 
        static void MenuB()
        {
            int? choixB;

            //Console.Clear();
            Console.WriteLine(@"  __  __                    ____  
 |  \/  | ___ _ __  _   _  | __ ) 
 | |\/| |/ _ \ '_ \| | | | |  _ \ 
 | |  | |  __/ | | | |_| | | |_) |
 |_|  |_|\___|_| |_|\__,_| |____/ 
         by Marwan Kaouachi         ");
            Console.WriteLine($"\n{cc.infoFlag} Utilisez 0 pour revenir au menu précédent.");
            Console.WriteLine("\n1 : Calcul de la date du lendemain\n2 : Calcul du nombre de jours entre 2 dates\n3 : Vérifier si une date est bissextile\n4 : Calculer la date de pâques\n5 : Afficher le calendrier d'une année");
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

        }
        #endregion Menus

        #region Partie_A
        static void AEX1()
        {
            Console.WriteLine(@"
  _______  ___ 
 | ____\ \/ / |
 |  _|  \  /| |
 | |___ /  \| |
 |_____/_/\_\_|
        Vérifie si un nombre est Premier              
");
            Console.WriteLine($"{cc.infoFlag} (Utilisez 0 pour quitter et revenir au menu précédent)\n");
            Console.WriteLine("Saisissez un nombre pour vérifier si il est Premier ou non:");
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
            Console.WriteLine(@"
  _______  ______  
 | ____\ \/ /___ \ 
 |  _|  \  /  __) |
 | |___ /  \ / __/ 
 |_____/_/\_\_____|
       Affiche la liste des nombres Premiers                    
");
            Console.WriteLine($"{cc.infoFlag} (Utilisez 0 dans les deux saisies pour quitter et revenir au menu précédent)\n");
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
                
                Console.WriteLine($"Entre {cc.cyan}{mini}{cc.end} et {cc.cyan}{maxi}{cc.end} il y a {cc.cyan}{cpt}{cc.end} nombres Premiers.\nEn voici la liste : {cc.cyan}{liste.TrimEnd(' ',';')}{cc.end}.\n"); // liste.TrimEnd() retire des caractères un à un en partant de la fin de la chaine (ici il retire "; " de ma chaine liste
            } while (mini != 0 || maxi != 0);
            
            Retour();
            MenuA();
        }
        static void AEX3()
        {
            Console.WriteLine(@"  _______  _______ 
 | ____\ \/ /___ / 
 |  _|  \  /  |_ \ 
 | |___ /  \ ___) |
 |_____/_/\_\____/ 
       Affiche le nombre premier supérieur            ");
            Console.WriteLine($"{cc.infoFlag} (Utilisez 0 pour quitter et revenir au menu précédent)\n");

            int nombre;
            do
            {
                Console.WriteLine("\nSaisissez un nombre pour afficher le nombre Premier supérieur à celui-ci:");
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
            int nombre;
            int prem = 2;
            int cpt = 0;
            string ligne = "";
            bool s;

            Console.WriteLine(@"  _______  ___  _   
 | ____\ \/ / || |  
 |  _|  \  /| || |_ 
 | |___ /  \|__   _|
 |_____/_/\_\  |_|  
       Décompose en produit de facteurs premier             ");

            do
            {
                Console.WriteLine("Saisissez un nombre à décomposer en produit de facteurs premiers:");
                int n = nombre = DemandeNombre();
                int copy;

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
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  Non fini
                while (n > 1)
                {
                    while (n % prem == 0)
                    {
                        n /= prem;

                        Console.WriteLine("facteur trouvé "+ prem);
                        cpt++;

                        Console.WriteLine(cpt);
                    }
                    prem += 1;
                    //cpt = 1;

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
                    

                    /*do
                    {
                        s = Premier(prem + 1);
                        prem += 1;
                    } while (s != true);*/
                }

                Console.WriteLine($"Après décomposition : {cc.cyan}{nombre}{cc.end} = {cc.cyan}{ligne}{cc.end}");
            } while (nombre != 0);

            Retour();
            MenuA();
        }
        static void AEX5()
        {
            Console.WriteLine(@"  _______  ______  
 | ____\ \/ / ___| 
 |  _|  \  /|___ \ 
 | |___ /  \ ___) |
 |_____/_/\_\____/ 
       Palindrome ? Pas palindrome ?            ");

            Console.WriteLine($"\n0 : Revenir au menu précédent\n1 : Affichage des nombres palindromes inférieur à {cc.green}1000{cc.end}\n2 : Bonus, Affichage des nombres {cc.cyan}premiers{cc.end} palindromes inférieur à {cc.green}1000{cc.end}\n3 : {cc.infoFlag} Bonus v2, vérification si un nombre unique est palindrome ou non\n");

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
                    int n = DemandeNombre();

                    if (n.ToString().SequenceEqual(n.ToString().Reverse()))
                        Console.WriteLine($"{cc.cyan}{n}{cc.end} {cc.green}est bien{cc.end} un nombre palindrome");
                    else
                        Console.WriteLine($"{cc.cyan}{n}{cc.end} {cc.red}n'est pas{cc.end} un nombre palindrome");
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
            Console.WriteLine(@"  _______  ____   
 | ____\ \/ / /_  
 |  _|  \  / '_ \ 
 | |___ /  \ (_) |
 |_____/_/\_\___/ 
       Affichage personnalisé           ");

            Console.WriteLine("\n0 : Revenir au menu précédent\n1 : Carré plein\n2 : Rectangle Plein\n3 : Carré Creux\n4 : Rectangle Creux\n5 : Damier\n6 : Triangle\n7 : Triangle inversé");

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


                for (int j = 1; j != largeur + 1;  j++)
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

            Console.WriteLine(@"
  _______  ___ 
 | ____\ \/ / |
 |  _|  \  /| |
 | |___ /  \| |
 |_____/_/\_\_|
       Calcul la date du lendemain              
");
            Console.WriteLine($"\n{cc.infoFlag} Utilisez 0 pour revenir au menu précédent.");

            do
            {
                Console.WriteLine("\nSaisissez la date dont vous voulez connaître le lendemain : (Sous la forme jj mm aaa ou bien jj/mm/aaaa)");

                saisie = Console.ReadLine();
                datum = saisie.Split(' ' , '/');                                                          // Je met dans un tableau tous les éléments qui sont séparé par un espace dans la string saisie

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

                    #region Lendemain
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
                    #endregion Lendemain

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
            int n, jour, jour2, j, mois, mois2, m, annee, annee2, a, cpt = 0, nextlap = 1;
            bool newlap = false;

            Console.WriteLine(@"
  _______  ______  
 | ____\ \/ /___ \ 
 |  _|  \  /  __) |
 | |___ /  \ / __/ 
 |_____/_/\_\_____|
       Calcul du nombre de jours entre 2 dates                    
");
            Console.WriteLine($"\n{cc.infoFlag} Utilisez 0 pour revenir au menu précédent.");

            do
            {
                Console.WriteLine("\nSaisissez la première des deux dates dont vous voulez connaître l'écart : (Sous la forme jj mm aaa ou bien jj/mm/aaaa)");

                saisie = Console.ReadLine();
                datum = saisie.Split(' ', '/');

                try
                {
                    n = Convert.ToInt32(saisie);
                    if (n == 0 && saisie.Length <= 1)                                               // Si l'utilisateur ne saisis qu'un 0 il est renvoyé au menu
                        Retour(); Console.Clear(); MenuB();

                }
                catch { }

                jour = j = Convert.ToInt32(datum[0]); // Erreurs de saisie style 12m 05 2012 non géré ici, ca me ferais beaucoup trop changer le fonctionnement de mon code */*
                mois = m = Convert.ToInt32(datum[1]);
                annee = a = Convert.ToInt32(datum[2]);

                if (VerifDate(jour, mois, annee) == false)
                {
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    BEX2();
                }               // Date 1

                Console.WriteLine("\nSaisissez la deuxième date : (Sous la forme jj mm aaa ou bien jj/mm/aaaa)");

                saisie = Console.ReadLine();
                datum2 = saisie.Split(' ', '/');


                jour2 = Convert.ToInt32(datum2[0]); // */* ici aussi
                mois2 = Convert.ToInt32(datum2[1]);
                annee2 = Convert.ToInt32(datum2[2]);

                if (VerifDate(jour2, mois2, annee2) == false)
                {
                    Console.Clear();
                    Console.WriteLine(cc.badVal);
                    BEX2();
                }               // Date 2

                /*do
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
                    else if (jour == 31 && mois == 4 || mois == 6 || mois == 9 || mois == 12)   // Cas des mois à 30 jours
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
                } while (jour != jour2 && mois != mois2 && annee != annee2);*/

                DateTime date1 = new DateTime(annee, mois, jour);
                DateTime date2 = new DateTime(annee2, mois2, jour2);

                TimeSpan T = date2 - date1;

                Console.WriteLine($"Entre le {j}/{m}/{a} et le {jour2}/{mois2}/{annee2}, il y a exactement {cc.cyan}{/*cpt*/T.TotalDays - 1}{cc.end} jours.");
                Console.WriteLine("\nVoulez vous recommencer(1) ou quitter(0) ?");
                nextlap = Convert.ToInt32(Console.ReadLine());

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

        }
        static void BEX4()
        {

        }
        static void BEX5()
        {

        }
        #endregion Partie_B
    }
}
