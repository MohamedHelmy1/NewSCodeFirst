using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSCodeFirst.DAI.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Brief { get; set; }

        // Navigation property for related News
        public virtual ICollection<News> News { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Brief}";
        }
    }

}
