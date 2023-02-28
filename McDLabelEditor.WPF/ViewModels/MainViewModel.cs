﻿using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.ViewModels;

internal class MainViewModel : ViewModelBase
{
    private ViewModelBase _currentVM = new StartScreenViewModel();
    public ViewModelBase CurrentVM { get => _currentVM; set => Set(ref _currentVM, value); }
}
