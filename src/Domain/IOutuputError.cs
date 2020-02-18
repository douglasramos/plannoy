using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Domain
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IOutputPortError
    {
        /// <summary>
        ///  Informs an error happened.
        /// </summary>
        /// <param name="message">Text description.</param>
        void Error(Exception exception);
    }
}
