/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.Mapping.Core;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ESRI.ArcGIS.Mapping.Core")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Esri")]
[assembly: AssemblyProduct("ESRI.ArcGIS.Mapping.Core")]
[assembly: AssemblyCopyright("Copyright © Esri 2010-2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//Default prefixes
//core
[assembly: System.Windows.Markup.XmlnsDefinition(Constants.esriMappingNamespace, "ESRI.ArcGIS.Mapping.Core")]
[assembly: System.Windows.Markup.XmlnsPrefix(Constants.esriMappingNamespace, Constants.esriMappingPrefix)]
//symbols
[assembly: System.Windows.Markup.XmlnsDefinition(Constants.esriMappingNamespace, "ESRI.ArcGIS.Mapping.Core.Symbols")]
[assembly: System.Windows.Markup.XmlnsPrefix(Constants.esriMappingNamespace, Constants.esriMappingPrefix)]
