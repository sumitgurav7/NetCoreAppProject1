using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAppProject1.Interface;

namespace NetCoreAppProject1
{
    static class ExtendingIAllStudent
    {
        public static int CountElements(this IDisplayAll displayAll)
        {
            
            return displayAll.DisplayAllStudent().Count;
        }
    }
}
