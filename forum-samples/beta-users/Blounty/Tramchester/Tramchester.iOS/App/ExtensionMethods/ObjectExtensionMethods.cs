using System;
using System.Threading.Tasks;
using System.Threading;

namespace System
{
	public static class ObjectExtensionMethods
	{
		public static void RunOnMainThread(this object view, Action action)
		{
			Task.Factory.StartNew (action,CancellationToken.None, TaskCreationOptions.None , TaskScheduler.FromCurrentSynchronizationContext ());
		}
	}
}

