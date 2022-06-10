using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenTimeXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimerCard : ContentView
	{
		public TimerCard()
		{
			InitializeComponent();
		}
	}
}