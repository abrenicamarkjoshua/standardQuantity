using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace standardquantity
{
    public class INStandardQuantityMaint : PXGraph<INStandardQuantityMaint, INStandardQuantity>
    {
        public PXSelect<INStandardQuantity> StandardQuantity;
    }
}