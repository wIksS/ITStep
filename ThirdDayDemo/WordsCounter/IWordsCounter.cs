using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCounter
{
    public interface IWordsCounter
    {
        Dictionary<string, int> Count(string text);
    }
}
