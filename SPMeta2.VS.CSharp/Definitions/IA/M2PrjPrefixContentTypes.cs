using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Syntax.Default;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixContentTypes
    {
        // add your content types here as per following samples

        public static ContentTypeDefinition IntranetItem = new ContentTypeDefinition
        {
            Name = "My Intranet Item",
            Id = new Guid("485F1B79-122F-4AA3-AD42-31711977BBBE"),
            ParentContentTypeId = BuiltInContentTypeId.Item,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// Base content type for all documents.
        /// </summary>
        public static ContentTypeDefinition IntranetDocument = new ContentTypeDefinition
        {
            Name = "My Intranet Document",
            Id = new Guid("7D657561-EB04-4BC7-BD31-B2C57F7E23CD"),
            ParentContentTypeId = BuiltInContentTypeId.Document,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// Custom contract based on the 'base' document - use .GetContentTypeId() method
        /// </summary>
        public static ContentTypeDefinition IntranetContract = new ContentTypeDefinition
        {
            Name = "My Intranet Contract",
            Id = new Guid("813C16F4-70B1-4978-867A-1497936D4881"),
            ParentContentTypeId = IntranetDocument.GetContentTypeId(),
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// Custom order based on the 'base' document - use .GetContentTypeId() method
        /// </summary>
        public static ContentTypeDefinition IntranetOrder = new ContentTypeDefinition
        {
            Name = "My Intranet Order",
            Id = new Guid("C012D6B2-3901-4E1A-A256-3079178F6305"),
            ParentContentTypeId = IntranetDocument.GetContentTypeId(),
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// Custom event
        /// </summary>
        public static ContentTypeDefinition IntranetEvent = new ContentTypeDefinition
        {
            Name = "My Intranet Event",
            Id = new Guid("0F014C82-DD84-4678-8E32-1E07EBAE69BD"),
            ParentContentTypeId = BuiltInContentTypeId.Event,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };
    }
}
