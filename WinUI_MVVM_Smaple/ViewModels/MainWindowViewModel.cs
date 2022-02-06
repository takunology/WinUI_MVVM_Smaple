using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_MVVM_Smaple.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {       
        private int _inputA;
        private int _inputB;
        private int _output;

        public string InputA
        {
            get => _inputA.ToString();
            set
            {
                _inputA = int.Parse(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(Output));
            }
        }

        public string InputB
        {
            get => _inputB.ToString();
            set
            {
                _inputB = int.Parse(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(Output));
            }
        }

        public string Output
        {
            get
            {
                _output = Models.Calc.Sum(_inputA, _inputB);
                return _output.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
