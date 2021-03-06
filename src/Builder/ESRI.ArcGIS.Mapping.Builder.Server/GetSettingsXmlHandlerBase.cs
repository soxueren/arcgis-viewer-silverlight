/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ESRI.ArcGIS.Mapping.Builder.Server
{
    public abstract class GetSettingsXmlHandlerBase : ServiceRequestHandlerBase
    {
        protected override void HandleRequest()
        {
            Response.Write(GetSettingsXml());
        }

        protected abstract string GetSettingsXml();
    }
}
