using McDLabelEditor.WPF.Models;
using McDLabelEditor.WPF.Services;
using McDLabelEditor.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.ViewModels;

internal class MainEditorViewModel : ViewModelBase
{
    private readonly XmlService _xmlService;
    private ObservableCollection<Item> _testOC;
    public ObservableCollection<Item> TestOC => _testOC;
    public MainEditorViewModel(XmlService xmlService)
    {
        _xmlService = xmlService;
        _testOC = new ObservableCollection<Item>();
        for (int i = 0; i < 50; i++)
        {
            TestOC.Add(new Item
            {
                Name = $"Item {i}",
                Category = "chleb",
                Exp1Days = "0",
                Exp1Hours = "4",
                Exp1Message = "gotowe",
                Exp1Minutes = "0",
                Exp2Message = "koniec",
                Exp2Days = "2",
                Line1st = $"Item {i}",
                Line2nd = "Line2nd",
                Format = ""
            });
        }
    }
}
