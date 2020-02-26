using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Plannoy.Domain.Establishment
{
    public class Establishment : Entity
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
        /// Sector of establishment. Could be Alimentation, Entertainment, etc. it should be enum?
        /// </summary>
        public string Sector { get; set; }

        /// <summary>
        /// Transactions associated with this establishment.
        /// </summary>
        /// <value></value>
        public ICollection<Transaction.Transaction>? Transactions { get; set; }
    }
}
