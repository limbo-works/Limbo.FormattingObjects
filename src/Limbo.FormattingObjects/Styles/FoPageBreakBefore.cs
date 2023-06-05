namespace Limbo.FormattingObjects.Styles
{

    /// <summary>
    /// A potential page break location is typically under the influence of the parent element's
    /// <c>page-break-inside</c> property, the <c>page-break-after</c> property of the preceding element, and the
    /// <c>page-break-before</c> property of the following element. When these properties have values other than
    /// <see cref="Auto"/>, the values <see cref="Always"/>, <see cref="Left"/>, and <see cref="Right"/> take
    /// precedence over <see cref="Avoid"/>. See the section on allowed page breaks for the exact rules on how these
    /// properties may force or suppress a page break.
    /// </summary>
    /// <see>
    ///     <cref>https://www.w3.org/TR/xsl11/#page-break-before</cref>
    /// </see>
    /// <see>
    ///     <cref>http://www.datypic.com/sc/fo11/a-page-break-before-1.html</cref>
    /// </see>
    public enum FoPageBreakBefore
    {

        /// <summary>
        /// Inherits the value from a parent or ancestor.
        /// </summary>
        Inherit,

        /// <summary>
        /// Neither force nor forbid a page break before (after, inside) the generated box.
        /// </summary>
        Auto,

        /// <summary>
        /// Always force a page break before (after) the generated box.
        /// </summary>
        Always,

        /// <summary>
        /// Avoid a page break before (after, inside) the generated box.
        /// </summary>
        Avoid,

        /// <summary>
        /// Force one or two page breaks before (after) the generated box so that the next page is formatted as a left page.
        /// </summary>
        Left,

        /// <summary>
        /// Force one or two page breaks before (after) the generated box so that the next page is formatted as a right page.
        /// </summary>
        Right

    }

}