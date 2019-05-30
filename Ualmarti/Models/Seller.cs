using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ualmarti.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        internal static void Add(Seller seller)
        {
            throw new NotImplementedException();
        }

        public void AddSales(SalesRecord sr) {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr) {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initialDate, DateTime finalDate)
        {

            var listFiltered = Sales.Where(sr => sr.Date >= initialDate && sr.Date <= finalDate);
            double result = listFiltered.Sum(sr => sr.Amount);

            return result;
        }

    }
}
