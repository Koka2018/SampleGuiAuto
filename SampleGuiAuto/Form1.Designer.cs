namespace SampleGuiAuto
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.rdoBtn2 = new System.Windows.Forms.RadioButton();
            this.rdoBtn1 = new System.Windows.Forms.RadioButton();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.myPanel1 = new SampleGuiAuto.MyPanel();
            this.mBtnFindForm = new System.Windows.Forms.Button();
            this.mTxtFormName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 59);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 15;
            this.lstResults.Location = new System.Drawing.Point(68, 201);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(159, 109);
            this.lstResults.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(21, 111);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(205, 22);
            this.txtInput.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 115);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "実行実行";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(56, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 516);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numUpDown);
            this.tabPage1.Controls.Add(this.rdoBtn2);
            this.tabPage1.Controls.Add(this.rdoBtn1);
            this.tabPage1.Controls.Add(this.chkBox);
            this.tabPage1.Controls.Add(this.cmbBox);
            this.tabPage1.Controls.Add(this.lstResults);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(375, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "タブページ1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(96, 434);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(160, 22);
            this.numUpDown.TabIndex = 7;
            // 
            // rdoBtn2
            // 
            this.rdoBtn2.AutoSize = true;
            this.rdoBtn2.Location = new System.Drawing.Point(100, 382);
            this.rdoBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtn2.Name = "rdoBtn2";
            this.rdoBtn2.Size = new System.Drawing.Size(110, 19);
            this.rdoBtn2.TabIndex = 6;
            this.rdoBtn2.Text = "radioButton2";
            this.rdoBtn2.UseVisualStyleBackColor = true;
            // 
            // rdoBtn1
            // 
            this.rdoBtn1.AutoSize = true;
            this.rdoBtn1.Checked = true;
            this.rdoBtn1.Location = new System.Drawing.Point(100, 355);
            this.rdoBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBtn1.Name = "rdoBtn1";
            this.rdoBtn1.Size = new System.Drawing.Size(110, 19);
            this.rdoBtn1.TabIndex = 5;
            this.rdoBtn1.TabStop = true;
            this.rdoBtn1.Text = "radioButton1";
            this.rdoBtn1.UseVisualStyleBackColor = true;
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(49, 25);
            this.chkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(101, 19);
            this.chkBox.TabIndex = 4;
            this.chkBox.Text = "checkBox1";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // cmbBox
            // 
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(124, 159);
            this.cmbBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(160, 23);
            this.cmbBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.myPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(375, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "タブページ2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // myPanel1
            // 
            this.myPanel1.Location = new System.Drawing.Point(47, 78);
            this.myPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(239, 246);
            this.myPanel1.TabIndex = 0;
            // 
            // mBtnFindForm
            // 
            this.mBtnFindForm.Location = new System.Drawing.Point(575, 242);
            this.mBtnFindForm.Margin = new System.Windows.Forms.Padding(4);
            this.mBtnFindForm.Name = "mBtnFindForm";
            this.mBtnFindForm.Size = new System.Drawing.Size(100, 29);
            this.mBtnFindForm.TabIndex = 5;
            this.mBtnFindForm.Text = "Form検索";
            this.mBtnFindForm.UseVisualStyleBackColor = true;
            this.mBtnFindForm.Click += new System.EventHandler(this.mBtnFindForm_Click);
            // 
            // mTxtFormName
            // 
            this.mTxtFormName.Location = new System.Drawing.Point(470, 212);
            this.mTxtFormName.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtFormName.Name = "mTxtFormName";
            this.mTxtFormName.Size = new System.Drawing.Size(205, 22);
            this.mTxtFormName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.mTxtFormName);
            this.Controls.Add(this.mBtnFindForm);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MyPanel myPanel1;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.RadioButton rdoBtn2;
        private System.Windows.Forms.RadioButton rdoBtn1;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button mBtnFindForm;
        private System.Windows.Forms.TextBox mTxtFormName;
    }
}

