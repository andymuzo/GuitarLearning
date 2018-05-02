using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuitarLearning.Models
{
    public class Piece
    {
        public int PieceID { get; set; }

        [Display(Name = "Composed By")]
        public string Composer { get; set; }

        [Display(Name = "Piece Title")]
        public string Name { get; set; }

        [Display(Name = "Year Published")]
        public string YearPublished { get; set; }
        public string Style { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Video")]
        public string VideoLink { get; set; }

        [Display(Name = "Used in Exams")]
        public virtual ICollection<Exam> Exams { get; set; }
    }
}