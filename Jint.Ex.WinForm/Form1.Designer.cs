﻿namespace Jint.Ex.WinForm
{
    partial class Form1
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
            this.butRunScript1 = new System.Windows.Forms.Button();
            this.lbOut = new System.Windows.Forms.ListBox();
            this.butRunScript2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butRunScript1
            // 
            this.butRunScript1.Location = new System.Drawing.Point(12, 240);
            this.butRunScript1.Name = "butRunScript1";
            this.butRunScript1.Size = new System.Drawing.Size(348, 23);
            this.butRunScript1.TabIndex = 0;
            this.butRunScript1.Text = "Wait Synchronous Interaction";
            this.butRunScript1.UseVisualStyleBackColor = true;
            this.butRunScript1.Click += new System.EventHandler(this.butRunScrip1_Click);
            // 
            // lbOut
            // 
            this.lbOut.FormattingEnabled = true;
            this.lbOut.Location = new System.Drawing.Point(12, 22);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(348, 212);
            this.lbOut.TabIndex = 1;
            // 
            // butRunScript2
            // 
            this.butRunScript2.Location = new System.Drawing.Point(12, 269);
            this.butRunScript2.Name = "butRunScript2";
            this.butRunScript2.Size = new System.Drawing.Size(348, 23);
            this.butRunScript2.TabIndex = 2;
            this.butRunScript2.Text = "Wait Asynchronous Interaction";
            this.butRunScript2.UseVisualStyleBackColor = true;
            this.butRunScript2.Click += new System.EventHandler(this.butRunScript2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wait Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(9, 343);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(348, 23);
            this.butClear.TabIndex = 4;
            this.butClear.Text = "Clear Listbox";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear pending events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 425);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butRunScript2);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.butRunScript1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRunScript1;
        private System.Windows.Forms.ListBox lbOut;
        private System.Windows.Forms.Button butRunScript2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}
