using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice.Models
{
    internal class Book : Product
    {
        public string genre;

        public Book(string genre, string name, int No, double price) : base(name, No, price)
        {
            this.genre = genre;

        }

        public void GetInfo()
        {
            Console.WriteLine($" Nomresi: {No} - Kitabin adi: {name}  - Janri: {genre} -  Sayi: {count} - Qiymeti: {price}");
        }
    }
}