using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefFrame : ICefBase
    {
        long Identifier { get; }
    }
}
