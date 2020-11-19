using System.Collections.Generic;

namespace Core.Domian
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //public string CategoryNameURL { get; set; }

        public int? parentId { get; set; }
         public Category Parent { get; set; }
         public List<Category> Childeren { get; set; }

    }
}
