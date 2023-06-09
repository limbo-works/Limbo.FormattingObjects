﻿using System.Xml.Linq;

namespace Limbo.FormattingObjects
{

    public class FoRenderOptions
    {

        public bool UseCData { get; set; }

        public SaveOptions SaveOptions { get; set; }

        public FoRenderOptions()
        {
            UseCData = true;
            SaveOptions = SaveOptions.None;
        }

    }

}