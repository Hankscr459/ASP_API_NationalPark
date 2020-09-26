using System.Collections.Generic;
using API.Models.Dtos;
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


        [HttpGet]
        public IActionResult GetNationalParks()
        {
            var objList = _npRepo.GetNationalParks();

            var objDto = new List<NationalParkDto>();

            foreach (var obj in objList) {
                objDto.Add(_mapper.Map<NationalParkDto>(obj));
            }
            
            return Ok(objDto);
        }

        [HttpGet("{nationalParkId:int}")]
        public IActionResult GetNationalPark(int nationalParkId)
        {
            var obj = _npRepo.GetNationalPark(nationalParkId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<NationalParkDto>(obj);
            return Ok(objDto);
        }
    }
}