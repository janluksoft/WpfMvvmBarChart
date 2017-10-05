using WpfProj.Model;
using System.Collections.ObjectModel;

namespace WpfProj.ViewModel
{
    internal class UserViewModel
    {
        public ObservableCollection<UserPeriod> Months { get; set; }

        public UserPeriod SelectedUser { get; set; }

        public UserViewModel()
        {
            Months = LoadUsers();
        }

        private ObservableCollection<UserPeriod> LoadUsers()
        {
            var users = new ObservableCollection<UserPeriod>
            {
                new UserPeriod { Period = "January", Value = 46 },
                new UserPeriod { Period = "February", Value = 32 },
                new UserPeriod { Period = "March", Value = 53 },
                new UserPeriod { Period = "April", Value = 14 },
                new UserPeriod { Period = "May", Value = 25 },
                new UserPeriod { Period = "June", Value = 36 },
                new UserPeriod { Period = "July", Value = 17 },
                new UserPeriod { Period = "August", Value = 48 },
                new UserPeriod { Period = "September", Value = 49 },
                new UserPeriod { Period = "October", Value = 20 },
                new UserPeriod { Period = "November", Value = 11 },
                new UserPeriod { Period = "December", Value = 12 },
            };

            return(users);
        }

        private void OnDelete(object user)
        {
            var u = user as UserPeriod;
            Months.Remove(u);
        }

        private bool CanDelete(object user)
        {
            var u = user as UserPeriod;
            return u != null;
        }
    }
}
