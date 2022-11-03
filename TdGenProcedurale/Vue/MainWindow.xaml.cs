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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TdGenProcedurale.Vue.Ecrans;

namespace TdGenProcedurale.Vue
{
    /// <summary>
    /// Fenetre Principale (singleton)
    /// </summary>
    public partial class MainWindow : RatioWindow
    {
        #region --- DP Singleton ---
        /// <summary>
        /// Instance du singleton
        /// </summary>
        private static MainWindow? instance;
        private static MainWindow Instance => instance ?? (instance = new MainWindow());

        /// <summary>
        /// Constructeur privé du singleton
        /// </summary>
        private MainWindow() : base()
        {
            InitializeComponent();
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.75);
            this.Height = (this.Width*9)/16;
        }
        #endregion

        /// <summary>
        /// Change l'écran de la fenetre principale
        /// </summary>
        /// <param name="typeEcranVoulu">Type de l'écran voulu</param>
        public static void ChargerEcran(TypeEcran typeEcranVoulu)
        {
            Instance.MainGrid.Children.Clear();
            Instance.MainGrid.Children.Add(FabriqueEcran.Creer(typeEcranVoulu));
        }

        /// <summary>
        /// Affiche l'écran d'accueil
        /// </summary>
        public static void Afficher()
        {
            ChargerEcran(TypeEcran.ACCUEIL);
            Instance.Show();
        }
    }
}
