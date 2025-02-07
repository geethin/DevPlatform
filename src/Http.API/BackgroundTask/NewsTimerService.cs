﻿using Share.NewsCollectionService;

namespace Http.API.BackgroundTask;
public class NewsTimerService : IHostedService, IDisposable
{
    private readonly ILogger<NewsTimerService> _logger;
    private Timer? _timer;

    public NewsTimerService(ILogger<NewsTimerService> logger, IServiceProvider services)
    {
        Services = services;
        _logger = logger;
    }

    public IServiceProvider Services { get; }

    public Task StartAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("News collection service start.");
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(4));
        return Task.CompletedTask;
    }

    private async void DoWork(object state)
    {
        using var scope = Services.CreateScope();

        //var twService = scope.ServiceProvider.GetRequiredService<TwitterService>();
        //await twService.StartAsync();

        var newsService = scope.ServiceProvider.GetRequiredService<NewsCollectionService>();
        await newsService.Start();
    }

    public Task StopAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Timed Hosted Service is stopping.");

        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public void Dispose() => _timer?.Dispose();
}
