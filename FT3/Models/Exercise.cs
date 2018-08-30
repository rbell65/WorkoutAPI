using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FT3.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int exerciseID { get; set; }
        public int exerciseMax { get; set; }
        public string exerciseName { get; set; }
        public string exerciseType { get; set; }
    }
}
