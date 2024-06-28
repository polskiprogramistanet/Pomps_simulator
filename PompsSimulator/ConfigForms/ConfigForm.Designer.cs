namespace PompsSimulator
{
    partial class ConfigForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpProvider = new System.Windows.Forms.GroupBox();
            this.btnSetProvider = new System.Windows.Forms.Button();
            this.lblProvider = new System.Windows.Forms.Label();
            this.grpProvider.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(607, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 100);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(607, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // grpProvider
            // 
            this.grpProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProvider.Controls.Add(this.btnSetProvider);
            this.grpProvider.Controls.Add(this.lblProvider);
            this.grpProvider.Location = new System.Drawing.Point(11, 2);
            this.grpProvider.Name = "grpProvider";
            this.grpProvider.Size = new System.Drawing.Size(744, 163);
            this.grpProvider.TabIndex = 2;
            this.grpProvider.TabStop = false;
            this.grpProvider.Text = "Podłączenie do bazy :";
            // 
            // btnSetProvider
            // 
            this.btnSetProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetProvider.Location = new System.Drawing.Point(663, 118);
            this.btnSetProvider.Name = "btnSetProvider";
            this.btnSetProvider.Size = new System.Drawing.Size(75, 39);
            this.btnSetProvider.TabIndex = 1;
            this.btnSetProvider.Text = "ustaw";
            this.btnSetProvider.UseVisualStyleBackColor = true;
            // 
            // lblProvider
            // 
            this.lblProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvider.Location = new System.Drawing.Point(6, 18);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(732, 97);
            this.lblProvider.TabIndex = 0;
            this.lblProvider.Text = "provider";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 478);
            this.Controls.Add(this.grpProvider);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "Konfiguracja";
            this.grpProvider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpProvider;
        private System.Windows.Forms.Button btnSetProvider;
        private System.Windows.Forms.Label lblProvider;
    }
}