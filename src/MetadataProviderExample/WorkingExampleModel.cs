using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetadataProviderExample
{
    public class WorkingExampleModel
    {

        private DateTime dateField = DateTime.Now;

        [Example]
        public DateTime DateField
        {
            get
            {
                return dateField;
            }

            set
            {
                dateField = value;
            }
        }
    }
}
