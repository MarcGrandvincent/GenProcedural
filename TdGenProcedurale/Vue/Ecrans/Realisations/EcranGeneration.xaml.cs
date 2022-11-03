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
using TdGenProcedurale.Vue.Ecrans.Elements;
using TdGenProcedurale.VueModele;

namespace TdGenProcedurale.Vue.Ecrans.Realisations
{
    /// <summary>
    /// Ecran de génération de cartes
    /// </summary>
    public partial class EcranGeneration : Ecran
    {

        private VueModeleCarte vueModele;

        /// <summary>
        /// Constructeur
        /// </summary>
        public EcranGeneration()
        {
            this.vueModele = new VueModeleCarte();
            this.DataContext = this.vueModele;
            this.vueModele.PropertyChanged += VueModele_PropertyChanged;
            InitializeComponent();
        }

        /// <summary>
        /// Modification de la VueModele
        /// </summary>
        /// <param name="sender">La vueModele</param>
        /// <param name="e">La propriété ayant changée</param>
        private void VueModele_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Carte")
            {
                this.GridDeLaCarte.Children.Clear();
                this.GridDeLaCarte.Children.Add(new GridCarte(this.vueModele.Carte,this.vueModele));
            }
        }

        //Click sur le bouton générer
        private void BoutonGenerer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.vueModele.GenererLaCarte(this.TextSeed.Text);
        }
    }
}
