X4QU - Xaml for (Xamarin) QuickUI
=================================

Get Started.
------------

Say we want to create a `CustomPage` inheriting from `ContentPage`

 1. Create some xaml. 

    First, we'll create the page in xaml, like this:
 
        <ContentPage 
          xmlns="http://xamarin.com/quickui"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          x:Class="X4QU.Sample.CustomPage">
          <ContentPage.Content>
            <StackLayout Id="Stack" Orientation="Vertical">
              <Label Text="Hello" Id="Label0"/>
              <Label Text="Xaml" Id="Label1">
            </StackLayout>
          </ContentPage.Content>
        </ContentPage>
 
    Some stuffs to notice:
    
     1. the toplevel element is <ContentPage> which is our base class
     2. `x:Class` is the full name of our class
     3. you **have** to use <ContentPage.Content> to set the Content property of the page, as there's no ContentPropertyAttribute equivalent in X.QuickUI
     4. collections are easy. you don't have to use `<StackLayout.Children>` (which won't work, as it's readonly)
     5. Setting an `Id` will generate a field of the same name and type accessible from code
 
    Add this file to your project as `EmbeddedResource`
 
 2. Create the class

    Create your class skeleton
 
        using System;
        using Xamarin.QuickUI;

        namespace X4QU.Sample
        {
	        public partial class CustomPage : ContentPage
	        {
		        public CustomPage ()
		        {
			        InitializeComponent ();
			    }
			}
        }
    
     The name of this class is irrelevant, by I name if CutomPage.xaml.cs

 3. Generate the xaml.g.cs
 
    Use `mono xamlg.exe CustomPage.xaml` to generate `CustomPage.xaml.g.cs`
 
And you're all set

Bindings
--------
Those syntaxes are supported:

    <Label Text="{Binding MyPropertyPath}"/>
    <Label Text="{Binding Path=MyPropertyPath}"/>

This syntax is NOT supported (as the xaml parser require a parameterless ctor, and Binding doesn't have one.

    <Label>
      <Label.Text>
        <Binding Path="MyPropertyPath">
      </Label.Text>
    </Label>

`Converter`, `Mode`, ... are NOT YET handled

ListView, Cells and Templates
-----------------------------

    <ContentPage 
        xmlns="http://xamarin.com/quickui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:X4QU="clr-namespace:X4QU.Extensions;assembly=X4QU"
        x:Class="X4QU.Sample.CustomPage">
      <ContentPage.Content>
        <ListView ItemSource="{Binding Items}">
          <ListView.Template>
            <X4QU:TextCellTemplate TextCell.Text="{Binding Name}" TextCell.Detail="{Binding Title}" />
          </ListView.Template>
        </ListView>
      </ContentPage.Content>
    </ContentPage>

Note: there's a new assembly to reference, declaring a TextCellTemplate class, which is only a `CellTemplate(typeof(TextCell))`

Resources and StaticResources bindings
--------------------------------------
Let's start by the example

    <ContentPage 
      xmlns="http://xamarin.com/quickui"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:X4QU="clr-namespace:X4QU;assembly=X4QU"
      xmlns:local="clr-namespace:X4QU.Sample;assembly=X4QUSample"
      x:Class="X4QU.Sample.CustomPage">
      <ContentPage.Resources>
        <X4QU:ResourceDictionary>
          <local:ReverseConverter x:Key="reverseConverter"/>
        </X4QU:ResourceDictionary>
      </ContentPage.Resources>
      <ContentPage.Content>
        <Label Text="{Binding Path=LabelBinding,Converter={StaticResource reverseConverter}}"/>
      </ContentPage.Content>  
    </ContentPage>

Some remarks:

 1. `ResourceDictionary` si define in x4QU
 2. we set the `Resources` property of `ContentPage`. This is a hack, there's no such property
 3. only define a single resourcedictionary per xaml, at the toplevel element for now. Or behavior is not guaranteed.
 4. you can't set both `Mode` and `Converter` in a Binding. If you do both, it'll take the `Mode` and ignore the `Converter`
 5. Case is important, in Bindings strings like everywhere else

TODO
----
 -

Features requests in Xamarin.QuickUI
------------------------------------
 - TypeConverterAttribute
 - ContentPropertyAttribute
