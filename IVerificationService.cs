using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Abstrack
{
    public interface IVerificationService
    {
        bool Validate(Customer customer);
    }
}

