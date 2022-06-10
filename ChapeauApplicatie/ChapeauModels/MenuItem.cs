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
        public int description  { get; set; }
        public int price { get; set; }
        public int alcohol { get; set; }
        public int menuID { get; set; }
        public int stock { get; set; }
    }
}
