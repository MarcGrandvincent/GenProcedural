using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Vue.Ecrans.Realisations;

namespace TdGenProcedurale.Vue.Ecrans
{
    /// <summary>
    /// Fabrique des écrans
    /// </summary>
    public static class FabriqueEcran
    {
        /// <summary>
        /// Création d'un écran
        /// </summary>
        /// <param name="type">Type de l'écran voulu</param>
        /// <returns>Le nouvel écran</returns>
        public static Ecran Creer(TypeEcran type)
        {
            Ecran ecran = null;
            switch (type)
            {
                case TypeEcran.ACCUEIL: ecran = new EcranAccueil(); break;
                case TypeEcran.GENERATION: ecran = new EcranGeneration(); break;
            }
            return ecran;
        }
    }
}
