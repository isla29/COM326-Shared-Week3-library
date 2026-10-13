using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        //private fields
        private string _title;
        private string _author;
        private string _ISBN;

        //public properties
        public string Title
        {
            get { return _title; }
            set
            {
                {
                    if (!value.Any(char.IsDigit) && value != "")
                    {
                        _title = value;
                    }
                    else
                    {
                        Console.WriteLine("Error: Book title cannot be blank or contain numbers.");
                    }
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                {
                    if (!value.Any(char.IsDigit) && value != "")
                    {
                        _author = value;
                    }
                    else
                    {
                        Console.WriteLine("Error: Book author cannot be blank or contain numbers.");
                    }
                }
            }
        }

        public string ISBN
        {
            get { return _ISBN; }
            set
            {
                { }
                    if (!value.Any(char.IsDigit) && value != "")
                    {
                        _ISBN = value;
                    }
                    else
                    {
                        Console.WriteLine("Error: ISBN must be 8 digits long and contain only numbers.");
                    }
                }
            }
        

        //constructor
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
