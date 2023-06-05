﻿using System.Xml.Linq;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Pdf.FormattingObjects.Styles;

namespace Skybrud.Pdf.FormattingObjects.Graphics {
    
    /// <summary>
    /// A graphic where the graphics data resides outside of the XML result tree in the fo namespace.
    /// </summary>
    /// <see>
    ///     <cref>https://www.w3.org/TR/xsl11/#fo_external-graphic</cref>
    /// </see>
    public class FoExternalGraphic : FoElement, ICanHasBackground {

        #region Properties

        public string Background { get; set; }

        public string BackgroundImage { get; set; }

        public string BackgroundRepeat { get; set; }

        /// <summary>
        /// The URI-specification to locate an external resource such as image/graphic data to be included as the
        /// content of this object, or color-profile data.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#src</cref>
        /// </see>
        public string Src;

        /// <summary>
        /// The content width of boxes generated by block-level and replaced elements. This property does not apply to
        /// non-replaced inline-level elements. The width of a non-replaced inline element's boxes is that of the
        /// rendered content within them (before any relative offset of children). Recall that inline boxes flow into
        /// line boxes. The width of line boxes is given by their containing block, but may be shorted by the presence
        /// of floats.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#width</cref>
        /// </see>
        public string Width { get; set; }

        /// <summary>
        /// The content height of boxes generated by block-level and replaced elements. This property does not apply to
        /// non-replaced inline-level elements. The height of a non-replaced inline element's boxes is given by the
        /// element's (possibly inherited) 'line-height' value.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#height</cref>
        /// </see>
        public string Height { get; set; }

        /// <summary>
        /// The content-width of some object (e.g., an external graphic). If the value is a percentage, the value of
        /// this property is the percentage applied to the intrinsic width.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#content-width</cref>
        /// </see>
        public string ContentWidth { get; set; }

        /// <summary>
        /// The content-height of some object (e.g., an external graphic). If the value is a percentage, the value of
        /// this property is the percentage applied to the intrinsic height.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#content-height</cref>
        /// </see>
        public string ContentHeight { get; set; }

        /// <summary>
        /// Whether scaling needs to preserve the intrinsic aspect ratio.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#scaling</cref>
        /// </see>
        public FoScaling Scaling { get; set; }

        /// <summary>
        /// Indicates a preference in the scaling/sizing tradeoff to be used when formatting bitmapped graphics.
        /// </summary>
        /// <see>
        ///     <cref>https://www.w3.org/TR/xsl11/#scaling-method</cref>
        /// </see>
        public FoScalingMethod ScalingMethod { get; set; }


        public string Margin { get; set; }

        public string MarginTop { get; set; }

        public string MarginRight { get; set; }

        public string MarginBottom { get; set; }

        public string MarginLeft { get; set; }

        public string Padding { get; set; }

        public string PaddingTop { get; set; }

        public string PaddingRight { get; set; }

        public string PaddingBottom { get; set; }

        public string PaddingLeft { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public FoExternalGraphic() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="src"/>.
        /// </summary>
        public FoExternalGraphic(string src) {
            Src = src;
        }

        #endregion

        #region Member methods

        protected override void RenderAttributes(XElement element, FoRenderOptions options) {

            if (Src.IsNullOrWhiteSpace()) throw new PropertyNotSetException(nameof(Src));
            element.Add(new XAttribute("src", Src));

            if (Width.HasValue()) element.Add(new XAttribute("width", Width));
            if (Height.HasValue()) element.Add(new XAttribute("height", Height));
            if (ContentWidth.HasValue()) element.Add(new XAttribute("content-width", ContentWidth));
            if (ContentHeight.HasValue()) element.Add(new XAttribute("content-height", ContentHeight));
            if (Scaling != FoScaling.Unspecified) element.Add(new XAttribute("scaling", ToKebabCase(Scaling)));
            if (ScalingMethod != FoScalingMethod.Unspecified) element.Add(new XAttribute("scaling-method", ToKebabCase(ScalingMethod)));

            if (Background.HasValue()) element.Add(new XAttribute("background", Background));
            if (BackgroundImage.HasValue()) element.Add(new XAttribute("background-image", BackgroundImage));
            if (BackgroundRepeat.HasValue()) element.Add(new XAttribute("background-repeat", BackgroundRepeat));

            if (Margin.HasValue()) element.Add(new XAttribute("margin", Margin));
            if (MarginTop.HasValue()) element.Add(new XAttribute("margin-top", MarginTop));
            if (MarginRight.HasValue()) element.Add(new XAttribute("margin-right", MarginRight));
            if (MarginBottom.HasValue()) element.Add(new XAttribute("margin-bottom", MarginBottom));
            if (MarginLeft.HasValue()) element.Add(new XAttribute("margin-left", MarginLeft));

            if (Padding.HasValue()) element.Add(new XAttribute("padding", Padding));
            if (PaddingTop.HasValue()) element.Add(new XAttribute("padding-top", PaddingTop));
            if (PaddingRight.HasValue()) element.Add(new XAttribute("padding-right", PaddingRight));
            if (PaddingBottom.HasValue()) element.Add(new XAttribute("padding-bottom", PaddingBottom));
            if (PaddingLeft.HasValue()) element.Add(new XAttribute("padding-left", PaddingLeft));

            base.RenderAttributes(element, options);

        }

        public override XElement ToXElement(FoRenderOptions options) {
            XElement element = Fo("external-graphic");
            RenderAttributes(element, options);
            RenderChildren(element, options);
            return element;
        }
        
        #endregion

    }

}