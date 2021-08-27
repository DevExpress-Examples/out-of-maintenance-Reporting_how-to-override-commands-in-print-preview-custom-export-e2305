<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602041/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2305)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/OverridePreviewCommands/Form1.cs) (VB: [Form1.vb](./VB/OverridePreviewCommands/Form1.vb))
<!-- default file list end -->
# How to override commands in Print Preview - Custom export


<p>This example demonstrates how to override the Print Preview command that exports a report document to an image file. This can be useful, for example, if it's necessary to silently save a report to the predefined location on a disk, using the predefined image format settings, and if no interaction with an end-user is required.</p><p>To implement this task you should handle the <strong>XtraPrinting.PrintingSystemCommand.ExportGraphic</strong> command in the Print Preview form. Note that to prevent the standard exporting procedure from being called you just need to set the <strong>handled</strong> property to <strong>true</strong>.</p><p>You may use this approach to override any other standard actions which can be performed by an end-user in the Print Preview form. To get the full list of these commands, see the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraPrintingPrintingSystemCommandEnumtopic.aspx">XtraPrinting.PrintingSystemCommand</a> enumeration's description.</p>

<br/>


