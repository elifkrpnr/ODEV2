namespace odev_2.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. sayı giriniz");
            Byte baslangic = byte.Parse(Console.ReadLine());
            Console.WriteLine("2. sayı giriniz");
            Byte maksimum = byte.Parse(Console.ReadLine());
            Console.WriteLine("Sayıların m");
            Byte adet = byte.Parse(Console.ReadLine());
            int[] sayilar = new int[baslangic];
            Random rnd = new Random();
            int tutulan;
            for (int i = 1; i < adet; i++)
            {
                tutulan = rnd.Next(baslangic, maksimum);
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[j] == tutulan)
                    {
                        i--;
                        break;

                    }
                    else
                    {
                        sayilar[i] = tutulan;
                    }
                }

            }
            for (int i = 1; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}