using System;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using KitchenTimeXamarin.Data.Models;
using KitchenTimeXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KitchenTimeXamarin.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimePicker : ContentView
	{
		private TimeSpan customTime;
		public TimeSpan CustomTime
		{
			get => customTime;
			set
			{
				customTime = value;
				OnPropertyChanged(nameof(CustomTime));
				OnPropertyChanged(nameof(CustomTimer));
			}
		}

		public Timer CustomTimer
		{
			get => new Timer()
			{
				Name = CustomTime.ToString(),
				Duration = new TimeSpan(CustomTime.Hours, CustomTime.Minutes, CustomTime.Seconds)
			};
		}

		public static readonly BindableProperty CreateCustomTimerCommandProperty = BindableProperty.Create(
			propertyName: nameof(CreateCustomTimerCommand),
			returnType: typeof(ICommand),
			declaringType: typeof(TimePicker));
		public ICommand CreateCustomTimerCommand
		{
			get => (ICommand)GetValue(CreateCustomTimerCommandProperty);
			set => SetValue(CreateCustomTimerCommandProperty, value);
		}

		public TimePicker()
		{
			InitializeComponent();
		}
		
	}
}