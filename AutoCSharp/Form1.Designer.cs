namespace AutoCSharp
{
    partial class frmAutoCsharp
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
            this.btnOpenNotepad = new System.Windows.Forms.Button();
            this.btnRunCmdCommand = new System.Windows.Forms.Button();
            this.btnRunCmdBack = new System.Windows.Forms.Button();
            this.btnRunBG_WithResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenNotepad
            // 
            this.btnOpenNotepad.Location = new System.Drawing.Point(13, 13);
            this.btnOpenNotepad.Name = "btnOpenNotepad";
            this.btnOpenNotepad.Size = new System.Drawing.Size(96, 23);
            this.btnOpenNotepad.TabIndex = 0;
            this.btnOpenNotepad.Text = "Open Notepad";
            this.btnOpenNotepad.UseVisualStyleBackColor = true;
            this.btnOpenNotepad.Click += new System.EventHandler(this.btnOpenNotepad_Click);
            // 
            // btnRunCmdCommand
            // 
            this.btnRunCmdCommand.Location = new System.Drawing.Point(116, 12);
            this.btnRunCmdCommand.Name = "btnRunCmdCommand";
            this.btnRunCmdCommand.Size = new System.Drawing.Size(118, 23);
            this.btnRunCmdCommand.TabIndex = 1;
            this.btnRunCmdCommand.Text = "Run Cmd Command";
            this.btnRunCmdCommand.UseVisualStyleBackColor = true;
            this.btnRunCmdCommand.Click += new System.EventHandler(this.btnRunCmdCommand_Click);
            // 
            // btnRunCmdBack
            // 
            this.btnRunCmdBack.Location = new System.Drawing.Point(60, 42);
            this.btnRunCmdBack.Name = "btnRunCmdBack";
            this.btnRunCmdBack.Size = new System.Drawing.Size(128, 23);
            this.btnRunCmdBack.TabIndex = 2;
            this.btnRunCmdBack.Text = "Run Cmd Background";
            this.btnRunCmdBack.UseVisualStyleBackColor = true;
            this.btnRunCmdBack.Click += new System.EventHandler(this.btnRunCmdBack_Click);
            // 
            // btnRunBG_WithResult
            // 
            this.btnRunBG_WithResult.Location = new System.Drawing.Point(12, 81);
            this.btnRunBG_WithResult.Name = "btnRunBG_WithResult";
            this.btnRunBG_WithResult.Size = new System.Drawing.Size(222, 23);
            this.btnRunBG_WithResult.TabIndex = 3;
            this.btnRunBG_WithResult.Text = "Run Cmd Background and Take out Result";
            this.btnRunBG_WithResult.UseVisualStyleBackColor = true;
            this.btnRunBG_WithResult.Click += new System.EventHandler(this.btnRunBG_WithResult_Click);
            // 
            // frmAutoCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnRunBG_WithResult);
            this.Controls.Add(this.btnRunCmdBack);
            this.Controls.Add(this.btnRunCmdCommand);
            this.Controls.Add(this.btnOpenNotepad);
            this.Name = "frmAutoCsharp";
            this.Text = "AutoCsharp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNotepad;
        private System.Windows.Forms.Button btnRunCmdCommand;
        private System.Windows.Forms.Button btnRunCmdBack;
        private System.Windows.Forms.Button btnRunBG_WithResult;
    }
}

