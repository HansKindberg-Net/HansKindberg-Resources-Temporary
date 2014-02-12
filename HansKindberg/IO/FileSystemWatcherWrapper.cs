using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace HansKindberg.IO
{
	[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "This is a wrapper.")]
	public class FileSystemWatcherWrapper : IFileSystemWatcher
	{
		#region Fields

		private readonly FileSystemWatcher _fileSystemWatcher;

		#endregion

		#region Constructors

		public FileSystemWatcherWrapper(FileSystemWatcher fileSystemWatcher)
		{
			if(fileSystemWatcher == null)
				throw new ArgumentNullException("fileSystemWatcher");

			this._fileSystemWatcher = fileSystemWatcher;
		}

		#endregion

		#region Events

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event FileSystemEventHandler Changed
		{
			add { this.FileSystemWatcher.Changed += value; }
			remove { this.FileSystemWatcher.Changed -= value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event FileSystemEventHandler Created
		{
			add { this.FileSystemWatcher.Created += value; }
			remove { this.FileSystemWatcher.Created -= value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event FileSystemEventHandler Deleted
		{
			add { this.FileSystemWatcher.Deleted += value; }
			remove { this.FileSystemWatcher.Deleted -= value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event EventHandler Disposed
		{
			add { this.FileSystemWatcher.Disposed += value; }
			remove { this.FileSystemWatcher.Disposed -= value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event ErrorEventHandler Error
		{
			add { this.FileSystemWatcher.Error += value; }
			remove { this.FileSystemWatcher.Error -= value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual event RenamedEventHandler Renamed
		{
			add { this.FileSystemWatcher.Renamed += value; }
			remove { this.FileSystemWatcher.Renamed -= value; }
		}

		#endregion

		#region Properties

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual bool EnableRaisingEvents
		{
			get { return this.FileSystemWatcher.EnableRaisingEvents; }
			set { this.FileSystemWatcher.EnableRaisingEvents = value; }
		}

		protected internal virtual FileSystemWatcher FileSystemWatcher
		{
			get { return this._fileSystemWatcher; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual string Filter
		{
			get { return this.FileSystemWatcher.Filter; }
			set { this.FileSystemWatcher.Filter = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual bool IncludeSubdirectories
		{
			get { return this.FileSystemWatcher.IncludeSubdirectories; }
			set { this.FileSystemWatcher.IncludeSubdirectories = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual int InternalBufferSize
		{
			get { return this.FileSystemWatcher.InternalBufferSize; }
			set { this.FileSystemWatcher.InternalBufferSize = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual NotifyFilters NotifyFilter
		{
			get { return this.FileSystemWatcher.NotifyFilter; }
			set { this.FileSystemWatcher.NotifyFilter = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual string Path
		{
			get { return this.FileSystemWatcher.Path; }
			set { this.FileSystemWatcher.Path = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual ISite Site
		{
			get { return this.FileSystemWatcher.Site; }
			set { this.FileSystemWatcher.Site = value; }
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual ISynchronizeInvoke SynchronizingObject
		{
			get { return this.FileSystemWatcher.SynchronizingObject; }
			set { this.FileSystemWatcher.SynchronizingObject = value; }
		}

		#endregion

		#region Methods

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual void BeginInit()
		{
			this.FileSystemWatcher.BeginInit();
		}

		[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "This is a wrapper.")]
		[SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "This is a wrapper.")]
		public virtual void Dispose()
		{
			this.FileSystemWatcher.Dispose();
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual void EndInit()
		{
			this.FileSystemWatcher.EndInit();
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
		{
			return this.FileSystemWatcher.WaitForChanged(changeType);
		}

		[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Justification = "This is a wrapper.")]
		public virtual WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
		{
			return this.FileSystemWatcher.WaitForChanged(changeType, timeout);
		}

		#endregion
	}
}