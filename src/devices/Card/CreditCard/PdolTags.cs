namespace Iot.Device.Card.CreditCardProcessing
{
    /// <summary>
    /// Constants for PdolTags
    /// </summary>
    public class PdolTags
    {
        /// <summary>
        /// Constants for the TagNumberType.TerminalType =  0x9F35
        /// </summary>
        public class TerminalType
        {
            /// <summary>
            /// Direct values
            /// </summary>
            public class Values
            {
                /// <summary>
                /// Value for FinancialInstitutionControlled_AttendedOnlinOnly
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_AttendedOnlinOnly = 0x11;

                /// <summary>
                /// Value for FinancialInstitutionControlled_AttendedOnlineWithOfflineCapability
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_AttendedOnlineWithOfflineCapability = 0x12;

                /// <summary>
                /// Value for FinancialInstitutionControlled_AttendedOfflineOnly
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_AttendedOfflineOnly = 0x13;

                /// <summary>
                /// Value for FinancialInstitutionControlled_UnattendedOnlineOnly
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_UnattendedOnlineOnly = 0x14;

                /// <summary>
                /// Value for FinancialInstitutionControlled_UnattendeOnlineWithOfflineCapability
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_UnattendeOnlineWithOfflineCapability = 0x15;

                /// <summary>
                /// Value for FinancialInstitutionControlled_UnattendedOfflineOnly
                /// </summary>
                public static readonly byte FinancialInstitutionControlled_UnattendedOfflineOnly = 0x16;

                /// <summary>
                /// Value for Merchant_AttendedOnlinOnly
                /// </summary>
                public static readonly byte Merchant_AttendedOnlinOnly = 0x21;

                /// <summary>
                /// Value for Merchant_AttendedOnlineWithOfflineCapability
                /// </summary>
                public static readonly byte Merchant_AttendedOnlineWithOfflineCapability = 0x22;

                /// <summary>
                /// Value for Merchant_AttendedOfflineOnly
                /// </summary>
                public static readonly byte Merchant_AttendedOfflineOnly = 0x23;

                /// <summary>
                /// Value for Merchant_UnattendedOnlineOnly
                /// </summary>
                public static readonly byte Merchant_UnattendedOnlineOnly = 0x24;

                /// <summary>
                /// Value for Merchant_UnattendeOnlineWithOfflineCapability
                /// </summary>
                public static readonly byte Merchant_UnattendeOnlineWithOfflineCapability = 0x25;

                /// <summary>
                /// Value for Merchant_UnattendedOfflineOnly
                /// </summary>
                public static readonly byte Merchant_UnattendedOfflineOnly = 0x26;

                /// <summary>
                /// Value for Cardholder_UnattendedOnlineOnly
                /// </summary>
                public static readonly byte Cardholder_UnattendedOnlineOnly = 0x34;

                /// <summary>
                /// Value for Cardholder_UnattendeOnlineWithOfflineCapability
                /// </summary>
                public static readonly byte Cardholder_UnattendeOnlineWithOfflineCapability = 0x35;

                /// <summary>
                /// Value for Cardholder_UnattendedOfflineOnly
                /// </summary>
                public static readonly byte Cardholder_UnattendedOfflineOnly = 0x36;
            }
        }

        /// <summary>
        /// TagNumberType.AdditionalTerminalCapabilities = 0x9F40
        /// </summary>
        public class AdditionalTerminalCapabilities
        {
            /// <summary>
            /// Bit ways values
            /// </summary>
            public class BitValues
            {
                /// <summary>
                /// Byte1_TransactionTypeCapability values
                /// </summary>
                public class Byte1_TransactionTypeCapability
                {
                    /// <summary>
                    /// Cash TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Cash = 0b1000_0000;

                    /// <summary>
                    /// Goods TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Goods = 0b0100_0000;

                    /// <summary>
                    /// Services TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Services = 0b0010_0000;

                    /// <summary>
                    /// Cashback TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Cashback = 0b0001_0000;

                    /// <summary>
                    /// Inquiry TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Inquiry = 0b0000_1000;

                    /// <summary>
                    /// Transfer TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Transfer = 0b0000_0100;

                    /// <summary>
                    /// Payment TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Payment = 0b0000_0010;

                    /// <summary>
                    /// Administrative TransactionTypeCapability
                    /// </summary>
                    public static readonly byte Administrative = 0b0000_0001;

                    /// <summary>
                    /// All TransactionTypeCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte2_TransactionTypeCapability values
                /// </summary>
                public class Byte2_TransactionTypeCapability
                {
                    /// <summary>
                    /// CashDeposit TransactionTypeCapability
                    /// </summary>
                    public static readonly byte CashDeposit = 0b1000_0000;

                    /// <summary>
                    /// RFU TransactionTypeCapability
                    /// </summary>
                    public static readonly byte RFU = 0b0111_1111;

                    /// <summary>
                    /// All TransactionTypeCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte3_TerminalDataInputCapability values
                /// </summary>
                public class Byte3_TerminalDataInputCapability
                {
                    /// <summary>
                    /// NumericKeys TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte NumericKeys = 0b1000_0000;

                    /// <summary>
                    /// AlphabeticAndSpecialCharacterKeys TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte AlphabeticAndSpecialCharacterKeys = 0b0100_0000;

                    /// <summary>
                    /// CommandKeys TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte CommandKeys = 0b0010_0000;

                    /// <summary>
                    /// FunctionKeys TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte FunctionKeys = 0b0001_0000;

                    /// <summary>
                    /// RFU TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte RFU = 0b0000_1111;

                    /// <summary>
                    /// All_No_RFU TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1111_0000;

                    /// <summary>
                    /// All TerminalDataInputCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte4_TerminalDataOutputCapability values
                /// </summary>
                public class Byte4_TerminalDataOutputCapability
                {
                    /// <summary>
                    /// NumericKeys TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte NumericKeys = 0b1000_0000;

                    /// <summary>
                    /// AlphabeticAndSpecialCharacterKeys TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte AlphabeticAndSpecialCharacterKeys = 0b0100_0000;

                    /// <summary>
                    /// CommandKeys TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CommandKeys = 0b0010_0000;

                    /// <summary>
                    /// FunctionKeys TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte FunctionKeys = 0b0001_0000;

                    /// <summary>
                    /// RFU TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte RFU = 0b0000_1111;

                    /// <summary>
                    /// All_No_RFU TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1111_0000;

                    /// <summary>
                    /// All TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte5_TerminalDataOutputCapability values
                /// </summary>
                public class Byte5_TerminalDataOutputCapability
                {
                    /// <summary>
                    /// CodeTable8 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable8 = 0b1000_0000;

                    /// <summary>
                    /// CodeTable7 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable7 = 0b0100_0000;

                    /// <summary>
                    /// CodeTable6 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable6 = 0b0010_0000;

                    /// <summary>
                    /// CodeTable5 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable5 = 0b0001_0000;

                    /// <summary>
                    /// CodeTable4 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable4 = 0b0000_1000;

                    /// <summary>
                    /// CodeTable3 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable3 = 0b0000_0100;

                    /// <summary>
                    /// CodeTable2 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable2 = 0b0000_0010;

                    /// <summary>
                    /// CodeTable1 TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte CodeTable1 = 0b0000_0001;

                    /// <summary>
                    /// All TerminalDataOutputCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }
            }
        }

        /// <summary>
        /// TagNumberType.TerminalCapabilities = 0x9F33
        /// </summary>
        public class TerminalCapabilities
        {
            /// <summary>
            /// Bit ways values
            /// </summary>
            public class BitValues
            {
                /// <summary>
                /// Byte1_CardDataInputCapability values
                /// </summary>
                public class Byte1_CardDataInputCapability
                {
                    /// <summary>
                    /// ManualKeyEntry CardDataInputCapability
                    /// </summary>
                    public static readonly byte ManualKeyEntry = 0b1000_0000;

                    /// <summary>
                    /// MagneticStripe CardDataInputCapability
                    /// </summary>
                    public static readonly byte MagneticStripe = 0b0100_0000;

                    /// <summary>
                    /// IcWithContacts CardDataInputCapability
                    /// </summary>
                    public static readonly byte IcWithContacts = 0b0010_0000;

                    /// <summary>
                    /// RFU CardDataInputCapability
                    /// </summary>
                    public static readonly byte RFU = 0b0001_1111;

                    /// <summary>
                    /// All_No_RFU CardDataInputCapability
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1110_0000;

                    /// <summary>
                    /// All CardDataInputCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte2_CVMCapability values
                /// </summary>
                public class Byte2_CVMCapability
                {
                    /// <summary>
                    /// PlaintextPINForICCVerification Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte PlaintextPINForICCVerification = 0b1000_0000;

                    /// <summary>
                    /// EncipheredPINForOnlineVerification Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte EncipheredPINForOnlineVerification = 0b0100_0000;

                    /// <summary>
                    /// Signature CardDataInputCapability
                    /// </summary>
                    public static readonly byte Signature = 0b0010_0000;

                    /// <summary>
                    /// EncipheredPINForOfflineVerification Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte EncipheredPINForOfflineVerification = 0b0001_0000;

                    /// <summary>
                    /// NoCVMRequired Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte NoCVMRequired = 0b0000_1000;

                    /// <summary>
                    /// RFU Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte RFU = 0b0000_0111;

                    /// <summary>
                    /// All_No_RFU Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1111_1000;

                    /// <summary>
                    /// All Byte2_CVMCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte3_SecurityCapability values
                /// </summary>
                public class Byte3_SecurityCapability
                {
                    /// <summary>
                    /// SDA Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte SDA = 0b1000_0000;

                    /// <summary>
                    /// DDA Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte DDA = 0b0100_0000;

                    /// <summary>
                    /// CardCapture Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte CardCapture = 0b0010_0000;

                    /// <summary>
                    /// RFU5 Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte RFU5 = 0b0001_0000;

                    /// <summary>
                    /// CDA Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte CDA = 0b0000_1000;

                    /// <summary>
                    /// RFU321 Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte RFU321 = 0b0000_0111;

                    /// <summary>
                    /// All_No_RFU Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1110_1000;

                    /// <summary>
                    /// All Byte3_SecurityCapability
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }
            }
        }

        /// <summary>
        /// TagNumberType.TerminalTransactionQualifiers_TTQ = 0x9F66
        /// </summary>
        public class TerminalTransactionQualifiers_TTQ
        {
            /// <summary>
            /// Bit ways values
            /// </summary>
            public class BitValues
            {
                /// <summary>
                /// Byte1 values
                /// </summary>
                public class Byte1
                {
                    /// <summary>
                    /// All Byte1
                    /// </summary>
                    public static readonly byte MagStripeModeSupported = 0b1000_0000;

                    /// <summary>
                    /// RFU Byte1
                    /// </summary>
                    public static readonly byte RFU = 0b0100_0000;

                    /// <summary>
                    /// EMVModeSupported Byte1
                    /// </summary>
                    public static readonly byte EMVModeSupported = 0b0010_0000;

                    /// <summary>
                    /// EMVContactChipSupported Byte1
                    /// </summary>
                    public static readonly byte EMVContactChipSupported = 0b0001_0000;

                    /// <summary>
                    /// OfflineOnlyReader Byte1
                    /// </summary>
                    public static readonly byte OfflineOnlyReader = 0b0000_1000;

                    /// <summary>
                    /// OnlinePinSupported Byte1
                    /// </summary>
                    public static readonly byte OnlinePinSupported = 0b0000_0100;

                    /// <summary>
                    /// SignatureSupported Byte1
                    /// </summary>
                    public static readonly byte SignatureSupported = 0b0000_0010;

                    /// <summary>
                    /// OfflineDataAuthenticationForOnlineAuthorizationsSupported Byte1
                    /// </summary>
                    public static readonly byte OfflineDataAuthenticationForOnlineAuthorizationsSupported = 0b0000_0001;

                    /// <summary>
                    /// All_No_RFU Byte1
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1011_1111;

                    /// <summary>
                    /// All Byte1
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte2 values
                /// </summary>
                public class Byte2
                {
                    /// <summary>
                    /// ___NoDocumentaion_b8 Byte2
                    /// </summary>
                    public static readonly byte ___NoDocumentaion_b8 = 0b1000_0000;

                    /// <summary>
                    /// CVMRequired Byte2
                    /// </summary>
                    public static readonly byte CVMRequired = 0b0100_0000;

                    /// <summary>
                    /// ContactChipOfflinePinSupported Byte2
                    /// </summary>
                    public static readonly byte ContactChipOfflinePinSupported = 0b0010_0000;

                    /// <summary>
                    /// RFU Byte2
                    /// </summary>
                    public static readonly byte RFU = 0b0001_1111;

                    /// <summary>
                    /// All_No_RFU Byte2
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1110_0000;

                    /// <summary>
                    /// All Byte2
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte3 values
                /// </summary>
                public class Byte3
                {
                    /// <summary>
                    /// IssuerUpdateProcessingSupported Byte3
                    /// </summary>
                    public static readonly byte IssuerUpdateProcessingSupported = 0b1000_0000;

                    /// <summary>
                    /// ConsumerDeviceCVMSupported Byte3
                    /// </summary>
                    public static readonly byte ConsumerDeviceCVMSupported = 0b0100_0000;

                    /// <summary>
                    /// RFU Byte3
                    /// </summary>
                    public static readonly byte RFU = 0b0011_1111;

                    /// <summary>
                    /// All_No_RFU Byte3
                    /// </summary>
                    public static readonly byte All_No_RFU = 0b1100_0000;

                    /// <summary>
                    /// All Byte3
                    /// </summary>
                    public static readonly byte All = 0b1111_1111;
                }

                /// <summary>
                /// Byte3 values
                /// </summary>
                public class Byte4
                {
                    /// <summary>
                    /// RFU Byte4
                    /// </summary>
                    public static readonly byte RFU = 0b1111_1111;

                    /// <summary>
                    /// No_RFU Byte4
                    /// </summary>
                    public static readonly byte No_RFU = 0b0000_0000;
                }
            }
        }
    }
}
