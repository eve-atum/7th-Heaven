/*
  This source is subject to the Microsoft Public License. See LICENSE.TXT for details.
  The original developer is Iros <irosff@outlook.com>
*/

namespace Iros._7th.Workshop {
    partial class fChunks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFLevel = new System.Windows.Forms.TextBox();
            this.bFLevel = new System.Windows.Forms.Button();
            this.bGo = new System.Windows.Forms.Button();
            this.bOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChunks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbChunk = new System.Windows.Forms.ProgressBar();
            this.ofFLevel = new System.Windows.Forms.OpenFileDialog();
            this.fbOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select FLEVEL:";
            // 
            // txtFLevel
            // 
            this.txtFLevel.Location = new System.Drawing.Point(98, 10);
            this.txtFLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFLevel.Name = "txtFLevel";
            this.txtFLevel.Size = new System.Drawing.Size(140, 20);
            this.txtFLevel.TabIndex = 1;
            // 
            // bFLevel
            // 
            this.bFLevel.Location = new System.Drawing.Point(246, 10);
            this.bFLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bFLevel.Name = "bFLevel";
            this.bFLevel.Size = new System.Drawing.Size(26, 16);
            this.bFLevel.TabIndex = 2;
            this.bFLevel.Text = "...";
            this.bFLevel.UseVisualStyleBackColor = true;
            this.bFLevel.Click += new System.EventHandler(this.bFLevel_Click);
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(98, 101);
            this.bGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(138, 22);
            this.bGo.TabIndex = 3;
            this.bGo.Text = "Extract";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // bOutput
            // 
            this.bOutput.Location = new System.Drawing.Point(246, 35);
            this.bOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bOutput.Name = "bOutput";
            this.bOutput.Size = new System.Drawing.Size(26, 16);
            this.bOutput.TabIndex = 6;
            this.bOutput.Text = "...";
            this.bOutput.UseVisualStyleBackColor = true;
            this.bOutput.Click += new System.EventHandler(this.bOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(98, 35);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(140, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Folder:";
            // 
            // txtChunks
            // 
            this.txtChunks.Location = new System.Drawing.Point(98, 61);
            this.txtChunks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChunks.Name = "txtChunks";
            this.txtChunks.Size = new System.Drawing.Size(140, 20);
            this.txtChunks.TabIndex = 8;
            this.txtChunks.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chunk #s:";
            // 
            // pbChunk
            // 
            this.pbChunk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbChunk.Location = new System.Drawing.Point(0, 151);
            this.pbChunk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbChunk.Name = "pbChunk";
            this.pbChunk.Size = new System.Drawing.Size(290, 12);
            this.pbChunk.TabIndex = 9;
            // 
            // ofFLevel
            // 
            this.ofFLevel.Filter = "FLevel.lgp|FLevel.lgp";
            // 
            // fChunks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 163);
            this.Controls.Add(this.pbChunk);
            this.Controls.Add(this.txtChunks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.bFLevel);
            this.Controls.Add(this.txtFLevel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChunks";
            this.Text = "Chunk Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFLevel;
        private System.Windows.Forms.Button bFLevel;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Button bOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChunks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbChunk;
        private System.Windows.Forms.OpenFileDialog ofFLevel;
        private System.Windows.Forms.FolderBrowserDialog fbOutput;
    }
}
