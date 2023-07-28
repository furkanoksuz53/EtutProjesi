using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etut.DataAccess.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public string Class { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

    }
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BranchId { get; set; }

    }
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string Name { get; set; }

    }
    public class Etut
    {
        [Key]
        public int EtutId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int BranchId { get; set; }
        public DateOnly Date { get; set; }
        public TimeSpan Time { get; set; }
        public bool Statu { get; set; } = false;

    }
}
