using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoXamarin.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		public Detail (Models.User user)
		{
			InitializeComponent ();

            this.LastName.Text = $"{user.id}: {user.first_name} {user.last_name}";
		}
	}
}