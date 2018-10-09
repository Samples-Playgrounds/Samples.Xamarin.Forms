using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using Xamarin.QuickUI;

namespace Spin2Win
{

	public enum HiddenViewType
	{
		SyncView,
		BackupLog
	}

	public class HiddenUsersPage : ContentPage
	{
		public HiddenUsersPage (HiddenViewType type)
		{
			Title = type == HiddenViewType.SyncView ? "Users have not synced to Azure" : "User Backup Log";

			string path = type == HiddenViewType.SyncView ? "Users.txt" : "BackupUsers.txt";
			List<string> users = BuildTableSource (path);

			var userList = new ListView {
				ItemSource = users
			};

			Content = userList;
		}

		List<string> BuildTableSource (string path)
		{
			var source = new List<string> ();

			Device.OnPlatform (iOS: () => source = GetDataSource (path));
			Device.OnPlatform (Android: () => source = GetDataSource (path));
			Device.OnPlatform (WinPhone: () => source = GetDataSourceWP7 (path));

			return source;
		}

		string ParseLineForReadableFormat (string line)
		{
			return line.Replace ("^", ", ");
		}

		List<string> GetDataSource (string path)
		{
			var result = new List<string> ();
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var filePath = Path.Combine (documents, path);
			if (File.Exists (filePath)) {
				try {
					using (var sr = new StreamReader (filePath)) {
						string line;

						while ((line = sr.ReadLine ()) != null) {
							var readableLine = ParseLineForReadableFormat (line);
							result.Add (readableLine);
						}
					}
				} catch (Exception e) {
					Console.WriteLine ("The file could not be read:");
					Console.WriteLine (e.Message);
				}
			}
			return result;
		}

		List<string> GetDataSourceWP7 (string path)
		{
			var result = new List<string> ();
			var isolatedStream = new IsolatedStorageFileStream (path, FileMode.Open, IsolatedStorageFile.GetUserStoreForApplication ());
			using (var sr = new StreamReader (isolatedStream)) {
				string line;
				while ((line = sr.ReadLine ()) != null) {
					var readableLine = ParseLineForReadableFormat (line);
					result.Add (readableLine);
				}
			}
			return result;
		} 
	}
}