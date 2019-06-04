using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NotePadWPF.Model; 

namespace NotePadWPF.ViewModel
{
	public class EditorVM
	{
		public ICommand FormatCommand { get; }
		public ICommand WrapCommand { get; }
		public ModelFormat Format { get; set; }
		public ModelDoc Document { get; set; }

		public EditorVM(ModelDoc document)
		{
			Document = document;
			Format = new ModelFormat();
			FormatCommand = new RelayCommand(OpenStyleWindow);
			WrapCommand = new RelayCommand(ToogleWrap);
		}

		private void OpenStyleWindow()
		{
			var fontWindow = new FontWindow();
			fontWindow.DataContext = Format;
			fontWindow.ShowDialog();
		}

		private void ToogleWrap()
		{
			if (Format.Wrap == System.Windows.TextWrapping.Wrap)
			{
				Format.Wrap = System.Windows.TextWrapping.NoWrap;
			}
			else
			{
				Format.Wrap = System.Windows.TextWrapping.Wrap;
			}
		}



	}
}
