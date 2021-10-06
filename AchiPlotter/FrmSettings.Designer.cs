
namespace SimpleChiaPlotter
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.lblDeamonDirectory = new System.Windows.Forms.Label();
            this.textBoxDeamonDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.btnExecutable = new System.Windows.Forms.Button();
            this.textBoxExecutable = new System.Windows.Forms.TextBox();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeamonDirectory
            // 
            this.lblDeamonDirectory.AutoSize = true;
            this.lblDeamonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeamonDirectory.Location = new System.Drawing.Point(133, 100);
            this.lblDeamonDirectory.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDeamonDirectory.Name = "lblDeamonDirectory";
            this.lblDeamonDirectory.Size = new System.Drawing.Size(292, 29);
            this.lblDeamonDirectory.TabIndex = 0;
            this.lblDeamonDirectory.Text = "Achi_Plot plotter folder";
            // 
            // textBoxDeamonDirectory
            // 
            this.textBoxDeamonDirectory.Location = new System.Drawing.Point(140, 138);
            this.textBoxDeamonDirectory.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxDeamonDirectory.Name = "textBoxDeamonDirectory";
            this.textBoxDeamonDirectory.Size = new System.Drawing.Size(375, 35);
            this.textBoxDeamonDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(534, 136);
            this.btnDirectory.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(140, 49);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Browse";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.btnSave);
            this.groupBoxSettings.Controls.Add(this.lblExecutable);
            this.groupBoxSettings.Controls.Add(this.btnExecutable);
            this.groupBoxSettings.Controls.Add(this.lblDeamonDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxExecutable);
            this.groupBoxSettings.Controls.Add(this.btnDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxDeamonDirectory);
            this.groupBoxSettings.Location = new System.Drawing.Point(28, 27);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxSettings.Size = new System.Drawing.Size(798, 437);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(239, 310);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(308, 114);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutable.Location = new System.Drawing.Point(133, 190);
            this.lblExecutable.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(273, 29);
            this.lblExecutable.TabIndex = 0;
            this.lblExecutable.Text = "Achi_Plot Executable";
            // 
            // btnExecutable
            // 
            this.btnExecutable.Location = new System.Drawing.Point(534, 225);
            this.btnExecutable.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnExecutable.Name = "btnExecutable";
            this.btnExecutable.Size = new System.Drawing.Size(140, 49);
            this.btnExecutable.TabIndex = 2;
            this.btnExecutable.Text = "Browse";
            this.btnExecutable.UseVisualStyleBackColor = true;
            this.btnExecutable.Click += new System.EventHandler(this.btnExecutable_Click);
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Location = new System.Drawing.Point(140, 228);
            this.textBoxExecutable.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(375, 35);
            this.textBoxExecutable.TabIndex = 1;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.Controls.Add(this.groupBoxSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmSettings";
            this.Text = "Achi Plotter GUI Settings";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeamonDirectory;
        private System.Windows.Forms.TextBox textBoxDeamonDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Button btnExecutable;
        private System.Windows.Forms.TextBox textBoxExecutable;
        private System.Windows.Forms.Button btnSave;
    }
}