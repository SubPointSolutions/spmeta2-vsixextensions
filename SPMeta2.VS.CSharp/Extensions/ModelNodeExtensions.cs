using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.CSharp.Extensions
{
    public static class ModelNodeExtensions
    {
        #region methods
        public static SiteModelNode $M2PrjPrefix$ImportFields(this SiteModelNode node, IEnumerable<FieldDefinition> fields)
        {
            foreach (var field in fields)
                node.AddField(node);

            return node;
        } 

        public static ListModelNode $M2PrjPrefix$SetDefaultContentType(this ListModelNode node, ContentTypeDefinition contentType)
        {
           return $M2PrjPrefix$SetDefaultContentType(node, contentType.Name);
        }
 
        public static ListModelNode $M2PrjPrefix$SetDefaultContentType(this ListModelNode node, string contentTypeName)
        {
           //node.AddUniqueContentTypeFieldOrder(new )

           return node;
        }

        #endregion
    }
}
