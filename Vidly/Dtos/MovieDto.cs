﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(0, 20)]
        public byte NumberInStock { get; set; }

        [Range(0, 20)]
        public byte NumberAvailability { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}