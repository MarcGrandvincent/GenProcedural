using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations.Graphes;
using TdGenProcedurale.Modele.Cartes;

namespace TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations
{
    public class AlgorithmeEliminationSimple : IAlgorithmeGeneration
    {
        public Carte Generer(string seed)
        {
            Graphe g = new Graphe();
            GenerateurAleatoire.SetSeed(seed);

            List<Coordonnees> coordonnees = new List<Coordonnees>();


            while (coordonnees.Count < 3)
            {
                bool add = true;
                Coordonnees c = GenerateurAleatoire.NextCoordonnees();

                if (coordonnees.Count >= 1)
                {
                    for (int i = 0; i < coordonnees.Count; i++)
                    {
                        if (c.Ligne == coordonnees[i].Ligne && c.Colonne == coordonnees[i].Colonne)
                        {
                            add = false;
                        }

                        if (c.Distance(coordonnees[i]) < 3)
                        {
                            add = false;
                        }
                    }

                    if (add)
                    {
                        coordonnees.Add(c);
                    }
                }
                else
                {
                    coordonnees.Add(c);
                }

            }

            g.GetSommet(coordonnees[0].Ligne, coordonnees[0].Colonne).TypeSalle = Cartes.Salles.TypeSalle.BOSS;
            g.GetSommet(coordonnees[1].Ligne, coordonnees[1].Colonne).TypeSalle = Cartes.Salles.TypeSalle.ITEM;
            g.GetSommet(coordonnees[2].Ligne, coordonnees[2].Colonne).TypeSalle = Cartes.Salles.TypeSalle.START;


            for (int i = 0; i < 2; i++)
            {
                int startint = GenerateurAleatoire.Next(g.GetSommet(coordonnees[i].Ligne, coordonnees[i].Colonne).Voisins.Count);
                for (int j = 0; j < g.GetSommet(coordonnees[i].Ligne, coordonnees[i].Colonne).Voisins.Count; j++)
                {
                    if (j != startint)
                    {
                        g.GetSommet(coordonnees[i].Ligne, coordonnees[i].Colonne).Voisins[j].TypeSalle = Cartes.Salles.TypeSalle.VIDE;
                    }
                }
            }

            return g.ToCarte();
        }
    }
}
