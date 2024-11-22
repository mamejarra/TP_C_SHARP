namespace UsingCollectionsDemo
{
    internal class Program  {
        //    static void Main(string[] args)
        //    {
        //        SortedList lstEmployé = new SortedList();
        //        lstEmployé.Add("Raci" +
        //            "ne", new Employé { Nom = "Racine", 
        //            Age= 32 });
        //        Employé layssa = new Employé()
        //        {
        //            Nom = "layssa",
        //            Age = 25
        //        };
        //        lstEmployé.Add(layssa.Nom, layssa);
        //        Employé unEmployé = (Employé)lstEmployé["Racine"];

        //        if (unEmployé != null)
        //        {
        //            Console.WriteLine($"Nom: {unEmployé.Nom}, Age:" +
        //                $" {unEmployé.Age.ToString()}");
        //        }

        //        Console.ReadLine();

        //        foreach (DictionaryEntry employé in lstEmployé)
        //        {
        //            Employé autreEmployé = (Employé)employé.Value;
        //            Console.WriteLine($"Nom: {autreEmployé.Nom}, Age: {autreEmployé.Age.ToString()}");
        //        }
        //        Console.ReadLine();
        //    }
        //}


        static void Main()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            bool continuer = true;

            while (continuer)
            {
                Console.WriteLine("\nMenu :");
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Afficher les détails d'un étudiant");
                Console.WriteLine("3. Afficher les détails de tous les étudiants");
                Console.WriteLine("4. Quitter");
                Console.Write("Choisissez une option : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AjouterEtudiant(etudiants);
                        break;

                    case "2":
                        AfficherEtudiant(etudiants);
                        break;

                    case "3":
                        AfficherTousLesEtudiants(etudiants);
                        break;

                    case "4":
                        continuer = false;
                        break;

                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        // Méthode pour ajouter un étudiant
        static void AjouterEtudiant(List<Etudiant> etudiants)
        {
            Console.Write("Nom de l'étudiant : ");
            string nom = Console.ReadLine();

            Console.Write("Note de Contrôle Continu : ");
            double noteCC = LireDouble();

            Console.Write("Note de Devoir : ");
            double noteDevoir = LireDouble();

            Etudiant etudiant = new Etudiant
            {
                Nom = nom,
                NoteCC = noteCC,
                NoteDevoir = noteDevoir
            };

            etudiants.Add(etudiant);
            Console.WriteLine("Étudiant ajouté avec succès !");
        }

        // Méthode pour afficher les détails d'un étudiant
        static void AfficherEtudiant(List<Etudiant> etudiants)
        {
            if (etudiants.Count == 0)
            {
                Console.WriteLine("Aucun étudiant dans la liste.");
                return;
            }

            Console.Write("Entrez le nom de l'étudiant : ");
            string nom = Console.ReadLine();

            Etudiant etudiant = etudiants.Find(e => e.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));

            if (etudiant != null)
            {
                etudiant.AfficherDetails();
            }
            else
            {
                Console.WriteLine("Étudiant introuvable.");
            }
        }

        // Méthode pour afficher les détails de tous les étudiants
        static void AfficherTousLesEtudiants(List<Etudiant> etudiants)
        {
            if (etudiants.Count == 0)
            {
                Console.WriteLine("Aucun étudiant dans la liste.");
                return;
            }

            Console.WriteLine("\nListe des étudiants :");
            foreach (var etudiant in etudiants)
            {
                etudiant.AfficherDetails();
            }
        }

        // Méthode pour lire un double avec validation
        static double LireDouble()
        {
            double valeur;
            while (!double.TryParse(Console.ReadLine(), out valeur) || valeur < 0 || valeur > 20)
            {
                Console.WriteLine("Veuillez entrer une note valide (entre 0 et 20) : ");
            }
            return valeur;
        }
    }
}
