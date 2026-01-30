namespace SecondDegre
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
            this.components = new System.ComponentModel.Container();
            this.lblXCare = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEssaiA = new System.Windows.Forms.TextBox();
            this.lblEssaiA = new System.Windows.Forms.Label();
            this.lblEssaiB = new System.Windows.Forms.Label();
            this.txtEssaiB = new System.Windows.Forms.TextBox();
            this.lblEssaiC = new System.Windows.Forms.Label();
            this.txtEssaiC = new System.Windows.Forms.TextBox();
            this.lblEssaiXCare = new System.Windows.Forms.Label();
            this.lblEssaiX = new System.Windows.Forms.Label();
            this.grpResultats = new System.Windows.Forms.GroupBox();
            this.lblAstuce = new System.Windows.Forms.Label();
            this.lblX2Resultat = new System.Windows.Forms.Label();
            this.lblX1Resultat = new System.Windows.Forms.Label();
            this.lblX0Resultat = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblNbrSolutions = new System.Windows.Forms.Label();
            this.lblDeltaResultat = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.btnAfficherResultats = new System.Windows.Forms.Button();
            this.btnRaz = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tipAstuce = new System.Windows.Forms.ToolTip(this.components);
            this.grpResultats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblXCare
            // 
            this.lblXCare.AutoSize = true;
            this.lblXCare.Location = new System.Drawing.Point(177, 150);
            this.lblXCare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXCare.Name = "lblXCare";
            this.lblXCare.Size = new System.Drawing.Size(33, 17);
            this.lblXCare.TabIndex = 0;
            this.lblXCare.Text = "x² +";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblX.Location = new System.Drawing.Point(358, 150);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(28, 17);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "x +";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(37, 142);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(132, 25);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(218, 142);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(132, 25);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(394, 142);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(132, 25);
            this.txtC.TabIndex = 5;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez entrer a, b et c tel que : ax² + bx + c.                    Dans le cas " +
    "où b et/ou c n\'existent pas, veuillez mettre un 0.";
            // 
            // txtEssaiA
            // 
            this.txtEssaiA.Location = new System.Drawing.Point(37, 197);
            this.txtEssaiA.Name = "txtEssaiA";
            this.txtEssaiA.Size = new System.Drawing.Size(132, 25);
            this.txtEssaiA.TabIndex = 7;
            this.txtEssaiA.Enter += new System.EventHandler(this.txtEssai_Enter);
            this.txtEssaiA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtEssaiA.Leave += new System.EventHandler(this.txtEssai_Leave);
            // 
            // lblEssaiA
            // 
            this.lblEssaiA.AutoSize = true;
            this.lblEssaiA.BackColor = System.Drawing.Color.White;
            this.lblEssaiA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEssaiA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEssaiA.Location = new System.Drawing.Point(43, 200);
            this.lblEssaiA.Name = "lblEssaiA";
            this.lblEssaiA.Size = new System.Drawing.Size(16, 17);
            this.lblEssaiA.TabIndex = 9;
            this.lblEssaiA.Text = "a";
            this.lblEssaiA.Click += new System.EventHandler(this.lblEssai_Click);
            // 
            // lblEssaiB
            // 
            this.lblEssaiB.AutoSize = true;
            this.lblEssaiB.BackColor = System.Drawing.Color.White;
            this.lblEssaiB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEssaiB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEssaiB.Location = new System.Drawing.Point(224, 200);
            this.lblEssaiB.Name = "lblEssaiB";
            this.lblEssaiB.Size = new System.Drawing.Size(16, 17);
            this.lblEssaiB.TabIndex = 11;
            this.lblEssaiB.Text = "b";
            this.lblEssaiB.Click += new System.EventHandler(this.lblEssaiB_Click);
            // 
            // txtEssaiB
            // 
            this.txtEssaiB.Location = new System.Drawing.Point(218, 197);
            this.txtEssaiB.Name = "txtEssaiB";
            this.txtEssaiB.Size = new System.Drawing.Size(132, 25);
            this.txtEssaiB.TabIndex = 10;
            this.txtEssaiB.Enter += new System.EventHandler(this.txtEssaiB_Enter);
            this.txtEssaiB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtEssaiB.Leave += new System.EventHandler(this.txtEssaiB_Leave);
            // 
            // lblEssaiC
            // 
            this.lblEssaiC.AutoSize = true;
            this.lblEssaiC.BackColor = System.Drawing.Color.White;
            this.lblEssaiC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEssaiC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEssaiC.Location = new System.Drawing.Point(400, 200);
            this.lblEssaiC.Name = "lblEssaiC";
            this.lblEssaiC.Size = new System.Drawing.Size(16, 17);
            this.lblEssaiC.TabIndex = 13;
            this.lblEssaiC.Text = "c";
            this.lblEssaiC.Click += new System.EventHandler(this.lblEssaiC_Click);
            // 
            // txtEssaiC
            // 
            this.txtEssaiC.Location = new System.Drawing.Point(394, 197);
            this.txtEssaiC.Name = "txtEssaiC";
            this.txtEssaiC.Size = new System.Drawing.Size(132, 25);
            this.txtEssaiC.TabIndex = 12;
            this.txtEssaiC.Enter += new System.EventHandler(this.txtEssaiC_Enter);
            this.txtEssaiC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtEssaiC.Leave += new System.EventHandler(this.txtEssaiC_Leave);
            // 
            // lblEssaiXCare
            // 
            this.lblEssaiXCare.AutoSize = true;
            this.lblEssaiXCare.Location = new System.Drawing.Point(177, 205);
            this.lblEssaiXCare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEssaiXCare.Name = "lblEssaiXCare";
            this.lblEssaiXCare.Size = new System.Drawing.Size(33, 17);
            this.lblEssaiXCare.TabIndex = 14;
            this.lblEssaiXCare.Text = "x² +";
            // 
            // lblEssaiX
            // 
            this.lblEssaiX.AutoSize = true;
            this.lblEssaiX.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblEssaiX.Location = new System.Drawing.Point(358, 205);
            this.lblEssaiX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEssaiX.Name = "lblEssaiX";
            this.lblEssaiX.Size = new System.Drawing.Size(28, 17);
            this.lblEssaiX.TabIndex = 15;
            this.lblEssaiX.Text = "x +";
            // 
            // grpResultats
            // 
            this.grpResultats.Controls.Add(this.lblAstuce);
            this.grpResultats.Controls.Add(this.lblX2Resultat);
            this.grpResultats.Controls.Add(this.lblX1Resultat);
            this.grpResultats.Controls.Add(this.lblX0Resultat);
            this.grpResultats.Controls.Add(this.lblX2);
            this.grpResultats.Controls.Add(this.lblX1);
            this.grpResultats.Controls.Add(this.lblX0);
            this.grpResultats.Controls.Add(this.lblNbrSolutions);
            this.grpResultats.Controls.Add(this.lblDeltaResultat);
            this.grpResultats.Controls.Add(this.lblDelta);
            this.grpResultats.Enabled = false;
            this.grpResultats.Location = new System.Drawing.Point(11, 258);
            this.grpResultats.Name = "grpResultats";
            this.grpResultats.Size = new System.Drawing.Size(772, 166);
            this.grpResultats.TabIndex = 16;
            this.grpResultats.TabStop = false;
            this.grpResultats.Text = "Résultats";
            // 
            // lblAstuce
            // 
            this.lblAstuce.AutoSize = true;
            this.lblAstuce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstuce.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstuce.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAstuce.Location = new System.Drawing.Point(739, 21);
            this.lblAstuce.Name = "lblAstuce";
            this.lblAstuce.Size = new System.Drawing.Size(24, 24);
            this.lblAstuce.TabIndex = 11;
            this.lblAstuce.Text = "?";
            // 
            // lblX2Resultat
            // 
            this.lblX2Resultat.AutoSize = true;
            this.lblX2Resultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX2Resultat.Location = new System.Drawing.Point(63, 133);
            this.lblX2Resultat.Name = "lblX2Resultat";
            this.lblX2Resultat.Size = new System.Drawing.Size(90, 17);
            this.lblX2Resultat.TabIndex = 9;
            this.lblX2Resultat.Text = "(-b +√∆) / 2a";
            this.lblX2Resultat.Click += new System.EventHandler(this.lblX0Resultat_Click);
            // 
            // lblX1Resultat
            // 
            this.lblX1Resultat.AutoSize = true;
            this.lblX1Resultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX1Resultat.Location = new System.Drawing.Point(63, 86);
            this.lblX1Resultat.Name = "lblX1Resultat";
            this.lblX1Resultat.Size = new System.Drawing.Size(86, 17);
            this.lblX1Resultat.TabIndex = 8;
            this.lblX1Resultat.Text = "(-b -√∆) / 2a";
            this.lblX1Resultat.Click += new System.EventHandler(this.lblX0Resultat_Click);
            // 
            // lblX0Resultat
            // 
            this.lblX0Resultat.AutoSize = true;
            this.lblX0Resultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX0Resultat.Location = new System.Drawing.Point(63, 86);
            this.lblX0Resultat.Name = "lblX0Resultat";
            this.lblX0Resultat.Size = new System.Drawing.Size(49, 17);
            this.lblX0Resultat.TabIndex = 7;
            this.lblX0Resultat.Text = "-b / 2a";
            this.lblX0Resultat.Click += new System.EventHandler(this.lblX0Resultat_Click);
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(26, 133);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(36, 17);
            this.lblX2.TabIndex = 6;
            this.lblX2.Text = "x2 =";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(26, 86);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(36, 17);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "x1 =";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(26, 86);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(36, 17);
            this.lblX0.TabIndex = 4;
            this.lblX0.Text = "x0 =";
            // 
            // lblNbrSolutions
            // 
            this.lblNbrSolutions.AutoSize = true;
            this.lblNbrSolutions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNbrSolutions.Location = new System.Drawing.Point(231, 36);
            this.lblNbrSolutions.Name = "lblNbrSolutions";
            this.lblNbrSolutions.Size = new System.Drawing.Size(142, 17);
            this.lblNbrSolutions.TabIndex = 3;
            this.lblNbrSolutions.Text = "Nombre de solutions";
            this.lblNbrSolutions.Click += new System.EventHandler(this.lblX0Resultat_Click);
            // 
            // lblDeltaResultat
            // 
            this.lblDeltaResultat.AutoSize = true;
            this.lblDeltaResultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeltaResultat.Location = new System.Drawing.Point(93, 36);
            this.lblDeltaResultat.Name = "lblDeltaResultat";
            this.lblDeltaResultat.Size = new System.Drawing.Size(58, 17);
            this.lblDeltaResultat.TabIndex = 2;
            this.lblDeltaResultat.Text = "b² - 4ac";
            this.lblDeltaResultat.Click += new System.EventHandler(this.lblX0Resultat_Click);
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(23, 36);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(63, 17);
            this.lblDelta.TabIndex = 0;
            this.lblDelta.Text = "Delta ∆ :";
            // 
            // btnAfficherResultats
            // 
            this.btnAfficherResultats.Location = new System.Drawing.Point(610, 142);
            this.btnAfficherResultats.Name = "btnAfficherResultats";
            this.btnAfficherResultats.Size = new System.Drawing.Size(161, 80);
            this.btnAfficherResultats.TabIndex = 17;
            this.btnAfficherResultats.Text = "Afficher les résultats";
            this.btnAfficherResultats.UseVisualStyleBackColor = true;
            this.btnAfficherResultats.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRaz
            // 
            this.btnRaz.Location = new System.Drawing.Point(569, 440);
            this.btnRaz.Name = "btnRaz";
            this.btnRaz.Size = new System.Drawing.Size(93, 28);
            this.btnRaz.TabIndex = 18;
            this.btnRaz.Text = "Raz";
            this.btnRaz.UseVisualStyleBackColor = true;
            this.btnRaz.Click += new System.EventHandler(this.btnRaz_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(679, 440);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(93, 28);
            this.btnQuitter.TabIndex = 19;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTitre.Location = new System.Drawing.Point(63, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(677, 22);
            this.lblTitre.TabIndex = 20;
            this.lblTitre.Text = "Calcul automatique des racines et de delta pour une équation du second degré.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 480);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRaz);
            this.Controls.Add(this.btnAfficherResultats);
            this.Controls.Add(this.grpResultats);
            this.Controls.Add(this.lblEssaiX);
            this.Controls.Add(this.lblEssaiXCare);
            this.Controls.Add(this.lblEssaiC);
            this.Controls.Add(this.txtEssaiC);
            this.Controls.Add(this.lblEssaiB);
            this.Controls.Add(this.txtEssaiB);
            this.Controls.Add(this.lblEssaiA);
            this.Controls.Add(this.txtEssaiA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblXCare);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(812, 519);
            this.MinimumSize = new System.Drawing.Size(812, 519);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Degré Automatique";
            this.grpResultats.ResumeLayout(false);
            this.grpResultats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXCare;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEssaiA;
        private System.Windows.Forms.Label lblEssaiA;
        private System.Windows.Forms.Label lblEssaiB;
        private System.Windows.Forms.TextBox txtEssaiB;
        private System.Windows.Forms.Label lblEssaiC;
        private System.Windows.Forms.TextBox txtEssaiC;
        private System.Windows.Forms.Label lblEssaiXCare;
        private System.Windows.Forms.Label lblEssaiX;
        private System.Windows.Forms.GroupBox grpResultats;
        //private System.Windows.Forms.Label lblDeltaResultat;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblDeltaResultat;
        private System.Windows.Forms.Label lblNbrSolutions;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Button btnAfficherResultats;
        private System.Windows.Forms.Button btnRaz;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblX2Resultat;
        private System.Windows.Forms.Label lblX1Resultat;
        private System.Windows.Forms.Label lblX0Resultat;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAstuce;
        private System.Windows.Forms.ToolTip tipAstuce;
    }
}

