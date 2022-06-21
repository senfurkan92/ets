using BLL.Data.Service;
using BLL.Model.Query;
using DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly IServiceCategory _managerCategory;

        public CategoriesController(IServiceCategory managerCategory)
        {
            _managerCategory = managerCategory;
        }

        [HttpGet]
        [Route("/Categories")]
        public async Task<IActionResult> ReadAll()
        {
            var query = await _managerCategory.ReadAll();
            return Ok(GetProperResponse(query));
        }

        [HttpGet]
        [Route("/Categories/{id}")]
        public async Task<IActionResult> ReadAll(int id)
        {
            var query = await _managerCategory.Read(x=> x.Id == id);
            return Ok(GetProperResponse(query));
        }

        [HttpPost]
        [Route("/Categories/Filter")]
        public async Task<IActionResult> Filter([FromBody] QueryModel filter)
        {
            var query = await _managerCategory.ReadAll(filter);
            return Ok(GetProperResponse(query));
        }

        [HttpPost]
        [Route("/Categories")]
        public async Task<IActionResult> Insert([FromBody] Category entity)
        {
            var query = await _managerCategory.Insert(entity);
            return Ok(GetProperResponse(query));
        }

        [HttpPatch]
        [Route("/Categories")]
        public async Task<IActionResult> Update([FromBody] Category entity)
        {
            var query = await _managerCategory.Update(entity);
            return Ok(GetProperResponse(query));
        }

        [HttpDelete]
        [Route("/Categories/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = await _managerCategory.Delete(id);
            return Ok(GetProperResponse(query));
        }
    }
}
