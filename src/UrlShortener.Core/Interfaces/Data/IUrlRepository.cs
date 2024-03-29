﻿using UrlShortener.Core.Models.Entities;

namespace UrlShortener.Core.Interfaces.Data
{
    public interface IUrlRepository
    {
        Task<UrlEntity?> FindByTokenAsync(string token);
        public Task<UrlEntity?> FindByOriginalUrlAsync(string originalUrl);
        public Task SaveAsync(UrlEntity token);
    }
}
