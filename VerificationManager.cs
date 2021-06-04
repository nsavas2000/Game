using MinoGame.Abstrack;
using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.FirstName == "Ali")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
