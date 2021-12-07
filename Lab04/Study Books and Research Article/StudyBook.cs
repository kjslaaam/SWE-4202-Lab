using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_R_Books_System
{
    internal class StudyBook:Book
    {
        public string ISBN;
        public string Genre;
        public string GetInfo()
        {
            return ID + "\t" + Title + "\t" + Author + "\t" + ISBN + "\t"+  Convert.ToString(Quantity);
        }
    }
}
