using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SPMeta2.Definitions;
using SPMeta2.Syntax.Default;

namespace SPMeta2.VS.CSharp.Extensions
{
    public static class ModelNodeExtensions
    {
        #region methods
        public static SiteModelNode M2ProjectPrefixImportFields(this SiteModelNode node, IEnumerable<FieldDefinition> fields)
        {
            foreach (var field in fields)
                node.AddField(field);

            return node;
        } 

        public static ListModelNode M2ProjectPrefixSetDefaultContentType(this ListModelNode node, ContentTypeDefinition contentType)
        {
           return M2ProjectPrefixSetDefaultContentType(node, contentType.Name);
        }
 
        public static ListModelNode M2ProjectPrefixSetDefaultContentType(this ListModelNode node, string contentTypeName)
        {
           //node.AddUniqueContentTypeFieldOrder(new )

           return node;
        }

        #endregion
    }
}
