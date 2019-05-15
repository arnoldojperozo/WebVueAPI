using System.Collections.Generic;
using WebVueModel;

namespace WebVueService.Interfaces
{
    public interface IStudentService
    {
        bool Add(Student model);

        bool Update(Student model);

        bool Delete(int id);

        IEnumerable<Student> GetAll();

        Student Get(int id);
    }
}
