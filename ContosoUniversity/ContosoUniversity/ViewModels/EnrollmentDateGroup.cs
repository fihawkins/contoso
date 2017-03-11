using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    //viewmodels are used to pass specific data of a model to the view, 
    //without having to pass all the properties, such as password.
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}