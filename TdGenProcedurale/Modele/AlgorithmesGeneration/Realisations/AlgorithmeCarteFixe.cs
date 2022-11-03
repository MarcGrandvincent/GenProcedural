using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.Cartes;
using TdGenProcedurale.Modele.Cartes.Salles;

namespace TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations
{
    /// <summary>
    /// Génère une carte fixe pour tester l'affichage
    /// </summary>
    public class AlgorithmeCarteFixe : IAlgorithmeGeneration
    {
        public Carte Generer(string seed)
        {
            Carte carte = new Carte();

            for(int i=0;i<Carte.Taille;i++)
            {
                for(int j=0;j<Carte.Taille;j++)
                {
                    carte.AjouterSalle(i, j, TypeSalle.VIDE);
                }
            }

            carte.AjouterSalle(5, 0, TypeSalle.BOSS);
            carte.AjouterSalle(5, 1, TypeSalle.NORMALE);
            carte.AjouterSalle(4, 1, TypeSalle.NORMALE);
            carte.AjouterSalle(4, 2, TypeSalle.NORMALE);
            carte.AjouterSalle(4, 3, TypeSalle.NORMALE);
            carte.AjouterSalle(5, 3, TypeSalle.GRANDECARRE);
            carte.AjouterSalle(7, 4, TypeSalle.ITEM);
            carte.AjouterSalle(5, 7, TypeSalle.NORMALE);
            carte.AjouterSalle(4, 5, TypeSalle.GRANDL2);
            carte.AjouterSalle(3, 5, TypeSalle.NORMALE);
            carte.AjouterSalle(3, 6, TypeSalle.NORMALE);
            carte.AjouterSalle(2, 5, TypeSalle.GRANDLONG);
            carte.AjouterSalle(1, 5, TypeSalle.NORMALE);
            carte.AjouterSalle(3, 7, TypeSalle.NORMALE);
            carte.AjouterSalle(3, 8, TypeSalle.NORMALE);
            carte.AjouterSalle(3, 9, TypeSalle.START);
            carte.AjouterSalle(4, 9, TypeSalle.NORMALE);
            return carte;
        }
    }
}
