using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    class Perfume
    {
        private string brand;
        private double price;
        private List<Perfume> perfumes;
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public double Price
        {
            get { return this.price; }
            set {
                if (value > 100)
                {
                    throw new ArgumentException($"Invalid perfume price!");
                }
                this.price = value; }
        }
        public Perfume (string brand, double price)
        {
            this.Brand = brand;
            this.Price = price;
        }
        public void AddPerfume(Perfume perfume) {
            this.perfumes.Add(perfume);
        }
        public override string ToString()
        {
            StringBuilder printPerfumeInfo = new StringBuilder();
            foreach (var perfume in perfumes)
            {
                printPerfumeInfo.Append($"Perfume {this.Brand} costs {this.Price}");
            }
            return printPerfumeInfo.ToString();
        }
    }
}
