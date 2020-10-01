namespace TwoCardDecks
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
            this.reset1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.shufle2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.deck1 = new System.Windows.Forms.ListBox();
            this.deck2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(28, 368);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(116, 23);
            this.reset1.TabIndex = 0;
            this.reset1.Text = "ResetDeck #1";
            this.reset1.UseVisualStyleBackColor = true;
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(235, 368);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(116, 23);
            this.reset2.TabIndex = 1;
            this.reset2.Text = "ResetDeck #2";
            this.reset2.UseVisualStyleBackColor = true;
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(28, 397);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(116, 23);
            this.shuffle1.TabIndex = 2;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // shufle2
            // 
            this.shufle2.Location = new System.Drawing.Point(235, 397);
            this.shufle2.Name = "shufle2";
            this.shufle2.Size = new System.Drawing.Size(116, 23);
            this.shufle2.TabIndex = 3;
            this.shufle2.Text = "ResetDeck #2";
            this.shufle2.UseVisualStyleBackColor = true;
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(167, 151);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(44, 23);
            this.moveToDeck1.TabIndex = 4;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(167, 200);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(44, 23);
            this.moveToDeck2.TabIndex = 5;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            // 
            // deck1
            // 
            this.deck1.FormattingEnabled = true;
            this.deck1.Location = new System.Drawing.Point(28, 38);
            this.deck1.Name = "deck1";
            this.deck1.Size = new System.Drawing.Size(116, 316);
            this.deck1.TabIndex = 6;
            // 
            // deck2
            // 
            this.deck2.FormattingEnabled = true;
            this.deck2.Location = new System.Drawing.Point(235, 38);
            this.deck2.Name = "deck2";
            this.deck2.Size = new System.Drawing.Size(116, 316);
            this.deck2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deck #1 ( 0 cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deck #2 ( 0 cards)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deck2);
            this.Controls.Add(this.deck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.shufle2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.reset1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button shufle2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.ListBox deck1;
        private System.Windows.Forms.ListBox deck2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

