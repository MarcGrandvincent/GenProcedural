using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdGenProcedurale.Modele.Cartes.Salles.Realisations
{
    /// <summary>
    /// Salle normale
    /// </summary>
    public class SalleNormale : Salle
    {
        public SalleNormale(int ligne, int colonne) : base(ligne, colonne)
        {
        }

        public override void Generation()
        {
            //Génération fixe que l'on modifiera plus tard
            base.Generation();
            this.NbMonstre = 2;
            this.NbItems = 1;
        }

        public override TypeSalle Type => TypeSalle.NORMALE;
    }
}
