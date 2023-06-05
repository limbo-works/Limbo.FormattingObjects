using System.Collections.Generic;
using System.Xml.Linq;
using Skybrud.Pdf.FormattingObjects.Inline;
using Skybrud.Pdf.FormattingObjects.Styles;

namespace Skybrud.Pdf.FormattingObjects {

    public class FoBlock : FoContainer<FoNode>, ICanHasText, ICanHasBackground {

        #region Properties

        public static FoBlock PageBreak => new FoBlock { PageBreakBefore = FoPageBreakBefore.Always };

        #endregion

        #region Constructor(s)

        public FoBlock() { }

        public FoBlock(string text) {
            Add(new FoText(text));
        }

        public FoBlock(IEnumerable<FoNode> children) {
            AddRange(children);
        }

        public FoBlock(params FoNode[] children) {
            AddRange(children);
        }

        #endregion

        #region Member methods

        //public FoBlock AppendTo(FoBlock block) {
        //    block.Add(this);
        //    return this;
        //}

        //public FoBlock AppendTo(FoBlockContainer container) {
        //    container.Add(this);
        //    return this;
        //}

        /// <summary>
        /// Appends a new <see cref="FoInline"/> child element containting the specified <paramref name="text"/>.
        /// </summary>
        /// <param name="text">The text of the inline element.</param>
        public void Add(string text) {
            Add(new FoInline(text ?? string.Empty));
        }

        public override XElement ToXElement(FoRenderOptions options) {
            XElement xBlock = Fo("block");
            RenderAttributes(xBlock, options);
            RenderChildren(xBlock, options);
            return xBlock;
        }

        #endregion

        #region Static methods

        public static FoBlock Create() {
            return new FoBlock();
        }

        public static FoBlock Create(string text) {
            return new FoBlock(text);
        }

        #endregion

    }

}