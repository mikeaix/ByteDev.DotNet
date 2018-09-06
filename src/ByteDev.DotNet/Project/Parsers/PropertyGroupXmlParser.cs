﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ByteDev.DotNet.Project.Parsers
{
    internal class PropertyGroupXmlParser
    {
        public static XElement GetOldStyleTargetFrameworkElement(IEnumerable<XElement> propertyGroups)
        {
            const string name = "TargetFrameworkVersion";

            return propertyGroups.SingleOrDefault(pg => pg.Elements().FirstOrDefault()?.Name.LocalName == name)?
                .Elements()
                .SingleOrDefault(pg => pg.Name.LocalName == name);
        }

        public static XElement GetNewStyleTargetFrameworkElement(IEnumerable<XElement> propertyGroups)
        {
            const string name = "TargetFramework";

            return propertyGroups.SingleOrDefault(pg => pg.Elements().FirstOrDefault()?.Name.LocalName == name)?
                .Elements()
                .SingleOrDefault(pg => pg.Name.LocalName == name);
        }
    }
}