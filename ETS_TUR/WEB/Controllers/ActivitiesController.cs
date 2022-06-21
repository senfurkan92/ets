using BLL.Data.Service;
using BLL.Model.Query;
using DOMAIN.Entities;
using DTOS.ActivityDtos;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class ActivitiesController : ApiController
    {
        private readonly IServiceActivity _managerActivity;

        public ActivitiesController(IServiceActivity managerActivity)
        {
            _managerActivity = managerActivity;
        }

        [HttpGet]
        [Route("/Activities")]
        public async Task<IActionResult> ReadAll()
        {
            var query = await _managerActivity.ReadAll();
            return Ok(GetProperResponse(query));
        }

        [HttpGet]
        [Route("/Activities/{id}")]
        public async Task<IActionResult> ReadAll(int id)
        {
            var query = await _managerActivity.Read(x => x.Id == id);
            return Ok(GetProperResponse(query));
        }

        [HttpPost]
        [Route("/Activities/Filter")]
        public async Task<IActionResult> Filter([FromBody] QueryModel filter)
        {
            var query = await _managerActivity.ReadAll(filter);
            return Ok(GetProperResponse(query));
        }

        [HttpPost]
        [Route("/Activities")]
        public async Task<IActionResult> Insert([FromForm] ActivityInsertDto dto)
        {
            var query = await _managerActivity.Insert(dto);
            return Ok(GetProperResponse(query));
        }

        [HttpPatch]
        [Route("/Activities")]
        public async Task<IActionResult> Update([FromForm] ActivityUpdateDto dto)
        {
            var query = await _managerActivity.Update(dto);
            return Ok(GetProperResponse(query));
        }

        [HttpDelete]
        [Route("/Activities/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = await _managerActivity.Delete(id);
            return Ok(GetProperResponse(query));
        }
    }
}
