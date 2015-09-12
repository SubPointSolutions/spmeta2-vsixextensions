using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SPMeta2.Definitions;
using SPMeta2.Syntax.Default;
using SPMeta2.Definitions.ContentTypes;

namespace SPMeta2.VS.CSharp.Extensions
{
    public static class ModelNodeExtensions
    {
        // add your project specific extensions here 
        // check how to created them here - http://docs.subpointsolutions.com/spmeta2/extensibility/writing-custom-syntax/

        #region methods

        public static ListModelNode M2ProjectPrefixSetDefaultListContentType(this ListModelNode node, ContentTypeDefinition contentTypeDefinition)
        {
            return M2ProjectPrefixSetDefaultListContentType(node, contentTypeDefinition.Name);
        }

        /// <summary>
        /// Sets content type as a default in the the target list.
        /// </summary>
        /// <param name="node">target list</param>
        /// <param name="contentTypeName">content type name</param>
        /// <returns></returns>
        public static ListModelNode M2ProjectPrefixSetDefaultListContentType(this ListModelNode node, string contentTypeName)
        {
            // do some stuff
            node.AddUniqueContentTypeOrder(new UniqueContentTypeOrderDefinition
            {
                ContentTypes = new List<ContentTypeLinkValue>
                {
                    new ContentTypeLinkValue{ ContentTypeName = contentTypeName }
                }
            });

            // always return the same node, so that fluent API and chaining will be possible
            return node;
        }

        #endregion
    }
}
