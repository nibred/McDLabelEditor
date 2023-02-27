using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.ViewModels;

internal class MainViewModel : ViewModelBase
{
    private string _title = "title";
    public string Title { get => _title; set => Set(ref _title, value); }
}
