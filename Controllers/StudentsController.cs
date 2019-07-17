using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KestraTest2.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        List<Student> students = new List<Student> {
            new Student {
                Name = "Anna Taylor",
                LanguageArtsGrade = 90,
                ScienceGrade = 85,
                SocialStudiesGrade = 86,
                MathsGrade = 89
            },
            new Student {
                Name = "Mark Smith",
                LanguageArtsGrade = 82,
                ScienceGrade = 75,
                SocialStudiesGrade = 89,
                MathsGrade = 86
            },
            new Student {
                Name = "John Doe",
                LanguageArtsGrade = 89,
                ScienceGrade = 76,
                SocialStudiesGrade = 94,
                MathsGrade = 82
            },
            new Student {
                Name = "Jack Jones",
                LanguageArtsGrade = 93,
                ScienceGrade = 73,
                SocialStudiesGrade = 97,
                MathsGrade = 90
            }
        };

        [HttpGet("[action]")]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int LanguageArtsGrade { get; set; }
        public int ScienceGrade { get; set; }
        public int SocialStudiesGrade { get; set; }
        public int MathsGrade { get; set; }
    }
}