using Luc.Lwx.Interface;
using Microsoft.AspNetCore.Authorization;

namespace Luc.Lwx.Example.Api.LwxAuthPolicies;

public static partial class AuthPolicyPublic
{
  [LwxAuthPolicy]
  public static void Configure( AuthorizationPolicyBuilder policy ) 
  { 
    policy.RequireAssertion( context => true );
  }
}
