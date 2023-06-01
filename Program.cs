using System;

namespace TutoCAPG
{
    class Program
    {
        static void Main(string[] args )
        {

            #region intro 
            // quand on exécute .exe cela se ferme rapidement avec notre message donc on fait comme suit
            //int age = 30;
            // Console.WriteLine(age); // affiche 30
            //age = 20;
            //Console.WriteLine(age);
            //Console.ReadLine(); tu peux même ajouter un message disant appuyer sur une touche pour quitter la console
            // ou bien ça 
            //System.Threading.Thread.Sleep(10000);

            //pour le saut de ligne vaut mieux utilisé ça car le FrameWork
            //Console.WriteLine("son âge est " + age + Environment.NewLine + "ans" );
            #endregion

            #region LES CONDITIONS
            //decimal compteEnBanque = -1;
            //if (compteEnBanque >0)
            //// }
            //else
            //{
            //    //console.writeline("vous n'avez pas encore d'argent, devenez riche !");
            //    if (compteenbanque < 0)
            //        console.writeline("votre compte est débiteur");
            //}

            // on peut fair aussi par méthode bool
            //decimal compteEnBanque = 000;
            //bool estCrediteur = compteEnBanque > 0;
            //if(estCrediteur)
            //{
            //    Console.WriteLine("Votre est bien vrai créditeur");
            //}
            //else
            //{
            //    Console.WriteLine("Votre compte ne dispose pas d'assez d'argent, ça débite et ça me débecte !");
            //}

            //int age = 30;
            //bool estAgeDe30Ans = age == 30;
            //Console.WriteLine(estAgeDe30Ans); // affiche True
            //bool estSuperieurA10 = age > 10;
            //Console.WriteLine(estSuperieurA10); // affiche True
            //bool estDifferentDe30 = age != 30;
            //Console.WriteLine(estDifferentDe30); // affiche False

            //string login = "Abder";
            //string motDePasse = "Otop";
            //if (login == "Abder" && motDePasse == "OTop")
            //{
            //    Console.WriteLine("Bienvenu, vous êtes connecté Mr Abder");

            //}
            //else
            //{
            //    Console.WriteLine("Votre Login ou mot de passe est incorrecte, svp pensez à vérifier !");

            //}

            #endregion

            #region cas du switch

            //{
            //    string prenom = "Nicolas";
            //    string civilite = "M.";
            //    if (prenom == "Nicolas")
            //    {
            //        int age = 30;
            //        Console.WriteLine("Votre age est : " + age);
            //        switch (civilite)
            //        {
            //            case "M.":
            //                Console.WriteLine("Vous êtes un homme de " + age + " ans");
            //                break;
            //            case "Mme":
            //                Console.WriteLine("Vous êtes une femme de " + age +
            //                " ans");
            //                break;

            //        }
            //        if (age >= 18)
            //        {
            //            Console.WriteLine(prenom + ", vous êtes majeur");
            //        }
            //    }


            //}
            #endregion

            #region une méthode simplifie les appels du code
            //static void AffichageBienvenue()
            //{
            //    Console.WriteLine("Bonjour Nicolas");
            //    Console.WriteLine("-------" + Environment.NewLine);
            //    Console.WriteLine("\tBienvenue dans le monde merveilleux du C#");
            //}
            //au lieu de répéter static void AffichageBienvenueJeremie() et static void AffichageBienvenueNicolas() il est évident que le nom de l’utilisateur sera un paramètre de la méthode.
            //Les paramètres s’écrivent à l’intérieur des parenthèses qui suivent le nom de la méthode. Nous devons indiquer le type du
            //paramètre ainsi que le nom de la variable qui le représentera au sein de la méthode. 
            #endregion

            //AffichageBienvenue();
            //AffichageBienvenue();
            //AffichageBienvenue();

            //pour que ça marche je défini une valeur qui est égale à la méthode LongueurHypothenuse et qui prend 2 nombres
            //enfin je stocke le résultat de l'exécution de la méthode dans une autre variable 
            double valeur =LongueurHypothenuse(12, 19);
            Console.WriteLine("la 1ère valeur de l'hypothénuse est " + valeur);

            //double val = LongueurHypothenuse(32, 25);
            //Console.WriteLine("la 2ème valeur de l'hypo est " + val);
            // je peux également directement le faire sans passer par une variable intermédiaire cela fait économiser des lignes de codes
            //je passe directement ma méthode LongueurHypothenuse en paramètre de la méthode Console.WriteLine
            Console.WriteLine("la 2ème valeur de l'hypo est " + LongueurHypothenuse(32, 25));

            #region exercice simple calcul de l'hypothénuse 
            static double LongueurHypothenuse (double a, double b)
            {
                double sommeDesCarres = a * a + b * b; //On aurait également pu faire Math.Pow(a, 2) et pareil pour b
                double result = Math.Sqrt(sommeDesCarres);
                return result; //le mot clé return peut apparaitre à n’importe quel endroit de la méthode
            }


            #endregion

            #region type de conjugaison vu précédement 
            // todo après avoir corrigé et optimisé le code du genre mettre ici le code de la sln genrePro
            // NB : noter que "" correspond à une chaine vide et peut également s’écrire : string.Empty. cette dernière est plus Pro
            // car elle est directement dans le framework .NET

            #endregion

            #region Résumé des notions de code
            // une méthode regoupe un ensemle d'instruction pouvant prendre des paramètres (dans nos fameuses parenthèses) et pouvant renvoyer une valeur 
            // les paramètres d'une méthode doivent être utilisés dans le bon type (exp string etc) 
            // une méthode qui ne renvoie rien (comme valeur etc) est préfixé avec le mot clé void (vide en anglais)
            // le point d'entrée d'un programme et ou en mode console est la méthode statique Main ()
            //le mot clé return permet de renvoyer une valeur du type de retour de la méthode. 
            #endregion

            #region let's go pour les tableaux, listes et énumérations 
            //Nous allons découvrir ici d'autres types qui vont s'avérer très utiles dans la construction de nos applications informatiques.

            // 1) les tableaux : pour info en programmation (tous) souvent une tableau est représenté par les crochets []

            // exemple avec les jours de la semaine
            string [] jours = new string [] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            //donc ici mon tableau contient 7 valeurs 
            // il faut toujours déclarer un tableau en nommant le tableau ici j'aurais pu mettre femmes à la place de jours laule ;)
            // le mot new veut dire qu'on crée notre nouvelle liste à partir de la déclaration
            // les [] disent au compilateur que nous utilisons un tableau de type string. 
            #endregion
        }

    }
}
