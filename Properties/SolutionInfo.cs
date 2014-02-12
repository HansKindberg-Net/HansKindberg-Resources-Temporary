using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Hans Kindberg - open source")]
[assembly: AssemblyConfiguration(
#if DEBUG
	"Debug"
#else
	"Release"
#endif
	)]
#pragma warning disable 436

[assembly: AssemblyFileVersion(SolutionInfo.AssemblyFileVersion)]
[assembly: AssemblyInformationalVersion(SolutionInfo.AssemblyInformationalVersion)]
[assembly: AssemblyProduct(AssemblyInfo.AssemblyName + " " + SolutionInfo.AssemblyInformationalVersion)]
[assembly: AssemblyTitle(AssemblyInfo.AssemblyName + " " + SolutionInfo.AssemblyInformationalVersion)]
[assembly: AssemblyVersion(SolutionInfo.AssemblyVersion)]
#pragma warning restore 436

[assembly: ComVisible(false)]

internal static class SolutionInfo
{
	// When you increase the majorversion: minorversion = 0, buildnumber = 0, revision = 0, fileversionrevision = 0
	// When you increase the minorversion: buildnumber = 0, revision = 0, fileversionrevision = 0
	// When you increase the buildnumber: revision = 0, fileversionrevision = 0
	// Else - foreach change: revision++, fileersionrevision++
	// Else - foreach small fix: fileversionrevision++
	// Note: fileversionrevision should not be less than revision

	#region Fields

	internal const string AssemblyFileVersion = _assemblyBaseVersion + "." + _fileVersionRevision;
	internal const string AssemblyInformationalVersion = _assemblyBaseVersion + "-alpha-" + _revision;
	internal const string AssemblyVersion = _assemblyBaseVersion + "." + _revision;
	private const string _assemblyBaseVersion = _majorVersion + "." + _minorVersion + "." + _buildNumber;
	private const string _buildNumber = "0";
	private const string _fileVersionRevision = "0";
	private const string _majorVersion = "1";
	private const string _minorVersion = "0";
	private const string _revision = "0";

	#endregion
}