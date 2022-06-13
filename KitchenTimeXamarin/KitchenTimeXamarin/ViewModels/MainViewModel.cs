using System;
using System.Collections.ObjectModel;
using KitchenTimeXamarin.Data.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace KitchenTimeXamarin.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		
		private ObservableCollection<Timer> timers;
		public ObservableCollection<Timer> Timers
		{
			get => timers; 
			set => SetProperty(ref timers, value);
			
		}
		public ObservableCollection<TimeSet> TimeSets { get; set; }
		

		public MainViewModel()
		{
			Timers = new ObservableRangeCollection<Timer>();
			Timers.Add(new Timer(){Name = "Pečené kuře", Duration = new TimeSpan(0, 10, 0) });
			Timers.Add(new Timer(){Name = "Svíčková", Duration = new TimeSpan(0, 35, 20) });
			
			TimeSets = new ObservableCollection<TimeSet>();
			TimeSets.Add(new TimeSet(){Name = "10s", Duration =new TimeSpan(0,0,10)});
			TimeSets.Add(new TimeSet(){Name = "1m", Duration= new TimeSpan(0,1,0)});
			TimeSets.Add(new TimeSet(){Name = "3m", Duration= new TimeSpan(0,3,0)});
			TimeSets.Add(new TimeSet(){Name = "10m", Duration =new TimeSpan(0,10,0)});
		}
		
	}
}