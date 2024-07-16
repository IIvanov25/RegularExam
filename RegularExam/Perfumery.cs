using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    class Perfumery
    {
        private string name;
        private List<Perfume> perfumes;
        public string Name
        {
            get { return this.name; }
            set {
                if (value.Length < 1)
                {
                    //това е промяна на кода 
                    throw new ArgumentException($"Invalid perfumery name!");
                }
                this.name = value; }
        }
        public Perfumery(string name)
        {
            this.Name = name;
            this.perfumes = new List<Perfume>();
        }
        public override string ToString()
        {
            StringBuilder printPerfumeryInfo = new StringBuilder();

            if (this.perfumes.Count == 0)
            {
                return $"Perfumery {this.Name} has no available perfumes.";
            }

            printPerfumeryInfo.Append($"Perfumery {this.Name} has {this.perfumes.Count} perfume/s:");

            foreach (var perfume in perfumes)
            {
                printPerfumeryInfo.Append($"\nPerfume {perfume.Brand} costs {perfume.Price.ToString("0.00")}");
            }
            return printPerfumeryInfo.ToString();
        }
        public void AddPerfume(Perfume perfume)
        {
            this.perfumes.Add(perfume);
        }
        public bool SellPerfume(Perfume perfume)
        {
            Perfume perfume1 = perfumes.Where(x => x.Brand == perfume.Brand).First();
            return this.perfumes.Remove(perfume1);
        }
        public double CalculateTotalPrice()
        {
            return this.perfumes.Sum(x=>x.Price);
        }
        public void RenamePerfumery(string newName)
        {
            this.Name = newName;
        }
        public void SellAllPerfumes()
        {
            this.perfumes = new List<Perfume>();
        }
        public Perfume GetPerfumeWithHighestPrice()
        {
            return this.perfumes.OrderByDescending(x => x.Price).First();
        }
        public Perfume GetPerfumeWithLowestPrice()
        {
            return this.perfumes.OrderBy(x => x.Price).First();
        }
    }
}
