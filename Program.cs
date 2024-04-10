using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_HuynhKimThang_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new EntityDBEntities1())
            {
                var select = from s in db.Student
                             join f in db.Faculty on s.FacultyId equals f.FacultyId
                             where (s.FacultyId == 1 && s.StudentAge >= 18 && s.StudentAge <=20)
                             select s;
                foreach (var item in select)
                {
                    Console.WriteLine($"Tên: {item.StudentName}, Tuổi: {item.StudentAge}, Giới tính: {item.StudentGender}, Khoa: {item.Faculty.FacultyName}");
                }
            }
            Console.ReadKey();
        }
    }
}
