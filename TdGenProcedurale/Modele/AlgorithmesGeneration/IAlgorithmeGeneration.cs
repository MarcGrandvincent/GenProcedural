using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.Cartes;

namespace TdGenProcedurale.Modele.AlgorithmesGeneration
{
    public interface IAlgorithmeGeneration
    {
        /// <summary>
        /// Génère une carte aléatoire à partir de la seed donnée
        /// </summary>
        /// <param name="seed">Seed de la carte</param>
        /// <returns>La carte générée</returns>
        Carte Generer(String seed);
    }
}
