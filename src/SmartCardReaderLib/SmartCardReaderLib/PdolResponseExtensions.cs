using System;

namespace SmartCardReaderLib
{
    /// <summary>
    /// Extension methods for PDOL Tags
    /// </summary>
    public static class PdolResponseExtensions
    {
        /// <summary>
        /// Add the response data for a PDOL tag
        /// </summary>
        /// <param name="pdolResponse">Where to write the response</param>
        /// <param name="dolTag">The PDOL tag for which to write the response</param>
        /// <param name="data">The binary date to write in the response</param>
        public static void AddPdolResponse(this Span<byte> pdolResponse, Tag dolTag, byte[] data)
        {
            var expectedResponseDataSize = dolTag.GetSizeOf_PDOL_ProcessingOptionsDataObjectList_SubTag_Response();

            if (data.Length < expectedResponseDataSize)
            {
                throw new Exception("Not enough data");
            }

            for (int i = 0; i < expectedResponseDataSize; i++)
            {
                pdolResponse[i] = data[i];

            }
        }
    }
}
