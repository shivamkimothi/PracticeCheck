using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Models
{
    public class Medicine
    {
        public int Mid { get; set; }
        public string Mname { get; set; }
        //public DateTime ExpiryDate { get; set; }
        public int Price { get; set; }
        public int QuantityRemaining { get; set; }
    }
}
