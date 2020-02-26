using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Application.CommonInterfaces
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IOutputPortError
    {
        /// <summary>
        ///  Informs an error happened.
        /// </summary>
        /// <param name="exception">Error execeptions</param>
        void Error(Exception exception);
    }
}
