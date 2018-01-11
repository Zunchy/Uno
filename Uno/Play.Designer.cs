namespace Uno
{
    partial class Play
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(434, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 229);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Location = new System.Drawing.Point(434, 465);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(146, 229);
            this.btnCard.TabIndex = 1;
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDraw.Location = new System.Drawing.Point(690, 521);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(86, 116);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 765);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.button1);
            this.Name = "Play";
            this.Text = "Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnDraw;
    }
}