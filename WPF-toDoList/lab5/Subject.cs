using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Subject : INotifyPropertyChanged
    {
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public string Name { get; set; }

        public bool Status
        {
            set
            {
                _status = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Status"));

            }
            get { return _status; }
        }
        private bool _status;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
