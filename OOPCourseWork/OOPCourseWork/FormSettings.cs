using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCourseWork
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        private void DisplayInformation(FormSimulation SimulationForm)
        {
            labelPercentageOfInfectd.Text = $"Percentage of infected at the end: " +
                    $"{SimulationForm.EndNumInfected} " +
                    $"({((double)SimulationForm.EndNumInfected / (double)InputInitialPeople.Value) * 100:f0}%)";
            labelR.Text = $"R (Effective Reporductive Number): {SimulationForm.R:f2}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var SimulationForm = new FormSimulation(
                (int)InputInitialPeople.Value,
                (int)InputInitialPercentageInfected.Value,
                true))
            {
                SimulationForm.ShowDialog();
                DisplayInformation(SimulationForm);
            }

            this.Show();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.txt"))
            {
                using (StreamReader sr = File.OpenText("settings.txt"))
                {
                    string[] read = sr.ReadToEnd()
                        .Trim().
                        Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    InputInitialPeople.Value = int.Parse(read[0]);
                    InputInitialPercentageInfected.Value = int.Parse(read[1]);
                }
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = File.CreateText("settings.txt"))
            {
                sw.WriteLine(InputInitialPeople.Value);
                sw.WriteLine(InputInitialPercentageInfected.Value);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var SimulationForm = new FormSimulation(
                (int)InputInitialPeople.Value,
                (int)InputInitialPercentageInfected.Value,
                false))
            {
                SimulationForm.ShowDialog();
                DisplayInformation(SimulationForm);
            }

            this.Show();
        }
    }
}
