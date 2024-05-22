using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

internal class DownloadContext 
{
    private IArquivoStrategy _arquivoStrategy; 

    public DownloadContext(IArquivoStrategy arquivoStrategy)
    {
        _arquivoStrategy = arquivoStrategy; 
    }

    public void SetStrategy()
    {
        _arquivoStrategy.BaixarArquivo(); 
    }
}
