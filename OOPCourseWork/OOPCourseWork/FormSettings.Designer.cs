
namespace OOPCourseWork
{
    partial class FormSettings
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
            this.InputInitialPeople = new System.Windows.Forms.NumericUpDown();
            this.labelInitNumberOfPeople = new System.Windows.Forms.Label();
            this.InputInitialPercentageInfected = new System.Windows.Forms.NumericUpDown();
            this.labelIntialNumberOfInfected = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPercentageOfInfectd = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputInitialPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInitialPercentageInfected)).BeginInit();
            this.SuspendLayout();
            // 
            // InputInitialPeople
            // 
            this.InputInitialPeople.Location = new System.Drawing.Point(55, 70);
            this.InputInitialPeople.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.InputInitialPeople.Name = "InputInitialPeople";
            this.InputInitialPeople.Size = new System.Drawing.Size(158, 20);
            this.InputInitialPeople.TabIndex = 0;
            this.InputInitialPeople.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelInitNumberOfPeople
            // 
            this.labelInitNumberOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInitNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitNumberOfPeople.Location = new System.Drawing.Point(55, 9);
            this.labelInitNumberOfPeople.Name = "labelInitNumberOfPeople";
            this.labelInitNumberOfPeople.Size = new System.Drawing.Size(158, 58);
            this.labelInitNumberOfPeople.TabIndex = 1;
            this.labelInitNumberOfPeople.Text = "Initial Number of People";
            this.labelInitNumberOfPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputInitialPercentageInfected
            // 
            this.InputInitialPercentageInfected.Location = new System.Drawing.Point(280, 73);
            this.InputInitialPercentageInfected.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.InputInitialPercentageInfected.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputInitialPercentageInfected.Name = "InputInitialPercentageInfected";
            this.InputInitialPercentageInfected.Size = new System.Drawing.Size(158, 20);
            this.InputInitialPercentageInfected.TabIndex = 0;
            this.InputInitialPercentageInfected.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIntialNumberOfInfected
            // 
            this.labelIntialNumberOfInfected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIntialNumberOfInfected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntialNumberOfInfected.Location = new System.Drawing.Point(280, 12);
            this.labelIntialNumberOfInfected.Name = "labelIntialNumberOfInfected";
            this.labelIntialNumberOfInfected.Size = new System.Drawing.Size(158, 58);
            this.labelIntialNumberOfInfected.TabIndex = 1;
            this.labelIntialNumberOfInfected.Text = "Initial number of infected";
            this.labelIntialNumberOfInfected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(55, 106);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(158, 50);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelPercentageOfInfectd
            // 
            this.labelPercentageOfInfectd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentageOfInfectd.Location = new System.Drawing.Point(12, 213);
            this.labelPercentageOfInfectd.Name = "labelPercentageOfInfectd";
            this.labelPercentageOfInfectd.Size = new System.Drawing.Size(201, 66);
            this.labelPercentageOfInfectd.TabIndex = 4;
            this.labelPercentageOfInfectd.Text = "Percentage of infected at the end";
            this.labelPercentageOfInfectd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(280, 106);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(158, 50);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelResults
            // 
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(179, 171);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(128, 42);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelR
            // 
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(243, 213);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(229, 66);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "R (Effective Reporductive Number)";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelPercentageOfInfectd);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelIntialNumberOfInfected);
            this.Controls.Add(this.InputInitialPercentageInfected);
            this.Controls.Add(this.labelInitNumberOfPeople);
            this.Controls.Add(this.InputInitialPeople);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputInitialPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInitialPercentageInfected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InputInitialPeople;
        private System.Windows.Forms.Label labelInitNumberOfPeople;
        private System.Windows.Forms.NumericUpDown InputInitialPercentageInfected;
        private System.Windows.Forms.Label labelIntialNumberOfInfected;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPercentageOfInfectd;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelR;
    }
}