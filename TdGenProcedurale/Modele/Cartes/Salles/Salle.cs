using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdGenProcedurale.Modele.Cartes.Salles
{
    /// <summary>
    /// Classe abstraite représentant une salle de la carte
    /// </summary>
    public abstract class Salle
    {
        //Numéro de ligne où se trouve la salle
        public int Ligne { get => ligne; set => ligne = value; }
        private int ligne;

        //Numéro de colonne où se trouve la salle
        public int Colonne { get => colonne; set => colonne = value; }
        private int colonne;

        /// <summary>
        /// Largeur de la salle
        /// </summary>
        public virtual int Largeur => 1;

        /// <summary>
        /// Hauteur de la salle
        /// </summary>
        public virtual int Hauteur => 1;

        /// <summary>
        /// Nombre de monstre dans la salle
        /// </summary>
        public int NbMonstre { get => nbMonstres; set => nbMonstres = value; }
        private int nbMonstres;

        /// <summary>
        /// Nombre d'items dans la salle
        /// </summary>
        public int NbItems { get => nbItems; set => nbItems = value; }
        private int nbItems;

        protected Salle(int ligne, int colonne)
        {
            this.ligne = ligne;
            this.colonne = colonne;
            this.nbItems = 0;
            this.nbMonstres = 0;
        }

        public abstract TypeSalle Type { get; }

        /// <summary>
        /// Génération de l'intérieur de la salle (de base il ne se passe rien)
        /// </summary>
        public virtual void Generation()
        {

        }

        /// <summary>
        /// La salle est-elle toujours vide de monstres
        /// </summary>
        public virtual bool EstVide => false;
    }
}
