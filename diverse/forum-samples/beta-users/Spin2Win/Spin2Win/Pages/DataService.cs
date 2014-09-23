using System;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using Xamarin.QuickUI;

namespace Spin2Win
{
	public class DataService
	{

		bool Connected { get; set; }

		public void WriteUserData (Person person)
		{
			WriteToLocalSyncFile (person);
			WriteToBackupLog (person);
		}

		void WriteToLocalSyncFile (Person person)
		{
			Debug.WriteLine ("Writing to sync...");
			string entry = person.FormatForWriting ();

			Device.OnPlatform (Android: () => WriteSync (entry));
			Device.OnPlatform (iOS: () => WriteBackup (entry));
			Device.OnPlatform (WinPhone: () => WriteSyncWP7 (entry));
		}

		void WriteSync (string line)
		{
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
 			var filePath = Path.Combine (documents, "Users.txt");

			using (StreamWriter streamWriter = File.AppendText (filePath)) {
				streamWriter.WriteLine (line);
			}

		}

		void WriteSyncWP7 (string line)
		{
			var fileStream = new IsolatedStorageFileStream ("Users.txt", FileMode.OpenOrCreate, IsolatedStorageFile.GetUserStoreForApplication ());
			using (var sw = new StreamWriter (fileStream)) {
				sw.WriteLine (line);
			}
		}

		void WriteToBackupLog (Person person)
		{
			Debug.WriteLine ("Writing to backup...");
			string entry = person.FormatForWriting ();

			Device.OnPlatform (Android: () => WriteBackup (entry));
			Device.OnPlatform (iOS: () => WriteBackup (entry));
			Device.OnPlatform (WinPhone: () => WriteBackupWP7 (entry));
		}

		void WriteBackup (string line)
		{		
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var filePath = Path.Combine (documents, "BackupUsers.txt");

			using (StreamWriter sw = File.AppendText (filePath)) {
				sw.WriteLine (line);
			}
		}

		void WriteBackupWP7 (string line)
		{
			var fileStream = new IsolatedStorageFileStream("BackupUsers.txt", FileMode.Append, IsolatedStorageFile.GetUserStoreForApplication ());
			using (StreamWriter sw = new StreamWriter (fileStream)) {
				sw.WriteLine (line);
			}
		}
	}

}