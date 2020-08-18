using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


class ImageProcessor
{
	/// <summary>
	/// invert color on batch of images given using multi-threading
	/// </summary>
	/// <param name="filenames">list of files</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, file =>
		{
			string name = file.ToString();
			int width;
			int height;
			string extension = "";
			string filename = Path.GetFileNameWithoutExtension(name);

			Bitmap bmp = new Bitmap(name);
			width = bmp.Width;
			height = bmp.Height;
			extension = name.Substring(name.LastIndexOf("."));

			for (int x = 0; x < width; ++x)
			{
				for ( int y = 0; y < height; ++y)
				{
					Color inv = bmp.GetPixel(x,y);
					int a = inv.A;
					inv = Color.FromArgb(a, (255 - inv.R), (255 - inv.G), (255 - inv.B));
					bmp.SetPixel(x, y, inv);
				}
			}
			bmp.Save(filename + "_inverse" + extension);
			});		
    }
}