﻿using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WeatherForecast.Domain.Entities;

namespace WeatherForecast.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<WeatherForecastEntity> WeatherForecasts { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}