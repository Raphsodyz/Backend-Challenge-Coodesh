﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.DTO
{
    public class LaunchServiceProviderDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        
        [Key]
        [Range(1, int.MaxValue)]
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Atention! The ID field can't be null.")]
        [JsonPropertyName("id")]
        public int IdFromApi { get; set; }

        [Display(Name = "Link")]
        [StringLength(500, ErrorMessage = "Atention! Write a valid link.", MinimumLength = 2)]
        public string Url { get; set; }

        [Display(Name = "Name")]
        [StringLength(200, ErrorMessage = "Atention! Write a valid Name.", MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Type")]
        [StringLength(200, ErrorMessage = "Atention! Write a valid Type.", MinimumLength = 2)]
        public string Type { get; set; }

    }
}
