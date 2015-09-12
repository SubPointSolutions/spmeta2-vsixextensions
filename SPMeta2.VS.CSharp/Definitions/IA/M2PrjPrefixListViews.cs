using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Syntax.Default;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixListViews
    {
        // add your list views here as per following samples

        // Use BuiltInInternalFieldNames and BuiltInInternalPublishingFieldNames to refer OOTB SharePoint fields
        // Always use internal name in the 'Fields' props, that's how list views work
        // Use 'Query' prop to define correct caml query

        public static ListViewDefinition LastTenDocuments = new ListViewDefinition
        {
            Title = "Last 10 Documents",
            RowLimit = 10,
            Fields = new Collection<string>
            {
                
                BuiltInInternalFieldNames.DocIcon,
                BuiltInInternalFieldNames.LinkFilename,
                BuiltInInternalFieldNames.Editor,
                BuiltInInternalFieldNames._UIVersionString,
                BuiltInInternalFieldNames.ContentType
            }
        };

        public static ListViewDefinition LastTenTasks = new ListViewDefinition
        {
            Title = "Last 10 Tasks",
            RowLimit = 10,
            Fields = new Collection<string>
            {
                BuiltInInternalFieldNames.LinkFilename,
                BuiltInInternalFieldNames.Editor,
                BuiltInInternalFieldNames._UIVersionString,
                BuiltInInternalFieldNames.ContentType
            }
        };
    }
}
