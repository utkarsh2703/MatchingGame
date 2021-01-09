
namespace Assignment4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblinstructions = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblWhichPlayer = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinstructions
            // 
            this.lblinstructions.AutoSize = true;
            this.lblinstructions.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstructions.Location = new System.Drawing.Point(75, 96);
            this.lblinstructions.Name = "lblinstructions";
            this.lblinstructions.Size = new System.Drawing.Size(787, 322);
            this.lblinstructions.TabIndex = 0;
            this.lblinstructions.Text = resources.GetString("lblinstructions.Text");
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.Location = new System.Drawing.Point(164, 48);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(518, 32);
            this.lblBegin.TabIndex = 1;
            this.lblBegin.Text = "PRESS ENTER TO START THE GAME ";
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Location = new System.Drawing.Point(885, 43);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(132, 20);
            this.lblP1Score.TabIndex = 2;
            this.lblP1Score.Text = "Player 1 Score: 0 ";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Location = new System.Drawing.Point(885, 83);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(85, 20);
            this.lblTurns.TabIndex = 3;
            this.lblTurns.Text = "Turns Left:";
            // 
            // lblWhichPlayer
            // 
            this.lblWhichPlayer.AutoSize = true;
            this.lblWhichPlayer.Location = new System.Drawing.Point(682, 9);
            this.lblWhichPlayer.Name = "lblWhichPlayer";
            this.lblWhichPlayer.Size = new System.Drawing.Size(152, 20);
            this.lblWhichPlayer.TabIndex = 4;
            this.lblWhichPlayer.Text = "Player Turn: Player 1";
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContinue.Location = new System.Drawing.Point(351, 228);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(318, 72);
            this.lblContinue.TabIndex = 5;
            this.lblContinue.Text = "NEXT PLAYERS TURN \r\n(PRESS TO CONTINUE)";
            this.lblContinue.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Location = new System.Drawing.Point(887, 63);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(128, 20);
            this.lblP2Score.TabIndex = 7;
            this.lblP2Score.Text = "Player 2 Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 653);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblWhichPlayer);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblinstructions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstructions;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblWhichPlayer;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblP2Score;
    }
}

