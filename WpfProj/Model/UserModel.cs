using System;
using System.ComponentModel;

namespace WpfProj.Model
{

    internal class UserPeriod : INotifyPropertyChanged
    {
        private string _period;
        private int _value;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Period
        {
            get => _period;
            set
            {
                if (_period != null && _period.Equals(value))
                {
                    return;
                }
                _period = value;
                RaisePropertyChanged(nameof(Period));
                //RaisePropertyChanged(nameof(FullName));
            }
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                RaisePropertyChanged(nameof(Value));
                //RaisePropertyChanged(nameof(FullName));
            }
        }

        //To gdy tylko zmieni się firstName lub lastName też jakby automatem się zmienia
        //public string FullName => string.Concat(firstName, " ", lastName);

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
