using NotePadWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePadWPF.ViewModel
{
	public class MainVM
	{
		private ModelDoc _document;

		public EditorVM Editor { get; set; }

		public FileVM File { get; set; }

		public MainVM()
		{
			_document = new ModelDoc();
			Editor = new EditorVM(_document);
			File = new FileVM(_document);
		}
	}
}
