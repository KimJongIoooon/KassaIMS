namespace Kassa
{
    partial class Kassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kassa));
            this.Bon = new System.Windows.Forms.TextBox();
            this.Totaal = new System.Windows.Forms.Label();
            this.TotaalBedrag = new System.Windows.Forms.Label();
            this.BTW = new System.Windows.Forms.Label();
            this.BTWBedrag = new System.Windows.Forms.Label();
            this.SubTotaalBedrag = new System.Windows.Forms.Label();
            this.SubTotaal = new System.Windows.Forms.Label();
            this.ProductNrTextBox = new System.Windows.Forms.TextBox();
            this.ProductNrLabel = new System.Windows.Forms.Label();
            this.BonButton = new System.Windows.Forms.Button();
            this.AantalTextbox = new System.Windows.Forms.TextBox();
            this.AantalLabel = new System.Windows.Forms.Label();
            this.DELButton = new System.Windows.Forms.Button();
            this.VolgendeKlant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.CorrectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bon
            // 
            this.Bon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Bon.Location = new System.Drawing.Point(857, 12);
            this.Bon.Multiline = true;
            this.Bon.Name = "Bon";
            this.Bon.ReadOnly = true;
            this.Bon.Size = new System.Drawing.Size(395, 786);
            this.Bon.TabIndex = 0;
            // 
            // Totaal
            // 
            this.Totaal.AutoSize = true;
            this.Totaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaal.Location = new System.Drawing.Point(850, 925);
            this.Totaal.Name = "Totaal";
            this.Totaal.Size = new System.Drawing.Size(113, 37);
            this.Totaal.TabIndex = 1;
            this.Totaal.Text = "Totaal";
            // 
            // TotaalBedrag
            // 
            this.TotaalBedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotaalBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaalBedrag.Location = new System.Drawing.Point(1022, 925);
            this.TotaalBedrag.Name = "TotaalBedrag";
            this.TotaalBedrag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotaalBedrag.Size = new System.Drawing.Size(237, 37);
            this.TotaalBedrag.TabIndex = 2;
            this.TotaalBedrag.Text = "TotaalBedrag";
            this.TotaalBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTW
            // 
            this.BTW.AutoSize = true;
            this.BTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTW.Location = new System.Drawing.Point(852, 866);
            this.BTW.Name = "BTW";
            this.BTW.Size = new System.Drawing.Size(128, 29);
            this.BTW.TabIndex = 3;
            this.BTW.Text = "BTW 21%";
            // 
            // BTWBedrag
            // 
            this.BTWBedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTWBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTWBedrag.Location = new System.Drawing.Point(1015, 862);
            this.BTWBedrag.Name = "BTWBedrag";
            this.BTWBedrag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTWBedrag.Size = new System.Drawing.Size(237, 37);
            this.BTWBedrag.TabIndex = 4;
            this.BTWBedrag.Text = "BTW Bedrag";
            this.BTWBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubTotaalBedrag
            // 
            this.SubTotaalBedrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTotaalBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotaalBedrag.Location = new System.Drawing.Point(1015, 825);
            this.SubTotaalBedrag.Name = "SubTotaalBedrag";
            this.SubTotaalBedrag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubTotaalBedrag.Size = new System.Drawing.Size(237, 37);
            this.SubTotaalBedrag.TabIndex = 5;
            this.SubTotaalBedrag.Text = "SubTotaalBedrag";
            this.SubTotaalBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubTotaal
            // 
            this.SubTotaal.AutoSize = true;
            this.SubTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotaal.Location = new System.Drawing.Point(852, 829);
            this.SubTotaal.Name = "SubTotaal";
            this.SubTotaal.Size = new System.Drawing.Size(140, 29);
            this.SubTotaal.TabIndex = 6;
            this.SubTotaal.Text = "Sub Totaal";
            // 
            // ProductNrTextBox
            // 
            this.ProductNrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNrTextBox.Location = new System.Drawing.Point(12, 70);
            this.ProductNrTextBox.Name = "ProductNrTextBox";
            this.ProductNrTextBox.Size = new System.Drawing.Size(551, 116);
            this.ProductNrTextBox.TabIndex = 7;
            this.ProductNrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductNrLabel
            // 
            this.ProductNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNrLabel.Location = new System.Drawing.Point(12, 12);
            this.ProductNrLabel.Name = "ProductNrLabel";
            this.ProductNrLabel.Size = new System.Drawing.Size(551, 55);
            this.ProductNrLabel.TabIndex = 8;
            this.ProductNrLabel.Text = "Product";
            this.ProductNrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BonButton
            // 
            this.BonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonButton.Location = new System.Drawing.Point(16, 829);
            this.BonButton.Name = "BonButton";
            this.BonButton.Size = new System.Drawing.Size(272, 133);
            this.BonButton.TabIndex = 9;
            this.BonButton.Text = "Bon";
            this.BonButton.UseVisualStyleBackColor = true;
            // 
            // AantalTextbox
            // 
            this.AantalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalTextbox.Location = new System.Drawing.Point(569, 70);
            this.AantalTextbox.Name = "AantalTextbox";
            this.AantalTextbox.Size = new System.Drawing.Size(275, 116);
            this.AantalTextbox.TabIndex = 10;
            this.AantalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AantalLabel
            // 
            this.AantalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalLabel.Location = new System.Drawing.Point(569, 9);
            this.AantalLabel.Name = "AantalLabel";
            this.AantalLabel.Size = new System.Drawing.Size(275, 55);
            this.AantalLabel.TabIndex = 11;
            this.AantalLabel.Text = "Aantal";
            this.AantalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DELButton
            // 
            this.DELButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELButton.Location = new System.Drawing.Point(294, 829);
            this.DELButton.Name = "DELButton";
            this.DELButton.Size = new System.Drawing.Size(272, 133);
            this.DELButton.TabIndex = 12;
            this.DELButton.Text = "DEL";
            this.DELButton.UseVisualStyleBackColor = true;
            // 
            // VolgendeKlant
            // 
            this.VolgendeKlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolgendeKlant.Location = new System.Drawing.Point(572, 829);
            this.VolgendeKlant.Name = "VolgendeKlant";
            this.VolgendeKlant.Size = new System.Drawing.Size(272, 133);
            this.VolgendeKlant.TabIndex = 13;
            this.VolgendeKlant.Text = "Volgende";
            this.VolgendeKlant.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 133);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 133);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(569, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 133);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 133);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(291, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 133);
            this.button5.TabIndex = 18;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(569, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(272, 133);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 470);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(272, 133);
            this.button7.TabIndex = 22;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(291, 470);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(272, 133);
            this.button8.TabIndex = 21;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(569, 470);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(272, 133);
            this.button9.TabIndex = 20;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EnterButton.Location = new System.Drawing.Point(569, 609);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(272, 133);
            this.EnterButton.TabIndex = 25;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(291, 609);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(272, 133);
            this.button0.TabIndex = 24;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // CorrectionButton
            // 
            this.CorrectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectionButton.ForeColor = System.Drawing.Color.Red;
            this.CorrectionButton.Location = new System.Drawing.Point(12, 609);
            this.CorrectionButton.Name = "CorrectionButton";
            this.CorrectionButton.Size = new System.Drawing.Size(272, 133);
            this.CorrectionButton.TabIndex = 23;
            this.CorrectionButton.Text = "CORR";
            this.CorrectionButton.UseVisualStyleBackColor = true;
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.CorrectionButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.VolgendeKlant);
            this.Controls.Add(this.DELButton);
            this.Controls.Add(this.AantalLabel);
            this.Controls.Add(this.AantalTextbox);
            this.Controls.Add(this.BonButton);
            this.Controls.Add(this.ProductNrLabel);
            this.Controls.Add(this.ProductNrTextBox);
            this.Controls.Add(this.SubTotaal);
            this.Controls.Add(this.SubTotaalBedrag);
            this.Controls.Add(this.BTWBedrag);
            this.Controls.Add(this.BTW);
            this.Controls.Add(this.TotaalBedrag);
            this.Controls.Add(this.Totaal);
            this.Controls.Add(this.Bon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kassa";
            this.Text = "IMS Kassa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bon;
        private System.Windows.Forms.Label Totaal;
        private System.Windows.Forms.Label TotaalBedrag;
        private System.Windows.Forms.Label BTW;
        private System.Windows.Forms.Label BTWBedrag;
        private System.Windows.Forms.Label SubTotaalBedrag;
        private System.Windows.Forms.Label SubTotaal;
        private System.Windows.Forms.TextBox ProductNrTextBox;
        private System.Windows.Forms.Label ProductNrLabel;
        private System.Windows.Forms.Button BonButton;
        private System.Windows.Forms.TextBox AantalTextbox;
        private System.Windows.Forms.Label AantalLabel;
        private System.Windows.Forms.Button DELButton;
        private System.Windows.Forms.Button VolgendeKlant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button CorrectionButton;
    }
}

