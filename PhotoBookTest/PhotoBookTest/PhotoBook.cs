using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookTest
{
    class PhotoBook
    {
        protected int numberPages; // init 

        public PhotoBook()
        {
            numberPages = 16;
        }
        public PhotoBook(int numberPages) // using parameter, means it will user will input data later
        {
            this.numberPages = numberPages; // user this coz we user parameter
        }
        public int getNumber()
        {
            return numberPages; // return whateve value from numberPage input
        }
    }
}
