using System;

namespace SoftIto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte[] a;

            Console.Write("Kaç adet sayı? ");
            byte b = byte.Parse(Console.ReadLine());
            a = new byte[b];
            for (int i = 0; i < b; i++)
            {
                Console.Write((i + 1).ToString() + ". sayı? ");
                a[i] = byte.Parse(Console.ReadLine());
            }
            //Array.Sort(a)yasak
            Console.Write("Oluşturduğunuz dizi : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            int minValueIndex;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                minValueIndex = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                byte tempValue = a[i];
                a[i] = a[minValueIndex];
                a[minValueIndex] = tempValue;
            }
            Console.Write("\nSıralama yapıldıktan sonra dönüştürülen dizi : ");
            foreach (var item in a)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();

        }
    }
}
