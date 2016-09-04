using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V5_DataCollection._Class.PythonExt;

namespace V5_DataCollection.Forms.Tools {
    public partial class frmEditor : BaseForm {
        public frmEditor() {
            InitializeComponent();

            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;

            this.fastColoredTextBox1.TextChanged += FastColoredTextBox1_TextChanged;
        }

        private void FastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {

        }

        private void toolStripButton_RunScript_Click(object sender, EventArgs e) {
            this.textBox1.Clear();
            PythonExtHelper.OutWriteHandler += (string msg)=> {
                this.textBox1.AppendText(msg);
                this.textBox1.AppendText("\r\n");
            };
            PythonExtHelper.RunScriptPython(this.fastColoredTextBox1.Text, new object[] { "test" });
        }
    }
}
