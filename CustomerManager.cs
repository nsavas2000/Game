using MinoGame.Abstrack;
using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Concrete
{
    public class CustomerManager : ICustomerService

       
    {

        IVerificationService _verificationService;

        public CustomerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        public void Add(Customer customer)
        {
            if (_verificationService.Validate(customer))
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
