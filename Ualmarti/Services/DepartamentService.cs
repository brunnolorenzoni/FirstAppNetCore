using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ualmarti.Models;

namespace Ualmarti.Services
{
    public class DepartamentService
    {

        private readonly UalmartiContext _context;

        public DepartamentService(UalmartiContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {

            var DepartamentList = _context.Departament.OrderBy(register => register.Name).ToList();

            return DepartamentList;

        }

    }
}
