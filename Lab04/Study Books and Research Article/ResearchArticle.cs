using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_R_Books_System
{
    internal class ResearchArticle:Book
    {
        public string DOI;
        public string PubDate;
        public string Type;
        public string GetInfo()
        {
            return ID + "\t" + Title + "\t" + Author + "\t" + DOI +"\t" + Convert.ToString(Quantity)+"\t"+Type;
        }
    }
}
