using Luc.Lwx.Example.Api.Web.AuthPolicies;
using Luc.Lwx.Example.Api.Web.Model;
using Luc.Lwx.Interface;
using Luc.Lwx.LwxActivityLog;
using Microsoft.AspNetCore.Mvc;

namespace Luc.Lwx.Example.Api.Web.Endpoints.ExampleParamInPath.ParamId;

public static partial class EndpointStep1
{ 
    [LwxEndpoint(
      Path = "PUT /apimanager-prefix/example-param-in-path/{id}/step1",
      AuthPolicy = typeof(AuthPolicyPublic),
      SwaggerFuncName = "Execute Step 1 of Example Process",
      SwaggerFuncSummary = "Executes the first step of the example process",
      SwaggerFuncDescription = "This endpoint executes the first step of the example process using the provided parameters.",
      SwaggerGroupTitle = "Example Process (Old Way - Not Recommended)",
      LowMaintanability_ParameterInPath_Justification="This is an example. Although not recommended, someone may need this to implement old style endpoints."
    )]
    [LwxActivityLog(
      Imporance = LwxActivityImportance.High,
      Step = LwxActionStep.Finish,
      ShortDescription = "Step 1 of the example process"
    )]
    public async static Task<ExampelParamInPathStep1ResponseDto> Execute
    ( 
      HttpContext ctx,
      [FromRoute(Name="id")] int id,
      [FromBody] ExampelParamInPathStep1RequestDto request
    ) 
    {
      // Process the request here
      return new ExampelParamInPathStep1ResponseDto { Ok = true };
    }

   
}
