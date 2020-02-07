using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClassExercise
{
    class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public Book() : this("N/A", "N/A", "N/A", "N/A", Category.Unknown, 0)
        {
            
        }

        public Book(string ISBN, string Title, string Author, string Publisher, Category Category, decimal Price)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Category = Category;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}{Environment.NewLine}Title: {Title}{Environment.NewLine}Author: {Author}{Environment.NewLine}Publisher: "
                + $"{Publisher}{Environment.NewLine}Category: {Category}{Environment.NewLine}Price: {Price} euro(s){Environment.NewLine}";
        }

    }
    
}
