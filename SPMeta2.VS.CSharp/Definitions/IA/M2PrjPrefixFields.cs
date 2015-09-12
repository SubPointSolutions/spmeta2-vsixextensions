using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2RootNamespace.Consts;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Fields;
using SPMeta2.Enumerations;

namespace M2RootNamespace.Definitions.IA
{
    public static class M2ProjectPrefixFields
    {
        /// SharePoint Foundation fields come under 'SPMeta2.Definitions.Fields' namespace
        /// SharePoint Standard+  fields come under 'SPMeta2.Standard.Definitions.Fields' namespace

        public static TextFieldDefinition DocumentHighlights = new TextFieldDefinition
        {
            Id = new Guid("67F1D09B-8149-4AAC-B5A4-2673C72542F7"),
            Title = "Highlights",
            InternalName = "intr_DocumentHighlights",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = true,
        };

        public static NoteFieldDefinition DocumentDescription = new NoteFieldDefinition
        {
            Id = new Guid("F602AB77-7335-4BF1-96D7-7262D307F4A1"),
            Title = "Description",
            InternalName = "intr_DocumentDescription",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = true,
        };

        public static NoteFieldDefinition ProductDescription = new NoteFieldDefinition
        {
            Id = new Guid("E34F3184-2CCD-4F22-AF32-02C6CDBFE4A4"),
            Title = "Product Description",
            InternalName = "intr_ProductDescription",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };

        public static BooleanFieldDefinition IsProductActive = new BooleanFieldDefinition
        {
            Id = new Guid("1DFB6100-C157-4AF7-85DB-45E7A30407B6"),
            Title = "Is Active",
            InternalName = "intr_IsProductActive",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };

        public static ChoiceFieldDefinition OrderAddressState = new ChoiceFieldDefinition
        {
            Id = new Guid("47A2CE86-2446-4C5D-8D50-07DE9365D093"),
            Title = "State",
            InternalName = "intr_OrderAddressState",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
            Choices = new Collection<string>
            {
               "NSW",
               "QLD",
               "SA",
               "TAS",
               "VIC",
               "WA",
               "ACT",
               "NT"
            }
        };

        public static CurrencyFieldDefinition OrderPrice = new CurrencyFieldDefinition
        {
            Id = new Guid("CE537F97-53FD-4D9E-A288-D1C926C80582"),
            Title = "Order Price",
            InternalName = "intr_OrderPrice",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };

        public static DateTimeFieldDefinition OrderDate = new DateTimeFieldDefinition
        {
            Id = new Guid("F483DF0C-92E8-4811-BAB3-87B3DDD95094"),
            Title = "Order Date",
            InternalName = "intr_OrderDate",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false
        };

        public static MultiChoiceFieldDefinition ProductType = new MultiChoiceFieldDefinition
        {
            Id = new Guid("6F4C046C-E39F-442B-B0E6-1150E8BF42B4"),
            Title = "Product Type",
            InternalName = "intr_ProductType",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
            Choices = new Collection<string>
            {
                "Product",
                "Service",
                "Leasing"
            }
        };

        public static NumberFieldDefinition OrderSalePercentage = new NumberFieldDefinition
        {
            Id = new Guid("1C82DCF2-EDE9-4F70-83CF-71D59277296F"),
            Title = "Order Sales Percentage",
            InternalName = "intr_OrderSales",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
            DisplayFormat = BuiltInNumberFormatTypes.TwoDecimals
        };

        public static URLFieldDefinition OrderTrackingUrl = new URLFieldDefinition
        {
            Id = new Guid("A2F6F17E-67B8-49C5-9F6D-9D47DA601CA6"),
            Title = "Order Tracking Url",
            InternalName = "intr_OrderTrackingUrl",
            Group = M2ProjectPrefixConsts.DefaultSiteFieldsGroup,
            Required = false,
        };
    }
}
