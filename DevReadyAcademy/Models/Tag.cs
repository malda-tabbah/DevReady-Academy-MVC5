﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevReadyAcademy.Models
{
    public class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }
    }
}