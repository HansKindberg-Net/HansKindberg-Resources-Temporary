using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace HansKindberg.IO
{
	public interface IFileSystemWatcher : IComponent, ISupportInitialize
	{
		#region Events

		event FileSystemEventHandler Changed;
		event FileSystemEventHandler Created;
		event FileSystemEventHandler Deleted;

		[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Error")]
		event ErrorEventHandler Error;

		event RenamedEventHandler Renamed;

		#endregion

		#region Properties

		bool EnableRaisingEvents { get; set; }
		string Filter { get; set; }
		bool IncludeSubdirectories { get; set; }
		int InternalBufferSize { get; set; }
		NotifyFilters NotifyFilter { get; set; }
		string Path { get; set; }
		ISynchronizeInvoke SynchronizingObject { get; set; }

		#endregion

		#region Methods

		WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);
		WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);

		#endregion
	}
}