using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using musicShool.Core.Service;
using System.Net;

namespace musicShool.Service
{
    public class MusicListService:IMusicListService
    {
        private readonly IMusicListRepository _musicListRepository;
        public MusicListService(IMusicListRepository musicListRepository)
        {
            _musicListRepository = musicListRepository;
        }
        public List<MusicList> GetAllMusicList() {
            return _musicListRepository.GetMusicList();
        }
        public MusicList GetMusicListById(int id) {
            return _musicListRepository.GetMusicListById(id);
        }
        public MusicList PostMusicList(MusicList musicList) {
            
            return _musicListRepository.PostMusicList(musicList);
        }
        public MusicList PutMusicList(int id , MusicList musicList)
        {
            return _musicListRepository.PutMusicList(id, musicList);
        }
        public MusicList DeleteMusicList(int id)
        {
            return _musicListRepository.DeleteMusicList(id);
        }
        

    }
}