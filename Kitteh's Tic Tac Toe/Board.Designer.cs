namespace Kitteh_s_Tic_Tac_Toe
{
    partial class Board
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMainBoard = new System.Windows.Forms.Panel();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnMiddleCenter = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMainBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 56);
            this.panelHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(728, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMainBoard
            // 
            this.panelMainBoard.BackColor = System.Drawing.Color.White;
            this.panelMainBoard.Controls.Add(this.btnBottomRight);
            this.panelMainBoard.Controls.Add(this.btnBottomMiddle);
            this.panelMainBoard.Controls.Add(this.btnBottomLeft);
            this.panelMainBoard.Controls.Add(this.btnMiddleRight);
            this.panelMainBoard.Controls.Add(this.btnMiddleCenter);
            this.panelMainBoard.Controls.Add(this.btnMiddleLeft);
            this.panelMainBoard.Controls.Add(this.btnTopRight);
            this.panelMainBoard.Controls.Add(this.btnTopMiddle);
            this.panelMainBoard.Controls.Add(this.btnTopLeft);
            this.panelMainBoard.Location = new System.Drawing.Point(8, 64);
            this.panelMainBoard.Name = "panelMainBoard";
            this.panelMainBoard.Size = new System.Drawing.Size(768, 489);
            this.panelMainBoard.TabIndex = 1;
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBottomRight.Location = new System.Drawing.Point(512, 324);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(256, 163);
            this.btnBottomRight.TabIndex = 8;
            this.btnBottomRight.Tag = "br";
            this.btnBottomRight.Text = "-";
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBottomMiddle.Location = new System.Drawing.Point(256, 324);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(256, 163);
            this.btnBottomMiddle.TabIndex = 7;
            this.btnBottomMiddle.Tag = "bm";
            this.btnBottomMiddle.Text = "-";
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnBottomMiddle_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBottomLeft.Location = new System.Drawing.Point(0, 324);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(256, 163);
            this.btnBottomLeft.TabIndex = 6;
            this.btnBottomLeft.Tag = "bl";
            this.btnBottomLeft.Text = "-";
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMiddleRight.Location = new System.Drawing.Point(512, 161);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(256, 162);
            this.btnMiddleRight.TabIndex = 5;
            this.btnMiddleRight.Tag = "tr";
            this.btnMiddleRight.Text = "-";
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btnMiddleRight_Click);
            // 
            // btnMiddleCenter
            // 
            this.btnMiddleCenter.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMiddleCenter.Location = new System.Drawing.Point(256, 161);
            this.btnMiddleCenter.Name = "btnMiddleCenter";
            this.btnMiddleCenter.Size = new System.Drawing.Size(256, 162);
            this.btnMiddleCenter.TabIndex = 4;
            this.btnMiddleCenter.Tag = "c";
            this.btnMiddleCenter.Text = "-";
            this.btnMiddleCenter.UseVisualStyleBackColor = true;
            this.btnMiddleCenter.Click += new System.EventHandler(this.btnMiddleCenter_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMiddleLeft.Location = new System.Drawing.Point(0, 161);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(256, 162);
            this.btnMiddleLeft.TabIndex = 3;
            this.btnMiddleLeft.Tag = "ml";
            this.btnMiddleLeft.Text = "-";
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btnMiddleLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopRight.Location = new System.Drawing.Point(512, 0);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(256, 160);
            this.btnTopRight.TabIndex = 2;
            this.btnTopRight.Tag = "tr";
            this.btnTopRight.Text = "-";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopMiddle.Location = new System.Drawing.Point(256, 0);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(256, 160);
            this.btnTopMiddle.TabIndex = 1;
            this.btnTopMiddle.Tag = "tm";
            this.btnTopMiddle.Text = "-";
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.btnTopMiddle_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopLeft.Location = new System.Drawing.Point(0, 0);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(256, 160);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.Tag = "tl";
            this.btnTopLeft.Text = "-";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainBoard);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitteh\'s Tic Tac Toe";
            this.panelHeader.ResumeLayout(false);
            this.panelMainBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Button btnClose;
        private Panel panelMainBoard;
        private Button btnTopLeft;
        private Button btnTopRight;
        private Button btnTopMiddle;
        private Button btnMiddleLeft;
        private Button btnMiddleCenter;
        private Button btnMiddleRight;
        private Button btnBottomRight;
        private Button btnBottomMiddle;
        private Button btnBottomLeft;
    }
}