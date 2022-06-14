using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using KitchenTimeXamarin.Data.Models;
using Xamarin.Forms;

namespace KitchenTimeXamarin.ViewModels
{
	[INotifyPropertyChanged]
	public partial class MainViewModel
	{
		[ObservableProperty]
		private ObservableCollection<Timer> timers;

		public ObservableCollection<TimeSet> TimeSets { get; set; }

		public ICommand CreateTimerCommant { get; }

		public MainViewModel()
		{
			Timers = new ObservableCollection<Timer>();
			Timers.Add(new Timer(){Name = "Pečené kuře", Duration = new TimeSpan(0, 10, 0) });

			TimeSets = new ObservableCollection<TimeSet>();
			TimeSets.Add(new TimeSet(){Name = "10s", Duration =new TimeSpan(0,0,10)});
			TimeSets.Add(new TimeSet(){Name = "1m", Duration= new TimeSpan(0,1,0)});
			TimeSets.Add(new TimeSet(){Name = "3m", Duration= new TimeSpan(0,3,0)});
			TimeSets.Add(new TimeSet(){Name = "10m", Duration =new TimeSpan(0,10,0)});

			CreateTimerCommant = new Command<Timer>(CreateTimer);
		}

		private void CreateTimer(Timer timer)
		{
			Timer newTimer = new Timer() { Name = "Nový", Duration = TimeSpan.Zero };
			Timers.Add(newTimer);
		}
	}
}