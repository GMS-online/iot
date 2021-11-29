// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Iot.Device.Card.CreditCardProcessing
{
    /// <summary>
    /// A Tag class containing part of a card information
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Create an empty tag
        /// </summary>
        public Tag()
        {
        }

        /// <summary>
        /// Instantiate Tag class containing part of a card information
        /// </summary>
        /// <param name="tagNumber">The Tag number.</param>
        /// <param name="data">The data of the Tag.</param>
        /// <param name="parent">The Tag parent, 0 is it's a root Tag.</param>
        /// <param name="tags">List of Tag that this Tag can contain if it's a constructed one or a template or a DOL.</param>
        public Tag(uint tagNumber, byte[] data, uint parent = 0, List<Tag>? tags = null)
        {
            TagNumber = tagNumber;
            Data = data;
            Parent = parent;
            if (tags is object)
            {
                Tags = tags;
            }
        }

        /// <summary>
        /// The Tag number
        /// </summary>
        public uint TagNumber { get; set; }

        /// <summary>
        /// The data of the Tag
        /// </summary>
        public byte[] Data { get; set; } = new byte[0];

        /// <summary>
        /// The Tag parent, 0 is it's a root Tag
        /// </summary>
        public uint Parent { get; set; }

        /// <summary>
        /// This is used to link the Tag to the corresponding App on the card.
        /// It is the string converted from the bytes of the ApplicationIdentifier Data
        /// </summary>
        public string CorrespondingApplicationIdentifier { get; set; } = string.Empty;

        /// <summary>
        /// True if the Tag is constructed, which means contains sub Tags
        /// A constructed tag is not necessary a template
        /// </summary>
        public bool IsConstructed
        {
            get
            {
                int inc = TagNumber > 0xFF ? 13 : 5;
                return ((TagNumber >> inc) & 0x01) == 0x01;
            }
        }

        /// <summary>
        /// List of Tag that this Tag can contain if it's a constructed one
        /// or a template or a DOL
        /// </summary>
        public List<Tag> Tags { get; set; } = new List<Tag>();

        /// <summary>
        /// Search for a specific tag in a list of Tag including the sub Tags
        /// </summary>
        /// <param name="availableTags">The list of tags to search in</param>
        /// <param name="tagNumberToFind">The tag number to search for</param>
        /// <returns>A list of tags</returns>
        public static List<Tag> SearchTag(IReadOnlyList<Tag> availableTags, uint tagNumberToFind)
        {
            var foundTags = new List<Tag>();

            foreach (var currentTag in availableTags)
            {
               if (currentTag.IsTemplateOrConstructed())
               {
                   var ret = SearchTag(currentTag.Tags, tagNumberToFind);
                   if (ret.Count > 0)
                   {
                       foundTags.AddRange(ret);
                   }
               }

               if (currentTag.TagNumber == tagNumberToFind)
               {
                   foundTags.Add(currentTag);
               }
            }

            return foundTags;
        }
    }
}
