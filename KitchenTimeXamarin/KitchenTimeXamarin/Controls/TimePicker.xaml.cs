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
	public partial class TimePicker : ContentView
	{
		public TimeSpan CustomTime { get; set; } = new TimeSpan(0, 10, 0);
		
		public TimePicker()
		{
			InitializeComponent();
			BindingContext = this;
		}
	}
}