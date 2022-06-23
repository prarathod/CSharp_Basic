using ConsoleApp9.Contexts;
using ConsoleApp9.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Services
{
    public class StudentService : IStudentContract
    {
        public void Add(Student student)
        {
            using(var context = new SchoolContext())
            {
                context.Student.Add(student);
                context.SaveChanges();
            }
        }

        public void Delete(int studentID)
        {
            using(var context = new SchoolContext())
            {
              var student = context.Student.Where(c=>c.ID == studentID).FirstOrDefault();
                context.Student.Remove(student);
                context.SaveChanges();
            }
        }

        public List<Student> GetAllStudent()
        {
            var context = new SchoolContext();
            List<Student> students = context.Student.Include(c=>c.StudentAddress).AsNoTracking().ToList();
            return students;

        }

        public List<Student> GetAllStudentByName(string name)
        {
            var context = new SchoolContext();
            List<Student> students = context.Student.Where(c=>c.Name.Equals(name)).ToList();
            return students;
        }

        public Student GetStudent(int id)
        {
            var context = new SchoolContext();
            Student student = context.Student.Where(c=> c.ID ==id).FirstOrDefault();
            return student;
        }

        public void Update(Student student)
        {
            using (var context = new SchoolContext())
            {
                var studentObj = context.Student.Where(c => c.ID == student.ID).FirstOrDefault();
                studentObj.Name = student.Name;
                context.SaveChanges();
            }
        }
    }
}
