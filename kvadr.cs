using System;

namespace VSkvadru
{
    public class Program
    {
        public float a;
        public float b;
        public float c;
        public float V;
        public float S;
        public static void Main(string[] args)
        {
            vstup();
            vypis();
        }
        public static void vstup()
        {
            Console.Write("Zadej stranu a v cm: ");
            string retezeca = Console.ReadLine();
            float a = float.Parse(retezeca);

            Console.Write("Zadej stranu b v cm: ");
            string retezecb = Console.ReadLine();
            float b = float.Parse(retezecb);

            Console.Write("Zadej stranu c v cm: ");
            string retezecc = Console.ReadLine();
            float c = float.Parse(retezecc);

            Console.WriteLine("Zadal jsi hodnoty: {0}, {1}, {2}", a, b, c);
            Console.ReadKey();
        }
        public void objem()
        {
            float V = a * b * c;
        }
        public void plocha()
        {
            float S = 2*(a*b + a*c + b*c);
        }
        public static void vypis()
        {
            Console.WriteLine("Objem je: {0}", V);
            Console.WriteLine("Plocha je: {0}", S);
            Console.ReadKey();
        }
    }
}
