using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForeverGaming.Models
{
    public partial class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(200)]
        public string Name { get; set; }

        // foreign key property
        [Required(ErrorMessage = "Please select a genre.")]
        public string GenreId { get; set; }
        // navigation properties
        public Genre Genre { get; set; }

        // foreign key property
        [Required(ErrorMessage = "Please select a type.")]
        public string TypeId { get; set; }
        // navigation properties
        public Type Type { get; set; }


        // foreign key property
        [Required(ErrorMessage = "Please select a format.")]
        public string FormatId { get; set; }
        // navigation properties
        public Format Format { get; set; }

        public string GameImage { get; set; }
    }
}
