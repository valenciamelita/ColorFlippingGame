namespace week_7_class_assignment
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
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.button_number = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_input
            // 
            this.textbox_input.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_input.Location = new System.Drawing.Point(162, 112);
            this.textbox_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(93, 27);
            this.textbox_input.TabIndex = 0;
            this.textbox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_input_KeyPress);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_input.Location = new System.Drawing.Point(26, 85);
            this.label_input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(378, 22);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Please Input a Number for your board\'s size";
            // 
            // button_number
            // 
            this.button_number.BackColor = System.Drawing.Color.LightSalmon;
            this.button_number.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_number.Location = new System.Drawing.Point(152, 184);
            this.button_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_number.Name = "button_number";
            this.button_number.Size = new System.Drawing.Size(112, 35);
            this.button_number.TabIndex = 2;
            this.button_number.Text = "Play";
            this.button_number.UseVisualStyleBackColor = false;
            this.button_number.Click += new System.EventHandler(this.button_number_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "COLOR FLIPPING PUZZLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "*at least 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(435, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_number);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textbox_input);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Welcome to the Game!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_input;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Button button_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

