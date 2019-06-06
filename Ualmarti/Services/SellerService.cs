using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ualmarti.Models;

namespace Ualmarti.Services
{
    public class SellerService
    {

        private readonly UalmartiContext _context;

        public SellerService(UalmartiContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() {

           var sellerList = _context.Seller.ToList();

            return sellerList;
        }


    }
}
