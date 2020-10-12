using BackendProject.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models.ViewModel
{
    public class HomeViewModel

    {
        public Setting Setting { get; set; }

        public ICollection<HomeHeroSlider> HomeHeroSliders { get; set; }

        public ICollection<PromoBlock> PromoBlocks { get; set; }

        public AboutUsText AboutUsText { get; set; }

        public ICollection<Service> Services { get; set; }

        public ICollection<ServicesCard> ServicesCards { get; set; }

        public Promo Promo { get; set; }

        public ICollection<PromoButton> PromoButtons { get; set; }

        public OurPortfolio OurPortfolio { get; set; }

        public OurBlog OurBlog { get; set; }

        public ICollection<BlogCard> BlogCards { get; set; }

        public Testimonial Testimonial { get; set; }

        public ICollection<TestimonialCard> TestimonialCards { get; set; }

        public TeamTwoText TeamTwoText { get; set; }

        public ICollection<TeamTwoCard> TeamTwoCards { get; set; }

        public HomeCallToAction HomeCallToAction { get; set; }

     
    }
}
