using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    public class Gracz
    {
        public string Nazwa;
        public int[,] Plansza;
        public bool[,] OdkrytePola;
        public int[] Flota;
        public int LiczbaStatkowDoZatopienia;

        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;

        public Gracz()
        {
            Flota = new int[] { 1, 2, 3, 4 };
            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            LiczbaStatkowDoZatopienia = Flota.Length;


            for (int i = 0; i < ROZMIAR_PLANSZY; i++)
            {
                for (int j = 0; j < ROZMIAR_PLANSZY; j++)
                {
                    Plansza[i, j] = -1;
                }
            }
        }

    }
}
