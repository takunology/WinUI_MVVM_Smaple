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

        public int InputA
        {
            get => _inputA;
            set
            {
                _inputA = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Output));
            }
        }

        public int InputB
        {
            get => _inputB;
            set
            {
                _inputB = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Output));
            }
        }

        public int Output => _output = Models.Calc.Sum(_inputA, _inputB);

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}