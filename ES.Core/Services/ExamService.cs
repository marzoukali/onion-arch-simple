using ES.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.Core.Domain;
using ES.Core.Interfaces.Repository;

namespace ES.Core.Services
{
    public class ExamService : IExamService
    {
        IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public Exam GetExamById(int id)
        {
           return _examRepository.GetExamById(id);
        }
    }
}
