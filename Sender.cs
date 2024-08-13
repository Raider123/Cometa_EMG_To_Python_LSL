using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSL;
using Waveplus.DaqExample;

namespace Waveplus_Daq_Example
{
    internal class Sender : Form
    {
        // The EMG example program
        private WaveplusDaqExampleForm wdaq;

        // LSL related fields
        private StreamOutlet outlet;
        private Button startButton;
        private TextBox outputTextBox;

        // Cancellation token to stop the sending loop
        private CancellationTokenSource cancellationTokenSource;

        public Sender()
        {
            // Extremly important for the programs purpose (extremly simple integration)
            wdaq = new WaveplusDaqExampleForm();
            wdaq.Show(); // Make the waveplus form visible

            InitializeLSL();
            InitializeComponent();
        }

        private void InitializeLSL()
        {
            // Erstellen von StreamInfo für den Stream mit mehrkanaligem Sample
            StreamInfo streamInfo = new StreamInfo("ExampleStream", "EMG", 8, 100, channel_format_t.cf_double64, "myuid34234");

            // Erstellen eines StreamOutlet
            outlet = new StreamOutlet(streamInfo);
        }

        private void InitializeComponent()
        {
            // Initialize the form components
            this.startButton = new Button();
            this.outputTextBox = new TextBox();
            this.SuspendLayout();

            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(150, 50);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 50);
            this.startButton.Text = "Senden Beginnen";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new EventHandler(StartButton_Click);

            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(50, 120);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(300, 200);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.ScrollBars = ScrollBars.Vertical;
            this.outputTextBox.ReadOnly = true;

            // 
            // Sender
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Sender";
            this.Text = "EMG Sender";
            this.FormClosing += new FormClosingEventHandler(Sender_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource == null || cancellationTokenSource.IsCancellationRequested)
            {
                // Starten des EMG-Datenstroms
                wdaq.StartCaptureButton_Click(sender, e);
                cancellationTokenSource = new CancellationTokenSource();
                Task.Run(() => Run(cancellationTokenSource.Token));

                // Button-Text ändern
                startButton.Text = "Senden Beenden";
            }
            else
            {
                // Stoppen des EMG-Datenstroms
                cancellationTokenSource.Cancel();
                wdaq.StopCaptureButton_Click(sender, e);

                // Button-Text zurücksetzen
                startButton.Text = "Senden Beginnen";
            }
        }

        private void Run(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    Update();

                    // Kurze Pause, um CPU-Überlastung zu vermeiden (z.B. 10ms)
                    //Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Senden der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            if (wdaq != null)
            {
                double[] current_emg_samples = wdaq.rec_emg_samples; // Angenommen, wdaq liefert nun ein Double-Array

                SendEMGData(current_emg_samples);

                // Anzeige der gesendeten Daten im Textfeld
                AppendTextToOutput(current_emg_samples);
            }
        }

        private void SendEMGData(double[] current_emg_samples)
        {
            // Senden der EMG-Daten als Array
            outlet.push_sample(current_emg_samples);
        }

        private void AppendTextToOutput(double[] data)
        {
            if (outputTextBox.InvokeRequired)
            {
                outputTextBox.Invoke(new Action(() => AppendTextToOutput(data)));
            }
            else
            {
                // Textbox mit den gesendeten EMG-Daten aktualisieren
                outputTextBox.AppendText(string.Join(", ", data) + Environment.NewLine);
            }
        }

        private void Sender_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sender());
        }
    }
}
