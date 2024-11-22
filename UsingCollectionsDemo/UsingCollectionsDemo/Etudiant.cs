

namespace UsingCollectionsDemo
{
    class Etudiant
    {
        // Propriétés
        public string Nom { get; set; }
        public double NoteCC { get; set; } // Note de Contrôle Continu
        public double NoteDevoir { get; set; } // Note de Devoir

        // Méthode pour calculer la moyenne
        public double CalculerMoyenne()
        {
            return (NoteCC * 0.33) + (NoteDevoir * 0.67);
        }

        // Méthode pour afficher les informations de l'étudiant
        public void AfficherDetails()
        {
            Console.WriteLine($"Nom : {Nom}, Note CC : {NoteCC:F2}, Note Devoir : {NoteDevoir:F2}, Moyenne : {CalculerMoyenne():F2}");
        }
    }
}
