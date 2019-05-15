using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebVueDAL;
using WebVueModel;
using WebVueService.Interfaces;

namespace WebVueService
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public bool Add(Student model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Student model)
        {
            try
            {
                var originalModel = _context.Students.Single(x => x.StudentId == model.StudentId);

                originalModel.Name = model.Name;
                originalModel.LastName = model.LastName;
                originalModel.Bio = model.Bio;

                _context.Update(model);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _context.Entry(new Student { StudentId = id }).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Student> GetAll()
        {
            
            var result = new List<Student>();

            try
            {
                result = _context.Students.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Student Get(int id)
        {
            var result = new Student();

            try
            {
                result = _context.Students.SingleOrDefault(x => x.StudentId == id);
            }
            catch
            {
                
            }

            return result;
        }
    }
}
