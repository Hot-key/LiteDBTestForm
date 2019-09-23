namespace LiteDbTestForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInitDataBase = new System.Windows.Forms.Button();
            this.buttonSelectData = new System.Windows.Forms.Button();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.buttonFindData = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.listBoxSelectData = new System.Windows.Forms.ListBox();
            this.textBoxDataBasePath = new System.Windows.Forms.TextBox();
            this.buttonSelectDataBasePath = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxQueryData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInitDataBase
            // 
            this.buttonInitDataBase.Location = new System.Drawing.Point(8, 64);
            this.buttonInitDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInitDataBase.Name = "buttonInitDataBase";
            this.buttonInitDataBase.Size = new System.Drawing.Size(141, 31);
            this.buttonInitDataBase.TabIndex = 0;
            this.buttonInitDataBase.Text = "InitDataBase";
            this.buttonInitDataBase.UseVisualStyleBackColor = true;
            this.buttonInitDataBase.Click += new System.EventHandler(this.ButtonInitDataBase_Click);
            // 
            // buttonSelectData
            // 
            this.buttonSelectData.Location = new System.Drawing.Point(9, 103);
            this.buttonSelectData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectData.Name = "buttonSelectData";
            this.buttonSelectData.Size = new System.Drawing.Size(141, 31);
            this.buttonSelectData.TabIndex = 1;
            this.buttonSelectData.Text = "SelectData";
            this.buttonSelectData.UseVisualStyleBackColor = true;
            this.buttonSelectData.Click += new System.EventHandler(this.ButtonSelectData_Click);
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Location = new System.Drawing.Point(9, 142);
            this.buttonInsertData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(141, 31);
            this.buttonInsertData.TabIndex = 2;
            this.buttonInsertData.Text = "InsertData";
            this.buttonInsertData.UseVisualStyleBackColor = true;
            this.buttonInsertData.Click += new System.EventHandler(this.ButtonInsertData_Click);
            // 
            // buttonFindData
            // 
            this.buttonFindData.Location = new System.Drawing.Point(9, 181);
            this.buttonFindData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindData.Name = "buttonFindData";
            this.buttonFindData.Size = new System.Drawing.Size(141, 31);
            this.buttonFindData.TabIndex = 3;
            this.buttonFindData.Text = "FindData";
            this.buttonFindData.UseVisualStyleBackColor = true;
            this.buttonFindData.Click += new System.EventHandler(this.ButtonFindData_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(9, 220);
            this.buttonUpdateData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(141, 31);
            this.buttonUpdateData.TabIndex = 4;
            this.buttonUpdateData.Text = "UpdateData";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.ButtonUpdateData_Click);
            // 
            // listBoxSelectData
            // 
            this.listBoxSelectData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelectData.FormattingEnabled = true;
            this.listBoxSelectData.IntegralHeight = false;
            this.listBoxSelectData.ItemHeight = 12;
            this.listBoxSelectData.Location = new System.Drawing.Point(154, 65);
            this.listBoxSelectData.Name = "listBoxSelectData";
            this.listBoxSelectData.Size = new System.Drawing.Size(554, 185);
            this.listBoxSelectData.TabIndex = 5;
            // 
            // textBoxDataBasePath
            // 
            this.textBoxDataBasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataBasePath.Location = new System.Drawing.Point(8, 11);
            this.textBoxDataBasePath.Name = "textBoxDataBasePath";
            this.textBoxDataBasePath.ReadOnly = true;
            this.textBoxDataBasePath.Size = new System.Drawing.Size(559, 21);
            this.textBoxDataBasePath.TabIndex = 6;
            this.textBoxDataBasePath.Text = "DataBase.db";
            // 
            // buttonSelectDataBasePath
            // 
            this.buttonSelectDataBasePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectDataBasePath.Location = new System.Drawing.Point(570, 11);
            this.buttonSelectDataBasePath.Name = "buttonSelectDataBasePath";
            this.buttonSelectDataBasePath.Size = new System.Drawing.Size(138, 23);
            this.buttonSelectDataBasePath.TabIndex = 7;
            this.buttonSelectDataBasePath.Text = "SelectDataBasePath";
            this.buttonSelectDataBasePath.UseVisualStyleBackColor = true;
            this.buttonSelectDataBasePath.Click += new System.EventHandler(this.ButtonSelectDataBasePath_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(12, 256);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(696, 252);
            this.textBoxLog.TabIndex = 8;
            // 
            // textBoxQueryData
            // 
            this.textBoxQueryData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueryData.Location = new System.Drawing.Point(84, 38);
            this.textBoxQueryData.Name = "textBoxQueryData";
            this.textBoxQueryData.Size = new System.Drawing.Size(624, 21);
            this.textBoxQueryData.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Query Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQueryData);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonSelectDataBasePath);
            this.Controls.Add(this.textBoxDataBasePath);
            this.Controls.Add(this.listBoxSelectData);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.buttonFindData);
            this.Controls.Add(this.buttonInsertData);
            this.Controls.Add(this.buttonSelectData);
            this.Controls.Add(this.buttonInitDataBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitDataBase;
        private System.Windows.Forms.Button buttonSelectData;
        private System.Windows.Forms.Button buttonInsertData;
        private System.Windows.Forms.Button buttonFindData;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.ListBox listBoxSelectData;
        private System.Windows.Forms.TextBox textBoxDataBasePath;
        private System.Windows.Forms.Button buttonSelectDataBasePath;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxQueryData;
        private System.Windows.Forms.Label label1;
    }
}

