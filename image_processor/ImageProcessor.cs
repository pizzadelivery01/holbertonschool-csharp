﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.IO;


class ImageProcessor
{
	/// <summary>
	/// invert color on batch of images given using multi-threading
	/// </summary>
	/// <param name="filenames">list of files</param>
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
		{
			Thread t = new Thread(ImageProcessor.invert);
			t.Start(file);
		}
    }
	/// <summary>
	/// inverts color scheme
	/// </summary>
	/// <param name="file">file</param>
	public static void invert(object file)
	{
		string name = file.ToString();
		int width;
		int height;
		string extension = "";
		string filename = "";

		Bitmap bmp = new Bitmap(name);
		width = bmp.Width;
		height = bmp.Height;
		extension = name.Substring(name.LastIndexOf("."));
		filename = name.Substring(name.LastIndexOf("/") + 1, name.Length - extension.Length - 7);

		//Console.WriteLine(filename);
		//Console.WriteLine(extension);
		for (int x = 0; x < width; ++x)
		{
			for ( int y = 0; y < height; ++y)
			{
				Color inv = bmp.GetPixel(x,y);
				inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
				bmp.SetPixel(x, y, inv);
			}
		}
		bmp.Save(filename + "_inverse" + extension);
	}
}