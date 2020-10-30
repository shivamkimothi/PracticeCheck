using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Models
{
    public class MedicineService : IMedicineService
    {
        private List<Medicine> _medlist;

        public MedicineService()
        {
            _medlist = new List<Medicine>()
            {
                new Medicine(){ Mid= 1, Mname = "ParaCetaMol", Price = 34, QuantityRemaining = 45 },
                new Medicine(){ Mid= 2, Mname = "abcd", Price = 234, QuantityRemaining = 145 },
                new Medicine(){ Mid= 3, Mname = "qrst", Price = 434, QuantityRemaining = 465 },
                new Medicine(){ Mid= 4, Mname = "std", Price = 374, QuantityRemaining = 458 },
            };
        }
        public List<Medicine> GetMedicine()
        {
            return _medlist;
        }

        public Medicine GetMedicine(int id)
        {
            return _medlist.FirstOrDefault(e => e.Mid == id);
        }

        
    }
}
