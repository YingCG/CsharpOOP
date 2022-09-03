using System;
using System.Drawing;

namespace WindowsFormsSandwichStore
{
    public class Product
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public Image ProductImage { get; set; }
        
        public Decimal Price { get; set; }
    }
}