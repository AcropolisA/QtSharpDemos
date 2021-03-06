using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemos.GuiExample;
using QtGui;

namespace QtSharpDemos {
	class Program {
		public static QApplication qtApp { get; private set; }

		static int Main( string[] args ) {
			// Init QT application
			// project-> properties -> allow unsafe code (must ce checked for now)
			try {
				// added try/catch block so we can log exception errors
				unsafe {
					int count = 0;

					qtApp = new QApplication( ref count, null );
					// TODO : missing implementation https://doc.qt.io/archives/qt-4.8/qapplication.html#setStyle
					// TODO : add dark Fusion theme https://github.com/Jorgen-VikingGod/Qt-Frameless-Window-DarkStyle
					//qtApp.SetStyle();
					//var qtApp = new QGuiApplication(ref count, null);
				}
				

				//var labelDemo = new LabelDemo();

				//var windowsDemo = new WindowsDemo();
				//var widgetDemo = new WidgetDemo();
				//var quitButtonDemo = new QuitButtonDemo();
				//var absolutePositionDemo = new ImagesWithAbsolutePositionDemo();
				//var buttonsDemo = new ButtonsDemo();
				//var checkBoxDemo = new CheckBoxDemo();
				//var lineEditDemo = new LineEditDemo();
				//var togleButtonsDemo = new TogleButtonsDemo();
				//var comboBoxDemo = new ComboBoxDemo();
				// var menuBar = new MenuBarDemo();
				//var toolbarDemo = new ToolbarDemo();
				//var messageBoxDemo = new MessageBoxDemo();
				//var inputDialogDemo = new InputDialogDemo();
				//var colorDialogDemo = new ColorDialogDemo();
				//var fontDialogDemo = new FontDialogDemo();

				//var panelDemo = new SpliterWithPanelsDemo();

				//var paintDemo = new PaintDemo();
				//var paint_ShapesDemo= new Paint_ShapesDemo();
				//var paint_TransparentRectDemo = new Paint_TransparentRectDemo();
				//var paint_TextDemo= new Paint_TextDemo();
				//var paint_DonutDemo = new Paint_DonutDemo();
				//var paint_GrayscaleImage = new Paint_GrayscaleImage();

				// load QML file
				//var qQmlApplicationEngineDemo = new QQmlApplicationEngineDemo();

				// This works
				//return QApplication.Exec();

				// Run the QApplication Process ( this also works)

				//var treeViewDemo = new TreeViewDemo();

				var demoList = new TreeWithDemoList();
				demoList.Show();

				return QGuiApplication.Exec();


				//  Console.WriteLine("All done");

			} catch (Exception ex) {
				Console.WriteLine( ex.Message );
				//Console.ReadKey();

				// throw;
			}
			return 0;

		}
	}
}
