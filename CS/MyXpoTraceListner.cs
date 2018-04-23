using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DelayedProperties {
    class MyTraceListner : System.Diagnostics.TraceListener {
        TextBox outputWindow;
        public MyTraceListner(TextBox outputWindow) {
            this.outputWindow = outputWindow;
        }
        public override void Write(string message) {
            outputWindow.AppendText(message);
        }
        public override void WriteLine(string message) {
            outputWindow.AppendText(message + "\r\n");
        }
    }
}
