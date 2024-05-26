namespace week_7_class_assignment
{
    partial class Form2
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
            this.label_red = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.label_scorered = new System.Windows.Forms.Label();
            this.label_scoreblue = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.BackColor = System.Drawing.Color.Wheat;
            this.label_red.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_red.ForeColor = System.Drawing.Color.Salmon;
            this.label_red.Location = new System.Drawing.Point(713, 190);
            this.label_red.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(47, 24);
            this.label_red.TabIndex = 0;
            this.label_red.Text = "Red";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.BackColor = System.Drawing.Color.Wheat;
            this.label_blue.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_blue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_blue.Location = new System.Drawing.Point(863, 190);
            this.label_blue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(53, 24);
            this.label_blue.TabIndex = 1;
            this.label_blue.Text = "Blue";
            // 
            // label_scorered
            // 
            this.label_scorered.AutoSize = true;
            this.label_scorered.BackColor = System.Drawing.Color.Wheat;
            this.label_scorered.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scorered.ForeColor = System.Drawing.Color.Salmon;
            this.label_scorered.Location = new System.Drawing.Point(723, 225);
            this.label_scorered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_scorered.Name = "label_scorered";
            this.label_scorered.Size = new System.Drawing.Size(21, 24);
            this.label_scorered.TabIndex = 2;
            this.label_scorered.Text = "0";
            // 
            // label_scoreblue
            // 
            this.label_scoreblue.AutoSize = true;
            this.label_scoreblue.BackColor = System.Drawing.Color.Wheat;
            this.label_scoreblue.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scoreblue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_scoreblue.Location = new System.Drawing.Point(874, 225);
            this.label_scoreblue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_scoreblue.Name = "label_scoreblue";
            this.label_scoreblue.Size = new System.Drawing.Size(21, 24);
            this.label_scoreblue.TabIndex = 3;
            this.label_scoreblue.Text = "0";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.Wheat;
            this.guna2Shapes1.Location = new System.Drawing.Point(566, 76);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 50;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(474, 320);
            this.guna2Shapes1.TabIndex = 4;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(752, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(644, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fill all tiles with one color!";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.BackColor = System.Drawing.Color.Wheat;
            this.label_timer.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_timer.Location = new System.Drawing.Point(762, 263);
            this.label_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(101, 24);
            this.label_timer.TabIndex = 7;
            this.label_timer.Text = "00:00:000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_scoreblue);
            this.Controls.Add(this.label_scorered);
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.guna2Shapes1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Finish the Puzzle!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.Label label_scorered;
        private System.Windows.Forms.Label label_scoreblue;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_timer;
    }
}