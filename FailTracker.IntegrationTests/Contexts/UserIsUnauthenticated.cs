using FailTracker.Web.Controllers;
using SpecsFor;
using SpecsFor.Mvc;

namespace FailTracker.IntegrationTests.Contexts
{
	public class UserIsUnauthenticated : IContext<MvcWebApp>
	{
		public void Initialize(ITestState<MvcWebApp> state)
		{
			state.SUT.NavigateTo<AuthenticationController>(c => c.LogOff());
		}
	}
}