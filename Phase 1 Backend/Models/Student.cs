using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phase_1_Backend
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        [Required, MaxLength(100)]
        public string firstName { get; set; }
        public string middleName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int phoneNumber { get; set; }

        public List<Address> Address { get; set; }
        [Timestamp]
        public DateTime timeCreated { get; set; }
    }

    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int addressID { get; set; }
        [ForeignKey("StudentForeignKey")]
        [Required]
        public int studentID { get; set; }
        [Required]
        public String addressType { get; set; }
        //public Student Student { get; set; }
        public string street_num { get; set; }
        [Required]
        public string street_name { get; set; }
        [Required]
        public string suburb { get; set; }
        [Required]
        public string city { get; set; }
        [Required, MaxLength(4)]
        public string postcode { get; set; }


    }
}
