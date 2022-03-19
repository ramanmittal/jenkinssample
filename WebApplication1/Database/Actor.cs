using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.Database
{
    [Table("Actor")]
    public partial class Actor
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        [Column("Job Title")]
        [StringLength(255)]
        public string JobTitle { get; set; }
        [Column("Email Address")]
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Movie { get; set; }
        [StringLength(255)]
        public string Universty { get; set; }
    }
}
