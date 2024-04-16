
namespace Lab16.Serialization
{
    public class FileDialogService<T> : IFileDialogService<T>
    {
        public string FilePath { get; set; } = "json";

        public bool OpenFileDialog(ISerializator<T> serializator)
        {
            using var openFileDialog = new System.Windows.Forms.OpenFileDialog();

            var fileType = serializator.FileType;
            openFileDialog.Filter = $"{fileType} files (*.{fileType})|*.{fileType}|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }

            return false;
        }

        public bool SaveFileDialog(ISerializator<T> serializator)
        {
            using var saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            var fileType = serializator.FileType;
            saveFileDialog.Filter = $"{fileType} files (*.{fileType})|*.{fileType}|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }

            return false;
        }
    }
}
