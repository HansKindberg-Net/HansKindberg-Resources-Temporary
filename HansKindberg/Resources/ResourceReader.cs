using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Resources;

namespace HansKindberg.Resources
{
	[SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")]
	[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
	public class ResourceReader : IResourceReader
	{
		#region Fields

		private readonly IDictionary _dictionary;

		#endregion

		#region Constructors

		public ResourceReader(IDictionary dictionary)
		{
			if(dictionary == null)
				throw new ArgumentNullException("dictionary");

			this._dictionary = dictionary;
		}

		#endregion

		#region Properties

		protected internal virtual IDictionary Dictionary
		{
			get { return this._dictionary; }
		}

		#endregion

		#region Methods

		public virtual void Close()
		{
			this.Dispose();
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing) {}

		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return this.Dictionary.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		#endregion
	}
}