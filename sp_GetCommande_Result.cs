//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin_MRLoca
{
    using System;
    
    public partial class sp_GetCommande_Result
    {
        public int IdReservation { get; set; }
        public int IdClient { get; set; }
        public int IdHebergement { get; set; }
        public System.DateTime DateReservation { get; set; }
        public System.DateTime DateDebut { get; set; }
        public System.DateTime DateFin { get; set; }
        public Nullable<bool> Statut { get; set; }
        public string PrixTotal { get; set; }
        public Nullable<int> ModePaiement { get; set; }
        public int IdHebergement1 { get; set; }
        public string Nom { get; set; }
        public string Photo { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdAdresse { get; set; }
        public int IdClient1 { get; set; }
        public Nullable<bool> Etat { get; set; }
        public int idTypeLgt { get; set; }
        public string NomLgt { get; set; }
    }
}
