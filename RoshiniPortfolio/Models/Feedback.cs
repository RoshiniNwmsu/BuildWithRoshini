using System;
using System.ComponentModel.DataAnnotations;

namespace RoshiniPortfolio.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public string Note { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}