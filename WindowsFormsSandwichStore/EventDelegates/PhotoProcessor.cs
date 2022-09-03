using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();

        }
    }
}
