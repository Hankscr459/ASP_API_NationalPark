using API.Models.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class NationalParksController : Controller {
        private INationalParkRepository _npRepo;
        private readonly IMapper _mapper;
        public NationalParksController (INationalParkRepository npRepo, IMapper mapper) {
            _npRepo = npRepo;
            _mapper = mapper;
        }
    }
}