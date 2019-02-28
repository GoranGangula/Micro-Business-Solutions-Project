using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOffice
{
    public class Task
    {
        public int TaskId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public int SpendTime { get; set; }
        public string Description { get; set; }

        public int UnderCaseId { get; set; }
        public int LawyerId { get{return UnderCase.Case.Client.LawyerId ;}}
        public string LawyerName{get{return UnderCase.Case.Client.Lawyer.Name + " " + UnderCase.Case.Client.Lawyer.Surname; }}
        public string UnderCaseName { get { return UnderCase.Name; } }

        public virtual UnderCase UnderCase { get; set; }
    }
}
