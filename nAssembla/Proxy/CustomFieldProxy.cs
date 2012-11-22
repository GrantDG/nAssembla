using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class CustomFieldProxy : ProxyReadOnlyBase<DTO.CustomField>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "tickets", "custom_fields" };
            }
        }


        internal override bool DataIsCachable
        {
            get { return true; }
        }

        
      
    }
}