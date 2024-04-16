

namespace Lab16.Serialization
{
    public class Dialog<T>
    {
        public IFileDialogService<T> dialog;
        public T obj;

        public Dialog(IFileDialogService<T> dialog, T obj)
        {
            this.dialog = dialog;
            this.obj = obj;
        }

        public bool LoadLDialog(ISerializator<T> serializator)
        {
            if (dialog.OpenFileDialog(serializator))
            {
                var obj2 = serializator.Load(dialog.FilePath);

                if (obj2 != null)
                    obj = obj2;

                return true;
            }

            return false;

        }
        public bool SaveDialog(ISerializator<T> serializator)
        {
            if (dialog.SaveFileDialog(serializator))
            {
                serializator.Save(obj, dialog.FilePath);
                return true;
            }

            return false;
        }
    }


}

