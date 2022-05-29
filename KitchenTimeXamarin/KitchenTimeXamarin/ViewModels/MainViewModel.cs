using System.Collections.Generic;
using System.Collections.ObjectModel;
using KitchenTimeXamarin.Data.Models;
using MvvmHelpers;
using Xamarin.Forms;

namespace KitchenTimeXamarin.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private string countDownDisplay = "00:00:00";
		public string CountDownDisplay
		{
			get => countDownDisplay;
			set => SetProperty(ref countDownDisplay, value);
		}
		public MvvmHelpers.Commands.Command<Timer> SetTimerCommand { get; set; }

		public ObservableCollection<Timer> Timers { get; set; }

		public MainViewModel()
		{
			Timers = new ObservableCollection<Timer>();
			Timers.Add(new Timer(){Name = "30s", Secunds = 30});
			Timers.Add(new Timer(){Name = "1m", Secunds = 60});
			Timers.Add(new Timer(){Name = "3m", Secunds = 180});
			Timers.Add(new Timer(){Name = "10m", Secunds = 600});

			SetTimerCommand = new MvvmHelpers.Commands.Command<Timer>(OnSetTimer);
		}

		private void OnSetTimer(Timer timer)
		{
			CountDownDisplay = timer.Secunds.ToString();
		}
	}
}