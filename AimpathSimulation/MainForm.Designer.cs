namespace AimpathSimulation
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.liveSimbut = new System.Windows.Forms.RadioButton();
            this.nonLiveSimbut = new System.Windows.Forms.RadioButton();
            this.linearnoisebut = new System.Windows.Forms.RadioButton();
            this.linearbut = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.curvebut = new System.Windows.Forms.RadioButton();
            this.randombut = new System.Windows.Forms.RadioButton();
            this.setbut = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.smoothbar = new System.Windows.Forms.TrackBar();
            this.smoothlabel = new System.Windows.Forms.Label();
            this.anglepointsbox = new System.Windows.Forms.GroupBox();
            this.aimmodebox = new System.Windows.Forms.GroupBox();
            this.simulationmodebox = new System.Windows.Forms.GroupBox();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.noiselabel = new System.Windows.Forms.Label();
            this.noisebar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.overaimpercent = new System.Windows.Forms.Label();
            this.overaimbar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.overaimbutton = new System.Windows.Forms.RadioButton();
            this.overaimnoisebut = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.smoothbar)).BeginInit();
            this.anglepointsbox.SuspendLayout();
            this.aimmodebox.SuspendLayout();
            this.simulationmodebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noisebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overaimbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulation mode";
            // 
            // liveSimbut
            // 
            this.liveSimbut.AutoSize = true;
            this.liveSimbut.Location = new System.Drawing.Point(6, 19);
            this.liveSimbut.Name = "liveSimbut";
            this.liveSimbut.Size = new System.Drawing.Size(96, 17);
            this.liveSimbut.TabIndex = 2;
            this.liveSimbut.TabStop = true;
            this.liveSimbut.Text = "Live Simulation";
            this.liveSimbut.UseVisualStyleBackColor = true;
            // 
            // nonLiveSimbut
            // 
            this.nonLiveSimbut.AutoSize = true;
            this.nonLiveSimbut.Location = new System.Drawing.Point(6, 42);
            this.nonLiveSimbut.Name = "nonLiveSimbut";
            this.nonLiveSimbut.Size = new System.Drawing.Size(119, 17);
            this.nonLiveSimbut.TabIndex = 3;
            this.nonLiveSimbut.TabStop = true;
            this.nonLiveSimbut.Text = "Non-Live Simulation";
            this.nonLiveSimbut.UseVisualStyleBackColor = true;
            // 
            // linearnoisebut
            // 
            this.linearnoisebut.AutoSize = true;
            this.linearnoisebut.Location = new System.Drawing.Point(6, 42);
            this.linearnoisebut.Name = "linearnoisebut";
            this.linearnoisebut.Size = new System.Drawing.Size(93, 17);
            this.linearnoisebut.TabIndex = 6;
            this.linearnoisebut.TabStop = true;
            this.linearnoisebut.Text = "Linear + Noise";
            this.linearnoisebut.UseVisualStyleBackColor = true;
            // 
            // linearbut
            // 
            this.linearbut.AutoSize = true;
            this.linearbut.Location = new System.Drawing.Point(6, 19);
            this.linearbut.Name = "linearbut";
            this.linearbut.Size = new System.Drawing.Size(54, 17);
            this.linearbut.TabIndex = 5;
            this.linearbut.TabStop = true;
            this.linearbut.Text = "Linear";
            this.linearbut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aim mode";
            // 
            // curvebut
            // 
            this.curvebut.AutoSize = true;
            this.curvebut.Location = new System.Drawing.Point(6, 111);
            this.curvebut.Name = "curvebut";
            this.curvebut.Size = new System.Drawing.Size(85, 17);
            this.curvebut.TabIndex = 7;
            this.curvebut.TabStop = true;
            this.curvebut.Text = "Bezier Curve";
            this.curvebut.UseVisualStyleBackColor = true;
            this.curvebut.CheckedChanged += new System.EventHandler(this.curvebut_CheckedChanged);
            // 
            // randombut
            // 
            this.randombut.AutoSize = true;
            this.randombut.Location = new System.Drawing.Point(6, 42);
            this.randombut.Name = "randombut";
            this.randombut.Size = new System.Drawing.Size(65, 17);
            this.randombut.TabIndex = 10;
            this.randombut.TabStop = true;
            this.randombut.Text = "Random";
            this.randombut.UseVisualStyleBackColor = true;
            // 
            // setbut
            // 
            this.setbut.AutoSize = true;
            this.setbut.Location = new System.Drawing.Point(6, 19);
            this.setbut.Name = "setbut";
            this.setbut.Size = new System.Drawing.Size(41, 17);
            this.setbut.TabIndex = 9;
            this.setbut.TabStop = true;
            this.setbut.Text = "Set";
            this.setbut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Angle points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Smooth";
            // 
            // smoothbar
            // 
            this.smoothbar.Location = new System.Drawing.Point(604, 396);
            this.smoothbar.Maximum = 50;
            this.smoothbar.Minimum = 1;
            this.smoothbar.Name = "smoothbar";
            this.smoothbar.Size = new System.Drawing.Size(184, 45);
            this.smoothbar.TabIndex = 12;
            this.smoothbar.Value = 1;
            this.smoothbar.Scroll += new System.EventHandler(this.smoothbar_Scroll);
            // 
            // smoothlabel
            // 
            this.smoothlabel.AutoSize = true;
            this.smoothlabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smoothlabel.Location = new System.Drawing.Point(679, 444);
            this.smoothlabel.Name = "smoothlabel";
            this.smoothlabel.Size = new System.Drawing.Size(21, 23);
            this.smoothlabel.TabIndex = 13;
            this.smoothlabel.Text = "1";
            // 
            // anglepointsbox
            // 
            this.anglepointsbox.Controls.Add(this.randombut);
            this.anglepointsbox.Controls.Add(this.setbut);
            this.anglepointsbox.Location = new System.Drawing.Point(604, 296);
            this.anglepointsbox.Name = "anglepointsbox";
            this.anglepointsbox.Size = new System.Drawing.Size(184, 66);
            this.anglepointsbox.TabIndex = 14;
            this.anglepointsbox.TabStop = false;
            // 
            // aimmodebox
            // 
            this.aimmodebox.Controls.Add(this.overaimnoisebut);
            this.aimmodebox.Controls.Add(this.overaimbutton);
            this.aimmodebox.Controls.Add(this.linearbut);
            this.aimmodebox.Controls.Add(this.linearnoisebut);
            this.aimmodebox.Controls.Add(this.curvebut);
            this.aimmodebox.Location = new System.Drawing.Point(604, 136);
            this.aimmodebox.Name = "aimmodebox";
            this.aimmodebox.Size = new System.Drawing.Size(184, 131);
            this.aimmodebox.TabIndex = 15;
            this.aimmodebox.TabStop = false;
            // 
            // simulationmodebox
            // 
            this.simulationmodebox.Controls.Add(this.liveSimbut);
            this.simulationmodebox.Controls.Add(this.nonLiveSimbut);
            this.simulationmodebox.Location = new System.Drawing.Point(604, 38);
            this.simulationmodebox.Name = "simulationmodebox";
            this.simulationmodebox.Size = new System.Drawing.Size(184, 71);
            this.simulationmodebox.TabIndex = 16;
            this.simulationmodebox.TabStop = false;
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(12, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(582, 593);
            this.drawPanel.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noiselabel
            // 
            this.noiselabel.AutoSize = true;
            this.noiselabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiselabel.Location = new System.Drawing.Point(679, 540);
            this.noiselabel.Name = "noiselabel";
            this.noiselabel.Size = new System.Drawing.Size(21, 23);
            this.noiselabel.TabIndex = 21;
            this.noiselabel.Text = "1";
            // 
            // noisebar
            // 
            this.noisebar.Location = new System.Drawing.Point(604, 492);
            this.noisebar.Maximum = 9;
            this.noisebar.Minimum = 1;
            this.noisebar.Name = "noisebar";
            this.noisebar.Size = new System.Drawing.Size(184, 45);
            this.noisebar.TabIndex = 20;
            this.noisebar.Value = 1;
            this.noisebar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Noise";
            // 
            // overaimpercent
            // 
            this.overaimpercent.AutoSize = true;
            this.overaimpercent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overaimpercent.Location = new System.Drawing.Point(679, 647);
            this.overaimpercent.Name = "overaimpercent";
            this.overaimpercent.Size = new System.Drawing.Size(39, 23);
            this.overaimpercent.TabIndex = 24;
            this.overaimpercent.Text = "1%";
            // 
            // overaimbar
            // 
            this.overaimbar.Location = new System.Drawing.Point(604, 599);
            this.overaimbar.Maximum = 50;
            this.overaimbar.Minimum = 1;
            this.overaimbar.Name = "overaimbar";
            this.overaimbar.Size = new System.Drawing.Size(184, 45);
            this.overaimbar.TabIndex = 23;
            this.overaimbar.Value = 1;
            this.overaimbar.Scroll += new System.EventHandler(this.overaimbar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(600, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Overaim";
            // 
            // overaimbutton
            // 
            this.overaimbutton.AutoSize = true;
            this.overaimbutton.Location = new System.Drawing.Point(6, 65);
            this.overaimbutton.Name = "overaimbutton";
            this.overaimbutton.Size = new System.Drawing.Size(105, 17);
            this.overaimbutton.TabIndex = 8;
            this.overaimbutton.TabStop = true;
            this.overaimbutton.Text = "Linear + Overaim";
            this.overaimbutton.UseVisualStyleBackColor = true;
            // 
            // overaimnoisebut
            // 
            this.overaimnoisebut.AutoSize = true;
            this.overaimnoisebut.Location = new System.Drawing.Point(6, 88);
            this.overaimnoisebut.Name = "overaimnoisebut";
            this.overaimnoisebut.Size = new System.Drawing.Size(144, 17);
            this.overaimnoisebut.TabIndex = 9;
            this.overaimnoisebut.TabStop = true;
            this.overaimnoisebut.Text = "Linear + Noise + Overaim";
            this.overaimnoisebut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.overaimpercent);
            this.Controls.Add(this.overaimbar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.noiselabel);
            this.Controls.Add(this.noisebar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.simulationmodebox);
            this.Controls.Add(this.aimmodebox);
            this.Controls.Add(this.anglepointsbox);
            this.Controls.Add(this.smoothlabel);
            this.Controls.Add(this.smoothbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.smoothbar)).EndInit();
            this.anglepointsbox.ResumeLayout(false);
            this.anglepointsbox.PerformLayout();
            this.aimmodebox.ResumeLayout(false);
            this.aimmodebox.PerformLayout();
            this.simulationmodebox.ResumeLayout(false);
            this.simulationmodebox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noisebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overaimbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton liveSimbut;
        private System.Windows.Forms.RadioButton nonLiveSimbut;
        private System.Windows.Forms.RadioButton linearnoisebut;
        private System.Windows.Forms.RadioButton linearbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton curvebut;
        private System.Windows.Forms.RadioButton randombut;
        private System.Windows.Forms.RadioButton setbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar smoothbar;
        private System.Windows.Forms.Label smoothlabel;
        private System.Windows.Forms.GroupBox anglepointsbox;
        private System.Windows.Forms.GroupBox aimmodebox;
        private System.Windows.Forms.GroupBox simulationmodebox;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton overaimbutton;
        private System.Windows.Forms.Label noiselabel;
        private System.Windows.Forms.TrackBar noisebar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label overaimpercent;
        private System.Windows.Forms.TrackBar overaimbar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton overaimnoisebut;
    }
}

