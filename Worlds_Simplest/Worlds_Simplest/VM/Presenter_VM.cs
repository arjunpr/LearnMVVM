using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Worlds_Simplest.Model;

namespace Worlds_Simplest.VM
{
    public class Presenter_VM : ObservableObject
    {
        private readonly TextConverter _textConveter 
            = new TextConverter(s => s.ToUpper());
        
        private string _someText;
        
        public readonly ObservableCollection<string> _history
            = new ObservableCollection<string>();

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history;  }
        }
        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }
        
        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(SomeText)) 
                return;
            AddToHistory(_textConveter.ConvertText(SomeText));
            SomeText = string.Empty;
        }

        private void AddToHistory (string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }
}
