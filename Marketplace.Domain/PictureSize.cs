using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class PictureSize : Value<PictureSize>
    {
        public int Width { get; internal set; }
        public int Height { get; internal set; }

        public PictureSize(int width, int height)
        {
            if(Width <= 0) throw new ArgumentOutOfRangeException(nameof(width), "Picture width must be positive number");
            if(height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Picture height must be positive number");

            Width = width;
            Height = height;
        }

        internal PictureSize() { }
    }
}
