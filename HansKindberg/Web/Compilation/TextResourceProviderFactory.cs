using System.Web.Compilation;

namespace HansKindberg.Web.Compilation
{
	public class TextResourceProviderFactory : System.Web.Compilation.ResourceProviderFactory
	{
		#region Methods

		public override IResourceProvider CreateGlobalResourceProvider(string classKey)
		{
			return new TextResourceProvider(classKey);
		}

		public override IResourceProvider CreateLocalResourceProvider(string virtualPath)
		{
			return new TextResourceProvider(virtualPath);
		}

		#endregion

		//// Fields
		//private static ResourceProviderFactory _fallbackProviderFactory;
		//// Methods
		//public override IResourceProvider CreateGlobalResourceProvider(string classKey)
		//{
		//	if (string.Compare(classKey, "EPiServer", StringComparison.OrdinalIgnoreCase) == 0)
		//	{
		//		return new LocalizationServiceResourceProvider(classKey);
		//	}
		//	return FallbackProviderFactory.CreateGlobalResourceProvider(classKey);
		//}
		//public override IResourceProvider CreateLocalResourceProvider(string virtualPath)
		//{
		//	return FallbackProviderFactory.CreateLocalResourceProvider(virtualPath);
		//}
		//// Properties
		//public static ResourceProviderFactory FallbackProviderFactory
		//{
		//	get
		//	{
		//		if (_fallbackProviderFactory == null)
		//		{
		//			Type type = Assembly.GetAssembly(typeof(ResourceProviderFactory)).GetType("System.Web.Compilation.ResXResourceProviderFactory");
		//			if (type == null)
		//			{
		//				throw new NotSupportedException("The current ASP.NET version is not supported as it does not contain the class 'System.Web.Compilation.ResXResourceProviderFactory' that is used as a fallback resource provider factory.");
		//			}
		//			_fallbackProviderFactory = (ResourceProviderFactory)Activator.CreateInstance(type);
		//		}
		//		return _fallbackProviderFactory;
		//	}
		//}
	}
}