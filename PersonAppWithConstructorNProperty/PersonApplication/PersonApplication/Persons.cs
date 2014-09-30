using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Persons
    {
        private string fName;
        private string mName;
        private string lName;

        public string FirstName
        {
            set { fName = value; }
            get { return fName; }
        }
        
        public string SecondName
        {
            set{ mName = value;}
            get{ return mName;}
        }
        public string LastName
        {
            set{ lName = value;}
            get{ return lName;}
        }
        public string getFullName()
        {
            return fName + "  " + mName + "  " + lName;
        }

        public Persons(string fName, string mName, string lName):this(fName, lName)
        {
            FirstName = fName;
            SecondName = mName;
            LastName = lName;
        }

        public Persons(string fName, string lName)
        {
            FirstName = fName;
            
            LastName = lName;
        }

        public string getReverseName()
        {
            string fullname = getFullName();
            char[] array = fullname.ToCharArray();
            string reverseName = "";
            for (int i = array.Length - 1; i > -1; i--)
            {
                reverseName += array[i];
                
            }
            return reverseName;

        }
        
    }
}
