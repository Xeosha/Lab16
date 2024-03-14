using EventBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lab_10lib;
using System.Text.Json;
using BinarySearchTree;

namespace Lab16.Serialization
{


    public static class Dialog
    {
        public static List<Goods> LoadListDialog(ISerializator<List<Goods>> serializator)
        {
            using var openFileDialog = new System.Windows.Forms.OpenFileDialog();

            var fileType = serializator.FileType;
            openFileDialog.Filter = $"{fileType} files (*.{fileType})|*.{fileType}|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                var obj = serializator.Load(filePath);

                if (obj != null)
                    return obj;

            }
            return new List<Goods>();
        }

        public static void LoadDialog(this BinaryTreeEvent<Goods> tree, ISerializator<List<Goods>> serializator)
        {
            try
            {
                tree.Add(Dialog.LoadListDialog(serializator));
                MessageBox.Show($"Коллекция загружена", "INFO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveListDialog(ISerializator<List<Goods>> serializator, List<Goods> lst)
        {
            using var saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            var fileType = serializator.FileType;
            saveFileDialog.Filter = $"{fileType} files (*.{fileType})|*.{fileType}|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                serializator.Save(lst, filePath);
            }
        }

        public static void SaveDialog(this BinaryTreeEvent<Goods> tree, ISerializator<List<Goods>> serializator)
        {
            try
            {
                Dialog.SaveListDialog(serializator, tree.ToList());
                MessageBox.Show($"Файл успешно сохранен\n", "Save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          ;
        }
    }


}

