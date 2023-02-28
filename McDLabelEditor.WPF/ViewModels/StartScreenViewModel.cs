using McDLabelEditor.WPF.Commands;
using McDLabelEditor.WPF.Services;
using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace McDLabelEditor.WPF.ViewModels;

internal class StartScreenViewModel : ViewModelBase
{
    private readonly ViewNavigationService _viewNavigationService;
    public ICommand OpenMainEditorCommand { get; }
    public StartScreenViewModel(ViewNavigationService viewNavigationService, MainEditorViewModel mainEditorViewModel)
    {
        _viewNavigationService = viewNavigationService;
        OpenMainEditorCommand = new RelayCommand(o => _viewNavigationService.CurrentVM = mainEditorViewModel);
    }
}
