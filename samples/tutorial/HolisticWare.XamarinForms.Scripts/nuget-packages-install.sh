#!/bin/bash

MONO=mono
NUGET=../.nuget/nuget.exe

# http://docs.nuget.org/docs/reference/command-line-reference
# http://community.sharpdevelop.net/blogs/mattward/archive/2011/06/12/InstallingNuGetPackagesOutsideVisualStudio.aspx

PACKAGENAMES=\
"
Xamarin.Forms.Labs
Xamarin.Forms.Labs.Caching.SQLiteNet
Xamarin.Forms.Labs.Services.TinyIOC 
Xamarin.Forms.Labs.Services.Ninject 
Xamarin.Forms.Labs.Services.Unity
Xamarin.Forms.Labs.Services.Serialization.JsonNET
Xamarin.Forms.Labs.Services.Autofac 
"
PROJECTNAMES=\
"
"

for package_name in $PACKAGENAMES
	do
		echo $package_name 
		$MONO --runtime=v4.0.30319 \
			$NUGET install \
				$package_name \
			-OutputDirectory ./packages
done

# for package_name in $PACKAGENAMES
#	do
#		echo $package_name 
#		$MONO --runtime=v4.0.30319 \
#			$NUGET install \
#				./packages.config \
#				-OutputDirectory ./packages
# done


# nuget.exe restore YourSolution.sln
# mono  install ./packages.config -OutputDirectory ./packages