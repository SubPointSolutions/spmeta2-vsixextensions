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

        /// <summary>
        /// Base document content type for all company documents.
        /// </summary>
        public static ContentTypeDefinition CompanyDocument = new ContentTypeDefinition
        {
            Name = "Company Document",
            Id = new Guid("7D657561-EB04-4BC7-BD31-B2C57F7E23CD"),
            ParentContentTypeId = BuiltInContentTypeId.Document,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// CProposal the 'base' document - use .GetContentTypeId() method
        /// </summary>
        public static ContentTypeDefinition SalesProposal = new ContentTypeDefinition
        {
            Name = "Sales Proposal",
            Id = new Guid("C012D6B2-3901-4E1A-A256-3079178F6305"),
            ParentContentTypeId = CompanyDocument.GetContentTypeId(),
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        ///  on the 'base' document - use .GetContentTypeId() method
        /// </summary>
        public static ContentTypeDefinition ProductDocument = new ContentTypeDefinition
        {
            Name = "Product Document",
            Id = new Guid("C012D6B2-3901-4E1A-A256-3079178F6305"),
            ParentContentTypeId = CompanyDocument.GetContentTypeId(),
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        public static ContentTypeDefinition OrderDocument = new ContentTypeDefinition
        {
            Name = "Order Document",
            Id = new Guid("485F1B79-122F-4AA3-AD42-31711977BBBE"),
            ParentContentTypeId = BuiltInContentTypeId.Item,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        public static ContentTypeDefinition ProductOrService = new ContentTypeDefinition
        {
            Name = "Product or Service",
            Id = new Guid("425E1307-5965-47D6-A570-58B039247A4D"),
            ParentContentTypeId = BuiltInContentTypeId.Item,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };

        /// <summary>
        /// Custom company event
        /// </summary>
        public static ContentTypeDefinition SaleEvents = new ContentTypeDefinition
        {
            Name = "Sale Events",
            Id = new Guid("0F014C82-DD84-4678-8E32-1E07EBAE69BD"),
            ParentContentTypeId = BuiltInContentTypeId.Event,
            Group = M2ProjectPrefixConsts.DefaultSiteContentTypesGroup
        };
    }
}
