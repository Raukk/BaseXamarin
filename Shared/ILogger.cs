using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    /// <summary>
    /// A simplified version of the ILog interface from Log4Net
    /// </summary>
    /// <typeparam name="T">The class that the logger belongs to.</typeparam>
    public interface ILogger<T>
    {

        /// <summary>
        /// Write a message to the log at the Fatal level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        void Fatal(string message);

        /// <summary>
        /// Write a message and exception details to the log at the Fatal level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        /// <param name="exception">An Exception to have it's details logged.</param>
        void Fatal(string message, Exception exception);

        /// <summary>
        /// Write a message to the log at the Error level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        void Error(string message);

        /// <summary>
        /// Write a message and exception details to the log at the Error level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        /// <param name="exception">An Exception to have it's details logged.</param>
        void Error(string message, Exception exception);

        /// <summary>
        /// Write a message to the log at the Warn level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        void Warn(string message);

        /// <summary>
        /// Write a message and exception details to the log at the Warn level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        /// <param name="exception">An Exception to have it's details logged.</param>
        void Warn(string message, Exception exception);
        
        /// <summary>
        /// Write a message to the log at the Info level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        void Info(string message);

        /// <summary>
        /// Write a message and exception details to the log at the Info level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        /// <param name="exception">An Exception to have it's details logged.</param>
        void Info(string message, Exception exception);

        /// <summary>
        /// Write a message to the log at the Debug level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        void Debug(string message);

        /// <summary>
        /// Write a message and exception details to the log at the Debug level
        /// </summary>
        /// <param name="message">A string to be written into the log.</param>
        /// <param name="exception">An Exception to have it's details logged.</param>
        void Debug(string message, Exception exception);

    }
}
