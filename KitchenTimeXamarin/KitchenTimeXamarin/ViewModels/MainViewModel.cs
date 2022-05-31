using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using KitchenTimeXamarin.Components;
using KitchenTimeXamarin.Data.Models;
using MvvmHelpers;
using Xamarin.Forms;

namespace KitchenTimeXamarin.ViewModels
{
	public class MainViewModel : ObservableObject
	{

		public ObservableRangeCollection<TimerCardViewModel> Timers { get; set; }

		public MvvmHelpers.Commands.Command<TimeSet> SetTimerCommand { get; set; }

		
		// Configs
		public ObservableCollection<TimeSet> TimeSets { get; set; }

		public MainViewModel()
		{
			Timers = new ObservableRangeCollection<TimerCardViewModel>();
			
			TimeSets = new ObservableCollection<TimeSet>();
			TimeSets.Add(new TimeSet(){Name = "10s", Duration =new TimeSpan(0,0,10)});
			TimeSets.Add(new TimeSet(){Name = "1m", Duration= new TimeSpan(0,1,0)});
			TimeSets.Add(new TimeSet(){Name = "3m", Duration= new TimeSpan(0,3,0)});
			TimeSets.Add(new TimeSet(){Name = "10m", Duration =new TimeSpan(0,10,0)});

			SetTimerCommand = new MvvmHelpers.Commands.Command<TimeSet>(TimeSetSelected);
		}
		
		private void TimeSetSelected(TimeSet timeSet)
		{
			var timer = new TimerCardViewModel(timeSet.Name, timeSet.Duration);
			StartNewTimer(timer);
		}

		private void StartNewTimer(TimerCardViewModel timer)
		{
			Timers.Add(timer);
		}


	}
}