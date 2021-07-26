
namespace Drink_Vending_Machine_Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CokePanel = new System.Windows.Forms.Panel();
            this.CokeStockOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CokeBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PepperStockOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PepperBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FantaStockOutput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FantaBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PepsiStockOutput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PepsiBox = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SpriteStockOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SpriteBox = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SaleOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CokePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CokeBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PepperBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FantaBox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PepsiBox)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "COKE.png");
            this.imageList1.Images.SetKeyName(1, "FANTA.jpg");
            this.imageList1.Images.SetKeyName(2, "PEPSI.png");
            this.imageList1.Images.SetKeyName(3, "SPRITE.png");
            this.imageList1.Images.SetKeyName(4, "DRPEPPER.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Drink";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CokePanel);
            this.panel1.Location = new System.Drawing.Point(512, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // CokePanel
            // 
            this.CokePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CokePanel.Controls.Add(this.CokeStockOutput);
            this.CokePanel.Controls.Add(this.label3);
            this.CokePanel.Controls.Add(this.label2);
            this.CokePanel.Controls.Add(this.CokeBox);
            this.CokePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CokePanel.Location = new System.Drawing.Point(-1, -1);
            this.CokePanel.Name = "CokePanel";
            this.CokePanel.Size = new System.Drawing.Size(200, 100);
            this.CokePanel.TabIndex = 2;
            // 
            // CokeStockOutput
            // 
            this.CokeStockOutput.AutoSize = true;
            this.CokeStockOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CokeStockOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CokeStockOutput.Location = new System.Drawing.Point(132, 69);
            this.CokeStockOutput.Name = "CokeStockOutput";
            this.CokeStockOutput.Size = new System.Drawing.Size(21, 15);
            this.CokeStockOutput.TabIndex = 3;
            this.CokeStockOutput.Text = "20";
            this.CokeStockOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks Left: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "£0.85";
            // 
            // CokeBox
            // 
            this.CokeBox.Image = ((System.Drawing.Image)(resources.GetObject("CokeBox.Image")));
            this.CokeBox.Location = new System.Drawing.Point(3, 3);
            this.CokeBox.Name = "CokeBox";
            this.CokeBox.Size = new System.Drawing.Size(100, 92);
            this.CokeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CokeBox.TabIndex = 0;
            this.CokeBox.TabStop = false;
            this.CokeBox.Click += new System.EventHandler(this.CokeBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PepperStockOutput);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.PepperBox);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(737, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // PepperStockOutput
            // 
            this.PepperStockOutput.AutoSize = true;
            this.PepperStockOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PepperStockOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperStockOutput.Location = new System.Drawing.Point(132, 69);
            this.PepperStockOutput.Name = "PepperStockOutput";
            this.PepperStockOutput.Size = new System.Drawing.Size(21, 15);
            this.PepperStockOutput.TabIndex = 3;
            this.PepperStockOutput.Text = "20";
            this.PepperStockOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Drinks Left: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "£0.85";
            // 
            // PepperBox
            // 
            this.PepperBox.Image = ((System.Drawing.Image)(resources.GetObject("PepperBox.Image")));
            this.PepperBox.Location = new System.Drawing.Point(3, 3);
            this.PepperBox.Name = "PepperBox";
            this.PepperBox.Size = new System.Drawing.Size(100, 92);
            this.PepperBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PepperBox.TabIndex = 0;
            this.PepperBox.TabStop = false;
            this.PepperBox.Click += new System.EventHandler(this.PepperBox_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.FantaStockOutput);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.FantaBox);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(512, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // FantaStockOutput
            // 
            this.FantaStockOutput.AutoSize = true;
            this.FantaStockOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FantaStockOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FantaStockOutput.Location = new System.Drawing.Point(132, 69);
            this.FantaStockOutput.Name = "FantaStockOutput";
            this.FantaStockOutput.Size = new System.Drawing.Size(21, 15);
            this.FantaStockOutput.TabIndex = 3;
            this.FantaStockOutput.Text = "20";
            this.FantaStockOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Drinks Left: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "£1.00";
            // 
            // FantaBox
            // 
            this.FantaBox.Image = ((System.Drawing.Image)(resources.GetObject("FantaBox.Image")));
            this.FantaBox.Location = new System.Drawing.Point(3, 3);
            this.FantaBox.Name = "FantaBox";
            this.FantaBox.Size = new System.Drawing.Size(100, 92);
            this.FantaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FantaBox.TabIndex = 0;
            this.FantaBox.TabStop = false;
            this.FantaBox.Click += new System.EventHandler(this.FantaBox_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.PepsiStockOutput);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.PepsiBox);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(737, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 5;
            // 
            // PepsiStockOutput
            // 
            this.PepsiStockOutput.AutoSize = true;
            this.PepsiStockOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PepsiStockOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepsiStockOutput.Location = new System.Drawing.Point(132, 69);
            this.PepsiStockOutput.Name = "PepsiStockOutput";
            this.PepsiStockOutput.Size = new System.Drawing.Size(21, 15);
            this.PepsiStockOutput.TabIndex = 3;
            this.PepsiStockOutput.Text = "20";
            this.PepsiStockOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Drinks Left: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "£1.00";
            // 
            // PepsiBox
            // 
            this.PepsiBox.Image = ((System.Drawing.Image)(resources.GetObject("PepsiBox.Image")));
            this.PepsiBox.Location = new System.Drawing.Point(3, 3);
            this.PepsiBox.Name = "PepsiBox";
            this.PepsiBox.Size = new System.Drawing.Size(100, 92);
            this.PepsiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PepsiBox.TabIndex = 0;
            this.PepsiBox.TabStop = false;
            this.PepsiBox.Click += new System.EventHandler(this.PepsiBox_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.SpriteStockOutput);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.SpriteBox);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(512, 378);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 6;
            // 
            // SpriteStockOutput
            // 
            this.SpriteStockOutput.AutoSize = true;
            this.SpriteStockOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpriteStockOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteStockOutput.Location = new System.Drawing.Point(132, 69);
            this.SpriteStockOutput.Name = "SpriteStockOutput";
            this.SpriteStockOutput.Size = new System.Drawing.Size(21, 15);
            this.SpriteStockOutput.TabIndex = 3;
            this.SpriteStockOutput.Text = "20";
            this.SpriteStockOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Drinks Left: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(132, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "£0.50";
            // 
            // SpriteBox
            // 
            this.SpriteBox.Image = ((System.Drawing.Image)(resources.GetObject("SpriteBox.Image")));
            this.SpriteBox.Location = new System.Drawing.Point(3, 3);
            this.SpriteBox.Name = "SpriteBox";
            this.SpriteBox.Size = new System.Drawing.Size(100, 92);
            this.SpriteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpriteBox.TabIndex = 0;
            this.SpriteBox.TabStop = false;
            this.SpriteBox.Click += new System.EventHandler(this.SpriteBox_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.SaleOutput);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(737, 378);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 4;
            // 
            // SaleOutput
            // 
            this.SaleOutput.AutoEllipsis = true;
            this.SaleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaleOutput.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.SaleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleOutput.Location = new System.Drawing.Point(38, 41);
            this.SaleOutput.Name = "SaleOutput";
            this.SaleOutput.Size = new System.Drawing.Size(123, 18);
            this.SaleOutput.TabIndex = 8;
            this.SaleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Sale Cost: ";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(689, 511);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 915);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Drink Vending Machine Simulator";
            this.panel1.ResumeLayout(false);
            this.CokePanel.ResumeLayout(false);
            this.CokePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CokeBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PepperBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FantaBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PepsiBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CokePanel;
        private System.Windows.Forms.Label CokeStockOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CokeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PepperStockOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PepperBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label FantaStockOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox FantaBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label PepsiStockOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PepsiBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label SpriteStockOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox SpriteBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label SaleOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitButton;
    }
}

