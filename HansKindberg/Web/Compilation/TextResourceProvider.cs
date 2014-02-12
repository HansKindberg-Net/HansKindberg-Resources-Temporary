using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Resources;
using System.Web.Compilation;

namespace HansKindberg.Web.Compilation
{
	public class TextResourceProvider : IResourceProvider, IImplicitResourceProvider
	{
		#region Fields

		private IDictionary<string, ICollection> _implicitResources;
		private readonly string _path;

		#endregion

		#region Constructors

		public TextResourceProvider(string path)
		{
			this._path = path ?? string.Empty;
		}

		#endregion

		#region Properties

		protected internal virtual IDictionary<string, ICollection> ImplicitResources
		{
			get
			{
				if(this._implicitResources == null)
				{
					this._implicitResources = new Dictionary<string, ICollection>(StringComparer.OrdinalIgnoreCase)
						{
							{"TestLabel", new Collection<ImplicitResourceKey> {new ImplicitResourceKey(string.Empty, "/hej/hopp/TestLabel", "Text"), new ImplicitResourceKey(string.Empty, "/hej/hopp/TestLabel", "ToolTip")}}
						};
				}
				return this._implicitResources;
			}
		}

		public virtual IResourceReader ResourceReader
		{
			get { throw new NotSupportedException(); }
		}

		#endregion

		#region Methods

		public virtual ICollection GetImplicitResourceKeys(string keyPrefix)
		{
			if(!this.ImplicitResources.ContainsKey(keyPrefix))
				return null;

			return this.ImplicitResources[keyPrefix];
		}

		public virtual object GetObject(string resourceKey, CultureInfo culture)
		{
			return string.Format(CultureInfo.InvariantCulture, "Path = {0}, ResourceKey = {1} & CultureInfo = {2}", this._path, resourceKey, culture);
		}

		public virtual object GetObject(ImplicitResourceKey key, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}