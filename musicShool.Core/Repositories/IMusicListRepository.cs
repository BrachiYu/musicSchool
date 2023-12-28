using System;
using System.Collections.Generic;
using musicSchool.Core.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Repositories
{
    public interface IMusicListRepository
    {
        List<MusicList> GetMusicList();
        MusicList GetMusicListById(int id);
        MusicList PostMusicList(MusicList musicList);
        MusicList PutMusicList(int id , MusicList musicList);
        MusicList DeleteMusicList(int id);
    }
}
