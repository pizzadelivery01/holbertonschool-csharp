﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;


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
			string extension = Path.GetExtension(file);
			string filename = Path.GetFileNameWithoutExtension(file);

			Bitmap bmp = new Bitmap(file);
			Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
			BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

			IntPtr ptr = data.Scan0;

			int bytes = Math.Abs(data.Stride) * bmp.Height;
			byte[] rgbValues = new byte[bytes];
			Marshal.Copy(ptr, rgbValues, 0, bytes);
			
			for(int i = 0; i < rgbValues.Length; i++)
			{
				rgbValues[i] = (byte) (255 - rgbValues[i]);
			}
			Marshal.Copy(ptr, rgbValues, 0, bytes);
			bmp.UnlockBits(data);
			bmp.Save(filename + "_inverse" + extension);
		});		
    }
	/// <summary>
	/// converts images to grayscale
	/// </summary>
	/// <param name="filenames">list of filenames</param>
	public static void Grayscale(string[] filenames)
	{
		Parallel.ForEach(filenames, file =>
		{
			string extension = Path.GetExtension(file);
			string filename = Path.GetFileNameWithoutExtension(file);

			Bitmap bmp = new Bitmap(file);
			Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
			BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

			IntPtr ptr = data.Scan0;

			int bytes = Math.Abs(data.Stride) * bmp.Height;
			byte[] rgbValues = new byte[bytes];
			Marshal.Copy(ptr, rgbValues, 0, bytes);
			
			for(int i = 0; i < rgbValues.Length - 2; i += 3)
			{
				byte gray = (byte)((rgbValues[i] * 0.21) + (rgbValues[i + 1] * 0.71) + (rgbValues[i + 2] * 0.072));
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = gray;
			}
			Marshal.Copy(rgbValues, 0, ptr, bytes);
			bmp.UnlockBits(data);
			bmp.Save(filename + "_greyscale" + extension);
		});		
    }
}