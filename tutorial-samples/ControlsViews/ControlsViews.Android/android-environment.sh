# mmoljac# 2014-08-09
# miljenko.cvjetko@xamarin.com

# troubleshooting and debugging support
# http://developer.xamarin.com/guides/android/troubleshooting/troubleshooting/#Android_Debug_Log_Output
# Environment support
# filename is irellevant
# BuildAction:
#     AndroidEnvironment
	
# Structure 
#		*	Key Value Pairs
#			*	Key format:
#				*	uppercase 	Environment Variables		
#					accessed from code Environment.GetEnvironmentVariable(string)
# 				* 	lowercase	Android System Properties 	
#					can be overriden, looked up during startup	
#		*	comments
	
	
# TODO: mc++ comment this stuff
# ENV_VAR=env-value
	
# adb shell setprop debug.mono.log gref
#debug.mono.log=gref
#debug.mono.env=MONO_LOG_LEVEL=debug
	
# http://developer.xamarin.com/guides/android/advanced_topics/environment/
# 
# GC parameters
# http://developer.xamarin.com/guides/android/advanced_topics/garbage_collection/#GC_Bridge_Options
# 
# MONO_GC_PARAMS environment variable is a comma-separated list of the following parameters:
# bridge-implementation= old | new | tarjan
# 
# MONO_GC_PARAMS=soft-heap-limit=128m,bridge-implementation=tarjan
	
# Disable Mono's GC (not actually a good idea)
# GC_DONT_GC=1