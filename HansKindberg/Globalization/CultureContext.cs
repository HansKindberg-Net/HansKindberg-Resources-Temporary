using System.Globalization;

namespace HansKindberg.Globalization
{
	public class CultureContext : ICultureContext
	{
		#region Properties

		public virtual CultureInfo CurrentCulture
		{
			get { return CultureInfo.CurrentCulture; }
		}

		public virtual CultureInfo CurrentUiCulture
		{
			get { return CultureInfo.CurrentUICulture; }
		}

		#endregion
	}
}