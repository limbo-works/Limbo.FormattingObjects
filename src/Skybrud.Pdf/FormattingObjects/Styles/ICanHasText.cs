namespace Skybrud.Pdf.FormattingObjects.Styles {
    
    public interface ICanHasText {

        FoFontWeight FontWeight { get; set; }

        FoFontStyle FontStyle { get; set; }

        string FontFamily { get; set; }

        string FontSize { get; set; }

        string LineHeight { get; set; }

    }

}