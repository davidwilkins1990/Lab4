namespace Submarines
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
            this.lvFleet = new System.Windows.Forms.ListView();
            this.btnCreateSub = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupControls = new System.Windows.Forms.GroupBox();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.btnFire = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHeading = new System.Windows.Forms.ComboBox();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmbFleet = new System.Windows.Forms.ComboBox();
            this.btnChanges = new System.Windows.Forms.Button();
            this.groupControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // lvFleet
            // 
            this.lvFleet.Location = new System.Drawing.Point(268, 12);
            this.lvFleet.Name = "lvFleet";
            this.lvFleet.Size = new System.Drawing.Size(281, 154);
            this.lvFleet.TabIndex = 0;
            this.lvFleet.UseCompatibleStateImageBehavior = false;
            this.lvFleet.SelectedIndexChanged += new System.EventHandler(this.lvFleet_SelectedIndexChanged);
            // 
            // btnCreateSub
            // 
            this.btnCreateSub.Location = new System.Drawing.Point(132, 12);
            this.btnCreateSub.Name = "btnCreateSub";
            this.btnCreateSub.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSub.TabIndex = 1;
            this.btnCreateSub.Text = "Add Sub";
            this.btnCreateSub.UseVisualStyleBackColor = true;
            this.btnCreateSub.Click += new System.EventHandler(this.btnCreateSub_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutput.Location = new System.Drawing.Point(283, 356);
            this.lblOutput.MinimumSize = new System.Drawing.Size(250, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(250, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(21, 263);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Sub From Fleet";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.btnChanges);
            this.groupControls.Controls.Add(this.label3);
            this.groupControls.Controls.Add(this.btnRemove);
            this.groupControls.Controls.Add(this.label2);
            this.groupControls.Controls.Add(this.label1);
            this.groupControls.Controls.Add(this.nudDepth);
            this.groupControls.Controls.Add(this.nudSpeed);
            this.groupControls.Controls.Add(this.cmbHeading);
            this.groupControls.Controls.Add(this.groupBox2);
            this.groupControls.Controls.Add(this.btnFire);
            this.groupControls.Location = new System.Drawing.Point(31, 67);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(200, 299);
            this.groupControls.TabIndex = 5;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Sub Controls";
            this.groupControls.Enter += new System.EventHandler(this.groupControls_Enter);
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Location = new System.Drawing.Point(6, 19);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(80, 17);
            this.rbOn.TabIndex = 0;
            this.rbOn.TabStop = true;
            this.rbOn.Text = "Reactor On";
            this.rbOn.UseVisualStyleBackColor = true;
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Location = new System.Drawing.Point(6, 42);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(80, 17);
            this.rbOff.TabIndex = 1;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Reactor Off";
            this.rbOff.UseVisualStyleBackColor = true;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(27, 234);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(136, 23);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire Torpedo";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOn);
            this.groupBox2.Controls.Add(this.rbOff);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reactor";
            // 
            // cmbHeading
            // 
            this.cmbHeading.FormattingEnabled = true;
            this.cmbHeading.Location = new System.Drawing.Point(37, 127);
            this.cmbHeading.Name = "cmbHeading";
            this.cmbHeading.Size = new System.Drawing.Size(121, 21);
            this.cmbHeading.TabIndex = 4;
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(128, 35);
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(48, 20);
            this.nudSpeed.TabIndex = 5;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(128, 82);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(48, 20);
            this.nudDepth.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Heading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fleet";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(286, 246);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(247, 107);
            this.txtOutput.TabIndex = 12;
            // 
            // cmbFleet
            // 
            this.cmbFleet.FormattingEnabled = true;
            this.cmbFleet.Location = new System.Drawing.Point(286, 219);
            this.cmbFleet.Name = "cmbFleet";
            this.cmbFleet.Size = new System.Drawing.Size(247, 21);
            this.cmbFleet.TabIndex = 11;
            this.cmbFleet.SelectedIndexChanged += new System.EventHandler(this.cmbFleet_SelectedIndexChanged);
            // 
            // btnChanges
            // 
            this.btnChanges.Location = new System.Drawing.Point(27, 195);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(136, 23);
            this.btnChanges.TabIndex = 11;
            this.btnChanges.Text = "Redirect Sub";
            this.btnChanges.UseVisualStyleBackColor = true;
            this.btnChanges.Click += new System.EventHandler(this.btnChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 394);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFleet);
            this.Controls.Add(this.groupControls);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCreateSub);
            this.Controls.Add(this.lvFleet);
            this.Name = "Form1";
            this.Text = "Fleet Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupControls.ResumeLayout(false);
            this.groupControls.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFleet;
        private System.Windows.Forms.Button btnCreateSub;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.ComboBox cmbHeading;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cmbFleet;
        private System.Windows.Forms.Button btnChanges;
    }
}

