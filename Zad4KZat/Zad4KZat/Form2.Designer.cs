
namespace Zad4KZat
{
    partial class FormOkno2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOkno2));
            this.labelWynik = new System.Windows.Forms.Label();
            this.pictureBoxWynik = new System.Windows.Forms.PictureBox();
            this.labelWynikTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWynik)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWynik
            // 
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(17, 19);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(595, 24);
            this.labelWynik.TabIndex = 0;
            this.labelWynik.Text = "Twój wynik prezentuje się następująco:";
            this.labelWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWynik
            // 
            this.pictureBoxWynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWynik.Location = new System.Drawing.Point(127, 56);
            this.pictureBoxWynik.Name = "pictureBoxWynik";
            this.pictureBoxWynik.Size = new System.Drawing.Size(371, 371);
            this.pictureBoxWynik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWynik.TabIndex = 1;
            this.pictureBoxWynik.TabStop = false;
            this.pictureBoxWynik.Click += new System.EventHandler(this.pictureBoxWynik_Click);
            // 
            // labelWynikTxt
            // 
            this.labelWynikTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynikTxt.Location = new System.Drawing.Point(12, 439);
            this.labelWynikTxt.Name = "labelWynikTxt";
            this.labelWynikTxt.Size = new System.Drawing.Size(600, 92);
            this.labelWynikTxt.TabIndex = 2;
            this.labelWynikTxt.Text = "jesteś xyz xyz xyz";
            this.labelWynikTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOkno2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.labelWynikTxt);
            this.Controls.Add(this.pictureBoxWynik);
            this.Controls.Add(this.labelWynik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 580);
            this.Name = "FormOkno2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Wynik  |  Zadanie nr 4  |  Autor: Paweł Siemiginowski (s101450)";
            this.Load += new System.EventHandler(this.FormOkno2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWynik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.PictureBox pictureBoxWynik;
        private System.Windows.Forms.Label labelWynikTxt;
    }
}