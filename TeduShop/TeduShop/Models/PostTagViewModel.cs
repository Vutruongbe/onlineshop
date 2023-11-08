using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { set; get; }
        public string TagID { set; get; }
        public virtual PostViewModel Post { set; get; }
        public virtual TagViewModel Tag { set; get; }
    }
}