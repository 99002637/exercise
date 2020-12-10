using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;


namespace Calculator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int number1;

        public int Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                OnPropertyChanged("Number1");
            }
        }
        private int number2;

        public int Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                OnPropertyChanged("Number2");
            }
        }
        private int result;

        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }


        private CalculatorCommand add;

        public CalculatorCommand Add 
        {
            get { return add; }
        }

        private CalculatorCommand sub;

        public CalculatorCommand Sub
        {
            get { return sub; }
        }


        public MainWindowViewModel()
        {
            add = new CalculatorCommand(SimpleAdd);
            sub = new CalculatorCommand(SimpleSub);
        }

        MainWindowModel Model = new MainWindowModel();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SimpleAdd()
        {
           this.Result = Model.Addition(Number1, Number2);
        }
        public void SimpleSub()
        {
            this.Result = Model.Subtraction(Number1, Number2);
        }
    }
}
