using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImageResizeFunction.Services
{
    public interface IImageResizer
    {
        void Resize(Stream input, Stream output);
    }
}
