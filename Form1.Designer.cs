namespace Tic_Tac_Toe
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.labTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labTheWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Tahoma", 20F);
            label1.ForeColor = System.Drawing.Color.Lime;
            label1.Location = new System.Drawing.Point(73, 65);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 33);
            label1.TabIndex = 9;
            label1.Text = "Turn:";
            // 
            // btnTwo
            // 
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnTwo.Location = new System.Drawing.Point(588, 70);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(93, 97);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Tag = "?";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnThree.Location = new System.Drawing.Point(711, 70);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(93, 97);
            this.btnThree.TabIndex = 2;
            this.btnThree.Tag = "?";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnFive.Location = new System.Drawing.Point(588, 193);
            this.btnFive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(93, 97);
            this.btnFive.TabIndex = 3;
            this.btnFive.Tag = "?";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnFour.Location = new System.Drawing.Point(466, 193);
            this.btnFour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(93, 97);
            this.btnFour.TabIndex = 4;
            this.btnFour.Tag = "?";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnSix.Location = new System.Drawing.Point(711, 193);
            this.btnSix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(93, 97);
            this.btnSix.TabIndex = 5;
            this.btnSix.Tag = "?";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnNine.Location = new System.Drawing.Point(711, 312);
            this.btnNine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(93, 97);
            this.btnNine.TabIndex = 8;
            this.btnNine.Tag = "?";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnSeven.Location = new System.Drawing.Point(466, 312);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(93, 97);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Tag = "?";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnEight.Location = new System.Drawing.Point(588, 312);
            this.btnEight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(93, 97);
            this.btnEight.TabIndex = 6;
            this.btnEight.Tag = "?";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // labTurn
            // 
            this.labTurn.AutoSize = true;
            this.labTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTurn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labTurn.ForeColor = System.Drawing.Color.Yellow;
            this.labTurn.Location = new System.Drawing.Point(73, 119);
            this.labTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTurn.Name = "labTurn";
            this.labTurn.Size = new System.Drawing.Size(102, 33);
            this.labTurn.TabIndex = 10;
            this.labTurn.Text = "Player1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(73, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "The Winner:";
            // 
            // labTheWinner
            // 
            this.labTheWinner.AutoSize = true;
            this.labTheWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTheWinner.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labTheWinner.ForeColor = System.Drawing.Color.Yellow;
            this.labTheWinner.Location = new System.Drawing.Point(73, 219);
            this.labTheWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTheWinner.Name = "labTheWinner";
            this.labTheWinner.Size = new System.Drawing.Size(126, 33);
            this.labTheWinner.TabIndex = 12;
            this.labTheWinner.Text = "Unknown";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(73, 281);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 45);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbChoice
            // 
            this.cbChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChoice.Font = new System.Drawing.Font("SimSun-ExtB", 16F);
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Items.AddRange(new object[] {
            "Friend",
            "Computer"});
            this.cbChoice.Location = new System.Drawing.Point(73, 388);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(176, 29);
            this.cbChoice.TabIndex = 14;
            this.cbChoice.Text = "Play With";
            this.cbChoice.SelectedIndexChanged += new System.EventHandler(this.cbChoice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Play With:";
            // 
            // btnOne
            // 
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnOne.Location = new System.Drawing.Point(466, 70);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(93, 97);
            this.btnOne.TabIndex = 0;
            this.btnOne.Tag = "?";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 43);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tic-Tac-Toe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChoice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labTheWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labTurn);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Font = new System.Drawing.Font("SimSun-ExtB", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Label labTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTheWinner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label label4;
    }
}

