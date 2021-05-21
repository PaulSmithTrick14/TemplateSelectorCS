using System.Windows.Input;

namespace TemplateSelectorCS.Model
{
    public class Domain : ViewModelBase
    {
        bool _valid;
        public bool Valid
        {
            get { return _valid; }
            set
            {
                _valid = value;
                RaisePropertyChangedEvent(nameof(Valid));
            }
        }

        ViewModelBase _specific;
        public ViewModelBase Specific
        {
            get { return _specific; }
            set
            {
                _specific = value;
                RaisePropertyChangedEvent(nameof(Specific));
                RaisePropertyChangedEvent(nameof(BackingModelName));
            }
        }

        public string BackingModelName => Specific.GetType().Name;

        public ICommand ShowReport
        {
            get { return new DelegateCommand(()=> Specific = new Report()); }
        }

        public ICommand ShowGather
        {
            get { return new DelegateCommand(() => Specific = new Gather()); }
        }

        public ICommand ToggleValid
        {
            get { return new DelegateCommand(() => Valid = !Valid); }
        }

        public Domain()
        {
            Valid = true;
            Specific = new Gather();
        }
    }
}
