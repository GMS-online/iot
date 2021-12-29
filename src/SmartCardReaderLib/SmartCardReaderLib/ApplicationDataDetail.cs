namespace SmartCardReaderLib
{
    /// <summary>
    /// Application data details
    /// </summary>
    public class ApplicationDataDetail
    {
        /// <summary>
        /// The Short File Identifier
        /// </summary>
        public byte Sfi { get; set; }

        /// <summary>
        /// The index of record to start reading
        /// </summary>
        public byte Start { get; set; }

        /// <summary>
        /// The index of last record to read
        /// </summary>
        public byte End { get; set; }

        /// <summary>
        /// The number of records
        /// </summary>
        public byte NumberOfRecords { get; set; }
    }
}
