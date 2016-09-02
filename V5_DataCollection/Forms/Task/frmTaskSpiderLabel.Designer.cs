using V5_WinControls;

namespace V5_DataCollection.Forms.Task
{
    partial class frmTaskSpiderLabel
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel6 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLabelNameCutRegex = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel5 = new V5_WinControls.V5LinkLabel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkhref = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.chkScript = new System.Windows.Forms.CheckBox();
            this.chkFont = new System.Windows.Forms.CheckBox();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkAllHtml = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDownResourceExt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chkDownResource = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContentRemoveDel = new System.Windows.Forms.Button();
            this.btnContentRemoveEdit = new System.Windows.Forms.Button();
            this.btnContentRemoveAdd = new System.Windows.Forms.Button();
            this.listViewContentRemove = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnContentReplaceDel = new System.Windows.Forms.Button();
            this.listViewContentReplace = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContentReplaceEdit = new System.Windows.Forms.Button();
            this.btnContentReplaceAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel2 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLabelValueIsLinkUrlRegex = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel1 = new V5_WinControls.V5LinkLabel(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.v5LinkLabel4 = new V5_WinControls.V5LinkLabel(this.components);
            this.txtLabelValueIsPagerRegex = new V5_WinControls.V5RichTextBox();
            this.v5LinkLabel3 = new V5_WinControls.V5LinkLabel(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.chkLabelNoNull = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkLabelIsLinkUrl = new System.Windows.Forms.CheckBox();
            this.chkLabelIsPager = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnUrl = new System.Windows.Forms.RadioButton();
            this.radioBtnSource = new System.Windows.Forms.RadioButton();
            this.chkLabelIsLoop = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSpiderPlugin = new System.Windows.Forms.ComboBox();
            this.lblPluginEdit = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkRemarkLbl = new System.Windows.Forms.CheckBox();
            this.chkDivLbl = new System.Windows.Forms.CheckBox();
            this.chkStyleLbl = new System.Windows.Forms.CheckBox();
            this.chkFontLbl = new System.Windows.Forms.CheckBox();
            this.chkIFrameLbl = new System.Windows.Forms.CheckBox();
            this.chkPLbl = new System.Windows.Forms.CheckBox();
            this.chkSpanLbl = new System.Windows.Forms.CheckBox();
            this.chkHrefLbl = new System.Windows.Forms.CheckBox();
            this.chkScriptLbl = new System.Windows.Forms.CheckBox();
            this.chkTableLbl = new System.Windows.Forms.CheckBox();
            this.txtTestUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtLogView = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(336, 544);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 21);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.v5LinkLabel6);
            this.groupBox2.Controls.Add(this.v5LinkLabel5);
            this.groupBox2.Controls.Add(this.txtLabelNameCutRegex);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "截取";
            // 
            // v5LinkLabel6
            // 
            this.v5LinkLabel6.AutoSize = true;
            this.v5LinkLabel6.LabelValue = "(*)";
            this.v5LinkLabel6.Location = new System.Drawing.Point(652, 41);
            this.v5LinkLabel6.Name = "v5LinkLabel6";
            this.v5LinkLabel6.RichTextBox = this.txtLabelNameCutRegex;
            this.v5LinkLabel6.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel6.TabIndex = 12;
            this.v5LinkLabel6.TabStop = true;
            this.v5LinkLabel6.Text = "(*)";
            // 
            // txtLabelNameCutRegex
            // 
            this.txtLabelNameCutRegex.Location = new System.Drawing.Point(65, 16);
            this.txtLabelNameCutRegex.Name = "txtLabelNameCutRegex";
            this.txtLabelNameCutRegex.Size = new System.Drawing.Size(583, 37);
            this.txtLabelNameCutRegex.TabIndex = 10;
            this.txtLabelNameCutRegex.Text = "";
            // 
            // v5LinkLabel5
            // 
            this.v5LinkLabel5.AutoSize = true;
            this.v5LinkLabel5.LabelValue = "[参数]";
            this.v5LinkLabel5.Location = new System.Drawing.Point(650, 17);
            this.v5LinkLabel5.Name = "v5LinkLabel5";
            this.v5LinkLabel5.RichTextBox = this.txtLabelNameCutRegex;
            this.v5LinkLabel5.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel5.TabIndex = 11;
            this.v5LinkLabel5.TabStop = true;
            this.v5LinkLabel5.Text = "[参数]";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "标签表达式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkhref);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.chkScript);
            this.groupBox3.Controls.Add(this.chkFont);
            this.groupBox3.Controls.Add(this.chkTable);
            this.groupBox3.Controls.Add(this.chkAllHtml);
            this.groupBox3.Location = new System.Drawing.Point(6, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Html标签排除";
            // 
            // chkhref
            // 
            this.chkhref.AutoSize = true;
            this.chkhref.Checked = true;
            this.chkhref.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkhref.Location = new System.Drawing.Point(241, 19);
            this.chkhref.Name = "chkhref";
            this.chkhref.Size = new System.Drawing.Size(30, 16);
            this.chkhref.TabIndex = 4;
            this.chkhref.Text = "A";
            this.chkhref.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(111, 41);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "p";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // chkScript
            // 
            this.chkScript.AutoSize = true;
            this.chkScript.Checked = true;
            this.chkScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScript.Location = new System.Drawing.Point(111, 18);
            this.chkScript.Name = "chkScript";
            this.chkScript.Size = new System.Drawing.Size(60, 16);
            this.chkScript.TabIndex = 4;
            this.chkScript.Text = "script";
            this.chkScript.UseVisualStyleBackColor = true;
            // 
            // chkFont
            // 
            this.chkFont.AutoSize = true;
            this.chkFont.Location = new System.Drawing.Point(11, 41);
            this.chkFont.Name = "chkFont";
            this.chkFont.Size = new System.Drawing.Size(84, 16);
            this.chkFont.TabIndex = 2;
            this.chkFont.Text = "font<span>";
            this.chkFont.UseVisualStyleBackColor = true;
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Location = new System.Drawing.Point(11, 19);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(54, 16);
            this.chkTable.TabIndex = 1;
            this.chkTable.Text = "Table";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // chkAllHtml
            // 
            this.chkAllHtml.AutoSize = true;
            this.chkAllHtml.Location = new System.Drawing.Point(241, 42);
            this.chkAllHtml.Name = "chkAllHtml";
            this.chkAllHtml.Size = new System.Drawing.Size(48, 16);
            this.chkAllHtml.TabIndex = 0;
            this.chkAllHtml.Text = "所有";
            this.chkAllHtml.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDownResourceExt);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.chkDownResource);
            this.groupBox4.Location = new System.Drawing.Point(359, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 65);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "下载选项";
            // 
            // txtDownResourceExt
            // 
            this.txtDownResourceExt.Location = new System.Drawing.Point(92, 18);
            this.txtDownResourceExt.Multiline = true;
            this.txtDownResourceExt.Name = "txtDownResourceExt";
            this.txtDownResourceExt.Size = new System.Drawing.Size(242, 43);
            this.txtDownResourceExt.TabIndex = 5;
            this.txtDownResourceExt.Text = ".jpg;.gif;.png;.bmp";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "下载文件后缀";
            // 
            // chkDownResource
            // 
            this.chkDownResource.AutoSize = true;
            this.chkDownResource.Location = new System.Drawing.Point(11, 18);
            this.chkDownResource.Name = "chkDownResource";
            this.chkDownResource.Size = new System.Drawing.Size(72, 16);
            this.chkDownResource.TabIndex = 2;
            this.chkDownResource.Text = "下载资源";
            this.chkDownResource.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContentRemoveDel);
            this.groupBox5.Controls.Add(this.btnContentRemoveEdit);
            this.groupBox5.Controls.Add(this.btnContentRemoveAdd);
            this.groupBox5.Controls.Add(this.listViewContentRemove);
            this.groupBox5.Location = new System.Drawing.Point(6, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 110);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "内容排除";
            // 
            // btnContentRemoveDel
            // 
            this.btnContentRemoveDel.Location = new System.Drawing.Point(15, 81);
            this.btnContentRemoveDel.Name = "btnContentRemoveDel";
            this.btnContentRemoveDel.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveDel.TabIndex = 1;
            this.btnContentRemoveDel.Text = "删除";
            this.btnContentRemoveDel.UseVisualStyleBackColor = true;
            this.btnContentRemoveDel.Click += new System.EventHandler(this.btnContentRemoveDel_Click);
            // 
            // btnContentRemoveEdit
            // 
            this.btnContentRemoveEdit.Location = new System.Drawing.Point(15, 51);
            this.btnContentRemoveEdit.Name = "btnContentRemoveEdit";
            this.btnContentRemoveEdit.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveEdit.TabIndex = 1;
            this.btnContentRemoveEdit.Text = "修改";
            this.btnContentRemoveEdit.UseVisualStyleBackColor = true;
            this.btnContentRemoveEdit.Click += new System.EventHandler(this.btnContentRemoveEdit_Click);
            // 
            // btnContentRemoveAdd
            // 
            this.btnContentRemoveAdd.Location = new System.Drawing.Point(15, 21);
            this.btnContentRemoveAdd.Name = "btnContentRemoveAdd";
            this.btnContentRemoveAdd.Size = new System.Drawing.Size(50, 23);
            this.btnContentRemoveAdd.TabIndex = 1;
            this.btnContentRemoveAdd.Text = "添加";
            this.btnContentRemoveAdd.UseVisualStyleBackColor = true;
            this.btnContentRemoveAdd.Click += new System.EventHandler(this.btnContentRemoveAdd_Click);
            // 
            // listViewContentRemove
            // 
            this.listViewContentRemove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listViewContentRemove.FullRowSelect = true;
            this.listViewContentRemove.GridLines = true;
            this.listViewContentRemove.Location = new System.Drawing.Point(71, 17);
            this.listViewContentRemove.MultiSelect = false;
            this.listViewContentRemove.Name = "listViewContentRemove";
            this.listViewContentRemove.Size = new System.Drawing.Size(260, 85);
            this.listViewContentRemove.TabIndex = 0;
            this.listViewContentRemove.UseCompatibleStateImageBehavior = false;
            this.listViewContentRemove.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "字符串";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "过滤整个标签";
            this.columnHeader4.Width = 90;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnContentReplaceDel);
            this.groupBox6.Controls.Add(this.listViewContentReplace);
            this.groupBox6.Controls.Add(this.btnContentReplaceEdit);
            this.groupBox6.Controls.Add(this.btnContentReplaceAdd);
            this.groupBox6.Location = new System.Drawing.Point(359, 342);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 110);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "内容替换";
            // 
            // btnContentReplaceDel
            // 
            this.btnContentReplaceDel.Location = new System.Drawing.Point(16, 80);
            this.btnContentReplaceDel.Name = "btnContentReplaceDel";
            this.btnContentReplaceDel.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceDel.TabIndex = 1;
            this.btnContentReplaceDel.Text = "删除";
            this.btnContentReplaceDel.UseVisualStyleBackColor = true;
            this.btnContentReplaceDel.Click += new System.EventHandler(this.btnContentReplaceDel_Click);
            // 
            // listViewContentReplace
            // 
            this.listViewContentReplace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewContentReplace.FullRowSelect = true;
            this.listViewContentReplace.GridLines = true;
            this.listViewContentReplace.Location = new System.Drawing.Point(71, 18);
            this.listViewContentReplace.MultiSelect = false;
            this.listViewContentReplace.Name = "listViewContentReplace";
            this.listViewContentReplace.Size = new System.Drawing.Size(260, 85);
            this.listViewContentReplace.TabIndex = 0;
            this.listViewContentReplace.UseCompatibleStateImageBehavior = false;
            this.listViewContentReplace.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "原字符串";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "替换后字符串";
            this.columnHeader3.Width = 125;
            // 
            // btnContentReplaceEdit
            // 
            this.btnContentReplaceEdit.Location = new System.Drawing.Point(15, 50);
            this.btnContentReplaceEdit.Name = "btnContentReplaceEdit";
            this.btnContentReplaceEdit.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceEdit.TabIndex = 1;
            this.btnContentReplaceEdit.Text = "修改";
            this.btnContentReplaceEdit.UseVisualStyleBackColor = true;
            this.btnContentReplaceEdit.Click += new System.EventHandler(this.btnContentReplaceEdit_Click);
            // 
            // btnContentReplaceAdd
            // 
            this.btnContentReplaceAdd.Location = new System.Drawing.Point(16, 21);
            this.btnContentReplaceAdd.Name = "btnContentReplaceAdd";
            this.btnContentReplaceAdd.Size = new System.Drawing.Size(50, 23);
            this.btnContentReplaceAdd.TabIndex = 1;
            this.btnContentReplaceAdd.Text = "添加";
            this.btnContentReplaceAdd.UseVisualStyleBackColor = true;
            this.btnContentReplaceAdd.Click += new System.EventHandler(this.btnContentReplaceAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(539, 541);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(624, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.v5LinkLabel2);
            this.groupBox7.Controls.Add(this.v5LinkLabel1);
            this.groupBox7.Controls.Add(this.txtLabelValueIsLinkUrlRegex);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(6, 137);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(340, 85);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "标签是链接";
            // 
            // v5LinkLabel2
            // 
            this.v5LinkLabel2.AutoSize = true;
            this.v5LinkLabel2.LabelValue = "(*)";
            this.v5LinkLabel2.Location = new System.Drawing.Point(291, 45);
            this.v5LinkLabel2.Name = "v5LinkLabel2";
            this.v5LinkLabel2.RichTextBox = this.txtLabelValueIsLinkUrlRegex;
            this.v5LinkLabel2.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel2.TabIndex = 12;
            this.v5LinkLabel2.TabStop = true;
            this.v5LinkLabel2.Text = "(*)";
            // 
            // txtLabelValueIsLinkUrlRegex
            // 
            this.txtLabelValueIsLinkUrlRegex.Enabled = false;
            this.txtLabelValueIsLinkUrlRegex.Location = new System.Drawing.Point(25, 16);
            this.txtLabelValueIsLinkUrlRegex.Name = "txtLabelValueIsLinkUrlRegex";
            this.txtLabelValueIsLinkUrlRegex.Size = new System.Drawing.Size(260, 66);
            this.txtLabelValueIsLinkUrlRegex.TabIndex = 10;
            this.txtLabelValueIsLinkUrlRegex.Text = "";
            // 
            // v5LinkLabel1
            // 
            this.v5LinkLabel1.AutoSize = true;
            this.v5LinkLabel1.LabelValue = "[参数]";
            this.v5LinkLabel1.Location = new System.Drawing.Point(291, 21);
            this.v5LinkLabel1.Name = "v5LinkLabel1";
            this.v5LinkLabel1.RichTextBox = this.txtLabelValueIsLinkUrlRegex;
            this.v5LinkLabel1.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel1.TabIndex = 11;
            this.v5LinkLabel1.TabStop = true;
            this.v5LinkLabel1.Text = "[参数]";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = "表达式内容";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.v5LinkLabel4);
            this.groupBox8.Controls.Add(this.v5LinkLabel3);
            this.groupBox8.Controls.Add(this.txtLabelValueIsPagerRegex);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(359, 137);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(340, 85);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "标签值为分页";
            // 
            // v5LinkLabel4
            // 
            this.v5LinkLabel4.AutoSize = true;
            this.v5LinkLabel4.LabelValue = "(*)";
            this.v5LinkLabel4.Location = new System.Drawing.Point(291, 43);
            this.v5LinkLabel4.Name = "v5LinkLabel4";
            this.v5LinkLabel4.RichTextBox = this.txtLabelValueIsPagerRegex;
            this.v5LinkLabel4.Size = new System.Drawing.Size(23, 12);
            this.v5LinkLabel4.TabIndex = 12;
            this.v5LinkLabel4.TabStop = true;
            this.v5LinkLabel4.Text = "(*)";
            // 
            // txtLabelValueIsPagerRegex
            // 
            this.txtLabelValueIsPagerRegex.Enabled = false;
            this.txtLabelValueIsPagerRegex.Location = new System.Drawing.Point(25, 15);
            this.txtLabelValueIsPagerRegex.Name = "txtLabelValueIsPagerRegex";
            this.txtLabelValueIsPagerRegex.Size = new System.Drawing.Size(260, 67);
            this.txtLabelValueIsPagerRegex.TabIndex = 10;
            this.txtLabelValueIsPagerRegex.Text = "";
            // 
            // v5LinkLabel3
            // 
            this.v5LinkLabel3.AutoSize = true;
            this.v5LinkLabel3.LabelValue = "[参数]";
            this.v5LinkLabel3.Location = new System.Drawing.Point(291, 18);
            this.v5LinkLabel3.Name = "v5LinkLabel3";
            this.v5LinkLabel3.RichTextBox = this.txtLabelValueIsPagerRegex;
            this.v5LinkLabel3.Size = new System.Drawing.Size(41, 12);
            this.v5LinkLabel3.TabIndex = 11;
            this.v5LinkLabel3.TabStop = true;
            this.v5LinkLabel3.Text = "[参数]";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 60);
            this.label5.TabIndex = 10;
            this.label5.Text = "表达式内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标签名称";
            // 
            // txtLabelName
            // 
            this.txtLabelName.Location = new System.Drawing.Point(65, 13);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size(401, 21);
            this.txtLabelName.TabIndex = 1;
            // 
            // chkLabelNoNull
            // 
            this.chkLabelNoNull.AutoSize = true;
            this.chkLabelNoNull.Location = new System.Drawing.Point(318, 45);
            this.chkLabelNoNull.Name = "chkLabelNoNull";
            this.chkLabelNoNull.Size = new System.Drawing.Size(96, 16);
            this.chkLabelNoNull.TabIndex = 4;
            this.chkLabelNoNull.Text = "标签不能为空";
            this.chkLabelNoNull.UseVisualStyleBackColor = true;
            this.chkLabelNoNull.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(505, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 16);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "标签不得重复";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // chkLabelIsLinkUrl
            // 
            this.chkLabelIsLinkUrl.AutoSize = true;
            this.chkLabelIsLinkUrl.Location = new System.Drawing.Point(604, 44);
            this.chkLabelIsLinkUrl.Name = "chkLabelIsLinkUrl";
            this.chkLabelIsLinkUrl.Size = new System.Drawing.Size(84, 16);
            this.chkLabelIsLinkUrl.TabIndex = 4;
            this.chkLabelIsLinkUrl.Text = "标签为链接";
            this.chkLabelIsLinkUrl.UseVisualStyleBackColor = true;
            this.chkLabelIsLinkUrl.Visible = false;
            this.chkLabelIsLinkUrl.CheckedChanged += new System.EventHandler(this.chkLabelValueIsLinkUrl_CheckedChanged);
            // 
            // chkLabelIsPager
            // 
            this.chkLabelIsPager.AutoSize = true;
            this.chkLabelIsPager.Location = new System.Drawing.Point(417, 45);
            this.chkLabelIsPager.Name = "chkLabelIsPager";
            this.chkLabelIsPager.Size = new System.Drawing.Size(84, 16);
            this.chkLabelIsPager.TabIndex = 5;
            this.chkLabelIsPager.Text = "标签为分页";
            this.chkLabelIsPager.UseVisualStyleBackColor = true;
            this.chkLabelIsPager.Visible = false;
            this.chkLabelIsPager.CheckedChanged += new System.EventHandler(this.chkLabelValueIsPager_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTestUrl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioBtnUrl);
            this.groupBox1.Controls.Add(this.radioBtnSource);
            this.groupBox1.Controls.Add(this.chkLabelIsPager);
            this.groupBox1.Controls.Add(this.chkLabelIsLinkUrl);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chkLabelNoNull);
            this.groupBox1.Controls.Add(this.chkLabelIsLoop);
            this.groupBox1.Controls.Add(this.txtLabelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // radioBtnUrl
            // 
            this.radioBtnUrl.AutoSize = true;
            this.radioBtnUrl.Location = new System.Drawing.Point(575, 13);
            this.radioBtnUrl.Name = "radioBtnUrl";
            this.radioBtnUrl.Size = new System.Drawing.Size(95, 16);
            this.radioBtnUrl.TabIndex = 7;
            this.radioBtnUrl.TabStop = true;
            this.radioBtnUrl.Text = "从网址中获取";
            this.radioBtnUrl.UseVisualStyleBackColor = true;
            // 
            // radioBtnSource
            // 
            this.radioBtnSource.AutoSize = true;
            this.radioBtnSource.Checked = true;
            this.radioBtnSource.Location = new System.Drawing.Point(473, 13);
            this.radioBtnSource.Name = "radioBtnSource";
            this.radioBtnSource.Size = new System.Drawing.Size(95, 16);
            this.radioBtnSource.TabIndex = 6;
            this.radioBtnSource.TabStop = true;
            this.radioBtnSource.Text = "从源码中获取";
            this.radioBtnSource.UseVisualStyleBackColor = true;
            // 
            // chkLabelIsLoop
            // 
            this.chkLabelIsLoop.AutoSize = true;
            this.chkLabelIsLoop.Location = new System.Drawing.Point(230, 45);
            this.chkLabelIsLoop.Name = "chkLabelIsLoop";
            this.chkLabelIsLoop.Size = new System.Drawing.Size(84, 16);
            this.chkLabelIsLoop.TabIndex = 3;
            this.chkLabelIsLoop.Text = "标签为循环";
            this.chkLabelIsLoop.UseVisualStyleBackColor = true;
            this.chkLabelIsLoop.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "插件:";
            // 
            // cmbSpiderPlugin
            // 
            this.cmbSpiderPlugin.FormattingEnabled = true;
            this.cmbSpiderPlugin.Location = new System.Drawing.Point(33, 544);
            this.cmbSpiderPlugin.Name = "cmbSpiderPlugin";
            this.cmbSpiderPlugin.Size = new System.Drawing.Size(262, 20);
            this.cmbSpiderPlugin.TabIndex = 10;
            // 
            // lblPluginEdit
            // 
            this.lblPluginEdit.AutoSize = true;
            this.lblPluginEdit.Location = new System.Drawing.Point(301, 552);
            this.lblPluginEdit.Name = "lblPluginEdit";
            this.lblPluginEdit.Size = new System.Drawing.Size(29, 12);
            this.lblPluginEdit.TabIndex = 11;
            this.lblPluginEdit.Text = "编辑";
            this.lblPluginEdit.Click += new System.EventHandler(this.lblPluginEdit_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chkRemarkLbl);
            this.groupBox9.Controls.Add(this.chkDivLbl);
            this.groupBox9.Controls.Add(this.chkStyleLbl);
            this.groupBox9.Controls.Add(this.chkFontLbl);
            this.groupBox9.Controls.Add(this.chkIFrameLbl);
            this.groupBox9.Controls.Add(this.chkPLbl);
            this.groupBox9.Controls.Add(this.chkSpanLbl);
            this.groupBox9.Controls.Add(this.chkHrefLbl);
            this.groupBox9.Controls.Add(this.chkScriptLbl);
            this.groupBox9.Controls.Add(this.chkTableLbl);
            this.groupBox9.Location = new System.Drawing.Point(6, 294);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(693, 44);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Html标签内容过滤";
            // 
            // chkRemarkLbl
            // 
            this.chkRemarkLbl.AutoSize = true;
            this.chkRemarkLbl.Location = new System.Drawing.Point(594, 20);
            this.chkRemarkLbl.Name = "chkRemarkLbl";
            this.chkRemarkLbl.Size = new System.Drawing.Size(96, 16);
            this.chkRemarkLbl.TabIndex = 0;
            this.chkRemarkLbl.Text = "<!-- -->注释";
            this.chkRemarkLbl.UseVisualStyleBackColor = true;
            // 
            // chkDivLbl
            // 
            this.chkDivLbl.AutoSize = true;
            this.chkDivLbl.Location = new System.Drawing.Point(524, 20);
            this.chkDivLbl.Name = "chkDivLbl";
            this.chkDivLbl.Size = new System.Drawing.Size(54, 16);
            this.chkDivLbl.TabIndex = 0;
            this.chkDivLbl.Text = "空Div";
            this.chkDivLbl.UseVisualStyleBackColor = true;
            // 
            // chkStyleLbl
            // 
            this.chkStyleLbl.AutoSize = true;
            this.chkStyleLbl.Location = new System.Drawing.Point(454, 20);
            this.chkStyleLbl.Name = "chkStyleLbl";
            this.chkStyleLbl.Size = new System.Drawing.Size(54, 16);
            this.chkStyleLbl.TabIndex = 0;
            this.chkStyleLbl.Text = "Style";
            this.chkStyleLbl.UseVisualStyleBackColor = true;
            // 
            // chkFontLbl
            // 
            this.chkFontLbl.AutoSize = true;
            this.chkFontLbl.Location = new System.Drawing.Point(390, 20);
            this.chkFontLbl.Name = "chkFontLbl";
            this.chkFontLbl.Size = new System.Drawing.Size(48, 16);
            this.chkFontLbl.TabIndex = 0;
            this.chkFontLbl.Text = "Font";
            this.chkFontLbl.UseVisualStyleBackColor = true;
            // 
            // chkIFrameLbl
            // 
            this.chkIFrameLbl.AutoSize = true;
            this.chkIFrameLbl.Location = new System.Drawing.Point(314, 20);
            this.chkIFrameLbl.Name = "chkIFrameLbl";
            this.chkIFrameLbl.Size = new System.Drawing.Size(60, 16);
            this.chkIFrameLbl.TabIndex = 0;
            this.chkIFrameLbl.Text = "IFrame";
            this.chkIFrameLbl.UseVisualStyleBackColor = true;
            // 
            // chkPLbl
            // 
            this.chkPLbl.AutoSize = true;
            this.chkPLbl.Location = new System.Drawing.Point(268, 20);
            this.chkPLbl.Name = "chkPLbl";
            this.chkPLbl.Size = new System.Drawing.Size(30, 16);
            this.chkPLbl.TabIndex = 0;
            this.chkPLbl.Text = "P";
            this.chkPLbl.UseVisualStyleBackColor = true;
            // 
            // chkSpanLbl
            // 
            this.chkSpanLbl.AutoSize = true;
            this.chkSpanLbl.Location = new System.Drawing.Point(204, 20);
            this.chkSpanLbl.Name = "chkSpanLbl";
            this.chkSpanLbl.Size = new System.Drawing.Size(48, 16);
            this.chkSpanLbl.TabIndex = 0;
            this.chkSpanLbl.Text = "SPAN";
            this.chkSpanLbl.UseVisualStyleBackColor = true;
            // 
            // chkHrefLbl
            // 
            this.chkHrefLbl.AutoSize = true;
            this.chkHrefLbl.Location = new System.Drawing.Point(158, 20);
            this.chkHrefLbl.Name = "chkHrefLbl";
            this.chkHrefLbl.Size = new System.Drawing.Size(30, 16);
            this.chkHrefLbl.TabIndex = 0;
            this.chkHrefLbl.Text = "A";
            this.chkHrefLbl.UseVisualStyleBackColor = true;
            // 
            // chkScriptLbl
            // 
            this.chkScriptLbl.AutoSize = true;
            this.chkScriptLbl.Location = new System.Drawing.Point(82, 20);
            this.chkScriptLbl.Name = "chkScriptLbl";
            this.chkScriptLbl.Size = new System.Drawing.Size(60, 16);
            this.chkScriptLbl.TabIndex = 0;
            this.chkScriptLbl.Text = "Script";
            this.chkScriptLbl.UseVisualStyleBackColor = true;
            // 
            // chkTableLbl
            // 
            this.chkTableLbl.AutoSize = true;
            this.chkTableLbl.Location = new System.Drawing.Point(12, 20);
            this.chkTableLbl.Name = "chkTableLbl";
            this.chkTableLbl.Size = new System.Drawing.Size(54, 16);
            this.chkTableLbl.TabIndex = 0;
            this.chkTableLbl.Text = "Table";
            this.chkTableLbl.UseVisualStyleBackColor = true;
            // 
            // txtTestUrl
            // 
            this.txtTestUrl.Location = new System.Drawing.Point(64, 39);
            this.txtTestUrl.Name = "txtTestUrl";
            this.txtTestUrl.Size = new System.Drawing.Size(402, 21);
            this.txtTestUrl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "测试地址";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtLogView);
            this.groupBox10.Location = new System.Drawing.Point(6, 451);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(693, 87);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "日志";
            // 
            // txtLogView
            // 
            this.txtLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogView.Location = new System.Drawing.Point(3, 17);
            this.txtLogView.MaxLength = 0;
            this.txtLogView.Multiline = true;
            this.txtLogView.Name = "txtLogView";
            this.txtLogView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogView.Size = new System.Drawing.Size(687, 67);
            this.txtLogView.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(451, 541);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // frmTaskSpiderLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 571);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.lblPluginEdit);
            this.Controls.Add(this.cmbSpiderPlugin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskSpiderLabel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内容页标签编辑";
            this.Load += new System.EventHandler(this.frmTaskSpiderLabel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listViewContentRemove;
        private System.Windows.Forms.ListView listViewContentReplace;
        private System.Windows.Forms.Button btnContentRemoveDel;
        private System.Windows.Forms.Button btnContentRemoveEdit;
        private System.Windows.Forms.Button btnContentRemoveAdd;
        private System.Windows.Forms.Button btnContentReplaceDel;
        private System.Windows.Forms.Button btnContentReplaceEdit;
        private System.Windows.Forms.Button btnContentReplaceAdd;
        private System.Windows.Forms.CheckBox chkAllHtml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkFont;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkScript;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox chkhref;
        private System.Windows.Forms.CheckBox chkDownResource;
        private System.Windows.Forms.TextBox txtDownResourceExt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLabelIsPager;
        private System.Windows.Forms.CheckBox chkLabelIsLinkUrl;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkLabelNoNull;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLabelIsLoop;
        private V5RichTextBox txtLabelValueIsLinkUrlRegex;
        private V5LinkLabel v5LinkLabel1;
        private V5LinkLabel v5LinkLabel2;
        private V5LinkLabel v5LinkLabel4;
        private V5RichTextBox txtLabelValueIsPagerRegex;
        private V5LinkLabel v5LinkLabel3;
        private V5LinkLabel v5LinkLabel6;
        private V5RichTextBox txtLabelNameCutRegex;
        private V5LinkLabel v5LinkLabel5;
        private System.Windows.Forms.ComboBox cmbSpiderPlugin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPluginEdit;
        private System.Windows.Forms.RadioButton radioBtnSource;
        private System.Windows.Forms.RadioButton radioBtnUrl;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chkRemarkLbl;
        private System.Windows.Forms.CheckBox chkDivLbl;
        private System.Windows.Forms.CheckBox chkStyleLbl;
        private System.Windows.Forms.CheckBox chkFontLbl;
        private System.Windows.Forms.CheckBox chkIFrameLbl;
        private System.Windows.Forms.CheckBox chkPLbl;
        private System.Windows.Forms.CheckBox chkSpanLbl;
        private System.Windows.Forms.CheckBox chkHrefLbl;
        private System.Windows.Forms.CheckBox chkScriptLbl;
        private System.Windows.Forms.CheckBox chkTableLbl;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTestUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtLogView;
        private System.Windows.Forms.Button btnTest;
    }
}