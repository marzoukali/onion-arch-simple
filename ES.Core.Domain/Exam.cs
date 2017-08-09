using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Core.Domain
{
    [Table("Exam")]
    public  class Exam
    {
        public Exam()
        {
            Question = new HashSet<Question>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }

}
