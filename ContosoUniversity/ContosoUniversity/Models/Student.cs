using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }

        [Required]
        //[Required(ErrorMessage = "Oh my gosh! Please enter the student's first name.")]
        [StringLength(50)]
        //[StringLength(50, ErrorMessage = "The first name must be less than 50 characters")]
        [Display(Name ="First Name:")]
        public string FirstMidName { get; set; }

        //ModelState consider valid yyyy-mm-dd, is it possible to change it?
        //this annotation adds a datepicker to the html field of this property
        [DataType(DataType.Date)]
        //in order to overwrite this strange format in the views create a custom display template
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Enrollment Date:")]
        public DateTime EnrollmentDate { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}