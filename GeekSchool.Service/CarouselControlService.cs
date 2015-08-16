using GeekSchool.Entity;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Media.Imaging;

namespace GeekSchool.Service
{
    public class CarouselControlService
    {
        public IList<CarouselControlEntity> GetImagesForCarouselControl()
        {
            var imagesSources = new List<CarouselControlEntity>()
            {
                new CarouselControlEntity() {ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/Carousel/1.jpg")) },
                new CarouselControlEntity() {ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/Carousel/2.jpg")) },
                new CarouselControlEntity() {ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/Carousel/3.jpg")) },
                new CarouselControlEntity() {ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Images/Carousel/4.jpg")) }
            };

            return imagesSources;
        }
    }
}
