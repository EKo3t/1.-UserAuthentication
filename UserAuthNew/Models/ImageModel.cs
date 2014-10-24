using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserAuthNew.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int UserId { get; set; }
        public string PhotoUrl { get; set; }
    }

    public class ImageEntities : DbContext
    {
        public ImageEntities() 
            : base("name=DefaultConnection") 
        { 
        } 
        public DbSet<Image> Images { get; set; }         
    }

}