using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Models
{
    public interface IMedicineService
    {
        public List<Medicine> GetMedicine();
        public Medicine GetMedicine(int id);
        
    }
}
