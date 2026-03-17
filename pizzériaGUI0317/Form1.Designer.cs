namespace pizzériaGUI0317
{
    partial class Pizzéria
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
            this.btnAdatb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdatb
            // 
            this.btnAdatb.Location = new System.Drawing.Point(357, 341);
            this.btnAdatb.Name = "btnAdatb";
            this.btnAdatb.Size = new System.Drawing.Size(75, 23);
            this.btnAdatb.TabIndex = 0;
            this.btnAdatb.Text = "Adatbevitel";
            this.btnAdatb.UseVisualStyleBackColor = true;
            // 
            // Pizzéria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pizzériaGUI0317.Properties.Resources.pizzeria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdatb);
            this.Name = "Pizzéria";
            this.Text = "Pizzéria";
            this.Load += new System.EventHandler(this.Pizzéria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdatb;
    }
}

