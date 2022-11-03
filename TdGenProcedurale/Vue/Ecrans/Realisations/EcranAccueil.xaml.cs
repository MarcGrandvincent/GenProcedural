using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TdGenProcedurale.Vue.Ecrans.Realisations
{
    /// <summary>
    /// Ecran d'acceil
    /// </summary>
    public partial class EcranAccueil : Ecran
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public EcranAccueil()
        {
            InitializeComponent();
        }

        //Clic de la souris => Chargement de l'écran de génération
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.ChargerEcran(TypeEcran.GENERATION);
        }
    }
}
