﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //Relations
        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public List<Answer>? Answers { get; set; }


    }
}
