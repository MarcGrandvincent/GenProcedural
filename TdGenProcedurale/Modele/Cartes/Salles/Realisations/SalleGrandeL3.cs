using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdGenProcedurale.Modele.Cartes.Salles.Realisations
{
    public class SalleGrandeL3 : Salle
    {
        public override int Hauteur => 2;
        public override int Largeur => 2;
        public SalleGrandeL3(int ligne, int colonne) : base(ligne, colonne)
        {
        }

        public override TypeSalle Type => TypeSalle.GRANDL3;
    }
}
