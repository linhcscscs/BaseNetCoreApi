using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services.Interface
{
    public interface IAuthenticateService
    {
        ReturnCode ChonXa(ChonXaLamViecRequest model, out AuthResponse authResponse);
        ReturnCode Login(LoginRequest model, out AuthResponse authResponse);
        ReturnCode RefreshAccessToken(RefreshAccessTokenRequest model, out AuthResponse authResponse);
        void Logout(LogoutRequest model);
        void ClearRefreshToken();
    }
}
