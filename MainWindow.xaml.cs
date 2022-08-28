using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Panuon.UI;
using Panuon.UI.Silver;
using Panuon.UI.Silver.Configurations;

namespace MCR
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnTest_Click(object sender, RoutedEventArgs e)
		{
			double cal = ComboBox1.SelectedIndex == 0
				? 66 + (13.7 * float.Parse(w.Text)) + (5 * float.Parse(h.Text)) - (6.8 * float.Parse(age.Text))
				: 655 + (9.6 * float.Parse(w.Text)) + (1.7 * float.Parse(h.Text)) - (4.7 * float.Parse(age.Text));
			double _mc = mc.SelectedIndex switch
			{
				0 => 1.2,
				1 => 1.375,
				2 => 1.550,
				3 => 1.725,
				4 => 1.9,
				_ => 1.2,
			};
			cal *= _mc;
			cal = Math.Round(cal, 2);
			MessageBoxX.Show(this, mc.Text + "情况下你一天的消耗为：" + cal.ToString() + "卡路里\n约为" + Math.Round(cal * 4.1859, 2) + "焦耳。", "计算结果", MessageBoxButton.OK, MessageBoxIcon.Success, DefaultButton.YesOK);
			ListView1.Items.Add(mc.Text + "情况下你一天的消耗为：" + cal.ToString() + "卡路里，约为" + Math.Round(cal * 4.1859, 2) + "焦耳。");
		}
	}
}
