using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_3_Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }
        
        public Prgm_3_Book() 
        {
            Title = "Unknown";
            Auther = "Unknown";
            ISBN = "N/A";
        }

        
        public Prgm_3_Book(string title, string auther)
        {
            Title = title;
            Auther = auther;
            ISBN = "N/A";
        }
        public Prgm_3_Book(string title, string auther, string isbn)
        {
            Title = title;
            Auther = auther;
            ISBN = isbn;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Auther: {Auther}, ISBN: {ISBN}");
        }

    }
}
