using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using People;

namespace OOPCourseWork
{
    public partial class FormSimulation : Form, IGraphics
    {
        public bool StartNew;
        private Person[] ActivePeople;
        private readonly Random r = new Random();

        public int InitialNumberOfPeople { get; set; }
        public int NumberOfInfected { get; set; }
        public double R { get; set; }
        public int ChanceOfSpread { get; set; }
        public int ticks { get; set; }
        public double ticksWithoutInfection { get; set; }

        //To return to the other form
        public int EndNumInfected { get; private set; }


        public FormSimulation(int intialNumberOfPeople, int numberOfInfected, bool startNew)
        {
            InitializeComponent();

            InitialNumberOfPeople = intialNumberOfPeople;
            NumberOfInfected = numberOfInfected;
            StartNew = startNew;

            timerSimulation.Start();
        }
        public void DrawEllipse(
            Pen colorPen,
            int locationX,
            int locationY,
            int width,
            int height)
        {
            using (var graphics = CreateGraphics())
            {
                graphics.DrawEllipse(colorPen, locationX, locationY, width, height);
            }
        }
        public void FillEllipse(
            Brush colorBrush,
            int locationX,
            int locationY,
            int width,
            int height)
        {
            using (var graphics = CreateGraphics())
            {
                graphics.FillEllipse(colorBrush, locationX, locationY, width, height);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics graphics = e.Graphics)
            {
                foreach (var person in ActivePeople)
                {
                    person.Draw(this);
                }
            }
        }

        private void FormSimulation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var person in ActivePeople)
            {
                person.IsWearingMask = !person.IsWearingMask;
                if (person is Infected)
                {
                    Infected infected = (Infected)person;
                    infected.InfectiousRadius = person.IsWearingMask ? infected.InfectiousRadius / 2 :
                        infected.InfectiousRadius * 2;
                }
            }
            if (ActivePeople[0].IsWearingMask)
            {
                ChanceOfSpread = 2;
                toolStripStatusLabelWearingMasks.Text = "Masks: ✓";
            }
            else
            {
                ChanceOfSpread = 5;
                toolStripStatusLabelWearingMasks.Text = "Masks: ✘";
            }
            toolStripStatusLabelSpread.Text = $"Spread: {ChanceOfSpread}%";
        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            if (StartNew)
            {
                ActivePeople = new Person[(int)InitialNumberOfPeople];
                int HealtyPeople = InitialNumberOfPeople - NumberOfInfected;

                for (int i = 0; i < HealtyPeople; i++)
                    ActivePeople[i] = (new Healthy(
                        new Point(r.Next(50, 950), r.Next(50, 700)),
                        new Point(r.Next(50, 950), r.Next(50, 700)),
                        10));

                for (int i = HealtyPeople; i < InitialNumberOfPeople; i++)
                    ActivePeople[i] = (new Infected(
                        new Point(r.Next(50, 950), r.Next(50, 700)),
                        new Point(r.Next(50, 950), r.Next(50, 700)))
                    );
                toolStripStatusLabelTimePassed.Text = "Timer: 0";
            }
            else
            {
                if (!File.Exists("data.bin"))
                    return;
                var formater = new BinaryFormatter();
                using (var stream = new FileStream("data.bin", FileMode.Open))
                {
                    ActivePeople = (Person[])formater.Deserialize(stream);
                }
                using (StreamReader sr = File.OpenText("ticks.txt"))
                {
                    string[] read = sr.ReadToEnd()
                        .Trim()
                        .Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    ticks = int.Parse(read[0]);
                }
            }
            ChanceOfSpread = ActivePeople[0].IsWearingMask ? 2 : 5;
            R = CalcuteR();
            toolStripStatusLabelTimePassed.Text = $"Timer: {ticks}";
            toolStripStatusLabelSpread.Text = $"Spread: {ChanceOfSpread}%";
            toolStripStatusLabelWearingMasks.Text = "Masks: ✘";
            toolStripStatusLabelR.Text = $"R: {R}";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var person in ActivePeople)
            {
                person.Move();

                if (ticks % 30 == 0 && person is Infected infected)
                {
                    var nearbyPeople = infected.NearbyPeople(ActivePeople
                        .Where(p => p is Healthy)
                        .ToArray());
                    foreach (var nearbyPerson in nearbyPeople)
                    {
                        if (r.Next(0, 100) < ChanceOfSpread)
                        {
                            ActivePeople[Array.IndexOf(ActivePeople, nearbyPerson)] = new Infected(
                                nearbyPerson.Position, 
                                nearbyPerson.NextPosition, 
                                nearbyPerson.IsWearingMask
                            );
                            infected.R += 1;
                            R = CalcuteR();
                            ticksWithoutInfection /= 3;
                        }
                    }
                }
            }
            Invalidate();
            ticks++;
            ticksWithoutInfection++;
            toolStripStatusLabelTimePassed.Text = $"Timer: {TimeSpan.FromSeconds(ticks*6)}";
            if (R - (ticksWithoutInfection / 500) > 0)
                toolStripStatusLabelR.Text = $"R: {R - (ticksWithoutInfection / 500):f2}";
            else 
                toolStripStatusLabelR.Text = $"R: 0";
        }

        public double CalcuteR()
        {
            Infected[] InfectedPeople = ActivePeople
                .Where(p => p is Infected)
                .Cast<Infected>()
                .ToArray();
            Healthy[] HealthyPeople = ActivePeople
                .Where(p => p is Healthy)
                .Cast<Healthy>()
                .ToArray();

            double totalR = InfectedPeople
                .Select(p => p.R)
                .Where(R => R > 0)
                .Sum();
            double spreaders = Math.Max(1, InfectedPeople
                .Where(p => p.R > 0)
                .Count());
            
            double currentR = totalR / spreaders;
            double potentialInfections = InfectedPeople.Count() > 2 ?
                Math.Pow(HealthyPeople.Count(), 1.0 / InfectedPeople.Count()) :
                Math.Sqrt(HealthyPeople.Count());
            
            return (currentR + potentialInfections) / 2;
        }

        private void FormSimulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formater = new BinaryFormatter();
            using (var stream = new FileStream("data.bin", FileMode.Create))
            {
                formater.Serialize(stream, ActivePeople);
            }
            using (StreamWriter sw = File.CreateText("ticks.txt"))
            {
                sw.WriteLine(ticks);
            }
            EndNumInfected = ActivePeople
                .Where(p => p is Infected)
                .Count();
        }
    }
}
