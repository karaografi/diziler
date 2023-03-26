internal class Program
{
    private static void Main(string[] args)
    {
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

        int[] dizi;
        dizi = new int[5];


        dizi[3] = 10;

        //Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngüler ile Dizi Kullanımı
        //Klaveyeden Girilen N tane Sayının ortalamasını hesaplayan program

        Console.WriteLine("Lütfen Dizinin Eleman Sayısını Giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.WriteLine("Lütfen {0}. sayısını giriniz: ", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
            toplam += sayi;

        Console.WriteLine("Sayı Ortalaması: "+ toplam/diziUzunlugu);
        
    }
}