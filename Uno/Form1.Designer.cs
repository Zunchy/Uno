namespace Uno
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn2Players = new System.Windows.Forms.Button();
            this.btn4Players = new System.Windows.Forms.Button();
            this.btn3Players = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 255);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO UNO! SELECT HOW MANY PLAYERS YOU WANT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn2Players
            // 
            this.btn2Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Players.Location = new System.Drawing.Point(49, 324);
            this.btn2Players.Name = "btn2Players";
            this.btn2Players.Size = new System.Drawing.Size(273, 172);
            this.btn2Players.TabIndex = 2;
            this.btn2Players.Text = "2 Players";
            this.btn2Players.UseVisualStyleBackColor = true;
            this.btn2Players.Click += new System.EventHandler(this.btn2Players_Click);
            // 
            // btn4Players
            // 
            this.btn4Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Players.Location = new System.Drawing.Point(737, 324);
            this.btn4Players.Name = "btn4Players";
            this.btn4Players.Size = new System.Drawing.Size(273, 172);
            this.btn4Players.TabIndex = 3;
            this.btn4Players.Text = "4 Players";
            this.btn4Players.UseVisualStyleBackColor = true;
            // 
            // btn3Players
            // 
            this.btn3Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Players.Location = new System.Drawing.Point(391, 324);
            this.btn3Players.Name = "btn3Players";
            this.btn3Players.Size = new System.Drawing.Size(273, 172);
            this.btn3Players.TabIndex = 4;
            this.btn3Players.Text = "3 Players";
            this.btn3Players.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Uno.Properties.Resources.uno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 604);
            this.Controls.Add(this.btn3Players);
            this.Controls.Add(this.btn4Players);
            this.Controls.Add(this.btn2Players);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2Players;
        private System.Windows.Forms.Button btn4Players;
        private System.Windows.Forms.Button btn3Players;
    }
}

