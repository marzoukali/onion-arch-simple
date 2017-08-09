using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Core.Domain
{
    [Table("Question")]
    public  class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Body { get; set; }

        public int? ExamId { get; set; }

        public virtual Exam Exam { get; set; }
    }

}
