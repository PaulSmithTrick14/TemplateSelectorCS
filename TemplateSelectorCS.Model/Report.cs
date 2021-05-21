using System.Collections.Generic;

namespace TemplateSelectorCS.Model
{
    public class Report : ViewModelBase
    {
        string _header;
        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                RaisePropertyChangedEvent("Header");
            }
        }

        List<string> _lotsOfStuff;
        public List<string> LotsOfStuff
        {
            get { return _lotsOfStuff; }
            set
            {
                _lotsOfStuff = value;
                RaisePropertyChangedEvent("LotsOfStuff");
            }
        }

        public Report()
        {
            Header = "The report header";
            LotsOfStuff = new List<string>() { "Line 1", "Line 2" };
        }
    }
}
