namespace BackupManagerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            btnSelectSource = new Button();
            btnSelectDestination = new Button();
            label4 = new Label();
            btnBackupNow = new Button();
            prbStatus = new ProgressBar();
            chkAutoBackup = new CheckBox();
            label5 = new Label();
            numInterval = new NumericUpDown();
            lstLogs = new ListBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            timerAutoBackup = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(151, 27);
            label1.TabIndex = 0;
            label1.Text = "Вибір папок";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(84, 119);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 1;
            label2.Text = "Що копіювати?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(84, 177);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.TabIndex = 2;
            label3.Text = "Куди зберігати?";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(290, 117);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(401, 30);
            txtSource.TabIndex = 3;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(290, 170);
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.Size = new Size(401, 30);
            txtDestination.TabIndex = 4;
            // 
            // btnSelectSource
            // 
            btnSelectSource.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectSource.Location = new Point(712, 117);
            btnSelectSource.Name = "btnSelectSource";
            btnSelectSource.Size = new Size(103, 30);
            btnSelectSource.TabIndex = 5;
            btnSelectSource.Text = "Огляд...";
            btnSelectSource.UseVisualStyleBackColor = true;
            btnSelectSource.Click += btnSelectSource_Click;
            // 
            // btnSelectDestination
            // 
            btnSelectDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectDestination.Location = new Point(712, 177);
            btnSelectDestination.Name = "btnSelectDestination";
            btnSelectDestination.Size = new Size(103, 30);
            btnSelectDestination.TabIndex = 6;
            btnSelectDestination.Text = "Огляд...";
            btnSelectDestination.UseVisualStyleBackColor = true;
            btnSelectDestination.Click += btnSelectDestination_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(29, 271);
            label4.Name = "label4";
            label4.Size = new Size(287, 27);
            label4.TabIndex = 7;
            label4.Text = "Параметри копіювання";
            // 
            // btnBackupNow
            // 
            btnBackupNow.BackColor = Color.Ivory;
            btnBackupNow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBackupNow.ForeColor = Color.DarkOliveGreen;
            btnBackupNow.Location = new Point(55, 319);
            btnBackupNow.Name = "btnBackupNow";
            btnBackupNow.Size = new Size(237, 35);
            btnBackupNow.TabIndex = 8;
            btnBackupNow.Text = "Створити копію зараз";
            btnBackupNow.UseVisualStyleBackColor = false;
            btnBackupNow.Click += btnBackupNow_Click;
            // 
            // prbStatus
            // 
            prbStatus.ForeColor = Color.YellowGreen;
            prbStatus.Location = new Point(323, 325);
            prbStatus.MarqueeAnimationSpeed = 400;
            prbStatus.Name = "prbStatus";
            prbStatus.Size = new Size(492, 29);
            prbStatus.Style = ProgressBarStyle.Marquee;
            prbStatus.TabIndex = 9;
            prbStatus.Visible = false;
            // 
            // chkAutoBackup
            // 
            chkAutoBackup.AutoSize = true;
            chkAutoBackup.Font = new Font("Segoe UI", 10F);
            chkAutoBackup.Location = new Point(55, 412);
            chkAutoBackup.Name = "chkAutoBackup";
            chkAutoBackup.Size = new Size(239, 27);
            chkAutoBackup.TabIndex = 10;
            chkAutoBackup.Text = " Автоматичне копіювання";
            chkAutoBackup.UseVisualStyleBackColor = true;
            chkAutoBackup.CheckedChanged += chkAutoBackup_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 451);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 11;
            label5.Text = "Інтервал (хв):";
            // 
            // numInterval
            // 
            numInterval.Location = new Point(206, 449);
            numInterval.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(86, 30);
            numInterval.TabIndex = 12;
            numInterval.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lstLogs
            // 
            lstLogs.FormattingEnabled = true;
            lstLogs.Location = new Point(323, 461);
            lstLogs.Name = "lstLogs";
            lstLogs.Size = new Size(492, 257);
            lstLogs.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(453, 412);
            label6.Name = "label6";
            label6.Size = new Size(220, 27);
            label6.TabIndex = 14;
            label6.Text = "Журнал операцій";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 514);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // timerAutoBackup
            // 
            timerAutoBackup.Tick += timerAutoBackup_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 759);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lstLogs);
            Controls.Add(numInterval);
            Controls.Add(label5);
            Controls.Add(chkAutoBackup);
            Controls.Add(prbStatus);
            Controls.Add(btnBackupNow);
            Controls.Add(label4);
            Controls.Add(btnSelectDestination);
            Controls.Add(btnSelectSource);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджер резервного копіювання";
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSource;
        private TextBox txtDestination;
        private Button btnSelectSource;
        private Button btnSelectDestination;
        private Label label4;
        private Button btnBackupNow;
        private ProgressBar prbStatus;
        private CheckBox chkAutoBackup;
        private Label label5;
        private NumericUpDown numInterval;
        private ListBox lstLogs;
        private Label label6;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerAutoBackup;
    }
}
