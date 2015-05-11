using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.ModelBinding.Metadata;
using Microsoft.Framework.Internal;

namespace MetadataProviderExample
{
    public class ExampleMetadataProvider : IDisplayMetadataProvider
    {
        public void GetDisplayMetadata(DisplayMetadataProviderContext context)
        {
            var ExampleAttributeIfExists = context.Attributes.OfType<ExampleAttribute>().FirstOrDefault();

            if (ExampleAttributeIfExists != null)
            {
                context.DisplayMetadata.AdditionalValues.Add("DidItWork", true);
            }
        }
    }
}
