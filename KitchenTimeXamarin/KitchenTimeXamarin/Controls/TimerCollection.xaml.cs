using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenTimeXamarin.Data.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenTimeXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimerCollection
	{

		#region Binding Properties

		public static readonly BindableProperty TimersProperty = BindableProperty.Create(
		propertyName: nameof(Timers),
		returnType: typeof(ObservableCollection<Timer>),
		declaringType: typeof(TimerCollection));

		public ObservableCollection<Timer> Timers
		{
			get { return (ObservableCollection<Timer>)GetValue(TimersProperty); }
			set { SetValue(TimersProperty, value); }
		}

		#endregion


		public TimerCollection()
		{
			InitializeComponent();
		}
	}
}