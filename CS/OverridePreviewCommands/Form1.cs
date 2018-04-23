#region #usings
using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...
#endregion #usings

namespace OverridePreviewCommands {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
private void button1_Click(object sender, EventArgs e) {

    // Create a report instance, assigned to a Print Tool.
    ReportPrintTool pt = new ReportPrintTool(new XtraReport1());

    // Generate the report's document. This step is required
    // to activate its PrintingSystem and access it later.
    pt.Report.CreateDocument(false);

    // Override the ExportGraphic command.
    pt.PrintingSystem.AddCommandHandler(new ExportToImageCommandHandler());

    // Show the report's print preview.
    pt.ShowPreview();

}

public class ExportToImageCommandHandler : ICommandHandler {
    public virtual void HandleCommand(PrintingSystemCommand command,
    object[] args, IPrintControl control, ref bool handled) {
        if (!CanHandleCommand(command, control)) return;

        // Export the document to png.
        control.PrintingSystem.ExportToImage("C:\\Report.png", ImageFormat.Png);

        // Set handled to 'true' to prevent the standard exporting procedure from being called.
        handled = true;
    }

    public virtual bool CanHandleCommand(PrintingSystemCommand command, IPrintControl control) {
        // This handler is used for the ExportGraphic command.
        return command == PrintingSystemCommand.ExportGraphic;
    }
}
#endregion #code

    }
}
