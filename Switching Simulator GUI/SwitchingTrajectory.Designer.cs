﻿namespace WindowsFormsApplication1
{
    partial class SwitchingTrajectory
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
            this.cbShotNoise = new System.Windows.Forms.CheckBox();
            this.tbSaveDirectory = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_start_simulation = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbDownPulse = new System.Windows.Forms.TextBox();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.tbSTime = new System.Windows.Forms.TextBox();
            this.tbPTime = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_d_sh_ent = new System.Windows.Forms.TextBox();
            this.tbDelta_time = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.jz_ent = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.jy_ent = new System.Windows.Forms.TextBox();
            this.jx_ent = new System.Windows.Forms.TextBox();
            this.h_z_ent = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.h_y_ent = new System.Windows.Forms.TextBox();
            this.h_x_ent = new System.Windows.Forms.TextBox();
            this.d_th_ent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCycles = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cbFieldTorque = new System.Windows.Forms.CheckBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbIac = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.Pz_ent = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Py_ent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Px_ent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.I_ent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Hx_ent = new System.Windows.Forms.TextBox();
            this.Hy_ent = new System.Windows.Forms.TextBox();
            this.cbHunits = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Hz_ent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.M_ent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Temp_ent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Nzz_ent = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Nyy_ent = new System.Windows.Forms.TextBox();
            this.cbMunits = new System.Windows.Forms.ComboBox();
            this.Nxx_ent = new System.Windows.Forms.TextBox();
            this.Alpha_ent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Thickness_ent = new System.Windows.Forms.TextBox();
            this.Area_ent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tb_theta_initial = new System.Windows.Forms.TextBox();
            this.tb_phi_initial = new System.Windows.Forms.TextBox();
            this.cb_initial_conditions = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShotNoise
            // 
            this.cbShotNoise.AutoSize = true;
            this.cbShotNoise.Location = new System.Drawing.Point(537, 289);
            this.cbShotNoise.Name = "cbShotNoise";
            this.cbShotNoise.Size = new System.Drawing.Size(91, 17);
            this.cbShotNoise.TabIndex = 124;
            this.cbShotNoise.Text = "Shot noise on";
            this.cbShotNoise.UseVisualStyleBackColor = true;
            // 
            // tbSaveDirectory
            // 
            this.tbSaveDirectory.Location = new System.Drawing.Point(128, 532);
            this.tbSaveDirectory.Name = "tbSaveDirectory";
            this.tbSaveDirectory.Size = new System.Drawing.Size(496, 20);
            this.tbSaveDirectory.TabIndex = 123;
            this.tbSaveDirectory.Text = "C:\\Users\\Tom\\Desktop\\Matlab\\new\\alpha scale";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(28, 532);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(85, 13);
            this.label34.TabIndex = 122;
            this.label34.Text = "Saving Directory";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(537, 324);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(126, 23);
            this.btn_convert.TabIndex = 116;
            this.btn_convert.Text = "Convert to Unitless";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_start_simulation
            // 
            this.btn_start_simulation.Location = new System.Drawing.Point(537, 363);
            this.btn_start_simulation.Name = "btn_start_simulation";
            this.btn_start_simulation.Size = new System.Drawing.Size(126, 23);
            this.btn_start_simulation.TabIndex = 115;
            this.btn_start_simulation.Text = "Start Simulation";
            this.btn_start_simulation.UseVisualStyleBackColor = true;
            this.btn_start_simulation.Click += new System.EventHandler(this.btn_start_simulation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.tbDownPulse);
            this.groupBox5.Controls.Add(this.cbSave);
            this.groupBox5.Controls.Add(this.tbSTime);
            this.groupBox5.Controls.Add(this.tbPTime);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.cbType);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(13, 415);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 94);
            this.groupBox5.TabIndex = 121;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulation Details";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(158, 65);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(64, 13);
            this.label36.TabIndex = 9;
            this.label36.Text = "Down Pulse";
            // 
            // tbDownPulse
            // 
            this.tbDownPulse.Location = new System.Drawing.Point(223, 62);
            this.tbDownPulse.Name = "tbDownPulse";
            this.tbDownPulse.Size = new System.Drawing.Size(74, 20);
            this.tbDownPulse.TabIndex = 7;
            this.tbDownPulse.Text = "0.0";
            this.tbDownPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Location = new System.Drawing.Point(378, 65);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(77, 17);
            this.cbSave.TabIndex = 6;
            this.cbSave.Text = "Save Data";
            this.cbSave.UseVisualStyleBackColor = true;
            // 
            // tbSTime
            // 
            this.tbSTime.Location = new System.Drawing.Point(374, 23);
            this.tbSTime.Name = "tbSTime";
            this.tbSTime.Size = new System.Drawing.Size(76, 20);
            this.tbSTime.TabIndex = 5;
            this.tbSTime.Text = "1000.0";
            this.tbSTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPTime
            // 
            this.tbPTime.Location = new System.Drawing.Point(223, 23);
            this.tbPTime.Name = "tbPTime";
            this.tbPTime.Size = new System.Drawing.Size(74, 20);
            this.tbPTime.TabIndex = 4;
            this.tbPTime.Text = "1000.0";
            this.tbPTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(314, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 3;
            this.label35.Text = "Sim Time";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(158, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Pulse Time";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "theta",
            "phi",
            "energy",
            "trajectory",
            "x vs t",
            "y vs t",
            "z vs t",
            "all"});
            this.cbType.Location = new System.Drawing.Point(52, 23);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(93, 21);
            this.cbType.TabIndex = 1;
            this.cbType.Text = "Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.tb_d_sh_ent);
            this.groupBox4.Controls.Add(this.tbDelta_time);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.jz_ent);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.jy_ent);
            this.groupBox4.Controls.Add(this.jx_ent);
            this.groupBox4.Controls.Add(this.h_z_ent);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.h_y_ent);
            this.groupBox4.Controls.Add(this.h_x_ent);
            this.groupBox4.Controls.Add(this.d_th_ent);
            this.groupBox4.Location = new System.Drawing.Point(514, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 262);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unitless Values";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 75;
            this.label30.Text = "d_sh";
            // 
            // tb_d_sh_ent
            // 
            this.tb_d_sh_ent.Location = new System.Drawing.Point(56, 52);
            this.tb_d_sh_ent.Name = "tb_d_sh_ent";
            this.tb_d_sh_ent.Size = new System.Drawing.Size(86, 20);
            this.tb_d_sh_ent.TabIndex = 74;
            this.tb_d_sh_ent.Text = "0";
            this.tb_d_sh_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDelta_time
            // 
            this.tbDelta_time.Location = new System.Drawing.Point(56, 233);
            this.tbDelta_time.Name = "tbDelta_time";
            this.tbDelta_time.Size = new System.Drawing.Size(86, 20);
            this.tbDelta_time.TabIndex = 73;
            this.tbDelta_time.Text = "0";
            this.tbDelta_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 237);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 72;
            this.label28.Text = "del time";
            // 
            // jz_ent
            // 
            this.jz_ent.Location = new System.Drawing.Point(56, 208);
            this.jz_ent.Name = "jz_ent";
            this.jz_ent.Size = new System.Drawing.Size(86, 20);
            this.jz_ent.TabIndex = 15;
            this.jz_ent.Text = "0";
            this.jz_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "jz";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(36, 185);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "jy";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "jx";
            // 
            // jy_ent
            // 
            this.jy_ent.Location = new System.Drawing.Point(56, 182);
            this.jy_ent.Name = "jy_ent";
            this.jy_ent.Size = new System.Drawing.Size(86, 20);
            this.jy_ent.TabIndex = 11;
            this.jy_ent.Text = "0";
            this.jy_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jx_ent
            // 
            this.jx_ent.Location = new System.Drawing.Point(56, 156);
            this.jx_ent.Name = "jx_ent";
            this.jx_ent.Size = new System.Drawing.Size(86, 20);
            this.jx_ent.TabIndex = 10;
            this.jx_ent.Text = "0";
            this.jx_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // h_z_ent
            // 
            this.h_z_ent.Location = new System.Drawing.Point(56, 130);
            this.h_z_ent.Name = "h_z_ent";
            this.h_z_ent.Size = new System.Drawing.Size(86, 20);
            this.h_z_ent.TabIndex = 9;
            this.h_z_ent.Text = "0";
            this.h_z_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "hz";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 107);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "hy";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "hx";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "d_th";
            // 
            // h_y_ent
            // 
            this.h_y_ent.Location = new System.Drawing.Point(56, 104);
            this.h_y_ent.Name = "h_y_ent";
            this.h_y_ent.Size = new System.Drawing.Size(86, 20);
            this.h_y_ent.TabIndex = 3;
            this.h_y_ent.Text = "0";
            this.h_y_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // h_x_ent
            // 
            this.h_x_ent.Location = new System.Drawing.Point(56, 78);
            this.h_x_ent.Name = "h_x_ent";
            this.h_x_ent.Size = new System.Drawing.Size(86, 20);
            this.h_x_ent.TabIndex = 2;
            this.h_x_ent.Text = "0";
            this.h_x_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // d_th_ent
            // 
            this.d_th_ent.Location = new System.Drawing.Point(56, 26);
            this.d_th_ent.Name = "d_th_ent";
            this.d_th_ent.Size = new System.Drawing.Size(86, 20);
            this.d_th_ent.TabIndex = 1;
            this.d_th_ent.Text = "0";
            this.d_th_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCycles);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.cbFieldTorque);
            this.groupBox3.Controls.Add(this.tbPeriod);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.tbIac);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.Pz_ent);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.Py_ent);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Px_ent);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.I_ent);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 142);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spin Current";
            // 
            // tbCycles
            // 
            this.tbCycles.Location = new System.Drawing.Point(356, 71);
            this.tbCycles.Name = "tbCycles";
            this.tbCycles.Size = new System.Drawing.Size(61, 20);
            this.tbCycles.TabIndex = 92;
            this.tbCycles.Text = "0.0";
            this.tbCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(319, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 13);
            this.label37.TabIndex = 91;
            this.label37.Text = "Cycles";
            // 
            // cbFieldTorque
            // 
            this.cbFieldTorque.AutoSize = true;
            this.cbFieldTorque.Location = new System.Drawing.Point(28, 109);
            this.cbFieldTorque.Name = "cbFieldTorque";
            this.cbFieldTorque.Size = new System.Drawing.Size(85, 17);
            this.cbFieldTorque.TabIndex = 90;
            this.cbFieldTorque.Text = "Field Torque";
            this.cbFieldTorque.UseVisualStyleBackColor = true;
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(219, 71);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(56, 20);
            this.tbPeriod.TabIndex = 89;
            this.tbPeriod.Text = "0.0";
            this.tbPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(183, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 88;
            this.label33.Text = "Period";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(109, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 13);
            this.label32.TabIndex = 87;
            this.label32.Text = "Amps";
            // 
            // tbIac
            // 
            this.tbIac.Location = new System.Drawing.Point(47, 71);
            this.tbIac.Name = "tbIac";
            this.tbIac.Size = new System.Drawing.Size(59, 20);
            this.tbIac.TabIndex = 86;
            this.tbIac.Text = "0.00033";
            this.tbIac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 74);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 13);
            this.label31.TabIndex = 85;
            this.label31.Text = "I ac";
            // 
            // Pz_ent
            // 
            this.Pz_ent.Location = new System.Drawing.Point(371, 29);
            this.Pz_ent.Name = "Pz_ent";
            this.Pz_ent.Size = new System.Drawing.Size(59, 20);
            this.Pz_ent.TabIndex = 84;
            this.Pz_ent.Text = "1.0";
            this.Pz_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(346, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 83;
            this.label19.Text = "Pz";
            // 
            // Py_ent
            // 
            this.Py_ent.Location = new System.Drawing.Point(279, 29);
            this.Py_ent.Name = "Py_ent";
            this.Py_ent.Size = new System.Drawing.Size(61, 20);
            this.Py_ent.TabIndex = 82;
            this.Py_ent.Text = "0.0";
            this.Py_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(254, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "Py";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Amps";
            // 
            // Px_ent
            // 
            this.Px_ent.Location = new System.Drawing.Point(194, 29);
            this.Px_ent.Name = "Px_ent";
            this.Px_ent.Size = new System.Drawing.Size(54, 20);
            this.Px_ent.TabIndex = 79;
            this.Px_ent.Text = "1.0";
            this.Px_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Px";
            // 
            // I_ent
            // 
            this.I_ent.Location = new System.Drawing.Point(47, 29);
            this.I_ent.Name = "I_ent";
            this.I_ent.Size = new System.Drawing.Size(59, 20);
            this.I_ent.TabIndex = 73;
            this.I_ent.Text = "0.0";
            this.I_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "I dc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Hx_ent);
            this.groupBox2.Controls.Add(this.Hy_ent);
            this.groupBox2.Controls.Add(this.cbHunits);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Hz_ent);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 57);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Field";
            // 
            // Hx_ent
            // 
            this.Hx_ent.Location = new System.Drawing.Point(48, 19);
            this.Hx_ent.Name = "Hx_ent";
            this.Hx_ent.Size = new System.Drawing.Size(59, 20);
            this.Hx_ent.TabIndex = 81;
            this.Hx_ent.Text = "0.0";
            this.Hx_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Hy_ent
            // 
            this.Hy_ent.Location = new System.Drawing.Point(159, 20);
            this.Hy_ent.Name = "Hy_ent";
            this.Hy_ent.Size = new System.Drawing.Size(59, 20);
            this.Hy_ent.TabIndex = 82;
            this.Hy_ent.Text = "0.0";
            this.Hy_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbHunits
            // 
            this.cbHunits.FormattingEnabled = true;
            this.cbHunits.Items.AddRange(new object[] {
            "A/m",
            "Oe"});
            this.cbHunits.Location = new System.Drawing.Point(364, 20);
            this.cbHunits.Name = "cbHunits";
            this.cbHunits.Size = new System.Drawing.Size(65, 21);
            this.cbHunits.TabIndex = 87;
            this.cbHunits.Text = "Units";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Hx";
            // 
            // Hz_ent
            // 
            this.Hz_ent.Location = new System.Drawing.Point(282, 22);
            this.Hz_ent.Name = "Hz_ent";
            this.Hz_ent.Size = new System.Drawing.Size(59, 20);
            this.Hz_ent.TabIndex = 83;
            this.Hz_ent.Text = "0.0";
            this.Hz_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Hz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Hy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.M_ent);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Temp_ent);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Nzz_ent);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Nyy_ent);
            this.groupBox1.Controls.Add(this.cbMunits);
            this.groupBox1.Controls.Add(this.Nxx_ent);
            this.groupBox1.Controls.Add(this.Alpha_ent);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Thickness_ent);
            this.groupBox1.Controls.Add(this.Area_ent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 124);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "k";
            // 
            // M_ent
            // 
            this.M_ent.Location = new System.Drawing.Point(48, 21);
            this.M_ent.Name = "M_ent";
            this.M_ent.Size = new System.Drawing.Size(59, 20);
            this.M_ent.TabIndex = 0;
            this.M_ent.Text = "1200";
            this.M_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Nzz";
            // 
            // Temp_ent
            // 
            this.Temp_ent.Location = new System.Drawing.Point(265, 23);
            this.Temp_ent.Name = "Temp_ent";
            this.Temp_ent.Size = new System.Drawing.Size(69, 20);
            this.Temp_ent.TabIndex = 105;
            this.Temp_ent.Text = "0.0";
            this.Temp_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(128, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 102;
            this.label15.Text = "Nyy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "M";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 101;
            this.label16.Text = "Nxx";
            // 
            // Nzz_ent
            // 
            this.Nzz_ent.Location = new System.Drawing.Point(282, 91);
            this.Nzz_ent.Name = "Nzz_ent";
            this.Nzz_ent.Size = new System.Drawing.Size(59, 20);
            this.Nzz_ent.TabIndex = 100;
            this.Nzz_ent.Text = "0.012";
            this.Nzz_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 104;
            this.label17.Text = "Temperature";
            // 
            // Nyy_ent
            // 
            this.Nyy_ent.Location = new System.Drawing.Point(159, 91);
            this.Nyy_ent.Name = "Nyy_ent";
            this.Nyy_ent.Size = new System.Drawing.Size(59, 20);
            this.Nyy_ent.TabIndex = 99;
            this.Nyy_ent.Text = "0.045";
            this.Nyy_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbMunits
            // 
            this.cbMunits.FormattingEnabled = true;
            this.cbMunits.Items.AddRange(new object[] {
            "A/m",
            "Emu/cm^3"});
            this.cbMunits.Location = new System.Drawing.Point(113, 21);
            this.cbMunits.Name = "cbMunits";
            this.cbMunits.Size = new System.Drawing.Size(69, 21);
            this.cbMunits.TabIndex = 90;
            this.cbMunits.Text = "Units";
            // 
            // Nxx_ent
            // 
            this.Nxx_ent.Location = new System.Drawing.Point(48, 91);
            this.Nxx_ent.Name = "Nxx_ent";
            this.Nxx_ent.Size = new System.Drawing.Size(59, 20);
            this.Nxx_ent.TabIndex = 98;
            this.Nxx_ent.Text = "0.943";
            this.Nxx_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Alpha_ent
            // 
            this.Alpha_ent.Location = new System.Drawing.Point(416, 23);
            this.Alpha_ent.Name = "Alpha_ent";
            this.Alpha_ent.Size = new System.Drawing.Size(59, 20);
            this.Alpha_ent.TabIndex = 72;
            this.Alpha_ent.Text = "0.015";
            this.Alpha_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "nm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Alpha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "nm^2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Area";
            // 
            // Thickness_ent
            // 
            this.Thickness_ent.Location = new System.Drawing.Point(239, 56);
            this.Thickness_ent.Name = "Thickness_ent";
            this.Thickness_ent.Size = new System.Drawing.Size(75, 20);
            this.Thickness_ent.TabIndex = 95;
            this.Thickness_ent.Text = "2.0";
            this.Thickness_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Area_ent
            // 
            this.Area_ent.Location = new System.Drawing.Point(48, 56);
            this.Area_ent.Name = "Area_ent";
            this.Area_ent.Size = new System.Drawing.Size(59, 20);
            this.Area_ent.TabIndex = 92;
            this.Area_ent.Text = "9900.0";
            this.Area_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Thickness";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_initial_conditions);
            this.groupBox6.Controls.Add(this.tb_phi_initial);
            this.groupBox6.Controls.Add(this.tb_theta_initial);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Location = new System.Drawing.Point(15, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(477, 56);
            this.groupBox6.TabIndex = 125;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Initial coordinates";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(18, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Theta";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(153, 29);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(22, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "Phi";
            // 
            // tb_theta_initial
            // 
            this.tb_theta_initial.Location = new System.Drawing.Point(59, 26);
            this.tb_theta_initial.Name = "tb_theta_initial";
            this.tb_theta_initial.Size = new System.Drawing.Size(68, 20);
            this.tb_theta_initial.TabIndex = 2;
            this.tb_theta_initial.Text = "0.01";
            this.tb_theta_initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_phi_initial
            // 
            this.tb_phi_initial.Location = new System.Drawing.Point(181, 26);
            this.tb_phi_initial.Name = "tb_phi_initial";
            this.tb_phi_initial.Size = new System.Drawing.Size(65, 20);
            this.tb_phi_initial.TabIndex = 3;
            this.tb_phi_initial.Text = "0.0";
            this.tb_phi_initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_initial_conditions
            // 
            this.cb_initial_conditions.AutoSize = true;
            this.cb_initial_conditions.Location = new System.Drawing.Point(275, 28);
            this.cb_initial_conditions.Name = "cb_initial_conditions";
            this.cb_initial_conditions.Size = new System.Drawing.Size(138, 17);
            this.cb_initial_conditions.TabIndex = 4;
            this.cb_initial_conditions.Text = "Manual initial conditions";
            this.cb_initial_conditions.UseVisualStyleBackColor = true;
            // 
            // SwitchingTrajectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 565);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.cbShotNoise);
            this.Controls.Add(this.tbSaveDirectory);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.btn_start_simulation);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SwitchingTrajectory";
            this.Text = "Switching Trajectory";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbShotNoise;
        private System.Windows.Forms.TextBox tbSaveDirectory;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_start_simulation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_d_sh_ent;
        private System.Windows.Forms.TextBox tbDelta_time;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox jz_ent;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox jy_ent;
        private System.Windows.Forms.TextBox jx_ent;
        private System.Windows.Forms.TextBox h_z_ent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox h_y_ent;
        private System.Windows.Forms.TextBox h_x_ent;
        private System.Windows.Forms.TextBox d_th_ent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbIac;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Pz_ent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Py_ent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Px_ent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox I_ent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Hx_ent;
        private System.Windows.Forms.TextBox Hy_ent;
        private System.Windows.Forms.ComboBox cbHunits;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Hz_ent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox M_ent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Temp_ent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Nzz_ent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Nyy_ent;
        private System.Windows.Forms.ComboBox cbMunits;
        private System.Windows.Forms.TextBox Nxx_ent;
        private System.Windows.Forms.TextBox Alpha_ent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Thickness_ent;
        private System.Windows.Forms.TextBox Area_ent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.CheckBox cbFieldTorque;
        private System.Windows.Forms.TextBox tbSTime;
        private System.Windows.Forms.TextBox tbPTime;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cbSave;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbDownPulse;
        private System.Windows.Forms.TextBox tbCycles;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_phi_initial;
        private System.Windows.Forms.TextBox tb_theta_initial;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox cb_initial_conditions;
    }
}