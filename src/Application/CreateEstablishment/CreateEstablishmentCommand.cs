using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;

namespace Plannoy.Application.CreateEstablishment
{
    public class CreateEstablishmentCommand : ICommand
    {
        public CreateEstablishmentCommand(string name, string sector)
        {
            Name = name;
            Sector = sector;
        }

        /// <summary>
        /// Name of the establishment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sector of the establishment. TODO:should it be an enum?
        /// </summary>
        public string Sector { get; set; }
    }
}
