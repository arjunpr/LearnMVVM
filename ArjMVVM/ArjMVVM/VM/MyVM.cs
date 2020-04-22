using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ArjMVVM.Framework;

namespace ArjMVVM.VM
{
    public class MyVM: ArjMVVM.Framework.ObservableObject
    {
        private int _button1Count = 0;
        private int _button2Count = 0;
        private readonly ICommand _button1ClickCommand;

        public MyModel testModel1 { get; set; }
        public MyModel testModel2 { get; set; }

        public string Property1 { get; set; }

        public MyVM()
        {
            _button1ClickCommand = new RelayCommand(
                param => Button1Clicked());
            Button2ClickCommand = new RelayCommand(
                param => Button2Clicked());
            TestRelayCommand = new RelayCommand(
                (m) => MessageBox.Show("Command Received!"));

            // Model Class for direct Binding
            testModel1 = new MyModel() { Property1 = "ABC", Property2 = "DEF" };
            testModel2 = new MyModel() { Property1 = "UVW", Property2 = "XYZ" };
            Property1 = "Hello World!";


        }
        /// <summary>
        /// Hello this is my summary
        /// </summary>
        public string Button1Count 
        {
            get
            {
                return _button1Count.ToString();
            }            
        }

        public string Button2Count
        {
            get
            {
                return _button2Count.ToString();
            }
        }
        
        public ICommand Button1ClickCommand
        {
            get => _button1ClickCommand;
            /*
            set
            {
                _button1ClickedCommand = value;
            }
            */
        }

        public ICommand Button2ClickCommand { get; set; }

        private void Button1Clicked()
        {
            _button1Count++;
            GeneratePropertyChangedNotification("Button1Count");
            //MessageBox.Show("Button1 Clicked");
        }
        private void Button2Clicked()
        {
            _button2Count++;
            GeneratePropertyChangedNotification("Button2Count");
            //MessageBox.Show("Button2 Clicked");
        }

        public RelayCommand TestRelayCommand { get; }

    }
}
