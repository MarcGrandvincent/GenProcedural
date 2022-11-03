using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations.Graphes;
using TdGenProcedurale.Modele.Cartes;


namespace TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations
{
    public class AlgorithmeCarteVide : IAlgorithmeGeneration
    {
        public Carte Generer(string seed)
        {
            Graphe g = new Graphe();
            return g.ToCarte();
        }
    }
}
