
namespace Weir_Designer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surpressed = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.double_contract = new System.Windows.Forms.RadioButton();
            this.angle = new System.Windows.Forms.TextBox();
            this.single_contract = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.weir_type = new System.Windows.Forms.ComboBox();
            this.weir_picture = new System.Windows.Forms.PictureBox();
            this.parameter_4_tb = new System.Windows.Forms.TextBox();
            this.parameter_3_tb = new System.Windows.Forms.TextBox();
            this.parameter_2_tb = new System.Windows.Forms.TextBox();
            this.parameter_1_tb = new System.Windows.Forms.TextBox();
            this.parameter_4 = new System.Windows.Forms.Label();
            this.parameter_3 = new System.Windows.Forms.Label();
            this.parameter_2 = new System.Windows.Forms.Label();
            this.parameter_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slope = new System.Windows.Forms.TextBox();
            this.energy_gradient = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.gs_channel = new System.Windows.Forms.TextBox();
            this.downstream_depth = new System.Windows.Forms.TextBox();
            this.upstream_depth = new System.Windows.Forms.TextBox();
            this.downstream_velocity = new System.Windows.Forms.TextBox();
            this.upstream_velocity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n_value_tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.velocity_no = new System.Windows.Forms.RadioButton();
            this.velocity_yes = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.uw_water = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.coefficient_type = new System.Windows.Forms.ComboBox();
            this.coefficient_value = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear_data = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weir_picture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.surpressed);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.double_contract);
            this.groupBox1.Controls.Add(this.angle);
            this.groupBox1.Controls.Add(this.single_contract);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.weir_type);
            this.groupBox1.Controls.Add(this.weir_picture);
            this.groupBox1.Controls.Add(this.parameter_4_tb);
            this.groupBox1.Controls.Add(this.parameter_3_tb);
            this.groupBox1.Controls.Add(this.parameter_2_tb);
            this.groupBox1.Controls.Add(this.parameter_1_tb);
            this.groupBox1.Controls.Add(this.parameter_4);
            this.groupBox1.Controls.Add(this.parameter_3);
            this.groupBox1.Controls.Add(this.parameter_2);
            this.groupBox1.Controls.Add(this.parameter_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weir design";
            // 
            // surpressed
            // 
            this.surpressed.AutoSize = true;
            this.surpressed.Location = new System.Drawing.Point(278, 14);
            this.surpressed.Name = "surpressed";
            this.surpressed.Size = new System.Drawing.Size(102, 21);
            this.surpressed.TabIndex = 11;
            this.surpressed.TabStop = true;
            this.surpressed.Text = "Surpressed";
            this.surpressed.UseVisualStyleBackColor = true;
            this.surpressed.CheckedChanged += new System.EventHandler(this.surpressed_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "Select weir type";
            // 
            // double_contract
            // 
            this.double_contract.AutoSize = true;
            this.double_contract.Location = new System.Drawing.Point(278, 52);
            this.double_contract.Name = "double_contract";
            this.double_contract.Size = new System.Drawing.Size(144, 21);
            this.double_contract.TabIndex = 4;
            this.double_contract.TabStop = true;
            this.double_contract.Text = "Doubly contracted";
            this.double_contract.UseVisualStyleBackColor = true;
            this.double_contract.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(325, 36);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(100, 22);
            this.angle.TabIndex = 9;
            this.angle.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // single_contract
            // 
            this.single_contract.AutoSize = true;
            this.single_contract.Location = new System.Drawing.Point(278, 33);
            this.single_contract.Name = "single_contract";
            this.single_contract.Size = new System.Drawing.Size(146, 21);
            this.single_contract.TabIndex = 3;
            this.single_contract.TabStop = true;
            this.single_contract.Text = "Singly countracted";
            this.single_contract.UseVisualStyleBackColor = true;
            this.single_contract.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Angle";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // weir_type
            // 
            this.weir_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weir_type.FormattingEnabled = true;
            this.weir_type.Location = new System.Drawing.Point(46, 44);
            this.weir_type.Name = "weir_type";
            this.weir_type.Size = new System.Drawing.Size(205, 24);
            this.weir_type.TabIndex = 1;
            this.weir_type.SelectedIndexChanged += new System.EventHandler(this.weir_type_SelectedIndexChanged);
            // 
            // weir_picture
            // 
            this.weir_picture.Location = new System.Drawing.Point(26, 79);
            this.weir_picture.Name = "weir_picture";
            this.weir_picture.Size = new System.Drawing.Size(417, 298);
            this.weir_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weir_picture.TabIndex = 8;
            this.weir_picture.TabStop = false;
            this.weir_picture.Click += new System.EventHandler(this.weir_picture_Click);
            // 
            // parameter_4_tb
            // 
            this.parameter_4_tb.Location = new System.Drawing.Point(387, 417);
            this.parameter_4_tb.Name = "parameter_4_tb";
            this.parameter_4_tb.Size = new System.Drawing.Size(73, 22);
            this.parameter_4_tb.TabIndex = 7;
            // 
            // parameter_3_tb
            // 
            this.parameter_3_tb.Location = new System.Drawing.Point(158, 417);
            this.parameter_3_tb.Name = "parameter_3_tb";
            this.parameter_3_tb.Size = new System.Drawing.Size(73, 22);
            this.parameter_3_tb.TabIndex = 6;
            // 
            // parameter_2_tb
            // 
            this.parameter_2_tb.Location = new System.Drawing.Point(387, 385);
            this.parameter_2_tb.Name = "parameter_2_tb";
            this.parameter_2_tb.Size = new System.Drawing.Size(73, 22);
            this.parameter_2_tb.TabIndex = 5;
            // 
            // parameter_1_tb
            // 
            this.parameter_1_tb.Location = new System.Drawing.Point(158, 385);
            this.parameter_1_tb.Name = "parameter_1_tb";
            this.parameter_1_tb.Size = new System.Drawing.Size(73, 22);
            this.parameter_1_tb.TabIndex = 4;
            // 
            // parameter_4
            // 
            this.parameter_4.AutoSize = true;
            this.parameter_4.Location = new System.Drawing.Point(237, 420);
            this.parameter_4.Name = "parameter_4";
            this.parameter_4.Size = new System.Drawing.Size(86, 17);
            this.parameter_4.TabIndex = 3;
            this.parameter_4.Text = "Parameter 4";
            // 
            // parameter_3
            // 
            this.parameter_3.AutoSize = true;
            this.parameter_3.Location = new System.Drawing.Point(2, 420);
            this.parameter_3.Name = "parameter_3";
            this.parameter_3.Size = new System.Drawing.Size(86, 17);
            this.parameter_3.TabIndex = 2;
            this.parameter_3.Text = "Parameter 3";
            // 
            // parameter_2
            // 
            this.parameter_2.AutoSize = true;
            this.parameter_2.Location = new System.Drawing.Point(238, 387);
            this.parameter_2.Name = "parameter_2";
            this.parameter_2.Size = new System.Drawing.Size(86, 17);
            this.parameter_2.TabIndex = 1;
            this.parameter_2.Text = "Parameter 2";
            // 
            // parameter_1
            // 
            this.parameter_1.AutoSize = true;
            this.parameter_1.Location = new System.Drawing.Point(2, 387);
            this.parameter_1.Name = "parameter_1";
            this.parameter_1.Size = new System.Drawing.Size(86, 17);
            this.parameter_1.TabIndex = 0;
            this.parameter_1.Text = "Parameter 1";
            this.parameter_1.Click += new System.EventHandler(this.parameter_1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.slope);
            this.groupBox2.Controls.Add(this.energy_gradient);
            this.groupBox2.Controls.Add(this.distance);
            this.groupBox2.Controls.Add(this.gs_channel);
            this.groupBox2.Controls.Add(this.downstream_depth);
            this.groupBox2.Controls.Add(this.upstream_depth);
            this.groupBox2.Controls.Add(this.downstream_velocity);
            this.groupBox2.Controls.Add(this.upstream_velocity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(484, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flow description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Slope (degrees)";
            // 
            // slope
            // 
            this.slope.Location = new System.Drawing.Point(211, 173);
            this.slope.Name = "slope";
            this.slope.Size = new System.Drawing.Size(100, 22);
            this.slope.TabIndex = 19;
            // 
            // energy_gradient
            // 
            this.energy_gradient.Location = new System.Drawing.Point(211, 228);
            this.energy_gradient.Name = "energy_gradient";
            this.energy_gradient.Size = new System.Drawing.Size(100, 22);
            this.energy_gradient.TabIndex = 18;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(211, 201);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(100, 22);
            this.distance.TabIndex = 17;
            // 
            // gs_channel
            // 
            this.gs_channel.Location = new System.Drawing.Point(211, 145);
            this.gs_channel.Name = "gs_channel";
            this.gs_channel.Size = new System.Drawing.Size(100, 22);
            this.gs_channel.TabIndex = 16;
            // 
            // downstream_depth
            // 
            this.downstream_depth.Location = new System.Drawing.Point(211, 117);
            this.downstream_depth.Name = "downstream_depth";
            this.downstream_depth.Size = new System.Drawing.Size(100, 22);
            this.downstream_depth.TabIndex = 15;
            // 
            // upstream_depth
            // 
            this.upstream_depth.Location = new System.Drawing.Point(211, 88);
            this.upstream_depth.Name = "upstream_depth";
            this.upstream_depth.Size = new System.Drawing.Size(100, 22);
            this.upstream_depth.TabIndex = 14;
            // 
            // downstream_velocity
            // 
            this.downstream_velocity.Location = new System.Drawing.Point(211, 59);
            this.downstream_velocity.Name = "downstream_velocity";
            this.downstream_velocity.Size = new System.Drawing.Size(100, 22);
            this.downstream_velocity.TabIndex = 13;
            // 
            // upstream_velocity
            // 
            this.upstream_velocity.Location = new System.Drawing.Point(211, 29);
            this.upstream_velocity.Name = "upstream_velocity";
            this.upstream_velocity.Size = new System.Drawing.Size(100, 22);
            this.upstream_velocity.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Energy gradient";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Channel distance (m)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gentle slope channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Downstream depth (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Downstream velocity (m/s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Upstream depth (m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Upstream velocity (m/s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.n_value_tb);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.velocity_no);
            this.groupBox3.Controls.Add(this.velocity_yes);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.uw_water);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.coefficient_type);
            this.groupBox3.Controls.Add(this.coefficient_value);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(484, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other specifications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Specified n-value";
            // 
            // n_value_tb
            // 
            this.n_value_tb.Location = new System.Drawing.Point(211, 156);
            this.n_value_tb.Name = "n_value_tb";
            this.n_value_tb.Size = new System.Drawing.Size(100, 22);
            this.n_value_tb.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Select coefficient type";
            // 
            // velocity_no
            // 
            this.velocity_no.AutoSize = true;
            this.velocity_no.Location = new System.Drawing.Point(243, 127);
            this.velocity_no.Name = "velocity_no";
            this.velocity_no.Size = new System.Drawing.Size(47, 21);
            this.velocity_no.TabIndex = 17;
            this.velocity_no.TabStop = true;
            this.velocity_no.Text = "No";
            this.velocity_no.UseVisualStyleBackColor = true;
            this.velocity_no.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // velocity_yes
            // 
            this.velocity_yes.AutoSize = true;
            this.velocity_yes.Location = new System.Drawing.Point(187, 127);
            this.velocity_yes.Name = "velocity_yes";
            this.velocity_yes.Size = new System.Drawing.Size(53, 21);
            this.velocity_yes.TabIndex = 4;
            this.velocity_yes.TabStop = true;
            this.velocity_yes.Text = "Yes";
            this.velocity_yes.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Neglect velocity?";
            // 
            // uw_water
            // 
            this.uw_water.Location = new System.Drawing.Point(211, 94);
            this.uw_water.Name = "uw_water";
            this.uw_water.Size = new System.Drawing.Size(100, 22);
            this.uw_water.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Unit weight of water N-m/s^2";
            // 
            // coefficient_type
            // 
            this.coefficient_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coefficient_type.FormattingEnabled = true;
            this.coefficient_type.Location = new System.Drawing.Point(162, 28);
            this.coefficient_type.Name = "coefficient_type";
            this.coefficient_type.Size = new System.Drawing.Size(160, 24);
            this.coefficient_type.TabIndex = 3;
            this.coefficient_type.SelectedIndexChanged += new System.EventHandler(this.coefficient_type_SelectedIndexChanged);
            // 
            // coefficient_value
            // 
            this.coefficient_value.Location = new System.Drawing.Point(211, 62);
            this.coefficient_value.Name = "coefficient_value";
            this.coefficient_value.Size = new System.Drawing.Size(100, 22);
            this.coefficient_value.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Coefficient value";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(12, 468);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(302, 50);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear_data
            // 
            this.clear_data.ForeColor = System.Drawing.Color.Red;
            this.clear_data.Location = new System.Drawing.Point(320, 468);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(158, 50);
            this.clear_data.TabIndex = 6;
            this.clear_data.Text = "Clear data";
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(542, 478);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 25);
            this.label16.TabIndex = 18;
            this.label16.Text = "WEIR DESIGNER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 542);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.clear_data);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Weir calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weir_picture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox weir_type;
        private System.Windows.Forms.PictureBox weir_picture;
        private System.Windows.Forms.TextBox parameter_4_tb;
        private System.Windows.Forms.TextBox parameter_3_tb;
        private System.Windows.Forms.TextBox parameter_2_tb;
        private System.Windows.Forms.TextBox parameter_1_tb;
        private System.Windows.Forms.Label parameter_4;
        private System.Windows.Forms.Label parameter_3;
        private System.Windows.Forms.Label parameter_2;
        private System.Windows.Forms.Label parameter_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox energy_gradient;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox gs_channel;
        private System.Windows.Forms.TextBox downstream_depth;
        private System.Windows.Forms.TextBox upstream_depth;
        private System.Windows.Forms.TextBox downstream_velocity;
        private System.Windows.Forms.TextBox upstream_velocity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton double_contract;
        private System.Windows.Forms.RadioButton single_contract;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton velocity_no;
        private System.Windows.Forms.RadioButton velocity_yes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uw_water;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox coefficient_type;
        private System.Windows.Forms.TextBox coefficient_value;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slope;
        private System.Windows.Forms.RadioButton surpressed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_value_tb;
    }
}

