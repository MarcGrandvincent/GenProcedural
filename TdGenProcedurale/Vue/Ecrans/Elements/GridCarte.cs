using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TdGenProcedurale.Modele.Cartes;
using TdGenProcedurale.VueModele;

namespace TdGenProcedurale.Vue.Ecrans.Elements
{
    /// <summary>
    /// GridPanel d'affichage d'une carte avec une bordure
    /// </summary>
    public class GridCarte : Grid
    {
        // Carte à afficher
        private Carte carte;
        // VueModele
        private VueModeleCarte vueModele;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="carte">Carte à afficher</param>
        public GridCarte(Carte carte, VueModeleCarte vueModele)
        {

            this.vueModele = vueModele;

            //Bordure
            Border bordure = new Border();
            bordure.BorderThickness = new Thickness(10);
            bordure.BorderBrush = Brushes.Black;
            this.Children.Add(bordure);
            //GridPanel interne
            Grid innerGrid = new Grid();
            bordure.Child = innerGrid;
            //Données
            this.carte = carte;
            //Binding de la largeur pour qu'elle s'adapte à la hauteur
            Binding bindingLargeur = new Binding("ActualHeight");
            bindingLargeur.Source = this;
            this.SetBinding(Grid.WidthProperty, bindingLargeur);

            //Création des lignes et colonnes de la grille
            for (int i=0;i<Carte.Taille;i++)
            {
                innerGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                innerGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            }
            //Ajout des salles
            for(int ligne=0; ligne < Carte.Taille; ligne++)
            {
                for(int colonne=0; colonne < Carte.Taille; colonne++)
                {
                    if (carte.Salles[ligne,colonne].Ligne == ligne && carte.Salles[ligne, colonne].Colonne == colonne)
                    {
                        ImageSalle imageSalle = new ImageSalle(carte.Salles[ligne, colonne]);
                        innerGrid.Children.Add(imageSalle);
                        imageSalle.GenerationToolTip();
                        int curLigne = ligne;
                        int curColonne = colonne;
                        imageSalle.MouseDown += (e, s) => this.vueModele.GenererLaSalle(carte.Salles[curLigne, curColonne]);
                        this.vueModele.PropertyChanged += (s, e) =>
                        {
                            if(e.PropertyName == "SALLE " + curLigne + " " + curColonne)
                            {
                                imageSalle.GenerationToolTip();
                            }
                        };
                    }
                }
            }
        }
    }
}
