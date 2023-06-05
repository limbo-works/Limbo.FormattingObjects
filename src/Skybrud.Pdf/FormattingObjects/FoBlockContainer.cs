﻿using System.Collections.Generic;
using System.Xml.Linq;
using Skybrud.Pdf.FormattingObjects.Styles;

namespace Skybrud.Pdf.FormattingObjects {

    public class FoBlockContainer : FoContainer<FoNode>, ICanHasBackground, ICanHasText {

        #region Constructors

        public FoBlockContainer() { }

        public FoBlockContainer(IEnumerable<FoContainer> children) {
            AddRange(children);
        }

        public FoBlockContainer(params FoContainer[] children) {
            AddRange(children);
        }

        #endregion

        #region Member methods
        
        public override XElement ToXElement(FoRenderOptions options) {
            XElement xBlockContainer = Fo("block-container");
            RenderAttributes(xBlockContainer, options);
            RenderChildren(xBlockContainer, options);
            return xBlockContainer;
        }

        #endregion

    }

}