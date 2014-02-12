using System.Web.Compilation;

namespace HansKindberg.Web.Compilation
{
	public class ResourceProviderFactory : System.Web.Compilation.ResourceProviderFactory
	{
		#region Fields

		private readonly System.Web.Compilation.ResourceProviderFactory _resourceProviderFactory = new TextResourceProviderFactory();

		#endregion

		#region Methods

		public override IResourceProvider CreateGlobalResourceProvider(string classKey)
		{
			return this._resourceProviderFactory.CreateGlobalResourceProvider(classKey);
		}

		public override IResourceProvider CreateLocalResourceProvider(string virtualPath)
		{
			return this._resourceProviderFactory.CreateLocalResourceProvider(virtualPath);
		}

		#endregion
	}
}