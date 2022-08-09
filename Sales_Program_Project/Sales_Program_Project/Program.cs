using System;

namespace Sales_Program_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamCiro = 0;
            int beyazEkmekAdet = 0, tamBugdayEkmekAdet = 0, tostEkmekAdet = 0;
            int beyazEkmekFiyat = 10, tamBugdayEkmekFiyat = 12, tostEkmekFiyat = 18;
            while (true)
            {
                Console.WriteLine("1-Beyaz Ekmek-10 lira");
                Console.WriteLine("2-Tam Buğday Ekmek-12 lira");
                Console.WriteLine("3-Tost Ekmeği-18 lira");
                Console.WriteLine("4-Toplam Ciro");
                Console.WriteLine("5-Çıkış");
                int deger;
                Console.Write("Hangi işlemi yapmak istiyorsunuz :");
                deger = Convert.ToInt32(Console.ReadLine());
                if (deger == 1)
                {
                    Console.WriteLine("--Beyaz Ekmek--");
                    Console.Write("Kaç tane almak istersin :");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    beyazEkmekAdet += adet;
                    toplamCiro += adet * beyazEkmekFiyat;
                    Console.WriteLine();
                }
                else if (deger == 2)
                {
                    Console.WriteLine("--Tam Buğday Ekmek--");
                    Console.Write("Kaç tane almak istersin :");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    tamBugdayEkmekAdet += adet;
                    toplamCiro += adet * tamBugdayEkmekFiyat;
                    Console.WriteLine();
                }
                else if (deger == 3)
                {
                    Console.WriteLine("--Tost Ekmek--");
                    Console.Write("Kaç tane almak istersin :");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    tostEkmekAdet += adet;
                    toplamCiro += adet * tostEkmekFiyat;
                    Console.WriteLine();
                }
                else if (deger == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Toplam Satış");
                    Console.WriteLine("Beyaz Ekmek :" + beyazEkmekAdet);
                    Console.WriteLine("Tam Buğday Ekmek :" + tamBugdayEkmekAdet);
                    Console.WriteLine("Tost Ekmek :" + tostEkmekAdet);
                    Console.WriteLine("Toplam Ciro :" + toplamCiro);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (deger == 5)
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hatalı Seçim! Lütfen Tekrar deneyin... Enter'e basarak devam edebilirsiniz :)");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
