using System;

namespace easygrammm
{
    class Extra
    {
        private static Random rastgele = new Random();

        public static string RandomYazi(int max,bool yazi,bool sayi)
        {
            string yaziText = "";
            
            for (int i = 0; i < max; i++)
            {
                if (yazi)
                {
                    yaziText += (char)rastgele.Next('a', 'z');
                }

                if (sayi)
                {
                    yaziText += rastgele.Next(0, 9);
                }
                
            }

            return yaziText;

        }

        public static string TekrarDuzenle(string gelenYazi, int max, bool yazi, bool sayi)
        {
            var yenilenenText = gelenYazi.Replace("[r]", RandomYazi(max,yazi,sayi));

            return yenilenenText;
        }

    }
}
