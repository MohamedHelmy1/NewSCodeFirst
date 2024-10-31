using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSCodeFirst.DAI.Model
{
    public class News
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime datetime { get; set; }
        [ForeignKey("Cataloge")]
        public int cat_id { get; set; }
        public virtual Cataloge Cataloge { get; set; }

        [ForeignKey("Author")]

        public int auth_id { get; set; }
        public virtual Author Author { get; set; }

    }
}
