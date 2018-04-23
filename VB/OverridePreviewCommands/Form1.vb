Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...
#End Region ' #usings

Namespace OverridePreviewCommands
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#code"
Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

	' Create a report instance, assigned to a Print Tool.
	Dim pt As New ReportPrintTool(New XtraReport1())

	' Generate the report's document. This step is required
	' to activate its PrintingSystem and access it later.
	pt.Report.CreateDocument(False)

	' Override the ExportGraphic command.
	pt.PrintingSystem.AddCommandHandler(New ExportToImageCommandHandler())

	' Show the report's print preview.
	pt.ShowPreview()

End Sub

Public Class ExportToImageCommandHandler
	Implements ICommandHandler
            Public Overridable Sub HandleCommand(ByVal command As PrintingSystemCommand, _ 
            ByVal args() As Object, ByVal control As IPrintControl, _ 
            ByRef handled As Boolean) Implements ICommandHandler.HandleCommand
                If (Not CanHandleCommand(command, control)) Then
                    Return
                End If

                ' Export the document to png.
                control.PrintingSystem.ExportToImage("C:\Report.png", ImageFormat.Png)

                ' Set handled to 'true' to prevent the standard exporting procedure from being called.
                handled = True
            End Sub

            Public Overridable Function CanHandleCommand(ByVal command As PrintingSystemCommand, _ 
            ByVal control As IPrintControl) As Boolean Implements ICommandHandler.CanHandleCommand
                ' This handler is used for the ExportGraphic command.
                Return command = PrintingSystemCommand.ExportGraphic
            End Function
End Class
#End Region ' #code

	End Class
End Namespace
