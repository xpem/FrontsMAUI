using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBank.Views
{
    public class CardsTemplateSelector : DataTemplateSelector
    {
      //  public DataTemplate? Rewards { get; set; }
        public DataTemplate Main { get; set; }
        public DataTemplate Card { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item switch
            {
                "1" => Main,
                "2" => Card,
                _ => Main,
            } ?? throw new NullReferenceException();
        }
    }
}
