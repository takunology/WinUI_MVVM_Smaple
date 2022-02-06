using Reactive.Bindings;
using System.Reactive.Linq;

namespace WinUI_Reactive_Sample.ViewModels
{
    public class MainWindowViewModel
    {
        public ReactivePropertySlim<int> InputA = new ReactivePropertySlim<int>();
        public ReactivePropertySlim<int> InputB = new ReactivePropertySlim<int>();

        public ReadOnlyReactivePropertySlim<int> Output => InputA
            .CombineLatest(InputB, (x, y) => Models.Calc.Sum(x, y))
            .ToReadOnlyReactivePropertySlim();
    }
}
