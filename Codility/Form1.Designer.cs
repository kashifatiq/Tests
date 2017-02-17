namespace Codility
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
            this.btnTennisTournament = new System.Windows.Forms.Button();
            this.btnSockSupply = new System.Windows.Forms.Button();
            this.btnBracketRotation = new System.Windows.Forms.Button();
            this.btnLights = new System.Windows.Forms.Button();
            this.txtWinterLights = new System.Windows.Forms.TextBox();
            this.btnChromium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTennisTournament
            // 
            this.btnTennisTournament.Location = new System.Drawing.Point(0, 0);
            this.btnTennisTournament.Name = "btnTennisTournament";
            this.btnTennisTournament.Size = new System.Drawing.Size(141, 47);
            this.btnTennisTournament.TabIndex = 0;
            this.btnTennisTournament.Text = "Tennis Tournament";
            this.btnTennisTournament.UseVisualStyleBackColor = true;
            this.btnTennisTournament.Click += new System.EventHandler(this.btnTennisTournament_Click);
            // 
            // btnSockSupply
            // 
            this.btnSockSupply.Location = new System.Drawing.Point(147, 0);
            this.btnSockSupply.Name = "btnSockSupply";
            this.btnSockSupply.Size = new System.Drawing.Size(141, 47);
            this.btnSockSupply.TabIndex = 1;
            this.btnSockSupply.Text = "Sock Supply";
            this.btnSockSupply.UseVisualStyleBackColor = true;
            this.btnSockSupply.Click += new System.EventHandler(this.btnSockSupply_Click);
            // 
            // btnBracketRotation
            // 
            this.btnBracketRotation.Location = new System.Drawing.Point(294, 0);
            this.btnBracketRotation.Name = "btnBracketRotation";
            this.btnBracketRotation.Size = new System.Drawing.Size(141, 47);
            this.btnBracketRotation.TabIndex = 2;
            this.btnBracketRotation.Text = "Bracket Rotation";
            this.btnBracketRotation.UseVisualStyleBackColor = true;
            this.btnBracketRotation.Click += new System.EventHandler(this.btnBracketRotation_Click);
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(0, 53);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(141, 47);
            this.btnLights.TabIndex = 3;
            this.btnLights.Text = "Winter Lights";
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // txtWinterLights
            // 
            this.txtWinterLights.Location = new System.Drawing.Point(147, 80);
            this.txtWinterLights.Name = "txtWinterLights";
            this.txtWinterLights.Size = new System.Drawing.Size(402, 20);
            this.txtWinterLights.TabIndex = 4;
            // 
            // btnChromium
            // 
            this.btnChromium.Location = new System.Drawing.Point(0, 106);
            this.btnChromium.Name = "btnChromium";
            this.btnChromium.Size = new System.Drawing.Size(141, 47);
            this.btnChromium.TabIndex = 5;
            this.btnChromium.Text = "Chromium";
            this.btnChromium.UseVisualStyleBackColor = true;
            this.btnChromium.Click += new System.EventHandler(this.btnChromium_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 419);
            this.Controls.Add(this.btnChromium);
            this.Controls.Add(this.txtWinterLights);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.btnBracketRotation);
            this.Controls.Add(this.btnSockSupply);
            this.Controls.Add(this.btnTennisTournament);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTennisTournament;
        private System.Windows.Forms.Button btnSockSupply;
        private System.Windows.Forms.Button btnBracketRotation;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.TextBox txtWinterLights;
        private System.Windows.Forms.Button btnChromium;
    }
}

