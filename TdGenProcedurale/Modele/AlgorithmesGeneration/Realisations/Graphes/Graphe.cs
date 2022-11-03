using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.Cartes;

namespace TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations.Graphes
{
    public class Graphe
    {
        private Dictionary<Coordonnees,Sommet> sommets = new Dictionary<Coordonnees, Sommet>();
        public Graphe()
        {
            for (int x = 0; x < Carte.Taille; x++)
            {
                for (int y = 0; y < Carte.Taille; y++)
                {
                    Sommet s = new Sommet();
                    sommets.Add(new Coordonnees(x,y),s);
                }
            }


            for (int x = 0; x < Carte.Taille - 1; x++)
            {
                for (int y = 0; y < Carte.Taille; y++)
                {
                    sommets[new Coordonnees(x, y)].AjouterVoisin(sommets[new Coordonnees(x + 1, y)]);
                    sommets[new Coordonnees(x + 1, y)].AjouterVoisin(sommets[new Coordonnees(x, y)]);
                }
            }

            for (int x = 0; x < Carte.Taille; x++)
            {
                for (int y = 0; y < Carte.Taille - 1; y++)
                {
                    sommets[new Coordonnees(x, y)].AjouterVoisin(sommets[new Coordonnees(x, y + 1)]);
                    sommets[new Coordonnees(x, y + 1)].AjouterVoisin(sommets[new Coordonnees(x, y)]);
                }
            }
        }

        public Sommet GetSommet(int ligne, int colonne)
        {
            Sommet sommet= null;

            if (sommets.ContainsKey(new Coordonnees(ligne, colonne)))
            {
                sommet = sommets[new Coordonnees(ligne, colonne)];
            }

            return sommet;
        }

        public Carte ToCarte()
        {
            Carte carte = new Carte();  
            
            foreach (Coordonnees c in sommets.Keys)
            {
                carte.AjouterSalle(c.Ligne, c.Colonne, GetSommet(c.Ligne,c.Colonne).TypeSalle);
            }
            return carte;
        }


        public List<Sommet> Parcours(Sommet depart, Sommet arrivee)
        {

        }

    }
}
