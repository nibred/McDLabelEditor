using Microsoft.Win32;
using System.Collections.Generic;

namespace McDLabelEditor.WPF.Services;

internal class FileDialogService
{
    public bool OpenFiles(out IEnumerable<string>? selectedFiles)
    {
        OpenFileDialog openDialog = new()
        {
            Title = "Select files",
            AddExtension = true,
            Multiselect = true,
            Filter = "XML Files (*.xml)|*.xml"
        };
        if (openDialog.ShowDialog() == true)
        {
            selectedFiles = openDialog.FileNames;
            return true;
        }
        selectedFiles = null;
        return false;
    }
}
