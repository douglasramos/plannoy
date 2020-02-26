using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.ApiModel
{
    public class CreateEstablishmentApiModel
    {
        /// <summary>
        /// Establishment's name
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Establishment's sector
        /// </summary>
        [Required]
        public string Sector { get; set; } = null!;
    }
}
