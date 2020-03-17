using System;
using System.ComponentModel.DataAnnotations;

namespace Entertainment.Model
{
    public class Actor
    {
        public int ActorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{FullName}, {DateOfBirth.ToShortDateString()}";
        }
    }
}