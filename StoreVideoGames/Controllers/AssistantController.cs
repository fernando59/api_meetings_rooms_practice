using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.Manager.AssistantM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistantController : ControllerBase
    {
        private readonly IAssistantManager _assistantManager;

        public AssistantController(IAssistantManager assistantManager)
        {
            _assistantManager = assistantManager;
        }


    }
}
