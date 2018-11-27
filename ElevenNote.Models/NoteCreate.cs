﻿using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in the title")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }
        public SubjectType Subject { get; set; }
        public bool IsStarred { get; set; }

        public override string ToString() => Title;
        
    }
}
