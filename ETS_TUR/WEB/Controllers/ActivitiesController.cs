using BLL.Data.Service;
using BLL.Model.Query;
using DOMAIN.Entities;
using DTOS.ActivityDtos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using CORE.Model;

namespace WEB.Controllers
{
    [EnableCors("FullAllow")]
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
            var query = await _managerActivity.ReadAll(null, true, null, 0, -1, "Tickets", "Images", "Category");
            var host = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;
            var queryTransformed = new ReturnModel<List<Activity>>
            {
                Exception = query.Exception,
                Result = query.Success ? query.Result.ToList() : null,
                Success = query.Success,
            };
            if (query.Success)
            {
                foreach (var item in queryTransformed.Result)
                {
                    item.PosterPath = item.PosterPath is not null ? host + item.PosterPath : item.PosterPath;
                    if (item.Images.Count() > 0) { 
                        item.Images = item.Images.ToList();
                        foreach (var image in item.Images)
                        { 
                            image.Path = host + image.Path;
                        }
                    }
                }
            }
            return Ok(GetProperResponse(queryTransformed));
        }

        [HttpGet]
        [Route("/Activities/{id}")]
        public async Task<IActionResult> Read(int id)
        {
            var query = await _managerActivity.Read(x => x.Id == id, "Tickets", "Images", "Category");
            var host = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;
            var queryTransformed = new ReturnModel<Activity>
            {
                Exception = query.Exception,
                Result = query.Success ? query.Result : null,
                Success = query.Success,
            };
            if (query.Success)
            {
                var item = queryTransformed.Result;
                item.PosterPath = item.PosterPath is not null ? host + item.PosterPath : item.PosterPath;
                if (item.Images.Count() > 0)
                {
                    item.Images = item.Images.ToList();
                    foreach (var image in item.Images)
                    {
                        image.Path = host + image.Path;
                    }
                }
            }
            return Ok(GetProperResponse(query));
        }

        [HttpPost]
        [Route("/Activities/Filter")]
        public async Task<IActionResult> Filter([FromBody] ActivityQueryModel filter)
        {
            var query = await _managerActivity.ReadAll(x => 
                (
                    x.Title.ToLower().Contains(filter.Contain.Trim().ToLower()) ||
                    x.Address.ToLower().Contains(filter.Contain.Trim().ToLower()) || 
                    x.City.ToLower().Contains(filter.Contain.Trim().ToLower())
                ) 
                &&
                (
                    filter.Active ? DateTime.Compare(x.StartDate, DateTime.Now) > 0 : DateTime.Compare(x.StartDate, DateTime.Now) <= 0
                )
                &&
                (
                    filter.categoryId.HasValue ? x.CategoryId == filter.categoryId : true
                )
                , false, "Id", 0, -1, "Category", "Images", "Tickets");
            var host = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;
            var queryTransformed = new ReturnModel<List<Activity>>
            {
                Exception = query.Exception,
                Result = query.Success ? query.Result.ToList() : null,
                Success = query.Success,
            };
            if (query.Success)
            {
                foreach (var item in queryTransformed.Result)
                {
                    item.PosterPath = item.PosterPath is not null ? host + item.PosterPath : item.PosterPath;
                    if (item.Images.Count() > 0)
                    {
                        item.Images = item.Images.ToList();
                        foreach (var image in item.Images)
                        {
                            image.Path = host + image.Path;
                        }
                    }
                }
            }
            return Ok(GetProperResponse(queryTransformed));
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

        [HttpGet]
        [Route("/Activities/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = await _managerActivity.Delete(id);
            return Ok(GetProperResponse(query));
        }
    }
}
