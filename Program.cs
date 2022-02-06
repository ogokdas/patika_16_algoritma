using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace patika_16_algoritma
{
    public class Algoritma
    {
        static void Main(string[] args)
        {
            
            #region 1. soru
            Console.WriteLine("Lütfen 1 sayı girin: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                int[] dizi = new int[sayi1];
                Console.WriteLine("{0} adet sayı girin: ",sayi1);
                for (int i = 0; i < sayi1; i++)
                {
                    
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Girdiğiniz saylardan çift olanlar: ");
                for (int i = 0; i < sayi1; i++)
                {
                    if (dizi[i] % 2 == 0)
                    {
                        Console.Write(dizi[i] + "\t");
                    }
                }

            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            #endregion

            #region 2. soru
            Console.WriteLine("\nLütfen 2 sayi girin: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sayi3 = Convert.ToInt32(Console.ReadLine());
                int[] dizi2 = new int[sayi2];
                 Console.WriteLine("{0} adet sayı girin: ", sayi2);
                    for (int i = 0; i < sayi2; i++)
            {

                dizi2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz {0} adet sayıdan {1} ile tam bölünenler:", sayi2,sayi3);
            for (int i = 0; i < sayi2; i++)
            {
                if (dizi2[i] % sayi3 == 0)
                {
                    Console.Write(dizi2[i] + "\t");
                }
            }
            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            #endregion

            #region 3. soru

            Console.WriteLine("\nLütfen 1 sayı girin: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            string[] dizi3 = new string[sayi4];
            Console.WriteLine("{0} adet kelime girin: ", sayi4);
            for (int i = 0; i < sayi4; i++)
            {

                dizi3[i] = Console.ReadLine();
            }
            Console.WriteLine("Girdiğiniz kelimeler tersten sıra ile: ");
            for (int i = sayi4-1; i >=0; i--)
            {

                    Console.Write(dizi3[i] + "\t");
                
            }

            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            #endregion

            #region 4. soru

            Console.WriteLine("Lütfen bir cümle yazın: ");
            string cumle = Console.ReadLine();
            char[] c = new char[cumle.Length];
            c = cumle.ToCharArray();
            int toplamkelime = 0;
            foreach (var item in c)
            {
                if (item == ' ') { toplamkelime++; }
            }

            int toplamharf = cumle.Length - toplamkelime;

            Console.WriteLine("{0} adet kelime ve {1} adet harf bulunmaktadır", toplamkelime+1,toplamharf);

            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            #endregion

        }
    }

}