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
    private ObservableCollection<Item> _testItems;
    public ObservableCollection<Item> TestItems => _testItems;
    private ObservableCollection<Category> _testCategory;
    public ObservableCollection<Category> TestCategory => _testCategory;
    public MainEditorViewModel(XmlService xmlService)
    {
        _xmlService = xmlService;
    }
    public MainEditorViewModel() : base() // design time constructor
    {
        _testItems = new ObservableCollection<Item>();
        for (int i = 0; i < 50; i++)
        {
            TestItems.Add(new Item
            {
                Name = $"Item {i + 1}",
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
        _testCategory = new ObservableCollection<Category>();
        for (int i = 0; i < 5; i++)
        {
            TestCategory.Add(new Category
            {
                Color = "#c5be97",
                Name = $"Category {i + 1}",
                Printer = "",
                PrintTemplate = ""
            });
        }
    }
}
