using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calcluatetip
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		private void btnNoTax_Click(object sender, RoutedEventArgs e)
		{
			double total = Convert.ToDouble(txtTotal.Text);
			double tip = 0.0;

			if (cboTip.SelectedIndex == 0)
			{
				tip = 0.05;
			}
			else if (cboTip.SelectedIndex == 1)
			{
				tip = 0.10;
			}
			else if (cboTip.SelectedIndex == 2)
			{
				tip = 0.15;
			}
			else if(cboTip.SelectedIndex == 3)
			{
				tip = 0.20;
			}
			else if(cboTip.SelectedIndex == 4)
			{
				tip = 0.25;
			}

			 txtTotNoTax.Text = CalcTip.CalcWithoutTax(total, tip);
		}

		private void btnTax_Click(object sender, RoutedEventArgs e)
		{
			double total = Convert.ToDouble(txtTotal.Text);
			double tip = 0.0;

			if (cboTip.SelectedIndex == 0)
			{
				tip = 0.05;
			}
			else if (cboTip.SelectedIndex == 1)
			{
				tip = 0.10;
			}
			else if (cboTip.SelectedIndex == 2)
			{
				tip = 0.15;
			}
			else if (cboTip.SelectedIndex == 3)
			{
				tip = 0.20;
			}
			else if (cboTip.SelectedIndex == 4)
			{
				tip = 0.25;
			}

			txtTotWTax.Text = CalcTip.CalcWithTax(total, tip);
		}
	}
}
