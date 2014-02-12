using System;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Web.Compilation;
using ResourceReader = HansKindberg.Resources.ResourceReader;

namespace HansKindberg.Web.Compilation
{
	public class TextResourceProvider : IResourceProvider
	{
		#region Fields

		private readonly IDictionary _dictionary;
		private readonly string _path;

		#endregion

		#region Constructors

		public TextResourceProvider(string path)
		{
			this._path = path ?? string.Empty;

			this._dictionary = new Hashtable
				{
					{"TestLabel.Text", "MyText"},
					{"TestLabel.ToolTip", "MyToolTip"}
					//{"MyMetaResourceKey.Text", "MyText"},
					//{"MyMetaResourceKey.ToolTip", "MyToolTip"}
				};
		}

		#endregion

		#region Properties

		protected internal virtual IDictionary Dictionary
		{
			get { return this._dictionary; }
		}

		public virtual IResourceReader ResourceReader
		{
			get { return new ResourceReader(this.Dictionary); }
		}

		#endregion

		#region Methods

		public virtual object GetObject(string resourceKey, CultureInfo culture)
		{
			// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if(resourceKey != null && resourceKey.StartsWith("TestLabel", StringComparison.OrdinalIgnoreCase))
				return this.Dictionary[resourceKey];

			// ReSharper restore ConditionIsAlwaysTrueOrFalse

			return string.Format(CultureInfo.InvariantCulture, "Path = {0}, ResourceKey = {1} & CultureInfo = {2}", this._path, resourceKey, culture);
		}

		#endregion
	}
}