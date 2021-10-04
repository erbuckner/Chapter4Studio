using System;
namespace Chapter4Studio
{
    public class MenuItem
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }
        private bool IsNew { get; set; }


        public MenuItem( string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }
}
