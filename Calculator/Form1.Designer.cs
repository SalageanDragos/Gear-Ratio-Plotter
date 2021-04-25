namespace Calculator
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
            this.MassH_Text = new System.Windows.Forms.TextBox();
            this.TorqueH_Text = new System.Windows.Forms.TextBox();
            this.Distance_Label = new System.Windows.Forms.Label();
            this.Torque_Label = new System.Windows.Forms.Label();
            this.RPM_Label = new System.Windows.Forms.Label();
            this.RPMH_Text = new System.Windows.Forms.TextBox();
            this.CalculateHoriz_Button = new System.Windows.Forms.Button();
            this.Mass_Label = new System.Windows.Forms.Label();
            this.RadiusH_Text = new System.Windows.Forms.TextBox();
            this.DistanceH_Text = new System.Windows.Forms.TextBox();
            this.Radius_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.CalculateVeri_Button = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MassH_Text
            // 
            this.MassH_Text.Location = new System.Drawing.Point(1441, 627);
            this.MassH_Text.Name = "MassH_Text";
            this.MassH_Text.Size = new System.Drawing.Size(100, 20);
            this.MassH_Text.TabIndex = 0;
            // 
            // TorqueH_Text
            // 
            this.TorqueH_Text.Location = new System.Drawing.Point(1441, 653);
            this.TorqueH_Text.Name = "TorqueH_Text";
            this.TorqueH_Text.Size = new System.Drawing.Size(100, 20);
            this.TorqueH_Text.TabIndex = 0;
            // 
            // Distance_Label
            // 
            this.Distance_Label.AutoSize = true;
            this.Distance_Label.Location = new System.Drawing.Point(1386, 578);
            this.Distance_Label.Name = "Distance_Label";
            this.Distance_Label.Size = new System.Drawing.Size(49, 13);
            this.Distance_Label.TabIndex = 1;
            this.Distance_Label.Text = "Distance";
            // 
            // Torque_Label
            // 
            this.Torque_Label.AutoSize = true;
            this.Torque_Label.Location = new System.Drawing.Point(1357, 656);
            this.Torque_Label.Name = "Torque_Label";
            this.Torque_Label.Size = new System.Drawing.Size(78, 13);
            this.Torque_Label.TabIndex = 2;
            this.Torque_Label.Text = "Motor\'s Torque";
            // 
            // RPM_Label
            // 
            this.RPM_Label.AutoSize = true;
            this.RPM_Label.Location = new System.Drawing.Point(1367, 682);
            this.RPM_Label.Name = "RPM_Label";
            this.RPM_Label.Size = new System.Drawing.Size(68, 13);
            this.RPM_Label.TabIndex = 3;
            this.RPM_Label.Text = "Motor\'s RPM";
            // 
            // RPMH_Text
            // 
            this.RPMH_Text.Location = new System.Drawing.Point(1441, 679);
            this.RPMH_Text.Name = "RPMH_Text";
            this.RPMH_Text.Size = new System.Drawing.Size(100, 20);
            this.RPMH_Text.TabIndex = 0;
            // 
            // CalculateHoriz_Button
            // 
            this.CalculateHoriz_Button.Location = new System.Drawing.Point(1474, 726);
            this.CalculateHoriz_Button.Name = "CalculateHoriz_Button";
            this.CalculateHoriz_Button.Size = new System.Drawing.Size(100, 44);
            this.CalculateHoriz_Button.TabIndex = 4;
            this.CalculateHoriz_Button.Text = "Horizontal Movement";
            this.CalculateHoriz_Button.UseVisualStyleBackColor = true;
            this.CalculateHoriz_Button.Click += new System.EventHandler(this.CalculateHorizontal_Button_Click);
            // 
            // Mass_Label
            // 
            this.Mass_Label.AutoSize = true;
            this.Mass_Label.Location = new System.Drawing.Point(1403, 630);
            this.Mass_Label.Name = "Mass_Label";
            this.Mass_Label.Size = new System.Drawing.Size(32, 13);
            this.Mass_Label.TabIndex = 1;
            this.Mass_Label.Text = "Mass";
            // 
            // RadiusH_Text
            // 
            this.RadiusH_Text.Location = new System.Drawing.Point(1441, 601);
            this.RadiusH_Text.Name = "RadiusH_Text";
            this.RadiusH_Text.Size = new System.Drawing.Size(100, 20);
            this.RadiusH_Text.TabIndex = 0;
            this.RadiusH_Text.TextChanged += new System.EventHandler(this.Radius_Text_TextChanged);
            // 
            // DistanceH_Text
            // 
            this.DistanceH_Text.Location = new System.Drawing.Point(1441, 575);
            this.DistanceH_Text.Name = "DistanceH_Text";
            this.DistanceH_Text.Size = new System.Drawing.Size(100, 20);
            this.DistanceH_Text.TabIndex = 0;
            // 
            // Radius_Label
            // 
            this.Radius_Label.AutoSize = true;
            this.Radius_Label.Location = new System.Drawing.Point(1361, 604);
            this.Radius_Label.Name = "Radius_Label";
            this.Radius_Label.Size = new System.Drawing.Size(74, 13);
            this.Radius_Label.TabIndex = 1;
            this.Radius_Label.Text = "Wheel Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1547, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1547, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1547, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1547, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "N*m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1547, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = " ";
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Location = new System.Drawing.Point(1357, 414);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(0, 13);
            this.Min_Label.TabIndex = 5;
            // 
            // CalculateVeri_Button
            // 
            this.CalculateVeri_Button.Location = new System.Drawing.Point(1360, 726);
            this.CalculateVeri_Button.Name = "CalculateVeri_Button";
            this.CalculateVeri_Button.Size = new System.Drawing.Size(100, 44);
            this.CalculateVeri_Button.TabIndex = 4;
            this.CalculateVeri_Button.Text = "Vertical Movement";
            this.CalculateVeri_Button.UseVisualStyleBackColor = true;
            this.CalculateVeri_Button.Click += new System.EventHandler(this.CalculateVertical_Button_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1367, 522);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 24);
            this.label27.TabIndex = 1;
            this.label27.Text = "Linear Movement";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(1357, 463);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 812);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.CalculateVeri_Button);
            this.Controls.Add(this.CalculateHoriz_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RPM_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Torque_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mass_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Radius_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Distance_Label);
            this.Controls.Add(this.RPMH_Text);
            this.Controls.Add(this.DistanceH_Text);
            this.Controls.Add(this.TorqueH_Text);
            this.Controls.Add(this.RadiusH_Text);
            this.Controls.Add(this.MassH_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MassH_Text;
        private System.Windows.Forms.TextBox TorqueH_Text;
        private System.Windows.Forms.Label Distance_Label;
        private System.Windows.Forms.Label Torque_Label;
        private System.Windows.Forms.Label RPM_Label;
        private System.Windows.Forms.TextBox RPMH_Text;
        private System.Windows.Forms.Button CalculateHoriz_Button;
        private System.Windows.Forms.Label Mass_Label;
        private System.Windows.Forms.TextBox RadiusH_Text;
        private System.Windows.Forms.TextBox DistanceH_Text;
        private System.Windows.Forms.Label Radius_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.Button CalculateVeri_Button;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label timeLabel;
    }
}

