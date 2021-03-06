﻿using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.ApiModel
{
    public class EstablishmentApiModel
    {
        /// <summary>
        /// Establishment's Id
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Establishment's name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Establishment's sector
        /// </summary>
        public string Sector { get; set; } = null!;
    }
}
