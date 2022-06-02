using System;
using System.Diagnostics;
using System.Timers;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;


namespace KitchenTimeXamarin.ViewModels
{
	public class TimerCardViewModel : ObservableObject
	{
		public string Title { get; set; }
		public TimeSpan Duration { get; set; }

		private TimeSpan countDown;
		public TimeSpan CountDown
		{
			get => countDown;
			set => SetProperty(ref countDown, value);
		}

		private bool isRunning = false;
		public bool IsRunning
		{
			get => isRunning; 
			set
			{
				SetProperty(ref isRunning, value);
				StartCommand.RaiseCanExecuteChanged();
			}
		}
		
		public Command StartCommand { get; set; }
		


		public TimerCardViewModel(string title, TimeSpan duration)
		{
			Title = title;
			Duration = duration;
			CountDown = Duration;
			StartCommand = new Command(StartCountDown, () => !IsRunning);
			StartCommand.Execute(null);
		}

		public void StartCountDown()
		{
			CountDown = Duration;
			IsRunning = true;
			
			Device.StartTimer(TimeSpan.FromSeconds(1), Tick );
		}

		private bool Tick()
		{
			CountDown -= TimeSpan.FromSeconds(1);

			if (CountDown.TotalSeconds > 0)
				return true;
			else
			{
				IsRunning = false;
				return false;
			}

		}
	}
}