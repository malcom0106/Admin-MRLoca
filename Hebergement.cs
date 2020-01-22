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
    using System.Collections.Generic;
    
    public partial class Hebergement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hebergement()
        {
            this.Avis = new HashSet<Avi>();
            this.DispoHebergs = new HashSet<DispoHeberg>();
            this.Favoris = new HashSet<Favori>();
            this.Reservations = new HashSet<Reservation>();
            this.Saisons = new HashSet<Saison>();
        }
    
        public int IdHebergement { get; set; }
        public string Nom { get; set; }
        public string Photo { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdAdresse { get; set; }
        public int IdClient { get; set; }
        public Nullable<bool> Etat { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avi> Avis { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispoHeberg> DispoHebergs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favori> Favoris { get; set; }
        public virtual TypeLgt TypeLgt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saison> Saisons { get; set; }
    }
}