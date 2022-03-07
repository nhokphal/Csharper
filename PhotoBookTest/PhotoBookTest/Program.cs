using System;

namespace PhotoBookTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook myAlbum = new PhotoBook(); 
            int x = myAlbum.getNumber();
            Console.WriteLine($"First photo book is {x}"); // output 16


            PhotoBook myAlbum2 = new PhotoBook(23); /// if not input value, automatically run 16 
            int y = myAlbum2.getNumber();
            Console.WriteLine($"Second photo book is {y}");


            SuperPhotoBook myBigAlbum = new SuperPhotoBook();
            int s = myBigAlbum.getNumber();
            Console.WriteLine($"Super Photo Book is {s}"); // out 45


        }
    }
}
