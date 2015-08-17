using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Consts;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Fields;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixFields
    {
        public static TextFieldDefinition ClientName = new TextFieldDefinition
        {
            Id = new Guid("67F1D09B-8149-4AAC-B5A4-2673C72542F7"),
            Title = "Client Name",
            InternalName = "intr_ClientName",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };

        public static NoteFieldDefinition ClientDescription = new NoteFieldDefinition
        {
            Id = new Guid("E34F3184-2CCD-4F22-AF32-02C6CDBFE4A4"),
            Title = "Client Description",
            InternalName = "intr_ClientName",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };

        
    }
}
