namespace BackupManagerApp
{
    public class BackupService
    {
        public string CreateBackup(string sourceFolder, string destinationFolder)
        {
            if (!Directory.Exists(sourceFolder))
                throw new DirectoryNotFoundException("Вихідну папку не знайдено.");

            string folderName = new DirectoryInfo(sourceFolder).Name;
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string backupPath = Path.Combine(destinationFolder, $"{folderName}_Backup_{timestamp}");

            CopyDirectory(sourceFolder, backupPath);

            return backupPath;
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string targetFile = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, targetFile, true);
            }

            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                string targetSubDir = Path.Combine(targetDir, Path.GetFileName(directory));
                CopyDirectory(directory, targetSubDir);
            }
        }
    }
}
