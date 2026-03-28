using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
      protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] imageUrls = new string[]
            {
                "https://picsum.photos/id/1011/800/400",
                "https://picsum.photos/id/1021/800/400",
                "https://picsum.photos/id/1031/800/400",
                "https://picsum.photos/id/1041/800/400"
            };

            StringBuilder sb = new StringBuilder();
            sb.Append(@"
<div id='carouselExampleIndicators' class='carousel slide' data-bs-ride='carousel'>
  <div class='carousel-indicators'>");

            for (int i = 0; i < imageUrls.Length; i++)
            {
                sb.AppendFormat("<button type='button' data-bs-target='#carouselExampleIndicators' data-bs-slide-to='{0}' {1} aria-label='Slide {0}'></button>",
                    i, i == 0 ? "class='active' aria-current='true'" : "");
            }

            sb.Append(@"
  </div>
  <div class='carousel-inner'>");

            for (int i = 0; i < imageUrls.Length; i++)
            {
                sb.AppendFormat(@"<div class='carousel-item {0}'>
                        <img src='{1}' class='d-block w-100' alt='Slide {2}' />
                      </div>",
                    i == 0 ? "active" : "", imageUrls[i], i + 1);
            }

            sb.Append(@"
  </div>
  <button class='carousel-control-prev' type='button' data-bs-target='#carouselExampleIndicators' data-bs-slide='prev'>
    <span class='carousel-control-prev-icon' aria-hidden='true'></span>
    <span class='visually-hidden'>Previous</span>
  </button>
  <button class='carousel-control-next' type='button' data-bs-target='#carouselExampleIndicators' data-bs-slide='next'>
    <span class='carousel-control-next-icon' aria-hidden='true'></span>
    <span class='visually-hidden'>Next</span>
  </button>
</div>");

            litSlider.Text = sb.ToString();
        }
    }

}