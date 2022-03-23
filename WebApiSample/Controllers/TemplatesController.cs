using Microsoft.AspNetCore.Mvc;
using Trinsic;
using Trinsic.Services.VerifiableCredentials.Templates.V1;

namespace WebApiSample.Controllers;

[Controller]
public class TemplatesController : ControllerBase
{
    private readonly TemplateService _templateService;

    public TemplatesController(TemplateService templateService) {
        _templateService = templateService;
    }

    [HttpGet("templates/list")]
    public async Task<IEnumerable<TemplateData>> List() {
        var response = await _templateService.ListAsync(new());

        return response.Templates;
    }
}
