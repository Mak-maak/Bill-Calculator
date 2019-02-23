namespace WindowsFormsFactoryPattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.rdbtnDomesticPlan = new System.Windows.Forms.RadioButton();
            this.rdbtnCommercialPlan = new System.Windows.Forms.RadioButton();
            this.rdbtnInstitutionalPlan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GenerateBill";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(252, 83);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(154, 20);
            this.txtUnits.TabIndex = 1;
            // 
            // rdbtnDomesticPlan
            // 
            this.rdbtnDomesticPlan.AutoSize = true;
            this.rdbtnDomesticPlan.Checked = true;
            this.rdbtnDomesticPlan.Location = new System.Drawing.Point(252, 144);
            this.rdbtnDomesticPlan.Name = "rdbtnDomesticPlan";
            this.rdbtnDomesticPlan.Size = new System.Drawing.Size(93, 17);
            this.rdbtnDomesticPlan.TabIndex = 2;
            this.rdbtnDomesticPlan.TabStop = true;
            this.rdbtnDomesticPlan.Text = "Domestic Plan";
            this.rdbtnDomesticPlan.UseVisualStyleBackColor = true;
            this.rdbtnDomesticPlan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnCommercialPlan
            // 
            this.rdbtnCommercialPlan.AutoSize = true;
            this.rdbtnCommercialPlan.Location = new System.Drawing.Point(252, 180);
            this.rdbtnCommercialPlan.Name = "rdbtnCommercialPlan";
            this.rdbtnCommercialPlan.Size = new System.Drawing.Size(103, 17);
            this.rdbtnCommercialPlan.TabIndex = 3;
            this.rdbtnCommercialPlan.TabStop = true;
            this.rdbtnCommercialPlan.Text = "Commercial Plan";
            this.rdbtnCommercialPlan.UseVisualStyleBackColor = true;
            this.rdbtnCommercialPlan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbtnInstitutionalPlan
            // 
            this.rdbtnInstitutionalPlan.AutoSize = true;
            this.rdbtnInstitutionalPlan.Location = new System.Drawing.Point(252, 217);
            this.rdbtnInstitutionalPlan.Name = "rdbtnInstitutionalPlan";
            this.rdbtnInstitutionalPlan.Size = new System.Drawing.Size(102, 17);
            this.rdbtnInstitutionalPlan.TabIndex = 4;
            this.rdbtnInstitutionalPlan.TabStop = true;
            this.rdbtnInstitutionalPlan.Text = "Institutional Plan";
            this.rdbtnInstitutionalPlan.UseVisualStyleBackColor = true;
            this.rdbtnInstitutionalPlan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter No.Of Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a plan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbtnInstitutionalPlan);
            this.Controls.Add(this.rdbtnCommercialPlan);
            this.Controls.Add(this.rdbtnDomesticPlan);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FactoryPatternAziz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.RadioButton rdbtnDomesticPlan;
        private System.Windows.Forms.RadioButton rdbtnCommercialPlan;
        private System.Windows.Forms.RadioButton rdbtnInstitutionalPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

