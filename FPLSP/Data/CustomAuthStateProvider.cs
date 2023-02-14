using Blazored.LocalStorage;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.IdentityModel.Tokens;
using Microsoft.JSInterop;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace FPLSP.Data
{
    public class CustomAuthStateProvider
    {
        public CustomAuthStateProvider()
        {
            ExternalUsers = new Dictionary<string, ClaimsPrincipal>();
        }
        public Dictionary<string,ClaimsPrincipal> ExternalUsers { get; set; }
    }
}

