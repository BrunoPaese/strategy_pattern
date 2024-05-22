using StrategyPattern;

DownloadContext download = new (new JpegStrategy());
download.SetStrategy();