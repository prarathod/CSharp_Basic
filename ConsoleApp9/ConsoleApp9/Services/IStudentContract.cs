using ConsoleApp9.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Services
{
    public interface IStudentContract
    {
        Student GetStudent(int id);
        List<Student> GetAllStudent();

        List<Student> GetAllStudentByName(string name);
        void Add(Student student);
        void Update(Student student);
        void Delete(int studentID);

    }
}
