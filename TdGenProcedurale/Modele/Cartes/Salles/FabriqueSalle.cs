using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.Cartes.Salles.Realisations;

namespace TdGenProcedurale.Modele.Cartes.Salles
{
    /// <summary>
    /// Fabrique des salles
    /// </summary>
    public static class FabriqueSalle
    {
        /// <summary>
        /// Créé une nouvelle salle en fonction de son type
        /// </summary>
        /// <param name="type">Type de la salle désirée</param>
        /// <param name="ligne">Ligne où se trouve la salle désirée</param>
        /// <param name="colonne">Colonne où se trouve la salle désirée</param>
        /// <returns>Nouvelle salle</returns>
        public static Salle Creer(TypeSalle type, int ligne, int colonne)
        {
            Salle salle = null;
            switch (type)
            {
                case TypeSalle.NORMALE: salle = new SalleNormale(ligne,colonne); break;
                case TypeSalle.BOSS: salle = new SalleBoss(ligne, colonne); break;
                case TypeSalle.ITEM: salle = new SalleItem(ligne, colonne); break;
                case TypeSalle.START: salle = new SalleStart(ligne, colonne); break;
                case TypeSalle.VIDE: salle = new SalleVide(ligne, colonne); break;
                case TypeSalle.GRANDECARRE: salle = new SalleGrandeCarre(ligne, colonne); break;
                case TypeSalle.GRANDLONG: salle = new SalleGrandeLong(ligne, colonne); break;
                case TypeSalle.GRANDHAUT: salle = new SalleGrandeHaut(ligne, colonne); break;
                case TypeSalle.GRANDL1: salle = new SalleGrandeL1(ligne, colonne); break;
                case TypeSalle.GRANDL2: salle = new SalleGrandeL2(ligne, colonne); break;
                case TypeSalle.GRANDL3: salle = new SalleGrandeL3(ligne, colonne); break;
                case TypeSalle.GRANDL4: salle = new SalleGrandeL4(ligne, colonne); break;
            }
            return salle;
        }
    }
}
