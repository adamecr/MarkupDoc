using System;
using System.Threading.Tasks;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Interface of the markup output writer
    /// </summary>
    public interface IMarkupWriter : INonWritableWriter
    {
        /// <summary>
        /// Writes the code model to the output
        /// </summary>
        /// <param name="writeContentActionAsync">Function rendering the model to the output</param>
        /// <returns>Async task</returns>
        Task WriteModelAsync(Func<Task> writeContentActionAsync);
        /// <summary>
        /// Writes the <paramref name="text"/> to the output
        /// </summary>
        /// <param name="text">Text to write</param>
        /// <returns>Async task</returns>
        Task WriteAsync(string text);
        /// <summary>
        /// Writes the <paramref name="text"/> and a new line to the output
        /// </summary>
        /// <param name="text">Text to write</param>
        /// <returns>Async task</returns>
        Task WriteLineAsync(string text = null);
    }

    /// <summary>
    /// Non writable interface of the output writer
    /// </summary>
    /// <remarks>This interface is used when the direct writing to the output is not allowed</remarks>
    public interface INonWritableWriter
    {
        /// <summary>
        /// Sets the initial target of the markdown writer
        /// </summary>
        /// <remarks>The target can't be set when the output is being generated</remarks>
        /// <param name="fileName">Full path to the file (including the extension) to write the output to</param>
        /// <returns>True when the target has been set, otherwise false (because the output is in progress)</returns>
        bool SetTarget(string fileName);

        /// <summary>
        /// Starts a new split of the output
        /// </summary>
        /// <param name="splitName">Name of the split</param>
        void Split(string splitName);
    }
}
