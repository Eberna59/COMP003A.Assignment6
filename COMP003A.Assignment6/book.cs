using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class book
    {
        public string Title;

        public int Pages;

        public bool Completed;


        public book(string title, int pages, bool completed)
        {
            Title = title;
            Pages = pages;
            Completed = completed;
        }

        public void DisplayBook()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Pages: " + Pages);
            Console.WriteLine("Completed: " + Completed);
        }


    }
}
