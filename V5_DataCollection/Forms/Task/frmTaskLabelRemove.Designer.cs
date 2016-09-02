namespace V5_DataCollection.Forms.Task
{
    partial class frmTaskLabelRemove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chkLabel = new System.Windows.Forms.CheckBox();
            this.txtRemoveStr = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel1 = new V5_WinControls.V5LinkLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(208, 183);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "间隔字符串为@@@@(如id@@@@div2)";
            // 
            // chkLabel
            // 
            this.chkLabel.AutoSize = true;
            this.chkLabel.Location = new System.Drawing.Point(106, 183);
            this.chkLabel.Name = "chkLabel";
            this.chkLabel.Size = new System.Drawing.Size(96, 16);
            this.chkLabel.TabIndex = 6;
            this.chkLabel.Text = "过滤整个标签";
            this.chkLabel.UseVisualStyleBackColor = true;
            // 
            // txtRemoveStr
            // 
            this.txtRemoveStr.Location = new System.Drawing.Point(13, 13);
            this.txtRemoveStr.Name = "txtRemoveStr";
            this.txtRemoveStr.Size = new System.Drawing.Size(351, 164);
            this.txtRemoveStr.TabIndex = 8;
            this.txtRemoveStr.Text = "";
            // 
            // v5LinkLabel1
            // 
            this.v5LinkLabel1.AutoSize = true;
            this.v5LinkLabel1.LabelValue = "(*)";
            this.v5LinkLabel1.Location = new System.Drawing.Point(12, 186);
            this.v5LinkLabel1.Name = "v5LinkLabel1";
            this.v5LinkLabel1.RichTextBox = this.txtRemoveStr;
            this.v5LinkLabel1.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel1.TabIndex = 9;
            this.v5LinkLabel1.TabStop = true;
            this.v5LinkLabel1.Text = "(*)";
            // 
            // frmTaskLabelRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 217);
            this.Controls.Add(this.v5LinkLabel1);
            this.Controls.Add(this.txtRemoveStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskLabelRemove";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符排除";
            this.Load += new System.EventHandler(this.frmTaskLabelRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLabel;
        private V5_WinControls.V5RichTextBox txtRemoveStr;
        private V5_WinControls.V5LinkLabel v5LinkLabel1;
    }
}