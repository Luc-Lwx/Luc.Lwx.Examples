using Luc.Lwx.Example.Api.Web.AuthPolicies;
using Luc.Lwx.Example.Api.Web.Model;
using Luc.Lwx.Interface;
using Luc.Lwx.LwxActivityLog;
using Microsoft.AspNetCore.Mvc;

namespace Luc.Lwx.Example.Api.Web.Endpoints.ExampleParamInPath.ParamId;

public static partial class EndpointStep2
{ 
    [LwxEndpoint(
      Path = "PUT /apimanager-prefix/example-param-in-path/{id}/step2",
      AuthPolicy = typeof(AuthPolicyPublic),
      SwaggerFuncName = "Execute Step 2 of Example Process",
      SwaggerFuncSummary = "Executes the second step of the example process",
      SwaggerFuncDescription = "This endpoint executes the second step of the example process using the provided parameters.",
      SwaggerGroupTitle = "Example Process (Old Way - Not Recommended)",
      LowMaintanability_ParameterInPath_Justification="This is an example. Although not recommended, someone may need this to implement old style endpoints."
    )]
    [LwxActivityLog(
      Imporance = LwxActivityImportance.High,
      Step = LwxActionStep.Finish,
      ShortDescription = "Step 2 of the example process"
    )]
    public async static Task<ExampelParamInPathStep2ResponseDto> Execute
    ( 
      HttpContext ctx,
      [FromRoute(Name="id")] int id,
      [FromBody] ExampelParamInPathStep2RequestDto request
    ) 
    {
      // Process the request here
      return new ExampelParamInPathStep2ResponseDto { Ok = true };
    }

    
}
