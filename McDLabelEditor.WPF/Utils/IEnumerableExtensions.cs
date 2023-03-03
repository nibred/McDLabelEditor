using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.Utils;

public static class IEnumerableExtensions
{
    public static bool IsEmpty<T>(this IEnumerable<T> sequence)
    {
        return !sequence!.Any();
    }
}
