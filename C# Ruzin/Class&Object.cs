using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Class_Object
    {
        private string ename;
        private int eid;
        public string Name
        {
            get { return ename; }
            set
            {
                ename = value;
            }
        }
        public int ID
        {
            get { return eid; }
            set
            {
                eid = value;
            }
        }
    }

}

