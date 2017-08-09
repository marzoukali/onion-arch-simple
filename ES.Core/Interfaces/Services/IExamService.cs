using ES.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Core.Interfaces.Services
{
    public interface IExamService
    {
        Exam GetExamById(int id);

    }
}
