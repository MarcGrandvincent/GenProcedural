using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TdGenProcedurale.Vue.Ecrans.Elements
{
    /// <summary>
    /// Bouton générer
    /// </summary>
    public class BoutonGenerer : Image
    {
        private BitmapImage notHover;       //Image quand le bouton est non recouvert
        private BitmapImage hover;          //Image quand le bouton est recouvert

        /// <summary>
        /// Constructeur
        /// </summary>
        public BoutonGenerer()
        {
            this.notHover = new BitmapImage(new Uri(@"../../Ressources/Generer.png", UriKind.Relative));
            this.hover = new BitmapImage(new Uri(@"../../Ressources/GenererHover.png", UriKind.Relative));
            this.Source = this.notHover;
            this.MouseEnter += BoutonGenerer_MouseEnter;
            this.MouseLeave += BoutonGenerer_MouseLeave;
        }

        // Survol de la souris
        private void BoutonGenerer_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Source = this.hover;
        }

        // Fin du survol
        private void BoutonGenerer_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Source = this.notHover;
        }
    }
}
