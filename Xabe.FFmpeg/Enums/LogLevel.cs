using System.ComponentModel;

namespace Xabe.FFmpeg.Enums
{
    /// <summary>
    ///     Log level for FFmpeg
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        ///     Show nothing at all; be silent.
        /// </summary>
        [Description("-8")] Quiet,

        /// <summary>
        ///     Only show fatal errors which could lead the process to crash, such as an assertion failure. This is not currently used for anything.
        /// </summary>
        [Description("0")] Panic,

        /// <summary>
        ///     Only show fatal errors. These are errors after which the process absolutely cannot continue.
        /// </summary>
        [Description("8")] Fatal,

        /// <summary>
        ///     Show all errors, including ones which can be recovered from.
        /// </summary>
        [Description("16")] Error,

        /// <summary>
        ///     Show all warnings and errors. Any message related to possibly incorrect or unexpected events will be shown.
        /// </summary>
        [Description("24")] Warning,

        /// <summary>
        ///     Show informative messages during processing. This is in addition to warnings and errors. This is the default value.
        /// </summary>
        [Description("32")] Info,

        /// <summary>
        ///     Same as info, except more verbose.
        /// </summary>
        [Description("40")] Verbose,

        /// <summary>
        ///     Advanced
        /// </summary>
        [Description("48")] Debug,

        /// <summary>
        ///     Advanced
        /// </summary>
        [Description("56")] Trace
    }
}
