using System;
using System.Collections;
namespace arrayList
{
    class Program
    {
        static void Main (string[]args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');
            //içerisindeki verilere erişim  
            //Console.WriteLine(liste[1]);
            foreach (var item in liste)
                Console.WriteLine(item);
            
            //Add Range
            Console.WriteLine("**** Add Range ****");
            //string[] renkler= {"Kırmızı", "Mavi","Sarı","Lacivert"};
            List<int>sayıları =new List<int>(){1,13,44,53,21};
            //liste.AddRange(renkler);
            liste.AddRange(sayıları);

            foreach (var item in liste)
            Console.WriteLine(item);
            
            // Sort
            Console.WriteLine("**** Sort ******");
            liste.Sort();
            foreach (var item in liste)
            Console.WriteLine(item);

            // Binary Search (Girilen sayı, sıralanmış dizide kaçıncı sırada yer alıyor onu gösterir.)
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(2));

            //Reverse (Listeyi tersinden sıralar.)
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach (var item in liste)
            Console.WriteLine(item);

            //Clear
            Console.WriteLine("**** Clear ****");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);




        }
    }
}