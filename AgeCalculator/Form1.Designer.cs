namespace AgeCalculator
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
            this.tmrAging = new System.Windows.Forms.Timer(this.components);
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmdCalculateAge = new System.Windows.Forms.Button();
            this.txtAgeReport = new System.Windows.Forms.TextBox();
            this.birthTime = new System.Windows.Forms.DateTimePicker();
            this.chkUseTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tmrAging
            // 
            this.tmrAging.Interval = 1000;
            this.tmrAging.Tick += new System.EventHandler(this.tmrAging_Tick);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(163, 33);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 0;
            // 
            // cmdCalculateAge
            // 
            this.cmdCalculateAge.Location = new System.Drawing.Point(430, 59);
            this.cmdCalculateAge.Name = "cmdCalculateAge";
            this.cmdCalculateAge.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculateAge.TabIndex = 1;
            this.cmdCalculateAge.Text = "&OK";
            this.cmdCalculateAge.UseVisualStyleBackColor = true;
            this.cmdCalculateAge.Click += new System.EventHandler(this.cmdCalculateAge_Click);
            // 
            // txtAgeReport
            // 
            this.txtAgeReport.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeReport.Location = new System.Drawing.Point(76, 108);
            this.txtAgeReport.Multiline = true;
            this.txtAgeReport.Name = "txtAgeReport";
            this.txtAgeReport.Size = new System.Drawing.Size(614, 458);
            this.txtAgeReport.TabIndex = 0;
            // 
            // birthTime
            // 
            this.birthTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.birthTime.Location = new System.Drawing.Point(430, 33);
            this.birthTime.Name = "birthTime";
            this.birthTime.Size = new System.Drawing.Size(102, 20);
            this.birthTime.TabIndex = 2;
            // 
            // chkUseTime
            // 
            this.chkUseTime.AutoSize = true;
            this.chkUseTime.Location = new System.Drawing.Point(430, 12);
            this.chkUseTime.Name = "chkUseTime";
            this.chkUseTime.Size = new System.Drawing.Size(71, 17);
            this.chkUseTime.TabIndex = 3;
            this.chkUseTime.Text = "Use Time";
            this.chkUseTime.UseVisualStyleBackColor = true;
            this.chkUseTime.CheckedChanged += new System.EventHandler(this.chkUseTime_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 604);
            this.Controls.Add(this.chkUseTime);
            this.Controls.Add(this.birthTime);
            this.Controls.Add(this.txtAgeReport);
            this.Controls.Add(this.cmdCalculateAge);
            this.Controls.Add(this.dtBirthDate);
            this.Name = "Form1";
            this.Text = "Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAging;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Button cmdCalculateAge;
        private System.Windows.Forms.TextBox txtAgeReport;
        private System.Windows.Forms.DateTimePicker birthTime;
        private System.Windows.Forms.CheckBox chkUseTime;
    }
}

