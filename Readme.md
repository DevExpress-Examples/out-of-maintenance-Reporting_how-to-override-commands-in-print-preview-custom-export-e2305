# How to override commands in Print Preview - Custom export


<p>This example demonstrates how to override the Print Preview command that exports a report document to an image file. This can be useful, for example, if it's necessary to silently save a report to the predefined location on a disk, using the predefined image format settings, and if no interaction with an end-user is required.</p><p>To implement this task you should handle the <strong>XtraPrinting.PrintingSystemCommand.ExportGraphic</strong> command in the Print Preview form. Note that to prevent the standard exporting procedure from being called you just need to set the <strong>handled</strong> property to <strong>true</strong>.</p><p>You may use this approach to override any other standard actions which can be performed by an end-user in the Print Preview form. To get the full list of these commands, see the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraPrintingPrintingSystemCommandEnumtopic.aspx">XtraPrinting.PrintingSystemCommand</a> enumeration's description.</p>

<br/>


