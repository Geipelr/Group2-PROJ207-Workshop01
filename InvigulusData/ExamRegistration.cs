using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public class ExamRegistration
    {
        public int RegistrationID
        {
            get; set;
        }

        public String ExamName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string PhoneNum
        {
            get; set;
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
