using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public class Exam {

        public int ExamID {
            get; set;
        }

        public int Administrator {
            get; set;
        }

        public string ExamName {
            get; set;
        }

        public int? Duration {
            get; set;
        }

        public string ExamURL {
            get; set;
        }

        public int? PermittedAttempts{
            get; set;
        }

    }
}
