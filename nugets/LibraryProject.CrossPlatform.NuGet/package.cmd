.nuget\nuget ^
	pack ^
	"src\SomeClassLibrary\SomeClassLibrary.csproj" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

.nuget\nuget ^
	pack ^
	"src\SomeOtherClassLibrary\SomeOtherClassLibrary.csproj" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive