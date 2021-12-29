using System;

namespace SmartCardReaderLib
{
    /// <summary>
    /// The source of a Tag
    /// </summary>
    [Flags]
    public enum Source
    {
        /// <summary>
        /// Card
        /// </summary>
        Icc = 0b0000_0001,

        /// <summary>
        /// Terminal
        /// </summary>
        Terminal = 0b0000_0010,

        /// <summary>
        /// Issuer
        /// </summary>
        Issuer = 0b0000_0100
    }
}
