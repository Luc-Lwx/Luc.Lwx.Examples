using Luc.Lwx.Example.Api.Web.AuthPolicies;
using Luc.Lwx.Example.Api.Web.Model;
using Luc.Lwx.Interface;
using Luc.Lwx.LwxActivityLog;
using Microsoft.AspNetCore.Mvc;

namespace Luc.Lwx.Example.Api.Web.Endpoints.ExampleSimpleProccess;

public static partial class EndpointStep2
{ 
    [LwxEndpoint(
      Path = "POST /apimanager-prefix/example-simple-proccess/step2",
      AuthPolicy = typeof(AuthPolicyPublic),
      SwaggerFuncName = "Example Step 2",
      SwaggerFuncSummary = "Executes the second step of the example process",
      SwaggerFuncDescription = "This endpoint handles the execution of the second step in the example process.",
      SwaggerGroupTitle = "Example Proccess (Recomended)"
    )]
    [LwxActivityLog(
      Imporance = LwxActivityImportance.High,
      Step = LwxActionStep.Finish,
      ShortDescription = "Executes step 2 of the example process"
    )]
    public async static Task<ExampleSimpleProccessStep2ResponseDto> Execute
    ( 
      HttpContext ctx,
      [FromQuery(Name="proc_id")] decimal proc_id,
      [FromBody] ExampleSimpleProccessStep2RequestDto request
    ) 
    {
      // Process the request here
      return new ExampleSimpleProccessStep2ResponseDto { Ok = true };
    }

 
}
