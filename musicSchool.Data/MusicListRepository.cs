using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicSchool.Data
{
    public class MusicListRepository:IMusicListRepository
    {
        private readonly DataContext _context;
        public MusicListRepository(DataContext context)
        {
            _context = context;
        }

        public List<MusicList> GetMusicList()
        {
            return _context.MusList.ToList();
        }

        public MusicList GetMusicListById(int id)
        {
            return _context.MusList.Find(id);
        }

        public MusicList PostMusicList(MusicList musicList)
        {
            _context.MusList.Add(musicList);
            _context.SaveChanges();
            return musicList;
        }
        public MusicList PutMusicList(int id , MusicList musicList)
        {
            var i=_context.MusList.Find(id);
            i.TeacherId= musicList.TeacherId;
            i.StudentId= musicList.StudentId;
            i.NumLessons= musicList.NumLessons;
            i.Level=musicList.Level;
            _context.SaveChanges();
            return i;
        }
        public MusicList DeleteMusicList(int id)
        {
            var i = _context.MusList.Find(id);
            if(i != null)
                _context.MusList.Remove(i);
            _context.SaveChanges();
            return i;
        }
        
    }
}
