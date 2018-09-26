﻿// Code generated by SqlToCsharp

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlToCsharpSample
{
    public partial class String
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string S { get; set; }
        [StringLength(50)]
        public string NS { get; set; }
        [Required]
        public string MS { get; set; }
        public string NMS { get; set; }
    }
}
