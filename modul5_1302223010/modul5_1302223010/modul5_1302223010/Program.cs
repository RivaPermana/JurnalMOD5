// See https://aka.ms/new-console-template for more information

using System.Numerics;

public class Penjumlahan
{
    //class 
     static void JumlahTigaAngka<T>(T msk1, T msk2, T msk3)
    {
        dynamic T1 = msk1;
        dynamic T2 = msk2;
        dynamic T3 = msk3;

        long hasil = T1 + T2 + T3;
        Console.WriteLine("hasil: " + hasil);
    }
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Masukkan: ");
        long t1 = int.Parse(Console.ReadLine());
        long t2 = int.Parse(Console.ReadLine());
        long t3 = int.Parse(Console.ReadLine());
        JumlahTigaAngka<long>(t1, t2, t3);
        
    }
}

