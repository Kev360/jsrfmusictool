using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class chapter1a : Form
    {
        public chapter1a(string folderPath)
        {
            InitializeComponent();
            textBox1.Text = folderPath;

            InitData(folderPath);

        }

        public void AppendToConsole(string message)
        {
            textBoxConsole.AppendText(message + Environment.NewLine);
            textBoxConsole.SelectionStart = textBoxConsole.Text.Length;
            textBoxConsole.ScrollToCaret();
        }
        private void finishandreplace()
        {
            //string setfile = Path.Combine(textBox1.Text, "s_set_01a.adx");
            //ConvertToWav(setfile);

            //string wavfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "working/s_set_01a.wav");
            //RemoveAndInsertSong(wavfile, "00:00:10", "00:03:17", "C:\\Users\\Kevin\\Music\\(2010) My Beautiful Dark Twisted Fantasy\\(2010) My Beautiful Dark Twisted Fantasy\\[2010] Kanye West - My Beautiful Dark Twisted Fantasy\\02 Gorgeous [feat. Kid Cudi].wav");

            XmlDocument ogsongsxml = new XmlDocument();
            ogsongsxml.Load(Path.Combine(textBox1.Text, "songsDONOTDELETE.xml"));

            XmlNode originaltitle = ogsongsxml.SelectSingleNode("//playlist[@id='01a']");

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                string xmlsong = originaltitle.SelectSingleNode($"song[{i + 1}]").InnerText;
                string comboboxtext = comboBoxes[i].Text;
                if ( comboboxtext == xmlsong)
                {
                    AppendToConsole($"Song {i + 1} is not changed");
                }
                else
                {
                    AppendToConsole($"Replacing {xmlsong} (song {i+1}) with {comboboxtext}...");

                    //find errm new song location because i coded it to look pretty rather than functional. what the sigma !
                    foreach (string item in listBox1.Items)
                    {
                        if (comboboxtext == item.Substring(item.LastIndexOf("\\") + 1))
                        {
                            string newsonglocation = item;
                        }
                    }

                }
            }

        }

        public void updateXml(string newsongtitle, string oldsongtitle, string oldsongplaylistid)
        {

        }

        public void ConvertToWav(string adxFile)
        {
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");

            if (!File.Exists(ffmpegPath))
            {
                AppendToConsole("ffmpeg.exe not found!");
                return;
            }

            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "working/s_set_01a.wav"))) 
            {
                AppendToConsole("setwav already exists");
                return;
            }

            // Check if input file exists
            if (!File.Exists(adxFile))
            {
                AppendToConsole($"Input file not found: {adxFile}");
                return;
            }

            // Create output directory if it doesn't exist
            string outputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "working");
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
                AppendToConsole($"Created output directory: {outputDirectory}");
            }

            // Output file path
            string outputFileName = Path.GetFileNameWithoutExtension(adxFile) + ".wav";
            string outputFile = Path.Combine(outputDirectory, outputFileName);

            // Command to convert .adx to .wav
            string arguments = $"-y -loglevel fatal -hide_banner -nostats -i \"{adxFile}\" \"{outputFile}\"";
            AppendToConsole($"Converting: {adxFile} -> {outputFile}");

            // Run ffmpeg to convert the file
            if (RunFFmpegCommand(ffmpegPath, arguments))
            {
                AppendToConsole($"Successfully converted {adxFile} to {outputFile}");
            }
            else
            {
                AppendToConsole($"Failed to convert {adxFile}");
            }
        }

        public bool RunFFmpegCommand(string ffmpegPath, string arguments)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        AppendToConsole($"FFmpeg Error: {error}");
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                AppendToConsole($"Exception running ffmpeg: {ex.Message}");
                return false;
            }
        }

        public void RemoveAndInsertSong(string inputFile, string startTime, string endTime, string insertSongFile)
        {
            // Define the working directory
            string workingDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "working");

            // Ensure the working directory exists
            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
                AppendToConsole("Created 'working' directory.");
            }

            // Define paths for the intermediate files inside the 'working' directory
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            string part1 = Path.Combine(workingDirectory, "part1.wav");
            string tempPart1Fade = Path.Combine(workingDirectory, "temp_part1_fade.wav");
            string part2 = Path.Combine(workingDirectory, "part2.wav");
            string tempPart2Fade = Path.Combine(workingDirectory, "temp_part2_fade.wav");
            string fadedInsert = Path.Combine(workingDirectory, "fadedInsert.wav");
            string tempFadedInsert = Path.Combine(workingDirectory, "temp_fadedInsert.wav");
            string crossfadeOutput1 = Path.Combine(workingDirectory, "crossfade_part1_insert.wav");
            string crossfadeOutput2 = Path.Combine(workingDirectory, "crossfade_insert_part2.wav");
            string finalOutput = Path.Combine(workingDirectory, "final_output.wav");

            try
            {
                if (!File.Exists(ffmpegPath))
                {
                    AppendToConsole("ffmpeg.exe not found!");
                    return;
                }

                // Extract the parts before and after the portion to remove
                AppendToConsole("Extracting part1.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{inputFile}\" -ss 00:00:00 -to {startTime} -c copy \"{part1}\""))
                {
                    AppendToConsole("Failed to extract part1.wav.");
                    return;
                }

                AppendToConsole("Extracting part2.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{inputFile}\" -ss {endTime} -c copy \"{part2}\""))
                {
                    AppendToConsole("Failed to extract part2.wav.");
                    return;
                }

                // Check duration of part1.wav
                string part1Duration = GetFFmpegDuration(ffmpegPath, part1);
                if (part1Duration == null || double.Parse(part1Duration) < 2.0)
                {
                    AppendToConsole("Error: part1.wav is shorter than the fade-out duration (2 seconds).");
                    return;
                }

                // Apply fade-out to part1.wav
                AppendToConsole("Applying fade-out to part1.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{part1}\" -af \"afade=t=out:st={double.Parse(part1Duration) - 2}:d=2\" \"{tempPart1Fade}\""))
                {
                    AppendToConsole("Failed to apply fade-out to part1.wav.");
                    return;
                }

                // Apply fade-in and fade-out to the insert song
                AppendToConsole("Applying fade-in and fade-out to insert song...");
                string insertDuration = GetFFmpegDuration(ffmpegPath, insertSongFile);
                if (insertDuration == null)
                {
                    AppendToConsole("Error: could not retrieve insert song duration.");
                    return;
                }

                double insertDurationDouble;
                if (!double.TryParse(insertDuration, out insertDurationDouble))
                {
                    AppendToConsole("Failed to parse insert song duration.");
                    return;
                }

                double fadeOutStart = insertDurationDouble - 2;

                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{insertSongFile}\" -af \"afade=t=in:st=0:d=2,afade=t=out:st={fadeOutStart}:d=2\" \"{fadedInsert}\""))
                {
                    AppendToConsole("Failed to apply fade-in and fade-out to the insert song.");
                    return;
                }

                // Check duration of part2.wav to ensure fade-in is valid
                string part2Duration = GetFFmpegDuration(ffmpegPath, part2);
                if (part2Duration == null || double.Parse(part2Duration) < 2.0)
                {
                    AppendToConsole("Error: part2.wav is shorter than the fade-in duration (2 seconds).");
                    return;
                }

                // Apply fade-in to part2.wav and save it as a temporary file
                AppendToConsole("Applying fade-in to part2.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{part2}\" -af \"afade=t=in:st=0:d=2\" \"{tempPart2Fade}\""))
                {
                    AppendToConsole("Failed to apply fade-in to part2.wav.");
                    return;
                }

                // Crossfade part1.wav and fadedInsert.wav with 2-second overlap
                AppendToConsole("Crossfading part1.wav and fadedInsert.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{tempPart1Fade}\" -i \"{fadedInsert}\" -filter_complex \"[0][1]acrossfade=d=2\" \"{crossfadeOutput1}\""))
                {
                    AppendToConsole("Failed to crossfade part1.wav and fadedInsert.wav.");
                    return;
                }

                File.Delete(inputFile);
                // Crossfade fadedInsert.wav and part2.wav with 2-second overlap
                AppendToConsole("Crossfading fadedInsert.wav and tempPart2Fade.wav...");
                if (!RunFFmpegCommand(ffmpegPath, $"-i \"{crossfadeOutput1}\" -i \"{tempPart2Fade}\" -filter_complex \"[0][1]acrossfade=d=2\" \"{inputFile}\""))
                {
                    AppendToConsole("Failed to crossfade fadedInsert.wav and tempPart2Fade.wav.");
                    return;
                }

                AppendToConsole($"Successfully removed portion, inserted song with fade, and saved to {inputFile}");

                

                // Clean up temporary files
                File.Delete(part1);
                File.Delete(tempPart1Fade);
                File.Delete(part2);
                File.Delete(tempPart2Fade);
                File.Delete(fadedInsert);
                File.Delete(crossfadeOutput1);
            }
            catch (Exception ex)
            {
                AppendToConsole($"An error occurred: {ex.Message}");
            }
        }




        // Function to get the duration of the audio file using ffmpeg
        private string GetFFmpegDuration(string ffmpegPath, string audioFile)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = $"-i \"{audioFile}\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    // Extract duration from the error output (ffmpeg outputs file info in the error stream)
                    string durationPattern = @"Duration: (\d{2}):(\d{2}):(\d{2})\.(\d{2})";
                    Match match = Regex.Match(error, durationPattern);
                    if (match.Success)
                    {
                        double hours = double.Parse(match.Groups[1].Value);
                        double minutes = double.Parse(match.Groups[2].Value);
                        double seconds = double.Parse(match.Groups[3].Value);
                        double milliseconds = double.Parse(match.Groups[4].Value);

                        double totalDuration = hours * 3600 + minutes * 60 + seconds + milliseconds / 100;
                        return totalDuration.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                AppendToConsole($"Exception getting duration: {ex.Message}");
            }

            return null;
        }




        private void InitData(string folderPath)
        {
            XmlDocument songsxml = new XmlDocument();
            songsxml.Load(Path.Combine(folderPath, "songsDONOTDELETE.xml"));

            XmlNode title = songsxml.SelectSingleNode("//playlist[@id='01a']");

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                string songText = title.SelectSingleNode($"song[{i + 1}]").InnerText;
                comboBoxes[i].Text = songText;
                comboBoxes[i].Items.Add(songText);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files (*.mp3;*.wav;*.flac;*.ogg)|*.mp3;*.wav;*.flac;*.ogg";
                openFileDialog.FilterIndex = 1;

                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    listBox1.Items.Add(selectedFilePath);

                    ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6 };

                    for (int i = 0; i < comboBoxes.Length; i++)
                    {
                        comboBoxes[i].Items.Add(selectedFilePath.Substring(selectedFilePath.LastIndexOf("\\") + 1));
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(System.IO.Directory.Exists(Path.Combine(Environment.CurrentDirectory, "working"))))
            {
                System.IO.Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "working"));
                AppendToConsole("Created Working Directory");
            }

            else
            {
                AppendToConsole("Working Directory Already Exists");
            }
            
            finishandreplace();
            // System.IO.Directory.Delete(Path.Combine(Environment.CurrentDirectory, "working"));
        }

        private void chapter1a_Load(object sender, EventArgs e)
        {

        }

        private void label3s_Click(object sender, EventArgs e)
        {

        }
    }
}
