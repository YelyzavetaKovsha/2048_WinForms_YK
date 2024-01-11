namespace _2048_Winform
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnNoRestart = new System.Windows.Forms.Button();
            this.btnYesRestart = new System.Windows.Forms.Button();
            this.lblRestart = new System.Windows.Forms.Label();
            this.btnOkRules = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblLost = new System.Windows.Forms.Label();
            this.pbBG = new System.Windows.Forms.PictureBox();
            this.pbFull = new System.Windows.Forms.PictureBox();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.picFirework = new System.Windows.Forms.PictureBox();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirework)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.btnNoRestart);
            this.panelGame.Controls.Add(this.btnYesRestart);
            this.panelGame.Controls.Add(this.lblRestart);
            this.panelGame.Controls.Add(this.btnOkRules);
            this.panelGame.Controls.Add(this.lblRules);
            this.panelGame.Controls.Add(this.lblRulesTitle);
            this.panelGame.Controls.Add(this.lblWon);
            this.panelGame.Controls.Add(this.btnResume);
            this.panelGame.Controls.Add(this.lblPause);
            this.panelGame.Controls.Add(this.btnContinue);
            this.panelGame.Controls.Add(this.btnExit);
            this.panelGame.Controls.Add(this.btnNewGame);
            this.panelGame.Controls.Add(this.lblLost);
            this.panelGame.Controls.Add(this.pbBG);
            this.panelGame.Controls.Add(this.pbFull);
            this.panelGame.Location = new System.Drawing.Point(342, 140);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(400, 400);
            this.panelGame.TabIndex = 0;
            // 
            // btnNoRestart
            // 
            this.btnNoRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnNoRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNoRestart.FlatAppearance.BorderSize = 0;
            this.btnNoRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoRestart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoRestart.Location = new System.Drawing.Point(244, 219);
            this.btnNoRestart.Name = "btnNoRestart";
            this.btnNoRestart.Size = new System.Drawing.Size(84, 31);
            this.btnNoRestart.TabIndex = 14;
            this.btnNoRestart.Text = "No";
            this.btnNoRestart.UseVisualStyleBackColor = false;
            this.btnNoRestart.Visible = false;
            this.btnNoRestart.Click += new System.EventHandler(this.btnNoRestart_Click);
            // 
            // btnYesRestart
            // 
            this.btnYesRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnYesRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYesRestart.FlatAppearance.BorderSize = 0;
            this.btnYesRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesRestart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYesRestart.Location = new System.Drawing.Point(72, 219);
            this.btnYesRestart.Name = "btnYesRestart";
            this.btnYesRestart.Size = new System.Drawing.Size(84, 31);
            this.btnYesRestart.TabIndex = 7;
            this.btnYesRestart.Text = "Yes";
            this.btnYesRestart.UseVisualStyleBackColor = false;
            this.btnYesRestart.Visible = false;
            this.btnYesRestart.Click += new System.EventHandler(this.btnYesRestart_Click);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblRestart.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRestart.Location = new System.Drawing.Point(118, 132);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRestart.Size = new System.Drawing.Size(164, 49);
            this.lblRestart.TabIndex = 13;
            this.lblRestart.Text = "Restart?";
            this.lblRestart.Visible = false;
            // 
            // btnOkRules
            // 
            this.btnOkRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnOkRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOkRules.FlatAppearance.BorderSize = 0;
            this.btnOkRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkRules.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOkRules.Location = new System.Drawing.Point(158, 323);
            this.btnOkRules.Name = "btnOkRules";
            this.btnOkRules.Size = new System.Drawing.Size(84, 31);
            this.btnOkRules.TabIndex = 7;
            this.btnOkRules.Text = "OK";
            this.btnOkRules.UseVisualStyleBackColor = false;
            this.btnOkRules.Visible = false;
            this.btnOkRules.Click += new System.EventHandler(this.btnOkRules_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblRules.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRules.Location = new System.Drawing.Point(15, 71);
            this.lblRules.Name = "lblRules";
            this.lblRules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRules.Size = new System.Drawing.Size(61, 29);
            this.lblRules.TabIndex = 7;
            this.lblRules.Text = "rules";
            this.lblRules.Visible = false;
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblRulesTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRulesTitle.Location = new System.Drawing.Point(136, 7);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRulesTitle.Size = new System.Drawing.Size(118, 49);
            this.lblRulesTitle.TabIndex = 7;
            this.lblRulesTitle.Text = "Rules:";
            this.lblRulesTitle.Visible = false;
            // 
            // lblWon
            // 
            this.lblWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWon.AutoSize = true;
            this.lblWon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblWon.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWon.Location = new System.Drawing.Point(5, 116);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(390, 90);
            this.lblWon.TabIndex = 9;
            this.lblWon.Text = "YOU WON!";
            this.lblWon.Visible = false;
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResume.Location = new System.Drawing.Point(158, 237);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(84, 33);
            this.btnResume.TabIndex = 11;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lblPause
            // 
            this.lblPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblPause.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.Gray;
            this.lblPause.Location = new System.Drawing.Point(57, 116);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(296, 90);
            this.lblPause.TabIndex = 10;
            this.lblPause.Text = "PAUSED";
            this.lblPause.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(158, 237);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(84, 33);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(244, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewGame.Location = new System.Drawing.Point(72, 237);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(84, 33);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblLost
            // 
            this.lblLost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLost.AutoSize = true;
            this.lblLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.lblLost.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.ForeColor = System.Drawing.Color.Red;
            this.lblLost.Location = new System.Drawing.Point(3, 100);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(395, 90);
            this.lblLost.TabIndex = 3;
            this.lblLost.Text = "YOU LOST!";
            this.lblLost.Visible = false;
            // 
            // pbBG
            // 
            this.pbBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.pbBG.Location = new System.Drawing.Point(0, 100);
            this.pbBG.Name = "pbBG";
            this.pbBG.Size = new System.Drawing.Size(400, 201);
            this.pbBG.TabIndex = 4;
            this.pbBG.TabStop = false;
            this.pbBG.Visible = false;
            // 
            // pbFull
            // 
            this.pbFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.pbFull.Location = new System.Drawing.Point(0, 0);
            this.pbFull.Name = "pbFull";
            this.pbFull.Size = new System.Drawing.Size(400, 400);
            this.pbFull.TabIndex = 12;
            this.pbFull.TabStop = false;
            this.pbFull.Visible = false;
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2048.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl2048.Location = new System.Drawing.Point(445, 9);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(194, 90);
            this.lbl2048.TabIndex = 1;
            this.lbl2048.Text = "2048";
            this.lbl2048.Click += new System.EventHandler(this.lbl2048_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblScore.Location = new System.Drawing.Point(848, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScore.Size = new System.Drawing.Size(137, 49);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // lblScoreVal
            // 
            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblScoreVal.Location = new System.Drawing.Point(848, 99);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScoreVal.Size = new System.Drawing.Size(43, 49);
            this.lblScoreVal.TabIndex = 3;
            this.lblScoreVal.Text = "0";
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRules.Location = new System.Drawing.Point(857, 165);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(84, 31);
            this.btnRules.TabIndex = 4;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestart.Location = new System.Drawing.Point(857, 225);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(84, 33);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnPause.Image = global::_2048_Winform.Properties.Resources.pause_35x35_gray_v2;
            this.btnPause.Location = new System.Drawing.Point(1022, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 6;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // picFirework
            // 
            this.picFirework.BackColor = System.Drawing.Color.Transparent;
            this.picFirework.Image = global::_2048_Winform.Properties.Resources.FIREWORKS_1000;
            this.picFirework.Location = new System.Drawing.Point(2, -2);
            this.picFirework.Name = "picFirework";
            this.picFirework.Size = new System.Drawing.Size(1081, 614);
            this.picFirework.TabIndex = 0;
            this.picFirework.TabStop = false;
            this.picFirework.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.lblScoreVal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbl2048);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.picFirework);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 YK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lbl2048;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pbBG;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picFirework;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.PictureBox pbFull;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRulesTitle;
        private System.Windows.Forms.Button btnOkRules;
        private System.Windows.Forms.Button btnNoRestart;
        private System.Windows.Forms.Button btnYesRestart;
        private System.Windows.Forms.Label lblRestart;
    }
}

