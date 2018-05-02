using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarLearning.Models
{
    public class Exam
    {
        public Exam()
        {
            this.Pieces = new HashSet<Piece>();
        }
        public int ExamID { get; set; }

        [Display(Name = "Grade Number")]
        [Range(1, 8, ErrorMessage = "Grade number must be between 1 and 8")]
        public int Grade { get; set; }

        public string Instrument { get; set; }

        [Display(Name = "Exam Board")]
        public string ExamBoard { get; set; }

        [Display(Name = "In Exam From")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateFrom { get; set; }

        [Display(Name = "In Exam Until")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTo { get; set; }

        [Display(Name = "Exam Pieces")]
        public virtual ICollection<Piece> Pieces { get; set; }
    }
}