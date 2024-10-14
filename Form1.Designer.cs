
namespace TranslateTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.btnTransferToTraditional = new System.Windows.Forms.Button();
            this.btnTransferToSimplified = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckTypeList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(367, 26);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 24);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(82, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(287, 22);
            this.txtPath.TabIndex = 1;
            this.txtPath.DoubleClick += new System.EventHandler(this.txtPath_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "目录：";
            // 
            // listMessage
            // 
            this.listMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 12;
            this.listMessage.Location = new System.Drawing.Point(12, 128);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(904, 436);
            this.listMessage.TabIndex = 3;
            // 
            // btnTransferToTraditional
            // 
            this.btnTransferToTraditional.Location = new System.Drawing.Point(654, 27);
            this.btnTransferToTraditional.Name = "btnTransferToTraditional";
            this.btnTransferToTraditional.Size = new System.Drawing.Size(75, 24);
            this.btnTransferToTraditional.TabIndex = 4;
            this.btnTransferToTraditional.Text = "简转繁";
            this.btnTransferToTraditional.UseVisualStyleBackColor = true;
            this.btnTransferToTraditional.Click += new System.EventHandler(this.btnTransferToTraditional_Click);
            // 
            // btnTransferToSimplified
            // 
            this.btnTransferToSimplified.Location = new System.Drawing.Point(761, 27);
            this.btnTransferToSimplified.Name = "btnTransferToSimplified";
            this.btnTransferToSimplified.Size = new System.Drawing.Size(75, 23);
            this.btnTransferToSimplified.TabIndex = 5;
            this.btnTransferToSimplified.Text = "繁轉簡";
            this.btnTransferToSimplified.UseVisualStyleBackColor = true;
            this.btnTransferToSimplified.Click += new System.EventHandler(this.btnTransferToSimplified_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "文件类型：";
            // 
            // ckTypeList
            // 
            this.ckTypeList.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.ckTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckTypeList.FormattingEnabled = true;
            this.ckTypeList.HorizontalScrollbar = true;
            this.ckTypeList.Location = new System.Drawing.Point(81, 60);
            this.ckTypeList.MultiColumn = true;
            this.ckTypeList.Name = "ckTypeList";
            this.ckTypeList.Size = new System.Drawing.Size(835, 55);
            this.ckTypeList.Sorted = true;
            this.ckTypeList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.ckTypeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransferToSimplified);
            this.Controls.Add(this.btnTransferToTraditional);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "文件翻译工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button btnTransferToTraditional;
        private System.Windows.Forms.Button btnTransferToSimplified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckTypeList;
    }
}

