using BLL.Data.Service;
using BLL.Model.Query;
using CORE.Model;
using DAL.Data;
using DOMAIN.Entities;
using DTOS.ActivityDtos;

namespace BLL.Data.Manager
{
    public class ManagerCategory : ManagerGeneric<Category, IDalCategory>, IServiceCategory
    {
        public ManagerCategory(IDalCategory dal) : base(dal)
        {

        }

        public Task<ReturnModel<IQueryable<Category>>> ReadAll(QueryModel query)
        {
            return _dal.ReadAll(x => x.Name.Contains(query.Contain), query.Asc, query.OrderBy, query.Skip, query.Take, query.Tables);
        }

        public override async Task<ReturnModel<Category>> Update(Category entity)
        {
            var currentCategoryQuery = await _dal.Read(x => x.Id == entity.Id);
            var current = currentCategoryQuery.Result;
            current!.Name = entity.Name;
            return await base.Update(current);
        }
    }

    public class ManagerActivity : ManagerGeneric<Activity, IDalActivity>, IServiceActivity
    {
        public ManagerActivity(IDalActivity dal) : base (dal)
        {

        }

        public Task<ReturnModel<IQueryable<Activity>>> ReadAll(QueryModel query)
        {
            return _dal.ReadAll(x => x.Title.Contains(query.Contain), query.Asc, query.OrderBy, query.Skip, query.Take, query.Tables);
        }

        public async Task<ReturnModel<Activity>> Insert(ActivityInsertDto dto)
        {
            // find root path
            var projectRoot = Directory.GetCurrentDirectory();
            var posterUnique = Guid.NewGuid().ToString().Split("-")[1];

            string posterPath = null;

            // upload poster
            if (dto.PosterFile is not null)
            {
                var posterExt = dto.PosterFile.FileName.Split(".").ToList().LastOrDefault();
                var posterUploadPath = Path.Combine(projectRoot, "wwwroot", "assets", "images", "activities", "posters", $"{posterUnique}.{posterExt}");
                var fsPoster = new FileStream(posterUploadPath, FileMode.Create);
                await dto.PosterFile.CopyToAsync(fsPoster);
                fsPoster.Close();
                posterPath = $"/assets/images/activities/posters/{posterUnique}.{posterExt}";
            }

            // upload images
            var imagePaths = new List<string>();
            if (dto.ImageFiles is not null) { 
                foreach (var file in dto.ImageFiles)
                {
                    var imageUnique = Guid.NewGuid().ToString().Split("-")[1];
                    var imageExt = file.FileName.Split(".").ToList().LastOrDefault();
                    var fileUploadPath = Path.Combine(projectRoot, "wwwroot", "assets", "images", "activities", "sliders", $"{imageUnique}.{imageExt}");
                    var fsImage = new FileStream(fileUploadPath, FileMode.Create);
                    await file.CopyToAsync(fsImage);
                    fsImage.Close();
                    imagePaths.Add($"/assets/images/activities/sliders/{imageUnique}.{imageExt}");
                }
            }

            // generate images
            List<ActivityImage> images = default;
            foreach (var path in imagePaths)
            {
                if (images is null)
                {
                    images = new List<ActivityImage>();
                }
                images.Add(new ActivityImage() { 
                    Path = path,
                });
            }

            // generate entity
            Activity entity = new()
            {
                Address = dto.Address,
                CategoryId = dto.CategoryId,
                City = dto.City,
                Description = dto.Description,
                EndDate = dto.EndDate,
                Images = images,
                MapLocation = dto.MapLocation,
                PlaceTitle = dto.PlaceTitle,
                PosterPath = posterPath,
                StartDate = dto.StartDate,
                Tickets = dto.Tickets,
                Title = dto.Title
            };

            return await base.Insert(entity);
        }

        public override Task<ReturnModel<Activity>> Update(Activity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<Activity>> Update(ActivityUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }

    public class ManagerActivityImage : ManagerGeneric<ActivityImage, IDalActivityImage>, IServiceActivityImage
    {
        public ManagerActivityImage(IDalActivityImage dal) : base(dal)
        {

        }
    }

    public class ManagerTicket : ManagerGeneric<Ticket, IDalTicket>, IServiceTicket
    {
        public ManagerTicket(IDalTicket dal) : base(dal)
        {

        }
    }
}
