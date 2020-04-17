using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Models
{
    
    public class Course
    {

        private Guid _id;
        [Key]
        public Guid ID
        {
            get { return _id; }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
