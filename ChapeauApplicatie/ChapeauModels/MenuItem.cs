using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;

namespace ChapeauModels
{
    public class MenuItem
    {
        public int menuItemID { get; set; }
        public string ?Category { get; set; }
        public string description  { get; set; }
        public double price { get; set; }
        public bool alcohol { get; set; }
        public int menuID { get; set; }
        public int stock { get; set; }
    }
}
