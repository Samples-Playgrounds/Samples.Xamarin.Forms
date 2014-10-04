quickui-beta
============

QuickUI Beta User Demo Apps

## Issues


### Windows Phone

##### Error

`
	Error	5	
	The OutputPath property is not set for project 'ControlsViews.csproj'.  
	Please check to make sure that you have specified a valid combination of Configuration and Platform 
	for this project.  Configuration='Debug'  Platform='x86'.  This error may also appear if some other 
	project is trying to follow a project-to-project reference to this project, this project has been 
	unloaded or is not included in the solution, and the referencing project does not build using the 
	same or an equivalent Configuration or Platform.	
	C:\Program Files (x86)\MSBuild\12.0\bin\Microsoft.Common.CurrentVersion.targets	617	5	
	ControlsViews.WinPhone

`

##### Analysis

ControlsViews.WinPhone was unloaded because of editing. Reload project


#### Failed Navigation

Exception in RootFrame_NavigationFailed

	private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
		{
			if (Debugger.IsAttached)
			{
				// A navigation has failed; break into the debugger
				Debugger.Break();
			}
		}
		
		
##### Analysis

Exception data:

`
	sender = {System.Windows.Navigation.NavigationService}

	NavigationFailedEventArgs e = 

		Exception: {System.Reflection.TargetInvocationException: 
		Exception has been thrown by the target of an invocation. ---> System.IO.FileLoadException: 
		Could not load file or assembly 'Xamarin.Forms.Core, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null' 
		or one of its dependencies. 
		The located assembly's manifest definition does not match the assembly reference. 
		(Exception from HRESULT: 0x80131040)
			at Layouts.WinPhone.MainPage..ctor()
			--- End of inner exception stack trace ---
			at System.Windows.Navigation.PageResourceContentLoader.EndLoad(IAsyncResult asyncResult)
			at System.Windows.Navigation.NavigationService.ContentLoader_BeginLoad_Callback(IAsyncResult result)}

	InnerException

		Could not load file or assembly 'Xamarin.Forms.Core, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null' 
		or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. 
		(Exception from HRESULT: 0x80131040)  
`	
   
 ##### [Re]Solution
 
1.	Check latest Xamarin forms version in packages/ folder (NuGet)
2.	Use latest version in all csproj files (Windows Phone expecially)
	1.	edit all csproj files by 		
		replacing in paths 		
		..\..\packages\Xamarin.Forms.1.0.6186\		
		with		
		..\..\packages\Xamarin.Forms.1.2.2.6243\