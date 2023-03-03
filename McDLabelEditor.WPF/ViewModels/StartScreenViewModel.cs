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
    private IEnumerable<string>? _selectedFiles;

    public ICommand OpenMainEditorCommand { get; }
    public ICommand SelectFilesCommand { get; }
    public StartScreenViewModel(ViewNavigationService viewNavigationService, FileDialogService fileDialogService, MainEditorViewModel mainEditorViewModel)
    {
        _viewNavigationService = viewNavigationService;
        OpenMainEditorCommand = new RelayCommand(o => _viewNavigationService.CurrentVM = mainEditorViewModel);
        SelectFilesCommand = new RelayCommand(o =>
        {
            if (fileDialogService.OpenFiles(out _selectedFiles))
            {
                viewNavigationService.CurrentVM = mainEditorViewModel;
            }
        });
    }
}
