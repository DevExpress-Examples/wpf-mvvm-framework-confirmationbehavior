<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642270/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T122992)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
# WPF MVVM Framework - Show a Confirmation Message Box Before Executing the Specified Command (a ConfirmationBehavior)

The example attaches a command to a [Button](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.button) and enables a confirmation message for the command.

## Overview

Specify the behavior's [Command](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.Command) property to set a command that displays a confirmation message and runs if the user accepts the message.

## Customize a Confirmation Box


| Property | Desciption |
|-|-|
| [Command](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.Command) | Gets or sets the command that runs if the user accepts the confirmation message. This is a dependency property. |
| [CommandPropertyName](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.CommandPropertyName) | Gets or sets a name of an associated control's command property. This is a dependency property. |
| [CommandParameter](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.CommandParameter) | Gets or sets parameters to pass to the [Command](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.Command). This is a dependency property. |
| [EnableConfirmationMessage](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.EnableConfirmationMessage) | Gets or sets whether a confirmation message should be displayed. This is a dependency property. |
| [MessageBoxService](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageBoxService) | Gets or sets a custom message box service. You can use the [WinUIMessageBox](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.WinUIMessageBox) or create a custom message box that implements the [IMessageBoxService](https://docs.devexpress.com/WPF/DevExpress.Mvvm.IMessageBoxService) interface. This is a dependency property. |
| [MessageDefaultResult](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageDefaultResult) | Gets or sets the confirmation message button that should be focused when the message appears. This is a dependency property. |
| [MessageButton](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageButton) | Gets or sets the confirmation message buttons. This is a dependency property. |
| [MessageIcon](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageIcon) | [Gets or sets the confirmation message icon. This is a dependency property. |
| [MessageText](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageText) | [Gets or sets the confirmation message text. This is a dependency property. |
| [MessageTitle](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageTitle) | Gets or sets the confirmation message title. This is a dependency property. |



<!-- default file list --> 
## Files to Look At:
- [MainView.xaml](./CS/View/View/MainView.xaml) (**VB**: [MainView.xaml](./VB/View/MainView.xaml))
- [MainViewMode.cs](./CS/ViewModel/ViewModel/MainViewModel.cs) (**VB**: [MainViewMode.vb](./VB/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [ConfirmationBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
