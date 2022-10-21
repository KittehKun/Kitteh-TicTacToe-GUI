namespace Kitteh_s_Tic_Tac_Toe
{
    partial class CoinFlip
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblFirstTurn = new System.Windows.Forms.Label();
            this.txtFlipCoin = new System.Windows.Forms.TextBox();
            this.btnFlipCoin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(400, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(456, 56);
            this.panelHeader.TabIndex = 1;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.White;
            this.panelMainContent.Controls.Add(this.btnContinue);
            this.panelMainContent.Controls.Add(this.lblFirstTurn);
            this.panelMainContent.Controls.Add(this.txtFlipCoin);
            this.panelMainContent.Controls.Add(this.btnFlipCoin);
            this.panelMainContent.Controls.Add(this.lblTitle);
            this.panelMainContent.Location = new System.Drawing.Point(8, 64);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(440, 280);
            this.panelMainContent.TabIndex = 2;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.Location = new System.Drawing.Point(352, 232);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 39);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "OK";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblFirstTurn
            // 
            this.lblFirstTurn.AutoSize = true;
            this.lblFirstTurn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstTurn.Location = new System.Drawing.Point(192, 108);
            this.lblFirstTurn.Name = "lblFirstTurn";
            this.lblFirstTurn.Size = new System.Drawing.Size(148, 25);
            this.lblFirstTurn.TabIndex = 3;
            this.lblFirstTurn.Text = "Who\'s First Turn";
            // 
            // txtFlipCoin
            // 
            this.txtFlipCoin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFlipCoin.Location = new System.Drawing.Point(192, 136);
            this.txtFlipCoin.Name = "txtFlipCoin";
            this.txtFlipCoin.ReadOnly = true;
            this.txtFlipCoin.Size = new System.Drawing.Size(232, 36);
            this.txtFlipCoin.TabIndex = 2;
            this.txtFlipCoin.TabStop = false;
            this.txtFlipCoin.Text = "Kitteh\'s Placeholder";
            this.txtFlipCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFlipCoin
            // 
            this.btnFlipCoin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFlipCoin.Location = new System.Drawing.Point(16, 128);
            this.btnFlipCoin.Name = "btnFlipCoin";
            this.btnFlipCoin.Size = new System.Drawing.Size(160, 56);
            this.btnFlipCoin.TabIndex = 1;
            this.btnFlipCoin.Text = "Flip Coin";
            this.btnFlipCoin.UseVisualStyleBackColor = true;
            this.btnFlipCoin.Click += new System.EventHandler(this.btnFlipCoin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(112, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Coin Flip";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(456, 354);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoinFlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoinFlip";
            this.panelHeader.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClose;
        private Panel panelHeader;
        private Panel panelMainContent;
        private Label lblTitle;
        private Button btnFlipCoin;
        private TextBox txtFlipCoin;
        private Label lblFirstTurn;
        private Button btnContinue;
    }
}