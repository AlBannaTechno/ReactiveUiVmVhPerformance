# Describe a performance issue when using both [reactiveUi](https://github.com/reactiveui/reactiveui) and [HandControl](https://github.com/HandyOrg/HandyControl)

 #### This repo created firstly for [This StackOverflow Question](https://stackoverflow.com/questions/60887258/reactiveui-validation-does-not-raise-error-notification-and-failed-to-bindvalida/61019825#61019825)
 
 #### Also Related To This [HandyControl Issue](https://github.com/HandyOrg/HandyControl/issues/383)
 But i found a big problem in my tests, `All of tests done with HandyControl Library` i used this library without reactiveUi without no problems
 So i does not expect to see any problem from it when using reactiveUi, but the problem occure 
 And I understand that, when i just ommit line `<hc:Theme Name="HandyTheme" xmlns:hc="https://handyorg.github.io/handycontrol" />`, yes stop using HandyControl just fix the problem
 
 #### App.xaml
 ```
 <Application x:Class="ReactiveUiVmVhPerformance.App" xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" xmlns:local="clr-namespace:ReactiveUiVmVhPerformance"
             xmlns:reactiveUi="http://reactiveui.net"
             StartupUri="MainWindow.xaml">
  <Application.Resources>
    <ResourceDictionary>
      <ResourceDictionary.MergedDictionaries>
		  <!-- TODO: Just comment next line To See How This UI Will be very fast without handy control-->
	      <hc:Theme Name="HandyTheme" xmlns:hc="https://handyorg.github.io/handycontrol" />
      </ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
  </Application.Resources>
</Application>
 ```

#### In Nutshell: poor performance comes from HandyControl Library not from reactiveUi, or it is something need to fix in reactiveUi to work with HC or fixs need in booth Repositories 
