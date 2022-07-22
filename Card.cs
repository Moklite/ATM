using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {
        public int Pin { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int Balance { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
