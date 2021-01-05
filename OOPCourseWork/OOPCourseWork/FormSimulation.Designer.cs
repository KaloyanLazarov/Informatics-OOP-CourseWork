
namespace OOPCourseWork
{
    partial class FormSimulation
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
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTimePassed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpread = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWearingMasks = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelR = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSimulation
            // 
            this.timerSimulation.Enabled = true;
            this.timerSimulation.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimePassed,
            this.toolStripStatusLabelSpread,
            this.toolStripStatusLabelWearingMasks,
            this.toolStripStatusLabelR});
            this.statusStrip1.Location = new System.Drawing.Point(782, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2, 461);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTimePassed
            // 
            this.toolStripStatusLabelTimePassed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTimePassed.Name = "toolStripStatusLabelTimePassed";
            this.toolStripStatusLabelTimePassed.Size = new System.Drawing.Size(1, 0);
            // 
            // toolStripStatusLabelSpread
            // 
            this.toolStripStatusLabelSpread.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelSpread.Name = "toolStripStatusLabelSpread";
            this.toolStripStatusLabelSpread.Size = new System.Drawing.Size(1, 0);
            // 
            // toolStripStatusLabelWearingMasks
            // 
            this.toolStripStatusLabelWearingMasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelWearingMasks.Name = "toolStripStatusLabelWearingMasks";
            this.toolStripStatusLabelWearingMasks.Size = new System.Drawing.Size(1, 0);
            // 
            // toolStripStatusLabelR
            // 
            this.toolStripStatusLabelR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelR.Name = "toolStripStatusLabelR";
            this.toolStripStatusLabelR.Size = new System.Drawing.Size(1, 0);
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormSimulation";
            this.Text = "Pandemic Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSimulation_FormClosing);
            this.Load += new System.EventHandler(this.FormSimulation_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormSimulation_MouseDoubleClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSimulation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimePassed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWearingMasks;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpread;
    }
}

