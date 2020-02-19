using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Application.CommonInterfaces
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IOutputPortSuccess<in TUseCaseResponse>
    {
        /// <summary>
        ///  Informs success message
        /// </summary>
        /// <param name="message">response object</param>
        void Success(TUseCaseResponse response);
    }
}
