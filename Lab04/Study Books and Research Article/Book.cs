using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_R_Books_System
{
    internal class Book
    {
        public string ID;
        public string Title;
        public string Author;
        public string Publisher;
        public int Quantity;
        public void Borrow()
        {
            this.Quantity--;
        }
    }
    
}
