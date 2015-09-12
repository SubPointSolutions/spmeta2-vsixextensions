using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Definitions.Webparts;

namespace M2RootNamespace.Definitions.UI
{
    public static class M2ProjectPrefixWebparts
    {
        // Use WebPartDefinition to define a generic or custom web part
        // One of WebpartType, WebpartXmlTemplate or WebpartFileName needs to be defined
        // http://docs.subpointsolutions.com/spmeta2/definitions/sharepoint-foundation/webpartdefinition

        // SharePoint Foundation web part are defined under 'SPMeta2.Definitions.Webparts'
        // SharePoint Standard web part are under 'SPMeta2.Standard.Definitions.Webparts'

        // Id and Title are to be always defined

        // More information can be found here
        // * WebPartDefinition - http://docs.subpointsolutions.com/spmeta2/definitions/sharepoint-foundation/webpartdefinition
        // * Provision scenarios - http://docs.subpointsolutions.com/spmeta2/scenarios/

        public static ContentEditorWebPartDefinition AboutCompanyContent = new ContentEditorWebPartDefinition
        {
            Title = "About Company",
            Id = "crmAboutCompany",
            Content = "Some nice content about the company"
        };

        public static ContentEditorWebPartDefinition ContactForm = new ContentEditorWebPartDefinition
        {
            Title = "How Tos",
            Id = "crmHowTow",
            ContentLink = "~sitecollection/Style Library/M2ProjectPrefix.Intranet/3rd part/ContactForm/contact-form.html",
        };
    }
}
