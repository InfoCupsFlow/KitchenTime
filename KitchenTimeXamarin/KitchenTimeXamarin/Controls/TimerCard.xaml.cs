using System;
using System.Runtime.CompilerServices;
using KitchenTimeXamarin.Data.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenTimeXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimerCard : ContentView
	{

		private TimeSpan countDown = TimeSpan.Zero;
		public TimeSpan CountDown
		{
			get => countDown;
			set { 
				countDown = value; 
				OnPropertyChanged(nameof(CountDown)); 
			}
		}

		#region Bindable Properties

		public static readonly BindableProperty TimerProperty = BindableProperty.Create(
		propertyName: nameof(Timer),
		returnType: typeof(Timer),
		declaringType: typeof(TimerCard),
		propertyChanged:OnTimerChanged
		);

		private static void OnTimerChanged(BindableObject bindable, object oldvalue, object newvalue)
		{
			var control = (TimerCard)bindable;
			control.StartCountDown();
		}


		public Timer Timer
		{
			get { return (Timer)GetValue(TimerProperty);}
			set { SetValue(TimerProperty, value); StartCountDown(); }
		}

		#endregion


		public TimerCard()
		{
			InitializeComponent();
		}

		private void StartCountDown()
		{
			CountDown = Timer.Duration;
			Device.StartTimer(new TimeSpan(0,0,1), () =>
			{
				if (CountDown.TotalSeconds <= 0)
				{
					CountDown = TimeSpan.Zero;
					OnCounDonwFinished();
					return false;
				}
				
				CountDown -= TimeSpan.FromSeconds(1);
				Console.WriteLine("Tick");

				return true;
			});
		}

		private void OnCounDonwFinished()
		{
			Console.WriteLine(" !!! Timer Finished!");
		}
	}
}