using MinoGame.Concrete;
using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Abstrack
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

    }
}
