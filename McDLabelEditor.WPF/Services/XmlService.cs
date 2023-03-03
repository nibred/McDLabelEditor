using McDLabelEditor.WPF.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace McDLabelEditor.WPF.Services;

internal class XmlService
{
    private FileDialogService _fileDialogService;
    private List<XmlDocument> _validXmlDocuments;
    public List<XmlDocument> ValidXmlDocuments => _validXmlDocuments;

    public XmlService(FileDialogService fileDialogService)
    {
        _fileDialogService = fileDialogService;
        _validXmlDocuments = new();
    }
    public bool OpenXmlFiles()
    {
        if (_fileDialogService.OpenFiles(out IEnumerable<string> selectedXmlFiles))
        {
            return IsValidFiles(selectedXmlFiles);
        }
        return false;
    }
    private bool IsValidFiles(IEnumerable<string> xmlFiles)
    {
        foreach (var xml in xmlFiles)
        {
            var document = new XmlDocument();
            document.Load(xml);
            bool checkRootElement = document.DocumentElement?.Name == "LabelDataFile";
            bool checkCategories = document.SelectNodes("LabelDataFile/Categories").Count > 0;
            bool checkLabels = document.SelectNodes("LabelDataFile/Labels").Count > 0;
            if (checkRootElement && checkCategories && checkLabels)
            {
                _validXmlDocuments.Add(document);
            }
        }
        return !_validXmlDocuments.IsEmpty();
    }
}
