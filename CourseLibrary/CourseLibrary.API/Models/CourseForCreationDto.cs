using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(
        ErrorMessage = "Title must be different from description")]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required(ErrorMessage = "You should fill out a title")]
        [MaxLength(100, ErrorMessage = "the title shouldn't have more than 100 characters")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "the description shouldn't have more than 500 characters")]
        public string Description { get; set; }

        /*
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Description)
            {
                yield return new ValidationResult("the provided description should be different from the title.",
                new[] {"CourseForCreationDto"});
            }
        }
        */
    }
}
