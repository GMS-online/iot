namespace SmartCardReaderLib
{
    /// <summary>
    /// The type of conversion for the data conversion.
    /// This apply only to the know types, the default is
    /// Byte Array which uses a simple BitConverter.ToString()
    /// </summary>
    public enum ConversionType
    {
        /// <summary>
        /// Byte array
        /// </summary>
        ByteArray = 0,

        /// <summary>
        /// BCD to string
        /// </summary>
        BcdToString,

        /// <summary>
        /// Raw string
        /// </summary>
        RawString,

        /// <summary>
        /// Date format
        /// </summary>
        Date,

        /// <summary>
        /// Decimal number
        /// </summary>
        DecimalNumber,

        /// <summary>
        /// Time
        /// </summary>
        Time,
    }
}
