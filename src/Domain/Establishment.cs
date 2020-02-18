using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Plannoy.Domain
{
    public class Establishment: Entity
    {
        public Establishment(string name, string sector)
        {
            Name = name;
            Sector = sector;
        }

        /// <summary>
        /// Name of establishment
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Sector of aestablishment. Could be Alimentation, Enterteinment, etc. it should be enum?
        /// </summary>
        public string Sector { get; set; }
    }
}
