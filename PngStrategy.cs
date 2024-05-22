using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

internal class PngStrategy : IArquivoStrategy
{
    public PngStrategy()
    {

    }
    public void BaixarArquivo()
    {
        Console.WriteLine("Baixando arquivo em formato PNG");
    }
}
