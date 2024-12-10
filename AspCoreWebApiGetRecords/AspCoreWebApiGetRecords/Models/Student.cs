using System;
using System.Collections.Generic;

namespace AspCoreWebApiGetRecords.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Studentname { get; set; } = null!;
        public string Studentgender { get; set; } = null!;
        public int Age { get; set; }
        public int Standard { get; set; }
    }
}
