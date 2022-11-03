using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdGenProcedurale.Modele.Cartes.Salles.Realisations
{
    public class SalleGrandeHaut : Salle
    {
        public override int Hauteur => 2;
        public SalleGrandeHaut(int ligne, int colonne) : base(ligne, colonne)
        {
        }

        public override TypeSalle Type => TypeSalle.GRANDHAUT;
    }
}
