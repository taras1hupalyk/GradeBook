using GradeBook.Data.Entities;
using GradeBook.Data.Repositories.Intefaces;

using System.Linq;

using System.Threading.Tasks;

namespace GradeBook.Data.Repositories
{
    public class AssignmentRepository : RepositoryBase<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<Assignment> GetAssignmentByNameAsync(string name)
        {
            var result = dbContext.Assignments.Where(item => item.Name == name).FirstOrDefault();
            return result;
        }
    }
}
