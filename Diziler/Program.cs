namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlaması 
            string[] renkler = new string[5];
            string[] hayvalar = {"kedi", "köpek", "kuş"};
            int[] dizi;
            dizi = new int[5];
            //dizileri değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvalar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            //döngülerle dizi kullanımı 
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program.
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz: ", i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
                
            }
            Console.WriteLine("ortalama:" + toplam/diziuzunlugu);

           

        }
    }
    
}

