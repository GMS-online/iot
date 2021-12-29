namespace SmartCardReaderLib
{
    /// <summary>
    /// Constants for TagNumbers
    /// </summary>
    public class TagNumberType
    {
        /// <summary>
        /// FileControlInformation_FCI_Template Value
        /// </summary>
        public static readonly uint FileControlInformation_FCI_Template = 0x6F;

        /// <summary>
        /// DedicatedFile_DF_Name Value
        /// </summary>
        public static readonly uint DedicatedFile_DF_Name = 0x84;

        /// <summary>
        /// FileControlInformation_FCI_ProprietaryTemplate Value
        /// </summary>
        public static readonly uint FileControlInformation_FCI_ProprietaryTemplate = 0xA5;

        /// <summary>
        /// PDOL_ProcessingOptionsDataObjectList Value
        /// </summary>
        public static readonly uint PDOL_ProcessingOptionsDataObjectList = 0x9F38;

        /// <summary>
        /// TemplateCommand Value
        /// </summary>
        public static readonly byte TemplateCommand = 0x83;

        /// <summary>
        /// TerminalCapabilities Value
        /// </summary>
        public static readonly uint TerminalCapabilities = 0x9F33;

        /// <summary>
        /// TerminalType Value
        /// </summary>
        public static readonly uint TerminalType = 0x9F35;

        /// <summary>
        /// AdditionalTerminalCapabilities Value
        /// </summary>
        public static readonly uint AdditionalTerminalCapabilities = 0x9F40;

        /// <summary>
        /// TerminalTransactionQualifiers_TTQ Value
        /// </summary>
        public static readonly uint TerminalTransactionQualifiers_TTQ = 0x9F66;

        /// <summary>
        /// AmountAuthorized_Numeric Value
        /// </summary>
        public static readonly uint AmountAuthorized_Numeric = 0x9F02;

        /// <summary>
        /// TerminalCountryCode Value
        /// </summary>
        public static readonly uint TerminalCountryCode = 0x9F1A;

        /// <summary>
        /// TransactionDate Value
        /// </summary>
        public static readonly uint TransactionDate = 0x009A;

        /// <summary>
        /// UnpredictableNumber Value
        /// </summary>
        public static readonly uint UnpredictableNumber = 0x9F37;

        /// <summary>
        /// TransactionCurrencyCode Value
        /// </summary>
        public static readonly uint TransactionCurrencyCode = 0x5F2A;

        /// <summary>
        /// ApplicationTemplate Value
        /// ex: master card, visa, girocard ...
        /// </summary>
        public static readonly uint ApplicationTemplate = 0x61;

        /// <summary>
        /// ApplicationDedicatedFile_ADF_Name Value
        /// The name of the file dedicated to an application. See "ApplicationTemplate".
        /// </summary>
        public static readonly uint ApplicationDedicatedFile_ADF_Name = 0x4F;

        /// <summary>
        /// ApplicationLabel Value
        /// The name of the an application. See "ApplicationTemplate".
        /// </summary>
        public static readonly uint ApplicationLabel = 0x50;

        /// <summary>
        /// ApplicationPriorityIndicator Value
        /// See "ApplicationTemplate".
        /// </summary>
        public static readonly uint ApplicationPriorityIndicator = 0x87;

        /// <summary>
        /// ApplicationExpirationDate Value
        /// </summary>
        public static readonly uint ApplicationExpirationDate = 0x5F24;

        /// <summary>
        /// ApplicationPrimaryAccountNumber_PAN Value
        /// </summary>
        public static readonly uint ApplicationPrimaryAccountNumber_PAN = 0x5A;

        /// <summary>
        /// IssuerCountryCode Value
        /// </summary>
        public static readonly uint IssuerCountryCode = 0x5F28;
    }
}
