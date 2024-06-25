<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642270/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T122992)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF MVVM Framework - Show a Confirmation Message Box Before Executing the Specified Command (a ConfirmationBehavior)

The example attaches a command to a [Button](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.button) and enables a confirmation message for the command. Users can confirm or cancel the operation.

## Overview

Specify the behavior's [Command](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.Command) property to set a command that shows a confirmation message and should be executed if the user confirms the operation.

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
| [MessageIcon](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageIcon) | Gets or sets the confirmation message icon. This is a dependency property. |
| [MessageText](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageText) | Gets or sets the confirmation message text. This is a dependency property. |
| [MessageTitle](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior.MessageTitle) | Gets or sets the confirmation message title. This is a dependency property. |


## Files to Review

- [MainView.xaml](./CS/View/MainView.xaml) (**VB**: [MainView.xaml](./VB/View/MainView.xaml))
- [MainViewMode.cs](./CS/ViewModel/MainViewModel.cs) (**VB**: [MainViewMode.vb](./VB/ViewModel/MainViewModel.vb))


## Documentation

- [ConfirmationBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ConfirmationBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-confirmationbehavior&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-confirmationbehavior&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
