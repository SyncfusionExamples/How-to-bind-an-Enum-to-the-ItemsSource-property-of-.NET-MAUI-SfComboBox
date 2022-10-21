using Syncfusion.Maui.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxBlank.ViewModel
{
    public class SocialMediaViewModel
    {
        public ObservableCollection<SocialMedia> SocialMedias { get; set; }
        public SocialMediaViewModel()
        {
            this.SocialMedias = new ObservableCollection<SocialMedia>();           
            this.SocialMedias = Enum.GetValues(typeof(SocialMedia)).Cast<SocialMedia>().ToObservableCollection();
        }

       public  enum SocialMedia
       {
            Facebook,
            GooglePlus,
            Instagram,
            LinkedIn,
            Skype,
            Meta
       }
    }

    
}
