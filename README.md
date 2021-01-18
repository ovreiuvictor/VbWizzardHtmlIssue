# VbWizardHtmlIssue
Fix for Wizard VB HTML helper

This is a project example to demonstrate the fix for Kendo WIzard VB HTML helper

Source code for issue: https://github.com/telerik/kendo-ui-core/issues/5986

Do not forget to add the Kendo.Mvc.dll in the appropriate folder

The solve for this issue was added Microsoft.CodeDom.Providers.DotNetCompilerPlatform.3.6.0 from NuGet 
or by manually adding Microsoft.CodeDom.Providers.DotNetCompilerPlatform.3.6.0.dll 
and the <system.codedom> -> <compilers> configuration as you can see in the last rows from web.config
