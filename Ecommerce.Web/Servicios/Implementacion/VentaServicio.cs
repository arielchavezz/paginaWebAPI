﻿using Ecommerce.DTO;
using Ecommerce.Web.Servicios.Contrato;
using System.Net.Http.Json;
using System.Reflection;

namespace Ecommerce.Web.Servicios.Implementacion
{
    public class VentaServicio : IVentaServicio
    {
        private readonly HttpClient _httpClient;
        public VentaServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<VentaDTO>> Registrar(VentaDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Venta/Registrar", modelo);
            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<VentaDTO>>();
            return result!;
        }
    }
}
