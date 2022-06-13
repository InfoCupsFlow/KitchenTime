using KitchenTimeXamarin.Data.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenTimeXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimerCard : ContentView
	{

		#region Bindable Properties

		public static readonly BindableProperty TimerProperty = BindableProperty.Create(
		propertyName: nameof(Timer),
		returnType: typeof(Timer),
		declaringType: typeof(TimerCard)
		);
		
		public Timer Timer
		{
			get { return (Timer)GetValue(TimerProperty);}
			set { SetValue(TimerProperty, value); }
		}

		#endregion


		

		public TimerCard()
		{
			InitializeComponent();
		}
	}
}