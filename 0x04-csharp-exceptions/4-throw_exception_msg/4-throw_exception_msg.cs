﻿using System;

class Except
{
    public static void ThrowMsg(string msg)
    {
        throw new System.IO.IOException(msg);
    }
}