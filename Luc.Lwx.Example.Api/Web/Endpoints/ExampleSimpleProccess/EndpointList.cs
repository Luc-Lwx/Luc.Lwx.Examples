using Luc.Lwx.Example.Api.Web.AuthPolicies;
using Luc.Lwx.Example.Api.Web.Model;
using Luc.Lwx.Interface;
using Luc.Lwx.LwxActivityLog;
using Microsoft.AspNetCore.Mvc;

namespace Luc.Lwx.Example.Api.Web.Endpoints.ExampleSimpleProccess;

public static partial class EndpointList
{ 
    [LwxEndpoint(
      Path = "GET /apimanager-prefix/example-simple-proccess/list",
      AuthPolicy = typeof(AuthPolicyPublic),
      SwaggerFuncName = "List Example Processes",
      SwaggerFuncSummary = "Lists all example processes",
      SwaggerFuncDescription = "This endpoint retrieves a list of all example processes based on the provided filters.",
      SwaggerGroupTitle = "Example Proccess (Recomended)"
    )]
    [LwxActivityLog(
      Imporance = LwxActivityImportance.High,
      Step = LwxActionStep.Finish,
      ShortDescription = "Lists all example processes"
    )]
    public async static Task<ExampleSimpleProccessEndpointListResponseDto> Execute
    ( 
      HttpContext ctx,
      [FromQuery(Name="filter1")] string? filter1,
      [FromQuery(Name="filter2")] string? filter2
    ) 
    {
      // Retrieve the list of processes here
      return new ExampleSimpleProccessEndpointListResponseDto 
      { 
          Ok = true,
          ProcList =
          [
              new ExampleSimpleProccessEndpointListProccessResponseDto { Id = 123, Status = "active", CreatedAt = "2023-10-01T12:00:00Z" },
              new ExampleSimpleProccessEndpointListProccessResponseDto { Id = 124, Status = "completed", CreatedAt = "2023-09-30T12:00:00Z" }
          ]
      };
    } 

}

