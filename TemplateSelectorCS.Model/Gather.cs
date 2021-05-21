using System;
using System.Windows.Input;

namespace TemplateSelectorCS.Model
{
    public class Gather : ViewModelBase
    {
        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                RaisePropertyChangedEvent("StartDate");
            }
        }

        public ICommand PreviousDate
        {
            get { return new DelegateCommand(() => StartDate = StartDate.AddDays(-1.0));  }
        }

        public Gather()
        {
            StartDate = DateTime.Today;
        }
    }
}
