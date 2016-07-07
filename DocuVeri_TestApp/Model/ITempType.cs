using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocuVeri_TestApp.Model
{
    /// <summary>
    /// Interface for both tempreture type
    /// </summary>
    public interface ITempType
    {
        /// <summary>
        /// Confirm if command is valid or not
        /// </summary>
        /// <param name="command">Requested Command</param>
        /// <returns>True, if valid</returns>
        bool IsValidCommand(string command);

        /// <summary>
        /// Get the description for command
        /// </summary>
        /// <param name="command">Requested Command</param>
        /// <returns>Description for requested command</returns>
        string GetCommandDesc(string command);
    }
}
