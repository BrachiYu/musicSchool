using Microsoft.AspNetCore.Mvc;
using musicSchool.Core.Entities;
using musicSchool.Data;
using musicShool.Core.Service;
using musicShool.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicListController : ControllerBase
    {
        private readonly IMusicListService _musicListService;
        public MusicListController(IMusicListService musicListService)
        {
            _musicListService = musicListService;
        }

        // GET: api/<MusicListController>
        [HttpGet]
        public ActionResult Get()
        { 
            return Ok(_musicListService.GetAllMusicList());
        }

        // GET api/<MusicListController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var i = _musicListService.GetMusicListById(id);
            if (i is not null) 
                return Ok(i);
            return NotFound();
        }

        // POST api/<MusicListController>
        [HttpPost]
        public ActionResult Post([FromBody] MusicList musicList)
        {
            var i = _musicListService.PostMusicList(musicList);
            if(i is not null)
              return Ok(musicList);
            return NotFound();
        }

        // PUT api/<MusicListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MusicList musicList)
        {
            var i = _musicListService.PutMusicList(id, musicList);
            if(i is not null) 
                return Ok(i);
            return NotFound();
        }


        // DELETE api/<MusicListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var i = _musicListService.DeleteMusicList(id);
            if( i is null)
            {
                return NotFound(i);
            }
            return NoContent();
        }
    }
}
