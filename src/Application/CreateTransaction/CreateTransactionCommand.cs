using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;

namespace Plannoy.Application.CreateTransaction
{
    public class CreateTransactionCommand : ICommand
    {
        public CreateTransactionCommand()
        {
        }

        //public CreateEstablishmentCommand(string name, string sector)
        //{
        //    Name = name;
        //    Sector = sector;
        //}

        /// <summary>
        /// Name of establishment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sector of establishment. Could be Alimentation, Entertainment, etc. it should be enum?
        /// </summary>
        public string Sector { get; set; }
    }
}
