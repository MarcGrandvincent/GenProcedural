using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TdGenProcedurale.Modele.Cartes.Salles;

namespace TdGenProcedurale.Vue.Ecrans.Elements
{
    /// <summary>
    /// Image d'une salle
    /// </summary>
    public class ImageSalle : Image
    {
        //Modèle
        private Salle salle;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="salle">Modèle</param>
        public ImageSalle(Salle salle) 
        {
            this.salle = salle;
            Grid.SetColumn(this, salle.Colonne);
            Grid.SetRow(this, salle.Ligne);
            Grid.SetColumnSpan(this, salle.Largeur);
            Grid.SetRowSpan(this, salle.Hauteur);
            this.Source = ImageManagerSalle.GetImage(salle.Type);
        }

        public void GenerationToolTip()
        {
            if (!salle.EstVide)
            {
                this.ToolTip = "Monstres : " + salle.NbMonstre + "\nItems : " + salle.NbItems;
            }
        }
    }
}
