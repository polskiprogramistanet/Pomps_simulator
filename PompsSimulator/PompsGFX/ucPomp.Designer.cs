namespace PompsSimulator.PompsGFX
{
    partial class ucPomp
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNamePomp = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.lblPompState = new System.Windows.Forms.Label();
            this.lblNumNozzle = new System.Windows.Forms.Label();
            this.lblEngineState = new System.Windows.Forms.Label();
            this.lblNozzleState = new System.Windows.Forms.Label();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPowerSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.grpState.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.Color.DimGray;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(1, 1);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(28, 35);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamePomp
            // 
            this.lblNamePomp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamePomp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamePomp.ForeColor = System.Drawing.Color.White;
            this.lblNamePomp.Location = new System.Drawing.Point(32, 1);
            this.lblNamePomp.Name = "lblNamePomp";
            this.lblNamePomp.Size = new System.Drawing.Size(145, 30);
            this.lblNamePomp.TabIndex = 1;
            this.lblNamePomp.Text = "Logitron";
            this.lblNamePomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Gray;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmount.Location = new System.Drawing.Point(32, 33);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(145, 35);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "0,00";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Gray;
            this.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVolume.Location = new System.Drawing.Point(32, 77);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(145, 35);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "0,00";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Gray;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.Location = new System.Drawing.Point(99, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "0,00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpState
            // 
            this.grpState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpState.BackColor = System.Drawing.Color.Transparent;
            this.grpState.Controls.Add(this.lblPompState);
            this.grpState.Controls.Add(this.lblNumNozzle);
            this.grpState.Controls.Add(this.lblEngineState);
            this.grpState.Controls.Add(this.lblNozzleState);
            this.grpState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpState.ForeColor = System.Drawing.Color.Azure;
            this.grpState.Location = new System.Drawing.Point(3, 151);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(174, 131);
            this.grpState.TabIndex = 5;
            this.grpState.TabStop = false;
            this.grpState.Text = "status:";
            // 
            // lblPompState
            // 
            this.lblPompState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPompState.ForeColor = System.Drawing.Color.Azure;
            this.lblPompState.Location = new System.Drawing.Point(6, 92);
            this.lblPompState.Name = "lblPompState";
            this.lblPompState.Size = new System.Drawing.Size(162, 30);
            this.lblPompState.TabIndex = 3;
            this.lblPompState.Text = "pomp state";
            this.lblPompState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumNozzle
            // 
            this.lblNumNozzle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumNozzle.ForeColor = System.Drawing.Color.Azure;
            this.lblNumNozzle.Location = new System.Drawing.Point(122, 28);
            this.lblNumNozzle.Name = "lblNumNozzle";
            this.lblNumNozzle.Size = new System.Drawing.Size(46, 30);
            this.lblNumNozzle.TabIndex = 2;
            this.lblNumNozzle.Text = "0";
            this.lblNumNozzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngineState
            // 
            this.lblEngineState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEngineState.ForeColor = System.Drawing.Color.Azure;
            this.lblEngineState.Location = new System.Drawing.Point(6, 60);
            this.lblEngineState.Name = "lblEngineState";
            this.lblEngineState.Size = new System.Drawing.Size(162, 30);
            this.lblEngineState.TabIndex = 1;
            this.lblEngineState.Text = "engine state";
            this.lblEngineState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNozzleState
            // 
            this.lblNozzleState.BackColor = System.Drawing.Color.Transparent;
            this.lblNozzleState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNozzleState.ForeColor = System.Drawing.Color.Azure;
            this.lblNozzleState.Location = new System.Drawing.Point(6, 28);
            this.lblNozzleState.Name = "lblNozzleState";
            this.lblNozzleState.Size = new System.Drawing.Size(115, 30);
            this.lblNozzleState.TabIndex = 0;
            this.lblNozzleState.Text = "nozzle state";
            this.lblNozzleState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPowerSwitch});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(125, 28);
            // 
            // tsmPowerSwitch
            // 
            this.tsmPowerSwitch.Name = "tsmPowerSwitch";
            this.tsmPowerSwitch.Size = new System.Drawing.Size(210, 24);
            this.tsmPowerSwitch.Text = "On/Off";
            this.tsmPowerSwitch.Click += new System.EventHandler(this.tsmPowerSwitch_Click);
            // 
            // Pomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNamePomp);
            this.Controls.Add(this.lblNumber);
            this.Name = "Pomp";
            this.Size = new System.Drawing.Size(180, 285);
            this.Load += new System.EventHandler(this.Pomp_Load);
            this.grpState.ResumeLayout(false);
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNamePomp;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.Label lblPompState;
        private System.Windows.Forms.Label lblNumNozzle;
        private System.Windows.Forms.Label lblEngineState;
        private System.Windows.Forms.Label lblNozzleState;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmPowerSwitch;
    }
}
