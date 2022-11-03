using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.AlgorithmesGeneration;
using TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations;
using TdGenProcedurale.Modele.Cartes;
using TdGenProcedurale.Modele.Cartes.Salles;

namespace TdGenProcedurale.VueModele
{
    /// <summary>
    /// Vue modèle de l'écran de génération de carte
    /// </summary>
    public class VueModeleCarte : INotifyPropertyChanged
    {
        //Carte
        private Carte carte;
        /// <summary>
        /// Carte à afficher
        /// </summary>
        public Carte Carte
        {
            get => carte;
            set
            {
                this.carte = value;
                this.NotifyPropertyChanged("Carte");
            }
        }


        /// <summary>
        /// Lance la génération de la carte
        /// </summary>
        /// <param name="seed">Seed de la carte pour la génération</param>
        public void GenererLaCarte(string seed)
        {
            IAlgorithmeGeneration algorithme = new AlgorithmeEliminationSimple();
            this.Carte = algorithme.Generer(seed);
        }

        /// <summary>
        /// Lance la génération de la salle
        /// </summary>
        /// <param name="salle">La salle à générer</param>
        public void GenererLaSalle(Salle salle)
        {
            salle.Generation();
            this.NotifyPropertyChanged("SALLE "+salle.Ligne+" "+salle.Colonne);
        }

        #region --- Pattern d'observation ---
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
