using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.Services;

internal class ViewNavigationService
{
    private ViewModelBase? _currentVM;
    public ViewModelBase CurrentVM
    {
        get => _currentVM;
        set
        {
            _currentVM = value;
            CurrentViewModelChanged?.Invoke();
        }
    }
    public event Action CurrentViewModelChanged;
    public void Close() => CurrentVM = null;
}
