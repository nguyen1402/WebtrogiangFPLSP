using FPLSP.Repositories.Interfaces.FPLExam;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace FPLSP.Data.FPLExam
{
    public class CircuitHandlerService : CircuitHandler
    {

        private readonly IUserInRoomRepo _inRoomRepo;
        private readonly NavigationManager _navMagager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        public CircuitHandlerService(IUserInRoomRepo inRoomRepo, NavigationManager navMagager, AuthenticationStateProvider authenticationStateProvider)
        {

            _inRoomRepo = inRoomRepo;
            _navMagager = navMagager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {

            var state = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = state.User;
            if (_navMagager.Uri.ToString().Contains("onlineroomhandler"))
            {
                if (user.Identity.IsAuthenticated)
                {
                    var claims = state.User.Claims.ToList()[11].Value;
                    var Email = state.User.Claims.ToList()[4].Value;
                    var Images = state.User.Claims.ToList()[6].Value;
                    var StudentCode = state.User.Claims.ToList()[3].Value.Replace(" ", "");
                    await _inRoomRepo.Connect(circuit.Id, Email, Images, StudentCode, claims);
                }
            }


        }



        public async override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
        {

            var state = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = state.User;
            if (_navMagager.Uri.ToString().Contains("onlineroomhandler"))
            {
                if (user.Identity.IsAuthenticated)
                {
                    var claims = state.User.Claims.ToList()[11].Value;
                    var Email = state.User.Claims.ToList()[4].Value;
                    await _inRoomRepo.DisConnect(circuit.Id, Email, claims);
                }
            }
        }




    }
}
