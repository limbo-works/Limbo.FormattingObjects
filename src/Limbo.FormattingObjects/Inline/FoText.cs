namespace Limbo.FormattingObjects.Inline
{

    public class FoText : FoNode
    {

        #region Properties

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Constructors

        public FoText() : this(string.Empty) { }

        public FoText(string value)
        {
            Value = value ?? string.Empty;
        }

        #endregion

    }

}