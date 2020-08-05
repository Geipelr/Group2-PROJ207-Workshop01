using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public class ExamAdministrator {

        public int AdministratorID {
            get; set;
        }

        public int UserID {
            get; set;
        }

        public string LastName {
            get; set;
        }

        public string FirstName {
            get; set;
        }

        public string Email {
            get; set;
        }

        public string InstitutionName {
            get; set;
        }

        public string FullName {
            get {
                return FirstName + " " + LastName; 
            }  
        }
    }
}
