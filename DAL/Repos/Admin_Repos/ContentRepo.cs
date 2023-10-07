using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class ContentRepo : Repo, ICrud<Content, int, bool>
    {
        public bool Create(Content content)
        {
            db.Contents.Add(content);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exContent = db.Contents.Find(id);
            db.Contents.Remove(exContent);
            return db.SaveChanges() > 0;
        }

        public List<Content> Get()
        {
            return db.Contents.ToList();
        }

        public Content Get(int id)
        {
            return db.Contents.Find(id);
        }

        public bool Update(Content content)
        {
            var exContent = db.Contents.Find(content.Id);
            exContent.Title = content.Title;
            exContent.Body = content.Body;
            exContent.Author = content.Author;
            exContent.CreateionDate = content.CreateionDate;

            return db.SaveChanges() > 0;
        }
    }
}
