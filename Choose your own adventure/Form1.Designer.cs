
namespace Choose_your_own_adventure
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.redOutputLabel = new System.Windows.Forms.Label();
            this.blueOutputLabel = new System.Windows.Forms.Label();
            this.greenOutputLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(11, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(648, 95);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Click \"M\" or \"N\" to begin";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // redOutputLabel
            // 
            this.redOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOutputLabel.ForeColor = System.Drawing.Color.White;
            this.redOutputLabel.Location = new System.Drawing.Point(116, 356);
            this.redOutputLabel.Name = "redOutputLabel";
            this.redOutputLabel.Size = new System.Drawing.Size(202, 54);
            this.redOutputLabel.TabIndex = 2;
            // 
            // blueOutputLabel
            // 
            this.blueOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueOutputLabel.ForeColor = System.Drawing.Color.White;
            this.blueOutputLabel.Location = new System.Drawing.Point(116, 442);
            this.blueOutputLabel.Name = "blueOutputLabel";
            this.blueOutputLabel.Size = new System.Drawing.Size(228, 54);
            this.blueOutputLabel.TabIndex = 3;
            // 
            // greenOutputLabel
            // 
            this.greenOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenOutputLabel.ForeColor = System.Drawing.Color.White;
            this.greenOutputLabel.Location = new System.Drawing.Point(452, 358);
            this.greenOutputLabel.Name = "greenOutputLabel";
            this.greenOutputLabel.Size = new System.Drawing.Size(167, 52);
            this.greenOutputLabel.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Choose_your_own_adventure.Properties.Resources.green_button;
            this.pictureBox4.Location = new System.Drawing.Point(361, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Choose_your_own_adventure.Properties.Resources.blue_button;
            this.pictureBox3.Location = new System.Drawing.Point(16, 416);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Choose_your_own_adventure.Properties.Resources.red_button;
            this.pictureBox2.Location = new System.Drawing.Point(16, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sceneImage.Location = new System.Drawing.Point(16, 98);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(603, 217);
            this.sceneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sceneImage.TabIndex = 1;
            this.sceneImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 509);
            this.Controls.Add(this.greenOutputLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.blueOutputLabel);
            this.Controls.Add(this.redOutputLabel);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.Label redOutputLabel;
        private System.Windows.Forms.Label blueOutputLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label greenOutputLabel;
    }
}

