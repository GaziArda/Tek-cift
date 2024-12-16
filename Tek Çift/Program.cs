namespace Tek_Çift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {                 Console.WriteLine("Tek mi çift mi?\n1.Tek\n2.Çift");
                byte tekcift = byte.Parse(Console.ReadLine());

                switch (tekcift)
                {
                    case 1:
                        Console.WriteLine("Başlangıç değeri giriniz");
                        int bas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Bitiş değeri giriniz");
                        int bit = int.Parse(Console.ReadLine());
                        int toplam = 0;

                        // Eğer başlangıç değeri bitiş değerinden büyükse, yer değiştir
                        if (bas > bit)
                        {
                            int temp = bit;
                            bit = bas;
                            bas = temp;
                        }

                        // Döngüyle tek sayıları topla
                        for (int i = bas; i <= bit; i++) // <= bit yaparak bit değeri de dahil ettik
                        {
                            if (i % 2 == 1) // Tek sayılar
                            {
                                Console.WriteLine($"{i}.Sayı");
                                toplam += i;
                            }
                        }
                        Console.WriteLine($"Toplam: {toplam}");
                        break;

                    case 2:
                        Console.WriteLine("Başlangıç değeri giriniz");
                        int bas1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Bitiş değeri giriniz");
                        int bit1 = int.Parse(Console.ReadLine());
                        int toplam1 = 0;

                        // Eğer başlangıç değeri bitiş değerinden büyükse, yer değiştir
                        if (bas1 > bit1)
                        {
                            int temp1 = bit1;
                            bit1 = bas1;
                            bas1 = temp1;
                        }

                        // Döngüyle çift sayıları topla
                        for (int i = bas1; i <= bit1; i++) // <= bit1 yaparak bit1 değeri de dahil ettik
                        {
                            if (i % 2 == 0) // Çift sayılar
                            {
                                Console.WriteLine($"{i}.Sayı");
                                toplam1 += i;
                            }
                        }
                        Console.WriteLine($"Toplam: {toplam1}");
                        break;

                    default:
                        Console.WriteLine("Yanlış tuşlama yaptınız");
                        break;
                }
            }
        }
    }

}
    