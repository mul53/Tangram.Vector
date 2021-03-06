﻿using Core.API.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.API.Onion
{
    public interface ITorClient
    {
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);

        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content,
            CancellationToken cancellationToken);

        Task<HttpResponseMessage> PostAsync(
            Uri requestUri,
            HttpContent content,
            CancellationToken cancellationToken);

        Task<byte[]> GetByteArrayAsync(string requestUri);
        Task<string> GetStringAsync(string requestUri);

        Task<byte[]> GetByteArrayAsync(Uri requestUri);
        Task<string> GetStringAsync(Uri requestUri);

        Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T content);
        Task<HttpResponseMessage> PostAsJsonAsync<T>(Uri requestUri, T content);

        Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T content,
            CancellationToken cancellationToken);

        Task<HttpResponseMessage> PostAsJsonAsync<T>(
            Uri requestUri,
            T content,
            CancellationToken cancellationToken);


        Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);
        Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
    }
}
