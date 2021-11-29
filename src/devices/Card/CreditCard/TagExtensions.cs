using System;
using System.Collections.Generic;
using System.Linq;

namespace Iot.Device.Card.CreditCardProcessing
{
    /// <summary>
    /// Extension methods for Tag class
    /// </summary>
    public static class TagExtensions
    {
        /// <summary>
        /// Gets all fileControlTemplates that contain proprietary templates for the specified ApplicationIdentifier
        /// </summary>
        /// <param name="tags">All tags that we have</param>
        /// <param name="applicationIdentifier">The application identifier used in the search</param>
        /// <returns>all fileControlTemplates that contain proprietary templates for the specified ApplicationIdentifier</returns>
        public static IReadOnlyList<Tag>
            GetAll_FileControlTemplates_ThatContainPropertaryTemplates_ForThisApplicationIdentifier(this IReadOnlyList<Tag> tags, byte[] applicationIdentifier)
        {
            // We need to select
            //  the Template 0x6F (TagNumberType.FileControlInformation_FCI_Template)
            //      where the Tag 0x84 contains the same App Id and where we have a template A5 attached.
            var templates = tags
                .Where(m => m.TagNumber == TagNumberType.FileControlInformation_FCI_Template)
                .Where(m => m.Tags.Where(t => t.TagNumber == TagNumberType.DedicatedFile_DF_Name).Where(t => t.Data.SequenceEqual(applicationIdentifier)) is object)
                .Where(m => m.Tags.Where(t => t.TagNumber == TagNumberType.FileControlInformation_FCI_ProprietaryTemplate) is object)
                .ToList();
            return templates;
        }

        /// <summary>
        /// Gets first PDOL (ProcessingOptionsDataObjectList) Tag from the specified FCI (FileControlInformation) tags
        /// </summary>
        /// <param name="fciTags">The fci (FileControlInformation) Tags</param>
        /// <returns>first PDOL Tag from the specified FCI Tag</returns>
        public static Tag?
            GetFirst_PDOL_ProcessingOptionsDataObjectList_Tag_From_FileControlInformation_FCI_Tags(this IReadOnlyList<Tag> fciTags)
        {
            foreach (var fciTag in fciTags)
            {
                if (fciTag.TagNumber != TagNumberType.FileControlInformation_FCI_Template)
                {
                    throw new Exception($"Expecting only FCI template Tags {TagNumberType.FileControlInformation_FCI_Template}, but found: {fciTag.TagNumber}");
                }

                var pdolTag =
                    Tag.SearchTag(fciTag.Tags, TagNumberType.FileControlInformation_FCI_ProprietaryTemplate)
                    .FirstOrDefault()?
                    .Tags.FirstOrDefault(m => m.TagNumber == TagNumberType.PDOL_ProcessingOptionsDataObjectList);

                if (pdolTag is object)
                {
                    return pdolTag;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the size required by a PDOL response
        /// </summary>
        /// <param name="pdolSubTag">A sub tag of a  PDOL tag (ProcessingOptionsDataObjectList)</param>
        /// <returns>the size required by a PDOL response</returns>
        public static byte
            GetSizeOf_PDOL_ProcessingOptionsDataObjectList_SubTag_Response(this Tag pdolSubTag)
        {
            if (pdolSubTag.Parent != TagNumberType.PDOL_ProcessingOptionsDataObjectList)
            {
                throw new Exception($"pdolSubTag.Parent = {pdolSubTag.Parent} is not PDOL_ProcessingOptionsDataObjectList = {TagNumberType.PDOL_ProcessingOptionsDataObjectList}");
            }

            return pdolSubTag.Data[0];
        }

        /// <summary>
        /// Gets the size required for all sub tags of a PDOL
        /// </summary>
        /// <param name="pdolTag">A PDOL tag</param>
        /// <returns>the size required for all sub tags of a PDOL</returns>
        public static byte
            GetSizeOf_PDOL_ProcessingOptionsDataObjectList_Tag_Response(this Tag pdolTag)
        {
            if (pdolTag.TagNumber != TagNumberType.PDOL_ProcessingOptionsDataObjectList)
            {
                throw new Exception($"pdolTag = {pdolTag.TagNumber} is not PDOL_ProcessingOptionsDataObjectList = {TagNumberType.PDOL_ProcessingOptionsDataObjectList}");
            }

            var responseSize = (byte)0;

            foreach (var pdolSubTag in pdolTag.Tags)
            {
                var sizeOfPdolSubTag = pdolSubTag.GetSizeOf_PDOL_ProcessingOptionsDataObjectList_SubTag_Response();
                responseSize += sizeOfPdolSubTag;
            }

            return responseSize;
        }

        /// <summary>
        /// Converts a Tag object to a TagDetails object
        /// </summary>
        /// <param name="tag">a tag</param>
        /// <returns>TagDetails from a Tag</returns>
        public static TagDetails? GetTagDetails(this Tag tag)
        {
            var tagDetails = TagList.Tags.FirstOrDefault(m => m.TagNumber == tag.TagNumber);
            return tagDetails;
        }

        /// <summary>
        /// Checks if a Tag is a Template or is if it has sub tags
        /// </summary>
        /// <param name="tag">a tag</param>
        /// <returns>true if a Tag is a Template else false</returns>
        public static bool IsTemplateOrConstructed(this Tag tag)
        {
            var tagDetails = tag.GetTagDetails();
            var isTmplOrConstruct = ((tagDetails?.IsTemplate == true) || (tagDetails?.IsConstructed == true));
            return isTmplOrConstruct;
        }

        /// <summary>
        /// Checks if a Tag is a DOL Tag
        /// </summary>
        /// <param name="tag">a tag</param>
        /// <returns>tru if a Tag is a DOL Tag else false</returns>
        public static bool IsDol(this Tag tag)
        {
            var isDol = TagList.Tags.FirstOrDefault(m => m.TagNumber == tag.TagNumber)?.IsDol == true;
            return isDol;
        }

        /// <summary>
        /// Gets all ApplicationTemplate Tags from a list of Tags
        /// </summary>
        /// <param name="tags">A list of Tags to search in</param>
        /// <returns>all ApplicationTemplate Tags</returns>
        public static IReadOnlyList<Tag> GetApplicationTemplates(this List<Tag> tags)
        {
            var appTemplates = Tag.SearchTag(tags, TagNumberType.ApplicationTemplate);
            return appTemplates;
        }

        /// <summary>
        /// Gets ADF (ApplicationDedicatedFile) from  a Tag
        /// </summary>
        /// <param name="applicationTemplateTag">a Tag</param>
        /// <returns>ADF (ApplicationDedicatedFile) Tag</returns>
        public static Tag GetApplicationDedicatedFile_ADF_NameTag(this Tag applicationTemplateTag)
        {
            if (applicationTemplateTag.TagNumber != TagNumberType.ApplicationTemplate)
            {
                throw new Exception(
                    $"Can only get the DedicatedFile_ADF_Name tag from an ApplicationTemplate tag, but got a tag type = {applicationTemplateTag.TagNumber}");
            }

            var appIdentifierTag = Tag.SearchTag(applicationTemplateTag.Tags, TagNumberType.ApplicationDedicatedFile_ADF_Name).First();

            return appIdentifierTag;
        }

        /// <summary>
        /// Gets the ApplicationLabel Tag from an ApplicationTemplate Tag
        /// </summary>
        /// <param name="applicationTemplateTag">a Tag</param>
        /// <returns>the ApplicationLabel Tag</returns>
        public static Tag? GetApplicationLabelTag(this Tag applicationTemplateTag)
        {
            if (applicationTemplateTag.TagNumber != TagNumberType.ApplicationTemplate)
            {
                throw new Exception(
                    $"Can only get the ApplicationLabel tag from an ApplicationTemplate tag, but got a tag type = {applicationTemplateTag.TagNumber}");
            }

            var appIdentifierTag = Tag.SearchTag(applicationTemplateTag.Tags, TagNumberType.ApplicationLabel).FirstOrDefault();

            return appIdentifierTag;
        }

        /// <summary>
        /// Gets the ApplicationPriorityIndicator Tag from an ApplicationTemplate Tag
        /// </summary>
        /// <param name="applicationTemplateTag">a Tag</param>
        /// <returns>the ApplicationPriorityIndicator</returns>
        public static Tag GetApplicationPriorityIndicatorTag(this Tag applicationTemplateTag)
        {
            if (applicationTemplateTag.TagNumber != TagNumberType.ApplicationTemplate)
            {
                throw new Exception(
                    $"Can only get the ApplicationPriorityIndicator tag from an ApplicationTemplate tag, but got a tag type = {applicationTemplateTag.TagNumber}");
            }

            // As it is not mandatory, some cards will have only 1
            // application and this may not be present
            var appPriotity =
                Tag.SearchTag(applicationTemplateTag.Tags, TagNumberType.ApplicationPriorityIndicator).FirstOrDefault() ??
            new Tag()
            {
                TagNumber = TagNumberType.ApplicationPriorityIndicator,
                Parent = applicationTemplateTag.TagNumber,
                Data = new byte[1] { 0 },
                Tags = new List<Tag>()
            };

            return appPriotity;
        }

        /// <summary>
        /// Sets the header for the PDOL (ProcessingOptionsDataObjectList) response
        /// </summary>
        /// <param name="pdolResponse">where to write the header </param>
        /// <param name="sizeOfPdolResponse">size Of Pdol Response</param>
        public static void Set_PDOL_ProcessingOptionsDataObjectList_ResponseHeader(this Span<byte> pdolResponse, byte sizeOfPdolResponse)
        {
            pdolResponse[0] = TagNumberType.TemplateCommand;
            pdolResponse[1] = sizeOfPdolResponse;
        }
    }
}
