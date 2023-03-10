using McDLabelEditor.WPF.Services;
using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.ViewModels;

internal class MainViewModel : ViewModelBase
{
    private readonly ViewNavigationService _viewNavigationService;
    public ViewModelBase CurrentVM => _viewNavigationService.CurrentVM;
    public MainViewModel(ViewNavigationService viewNavigationService, StartScreenViewModel startScreenViewModel)
    {
        _viewNavigationService = viewNavigationService;
        _viewNavigationService.CurrentVM = startScreenViewModel;
        _viewNavigationService.CurrentViewModelChanged += _viewNavigationService_CurrentViewModelChanged;
    }
    private void _viewNavigationService_CurrentViewModelChanged() => OnPropertyChanged(nameof(CurrentVM));
    protected override void Dispose()
    {
        _viewNavigationService.CurrentViewModelChanged -= _viewNavigationService_CurrentViewModelChanged;
        base.Dispose();
    }
}
