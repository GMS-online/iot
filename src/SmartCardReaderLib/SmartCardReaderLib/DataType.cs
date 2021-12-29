namespace SmartCardReaderLib
{
    /// <summary>
    /// Additional data that can be extracted from the Credit Card
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// Application transaction counter
        /// </summary>
        ApplicationTransactionCounter,

        /// <summary>
        /// Number of pin try left
        /// </summary>
        PinTryCounter,

        /// <summary>
        /// Last online ATC register
        /// </summary>
        LastOnlineAtcRegister,

        /// <summary>
        /// Log format
        /// </summary>
        LogFormat
    }
}
