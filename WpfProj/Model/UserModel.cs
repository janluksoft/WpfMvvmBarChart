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
            }
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                RaisePropertyChanged(nameof(Value));
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
