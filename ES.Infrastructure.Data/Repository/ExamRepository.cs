using ES.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.Core.Domain;
using ES.Infrastructure.Data.DAL;

namespace ES.Infrastructure.Data.Repository
{
    public class ExamRepository : IExamRepository
    {
        ApplicationDbContext _appContext;

        public ExamRepository(ApplicationDbContext appContext)
        {
            _appContext = appContext;

        }
        public Exam GetExamById(int id)
        {
            return _appContext.Exam.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
