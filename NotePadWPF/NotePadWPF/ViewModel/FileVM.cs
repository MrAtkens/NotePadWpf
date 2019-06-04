using Microsoft.Win32;
using NotePadWPF.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace NotePadWPF.ViewModel
{
	public class FileVM
	{
		public bool isFileSave { get; set; }
		public ModelDoc Document { get; private set; }

		public ICommand NewCommand { get; }
		public ICommand SaveCommand { get; }
		public ICommand SaveAsCommand { get; }
		public ICommand OpenCommand { get; }

		public FileVM(ModelDoc document)
		{
			Document = document;
			NewCommand = new RelayCommand(NewFile);
			SaveCommand = new RelayCommand(SaveFile);
			SaveAsCommand = new RelayCommand(SaveFileAs);
			OpenCommand = new RelayCommand(OpenFile);
		}

		public void NewFile()
		{
			Document.FileName = "Безимянный";
			Document.FilePath = string.Empty;
			Document.Text = string.Empty;
			isFileSave = false;
		}

		private void SaveFile()
		{

			if (isFileSave == false)
			{
				var saveFileWindow = new SaveFileDialog();
				saveFileWindow.Filter = "Text File (*.txt)|*.txt";
				saveFileWindow.FileName = "Безимянный";
				if (saveFileWindow.ShowDialog() == true)
				{
					DockFile(saveFileWindow);
					File.WriteAllText(saveFileWindow.FileName, Document.Text);
					isFileSave = true;
					DispatcherTimer dispatcherTimer = new DispatcherTimer();

					dispatcherTimer.Tick += new EventHandler(Save);
					dispatcherTimer.Interval = new TimeSpan(0, 0, 9);
					dispatcherTimer.Start();
				}
			}
			else
			{
				File.WriteAllText(Document.FilePath, Document.Text);
			}
		}

		private void SaveFileAs()
		{
			var saveFileWindow = new SaveFileDialog();
			saveFileWindow.Filter = "Text File (*.txt)|*.txt | Word (*.doc)|*.doc | PDF (*.pdf)|*.pdf";
			if (saveFileWindow.ShowDialog() == true)
			{
				DockFile(saveFileWindow);
				File.WriteAllText(saveFileWindow.FileName, Document.Text);
			}
		}
		private void Save(object data, EventArgs e)
		{
			File.WriteAllText(Document.FilePath, Document.Text);
		}

		private void OpenFile()
		{
			var openFileWindow = new OpenFileDialog();
			if (openFileWindow.ShowDialog() == true)
			{
				DockFile(openFileWindow);
				Document.Text = File.ReadAllText(openFileWindow.FileName);
				isFileSave = true;
			}
		}

		private void DockFile<T>(T dialog) where T : FileDialog
		{
			Document.FilePath = dialog.FileName;
			Document.FileName = dialog.SafeFileName;
		}

	}

}
