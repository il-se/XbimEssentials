// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.Kernel
{
	public partial class @IfcRelAssignsToResource : IIfcRelAssignsToResource
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssignsToResource), 7)]
		IIfcResourceSelect IIfcRelAssignsToResource.RelatingResource 
		{ 
			get
			{
				if (RelatingResource == null) return null;
				var ifcresource = RelatingResource as IfcResource;
				if (ifcresource != null) 
					return ifcresource;
				var ifctyperesource = RelatingResource as IfcTypeResource;
				if (ifctyperesource != null) 
					return ifctyperesource;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelatingResource = null;
					return;
				}	
				var ifcresource = value as IfcResource;
				if (ifcresource != null) 
				{
					RelatingResource = ifcresource;
					return;
				}
				var ifctyperesource = value as IfcTypeResource;
				if (ifctyperesource != null) 
				{
					RelatingResource = ifctyperesource;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}