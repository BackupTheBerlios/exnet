using System;
using System.Reflection;
using System.Globalization;
using System.Resources;
using System.Data;
using System.Collections.Generic;
using System.Threading;

namespace Resources
{
	[Serializable]
	public class Function
	{
		private ResourceManager _rm;
		private CultureInfo [] _cultures;
		private CultureInfo _ci;
		
		public Function ()
		{
			_rm = new ResourceManager("Resources.GuiLogin",Assembly.GetExecutingAssembly());
			_cultures = GetInstalledCultures();
		}
						
		public CultureInfo [] Cultures
		{
			get	{
				return _cultures;}
		}
		
		public CultureInfo Culture
		{
			get{
				if(_ci == null)
				{
					_ci = Thread.CurrentThread.CurrentCulture;					
				}
				return _ci;}
			
			set	{
				_ci = value;
			}
		}
		
		private CultureInfo [] GetInstalledCultures()
		{
			ResourceSet rs;
			List<CultureInfo> uc = new List<CultureInfo>();
			
			foreach (CultureInfo ci in  CultureInfo.GetCultures(CultureTypes.NeutralCultures))
			{
				rs = _rm.GetResourceSet(ci,true,false);				
				if( rs != null ){
					uc.Add(ci);
				}
			}		
			return uc.ToArray();
		} 
		
		public string Translate(String resource)
		{
			return _rm.GetString(resource, Culture);			
		}
	}
}
