using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using TdGenProcedurale.Modele.Cartes.Salles;

namespace TdGenProcedurale.Vue.Ecrans.Elements
{
    //Classe permettant de gérer les images des différents type de salles
    public static class ImageManagerSalle
    {
        private static Dictionary<TypeSalle, BitmapImage> images = new Dictionary<TypeSalle, BitmapImage>()
        {
            {TypeSalle.START, new BitmapImage(new Uri(@"../../Ressources/SalleSTART.png", UriKind.Relative)) },
            {TypeSalle.BOSS, new BitmapImage(new Uri(@"../../Ressources/SalleBOSS.png", UriKind.Relative)) },
            {TypeSalle.ITEM, new BitmapImage(new Uri(@"../../Ressources/SalleITEM.png", UriKind.Relative)) },
            {TypeSalle.NORMALE, new BitmapImage(new Uri(@"../../Ressources/SalleNORMALE.png", UriKind.Relative)) },
            {TypeSalle.VIDE, new BitmapImage(new Uri(@"../../Ressources/SalleVIDE.png", UriKind.Relative)) },
            {TypeSalle.GRANDECARRE, new BitmapImage(new Uri(@"../../Ressources/SalleGrandCARRE.png", UriKind.Relative)) },
            {TypeSalle.GRANDLONG, new BitmapImage(new Uri(@"../../Ressources/SalleGrandLONG.png", UriKind.Relative)) },
            {TypeSalle.GRANDHAUT, new BitmapImage(new Uri(@"../../Ressources/SalleGrandHAUT.png", UriKind.Relative)) },
            {TypeSalle.GRANDL1, new BitmapImage(new Uri(@"../../Ressources/SalleGrandL1.png", UriKind.Relative)) },
            {TypeSalle.GRANDL2, new BitmapImage(new Uri(@"../../Ressources/SalleGrandL2.png", UriKind.Relative)) },
            {TypeSalle.GRANDL3, new BitmapImage(new Uri(@"../../Ressources/SalleGrandL3.png", UriKind.Relative)) },
            {TypeSalle.GRANDL4, new BitmapImage(new Uri(@"../../Ressources/SalleGrandL4.png", UriKind.Relative)) }
        };

        /// <summary>
        /// Renvoie l'image de la salle demandée
        /// </summary>
        /// <param name="typeSalle">Type de la salle demandée</param>
        /// <returns>L'image de la salle demandée</returns>
        public static BitmapImage GetImage(TypeSalle typeSalle)
        {
            return images[typeSalle];
        }
    }
}
