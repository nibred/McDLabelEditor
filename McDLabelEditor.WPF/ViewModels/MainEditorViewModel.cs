using McDLabelEditor.WPF.Services;
using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.ViewModels;

internal class MainEditorViewModel : ViewModelBase
{
    private readonly XmlService _xmlService;
    public string Test => _xmlService.ValidXmlDocuments.Count.ToString();

    public MainEditorViewModel(XmlService xmlService)
    {
        _xmlService = xmlService;
    }
}
