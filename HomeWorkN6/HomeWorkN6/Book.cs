﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN6
{
    public class Book
    {
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;

        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

    }
}

