﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string QuestionNumber { get; set; }
        [StringLength(maximumLength: 1000)]
        public string HeaderLogo { get; set; }
        [NotMapped]
        public IFormFile HeaderFile { get; set; }
        [StringLength(maximumLength: 1000)]
        public string FooterLogo { get; set; }
        [NotMapped]
        public IFormFile FooterFile { get; set; }
        [StringLength(maximumLength: 1500)]
        public string FooterText { get; set; }
        [StringLength(maximumLength: 1000)]
        public string FacebookUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string PinterestUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string VimeUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string TwitterUrl { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Address { get; set; }
        [StringLength(maximumLength: 2000)]
        public string PhoneNumber1 { get; set; }
        [StringLength(maximumLength: 2000)]
        public string PhoneNumber2 { get; set; }
        [StringLength(maximumLength: 2000)]
        public string Mail { get; set; }
        [StringLength(maximumLength: 300)]
        public string WebSite { get; set; }
        [Column(TypeName = "decimal(11,8)")]
        public decimal Latitude { get; set; }
        [Column(TypeName = "decimal(11,8)")]
        public decimal Longitude { get; set; }
        [StringLength(maximumLength: 1000)]
        public string VideoUrl { get; set; }
    }
}
