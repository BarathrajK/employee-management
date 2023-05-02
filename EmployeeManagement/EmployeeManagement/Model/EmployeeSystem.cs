using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class EmployeeSystem
    {
        public EmployeeSystem(string? firstname, string? lastname, int age, DateTime dateofbirth, DateTime joiningdate, int basicsalary)
        {
            Id = generate();
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            DateOfBirth = dateofbirth;
            JoiningDate = joiningdate;
            BasicSalary = basicsalary;
        }

        [Key]
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set;}
        public DateTime? JoiningDate { get; set; }
        public decimal? BasicSalary { get; set; }

        private static int id = 1;
        static int generate()
        {
            return id++;
        }
    }


}
