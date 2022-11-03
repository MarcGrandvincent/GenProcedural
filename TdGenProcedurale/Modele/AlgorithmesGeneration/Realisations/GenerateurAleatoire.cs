using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations.Graphes;
using TdGenProcedurale.Modele.Cartes;

namespace TdGenProcedurale.Modele.AlgorithmesGeneration.Realisations
{
    public class GenerateurAleatoire
    {
        private static GenerateurAleatoire instance = new GenerateurAleatoire();
        public static GenerateurAleatoire Instance { get => instance; set => instance = value; }

        private Random random;

        private int seedGlobale;

        private GenerateurAleatoire()
        {

        }


        public static void SetSeed(string seed)
        {
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(seed));
            Instance.seedGlobale = BitConverter.ToInt32(hashed, 0);
            Instance.random = new Random(Instance.seedGlobale);

        }


        public static int Next()
        {
            return Instance.random.Next();
        }

        public static int Next(int borneMax)
        {
            return Instance.random.Next(borneMax);
        }

        public static Coordonnees NextCoordonnees()
        {
            return new Coordonnees(Next(Carte.Taille), Next(Carte.Taille));
        }
    }
}
