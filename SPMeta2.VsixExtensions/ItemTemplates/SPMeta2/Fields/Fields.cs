using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Fields;
using SPMeta2.Enumerations;

namespace $rootnamespace$
{
    public static class $safeitemname$
    {
        // add your fields here as per following samples

        // SharePoint Foundation fields come under 'SPMeta2.Definitions.Fields' namespace
        // SharePoint Standard+  fields come under 'SPMeta2.Standard.Definitions.Fields' namespace

		#region samples

        //public static TextFieldDefinition OrderName = new TextFieldDefinition
        //{
        //    Id = new Guid("67F1D09B-8149-4AAC-B5A4-2673C72542F7"),
        //    Title = "Order Name",
        //    InternalName = "intr_OrderName",
        //    Group = "_My Intranet",
        //    Required = false,
        //};

        //public static NoteFieldDefinition OrderDescription = new NoteFieldDefinition
        //{
        //    Id = new Guid("E34F3184-2CCD-4F22-AF32-02C6CDBFE4A4"),
        //    Title = "Order Description",
        //    InternalName = "intr_OrderDescription",
        //    Group = "_My Intranet",
        //    Required = false,
        //};

        //public static BooleanFieldDefinition IsOrderActive = new BooleanFieldDefinition
        //{
        //    Id = new Guid("1DFB6100-C157-4AF7-85DB-45E7A30407B6"),
        //    Title = "Is Active",
        //    InternalName = "intr_IsActiveClient",
        //    Group = "_My Intranet",
        //    Required = false,
        //};

        public static ChoiceFieldDefinition OrderAddressState = new ChoiceFieldDefinition
        {
            Id = new Guid("47A2CE86-2446-4C5D-8D50-07DE9365D093"),
            Title = "State",
            InternalName = "intr_OrderAddressState",
            Group = "_My Intranet",
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

        //public static CurrencyFieldDefinition OrderPrice = new CurrencyFieldDefinition
        //{
        //    Id = new Guid("CE537F97-53FD-4D9E-A288-D1C926C80582"),
        //    Title = "Order Price",
        //    InternalName = "intr_OrderPrice",
        //    Group = "_My Intranet",
        //    Required = false,
        //};

        //public static DateTimeFieldDefinition OrderDate = new DateTimeFieldDefinition
        //{
        //    Id = new Guid("F483DF0C-92E8-4811-BAB3-87B3DDD95094"),
        //    Title = "Order Date",
        //    InternalName = "intr_OrderDate",
        //    Group = "_My Intranet",
        //    Required = false
        //};

        //public static GuidFieldDefinition OrderExternalId = new GuidFieldDefinition
        //{
        //    Id = new Guid("5201BA98-FDA6-48DC-8735-5DB55D345FC7"),
        //    Title = "Order External Id",
        //    InternalName = "intr_OrderExernaltId",
        //    Group = "_My Intranet",
        //    Required = false
        //};

        //public static MultiChoiceFieldDefinition OrderType = new MultiChoiceFieldDefinition
        //{
        //    Id = new Guid("6F4C046C-E39F-442B-B0E6-1150E8BF42B4"),
        //    Title = "Order Type",
        //    InternalName = "intr_OrderType",
        //    Group = "_My Intranet",
        //    Required = false,
        //    Choices = new Collection<string>
        //    {
        //        "Gift",
        //        "Trial",
        //        "Commertial"
        //    }
        //};

        //public static NumberFieldDefinition OrderSalePercentage = new NumberFieldDefinition
        //{
        //    Id = new Guid("1C82DCF2-EDE9-4F70-83CF-71D59277296F"),
        //    Title = "Order Sales Percentage",
        //    InternalName = "intr_OrderSales",
        //    Group = "_My Intranet",
        //    Required = false,
        //    DisplayFormat = BuiltInNumberFormatTypes.TwoDecimals
        //};

        //public static URLFieldDefinition OrderTrackingUrl = new URLFieldDefinition
        //{
        //    Id = new Guid("A2F6F17E-67B8-49C5-9F6D-9D47DA601CA6"),
        //    Title = "Order Tracking Url",
        //    InternalName = "intr_OrderTrackingUrl",
        //    Group = "_My Intranet",
        //    Required = false,
        //};

		#endregion
    }
}
