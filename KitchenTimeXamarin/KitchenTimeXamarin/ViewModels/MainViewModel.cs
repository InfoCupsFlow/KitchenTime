using MvvmHelpers;
using Xamarin.Forms;

namespace KitchenTimeXamarin.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		public string TimeListLabel { get; set; } = "Časy:";
		public string DishListLabel { get; set; } = "Pokrmy:";
	}
}