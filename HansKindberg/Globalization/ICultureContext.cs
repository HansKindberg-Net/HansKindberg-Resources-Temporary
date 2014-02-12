using System.Globalization;

namespace HansKindberg.Globalization
{
	public interface ICultureContext
	{
		#region Properties

		CultureInfo CurrentCulture { get; }
		CultureInfo CurrentUiCulture { get; }

		#endregion
	}
}