using AutoMapper;
using DIRTBIKESBM.Dto;
using DIRTBIKESBM.Interfaces;
using DIRTBIKESBM.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace DIRTBIKESBM.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class MotorController : Controller
    {
        private readonly IMotorRepository _motorRepository;
        private readonly IMapper _mapper;

        public MotorController(IMotorRepository motorRepository, IMapper mapper)
        {
            _motorRepository = motorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Motor>))]
        public IActionResult GetMotors()
        {
            var motors = _mapper.Map<List<MotorDto>>(_motorRepository.GetMotors());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(motors);
        }

        [HttpGet("{motoId}")]
        [ProducesResponseType(200, Type = typeof(Motor))]
        [ProducesResponseType(400)]
        public IActionResult GetMotor(int motoId)
        {
            if (!_motorRepository.MotorExists(motoId))
                return NotFound();

            var motor = _mapper.Map<MotorDto>(_motorRepository.GetMotor(motoId)) ;

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(motor);
        }

        [HttpGet("{motoId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetMotorRating(int motoId)
        {
            if(!_motorRepository.MotorExists(motoId))
                return NotFound();

           var rating = _motorRepository.GetMotorRating(motoId);

            if (!ModelState.IsValid)
                return BadRequest();
                return Ok(rating);

        }
    }
}