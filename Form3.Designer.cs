namespace TrainingPractice_02
{
    partial class Form3
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
            this.startVsCpu = new System.Windows.Forms.Button();
            this.xResult = new System.Windows.Forms.Label();
            this.oResult = new System.Windows.Forms.Label();
            this.xRexultLabel = new System.Windows.Forms.Label();
            this.oRexultLabel = new System.Windows.Forms.Label();
            this.gameFieldPanel = new System.Windows.Forms.Panel();
            this.field_22 = new System.Windows.Forms.Button();
            this.field_12 = new System.Windows.Forms.Button();
            this.field_02 = new System.Windows.Forms.Button();
            this.field_21 = new System.Windows.Forms.Button();
            this.field_11 = new System.Windows.Forms.Button();
            this.field_01 = new System.Windows.Forms.Button();
            this.field_20 = new System.Windows.Forms.Button();
            this.field_10 = new System.Windows.Forms.Button();
            this.field_00 = new System.Windows.Forms.Button();
            this.gameFieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(238, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startVsCpu
            // 
            this.startVsCpu.BackColor = System.Drawing.Color.PapayaWhip;
            this.startVsCpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startVsCpu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startVsCpu.Location = new System.Drawing.Point(238, 30);
            this.startVsCpu.Name = "startVsCpu";
            this.startVsCpu.Size = new System.Drawing.Size(91, 30);
            this.startVsCpu.TabIndex = 2;
            this.startVsCpu.Text = "Начать игру";
            this.startVsCpu.UseVisualStyleBackColor = false;
            this.startVsCpu.Click += new System.EventHandler(this.startVsCpu_Click);
            // 
            // xResult
            // 
            this.xResult.AutoSize = true;
            this.xResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xResult.Location = new System.Drawing.Point(291, 97);
            this.xResult.Name = "xResult";
            this.xResult.Size = new System.Drawing.Size(24, 26);
            this.xResult.TabIndex = 12;
            this.xResult.Text = "0";
            // 
            // oResult
            // 
            this.oResult.AutoSize = true;
            this.oResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oResult.Location = new System.Drawing.Point(291, 132);
            this.oResult.Name = "oResult";
            this.oResult.Size = new System.Drawing.Size(24, 26);
            this.oResult.TabIndex = 13;
            this.oResult.Text = "0";
            // 
            // xRexultLabel
            // 
            this.xRexultLabel.AutoSize = true;
            this.xRexultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xRexultLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.xRexultLabel.Location = new System.Drawing.Point(250, 98);
            this.xRexultLabel.Name = "xRexultLabel";
            this.xRexultLabel.Size = new System.Drawing.Size(33, 26);
            this.xRexultLabel.TabIndex = 15;
            this.xRexultLabel.Text = "X:";
            // 
            // oRexultLabel
            // 
            this.oRexultLabel.AutoSize = true;
            this.oRexultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oRexultLabel.ForeColor = System.Drawing.Color.Red;
            this.oRexultLabel.Location = new System.Drawing.Point(248, 131);
            this.oRexultLabel.Name = "oRexultLabel";
            this.oRexultLabel.Size = new System.Drawing.Size(35, 26);
            this.oRexultLabel.TabIndex = 16;
            this.oRexultLabel.Text = "O:";
            // 
            // gameFieldPanel
            // 
            this.gameFieldPanel.Controls.Add(this.field_22);
            this.gameFieldPanel.Controls.Add(this.field_12);
            this.gameFieldPanel.Controls.Add(this.field_02);
            this.gameFieldPanel.Controls.Add(this.field_21);
            this.gameFieldPanel.Controls.Add(this.field_11);
            this.gameFieldPanel.Controls.Add(this.field_01);
            this.gameFieldPanel.Controls.Add(this.field_20);
            this.gameFieldPanel.Controls.Add(this.field_10);
            this.gameFieldPanel.Controls.Add(this.field_00);
            this.gameFieldPanel.Location = new System.Drawing.Point(10, 18);
            this.gameFieldPanel.Name = "gameFieldPanel";
            this.gameFieldPanel.Size = new System.Drawing.Size(215, 215);
            this.gameFieldPanel.TabIndex = 18;
            // 
            // field_22
            // 
            this.field_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_22.Location = new System.Drawing.Point(143, 145);
            this.field_22.Name = "field_22";
            this.field_22.Size = new System.Drawing.Size(60, 60);
            this.field_22.TabIndex = 8;
            this.field_22.UseVisualStyleBackColor = true;
            // 
            // field_12
            // 
            this.field_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_12.Location = new System.Drawing.Point(77, 145);
            this.field_12.Name = "field_12";
            this.field_12.Size = new System.Drawing.Size(60, 60);
            this.field_12.TabIndex = 7;
            this.field_12.UseVisualStyleBackColor = true;
            // 
            // field_02
            // 
            this.field_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_02.Location = new System.Drawing.Point(11, 145);
            this.field_02.Name = "field_02";
            this.field_02.Size = new System.Drawing.Size(60, 60);
            this.field_02.TabIndex = 6;
            this.field_02.UseVisualStyleBackColor = true;
            // 
            // field_21
            // 
            this.field_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_21.Location = new System.Drawing.Point(143, 79);
            this.field_21.Name = "field_21";
            this.field_21.Size = new System.Drawing.Size(60, 60);
            this.field_21.TabIndex = 5;
            this.field_21.UseVisualStyleBackColor = true;
            // 
            // field_11
            // 
            this.field_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_11.Location = new System.Drawing.Point(77, 79);
            this.field_11.Name = "field_11";
            this.field_11.Size = new System.Drawing.Size(60, 60);
            this.field_11.TabIndex = 4;
            this.field_11.UseVisualStyleBackColor = true;
            // 
            // field_01
            // 
            this.field_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_01.Location = new System.Drawing.Point(11, 79);
            this.field_01.Name = "field_01";
            this.field_01.Size = new System.Drawing.Size(60, 60);
            this.field_01.TabIndex = 3;
            this.field_01.UseVisualStyleBackColor = true;
            // 
            // field_20
            // 
            this.field_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_20.Location = new System.Drawing.Point(143, 12);
            this.field_20.Name = "field_20";
            this.field_20.Size = new System.Drawing.Size(60, 60);
            this.field_20.TabIndex = 2;
            this.field_20.UseVisualStyleBackColor = true;
            // 
            // field_10
            // 
            this.field_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_10.Location = new System.Drawing.Point(77, 12);
            this.field_10.Name = "field_10";
            this.field_10.Size = new System.Drawing.Size(60, 60);
            this.field_10.TabIndex = 1;
            this.field_10.UseVisualStyleBackColor = true;
            // 
            // field_00
            // 
            this.field_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field_00.Location = new System.Drawing.Point(11, 12);
            this.field_00.Name = "field_00";
            this.field_00.Size = new System.Drawing.Size(60, 60);
            this.field_00.TabIndex = 0;
            this.field_00.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(352, 250);
            this.Controls.Add(this.gameFieldPanel);
            this.Controls.Add(this.oRexultLabel);
            this.Controls.Add(this.xRexultLabel);
            this.Controls.Add(this.oResult);
            this.Controls.Add(this.xResult);
            this.Controls.Add(this.startVsCpu);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Игра";
            this.gameFieldPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startVsCpu;
        private System.Windows.Forms.Label xResult;
        private System.Windows.Forms.Label oResult;
        private System.Windows.Forms.Label xRexultLabel;
        private System.Windows.Forms.Label oRexultLabel;
        private System.Windows.Forms.Panel gameFieldPanel;
        private System.Windows.Forms.Button field_00;
        private System.Windows.Forms.Button field_22;
        private System.Windows.Forms.Button field_12;
        private System.Windows.Forms.Button field_02;
        private System.Windows.Forms.Button field_21;
        private System.Windows.Forms.Button field_11;
        private System.Windows.Forms.Button field_01;
        private System.Windows.Forms.Button field_20;
        private System.Windows.Forms.Button field_10;
    }
}