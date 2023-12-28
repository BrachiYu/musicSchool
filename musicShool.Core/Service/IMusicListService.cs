using musicSchool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Service
{
    public interface IMusicListService
    {
        List<MusicList> GetAllMusicList();
        MusicList GetMusicListById(int id);
        MusicList PostMusicList(MusicList musicList);
        MusicList PutMusicList(int id, MusicList musicList);
        MusicList DeleteMusicList(int id);
    }
}
