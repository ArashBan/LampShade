using System.Collections.Generic;

namespace _01_LampShadeQuery.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}
