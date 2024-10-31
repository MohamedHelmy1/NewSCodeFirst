using Castle.Components.DictionaryAdapter.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSCodeFirst.DAI.Model
{
    public class Cataloge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property for related News
        public virtual ICollection<News> News { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Description}";
        }
    }

}
