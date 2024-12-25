using FragrantWorld.DatabaseContext;
using FragrantWorld.Interface;
using FragrantWorld.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Services
{
    public class CustomerService : IClientService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }
        public List<Customer> GetAllClients()
        {
            return _context.Customers.ToList();
        }
    }
}
