using Newtonsoft.Json;

namespace BackupManagerApp
{
    public partial class MainForm : Form
    {
        private BackupService _backupService;
        private string _settingsFilePath = "settings.json";

        public MainForm()
        {
            InitializeComponent();
            _backupService = new BackupService();

            LoadSettings();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = fbd.SelectedPath;
                    Log($"Вибрано джерело: {txtSource.Text}");
                }
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = fbd.SelectedPath;
                    Log($"Вибрано місце збереження: {txtDestination.Text}");
                }
            }
        }

        private void btnBackupNow_Click(object sender, EventArgs e)
        {
            PerformBackup();
        }

        private void chkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoBackup.Checked)
            {
                if (string.IsNullOrEmpty(txtSource.Text) || string.IsNullOrEmpty(txtDestination.Text))
                {
                    MessageBox.Show("Спочатку оберіть обидві папки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkAutoBackup.Checked = false;
                    return;
                }

                timerAutoBackup.Interval = (int)numInterval.Value * 60 * 1000;
                timerAutoBackup.Start();
                Log($"Автобекап увімкнено. Інтервал: {numInterval.Value} хв.");
            }
            else
            {
                timerAutoBackup.Stop();
                Log("Автобекап вимкнено.");
            }
        }

        private void timerAutoBackup_Tick(object sender, EventArgs e)
        {
            Log("Запуск автоматичного резервного копіювання...");
            PerformBackup();
        }

        private void PerformBackup()
        {
            if (string.IsNullOrEmpty(txtSource.Text) || string.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Оберіть вихідну папку та папку збереження.", "Увага");
                return;
            }

            try
            {
                btnBackupNow.Enabled = false;
                prbStatus.Visible = true;
                Application.DoEvents();

                Log("Початок копіювання. Зачекайте...");

                string resultPath = _backupService.CreateBackup(txtSource.Text, txtDestination.Text);

                Log($"Копію успішно створено у {resultPath}");
            }
            catch (Exception ex)
            {
                Log($"Помилка! {ex.Message}");
            }
            finally
            {
                btnBackupNow.Enabled = true;
                prbStatus.Visible = false;
            }
        }

        private void Log(string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            lstLogs.Items.Add($"[{time}] {message}");
            lstLogs.TopIndex = lstLogs.Items.Count - 1;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
            base.OnFormClosing(e);
        }

        private void SaveSettings()
        {
            AppSettings settings = new AppSettings();
            settings.SourceFolder = txtSource.Text;
            settings.DestinationFolder = txtDestination.Text;
            settings.Interval = (int)numInterval.Value;

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);

            File.WriteAllText(_settingsFilePath, json);
        }

        private void LoadSettings()
        {
            if (File.Exists(_settingsFilePath))
            {
                string json = File.ReadAllText(_settingsFilePath);
                AppSettings settings = JsonConvert.DeserializeObject<AppSettings>(json);

                if (settings != null)
                {
                    txtSource.Text = settings.SourceFolder;
                    txtDestination.Text = settings.DestinationFolder;
                    if (settings.Interval > 0 && settings.Interval <= numInterval.Maximum)
                    {
                        numInterval.Value = settings.Interval;
                    }
                }
            }
        }
    }
}