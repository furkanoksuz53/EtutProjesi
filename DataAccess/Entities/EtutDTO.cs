using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProject.DataAccess.Entities
{
    public class EtutDTO
    {
        public int EtutId { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public DateOnly Date { get; set; }
        public TimeSpan Time { get; set; }
        public bool Statu { get; set; }

    }
}
