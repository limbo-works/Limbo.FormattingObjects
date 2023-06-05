using System;
using Skybrud.Pdf.FormattingObjects.Styles;

namespace Skybrud.Pdf.FormattingObjects.Extensions {

    public static class FoExtensions {

        public static TElement For<TElement>(this TElement element, Action<TElement> action) where TElement : FoNode {
            action(element);
            return element;
        }

        ///// <summary>
        ///// Adds (appends) <see cref="element"/> to <paramref name="parent"/>.
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="element">The element to be added.</param>
        ///// <param name="parent">The parent container.</param>
        ///// <returns><paramref name="element"/>.</returns>
        //public static T AddTo<T>(this T element, FoContainer parent) where T : FoContainer {
        //    parent.Add(element);
        //    return element;
        //}
        
        public static T SetId<T>(this T element, string value) where T : FoContainer {
            element.Id = value;
            return element;
        }

        public static T SetColor<T>(this T container, string color) where T : FoContainer {
            container.Color = color;
            return container;
        }

        public static T SetBackground<T>(this T element, string value) where T : ICanHasBackground {
            element.Background = value;
            return element;
        }

        public static T SetFontFamily<T>(this T container, string family) where T : ICanHasText {
            container.FontFamily = family;
            return container;
        }
        
        public static T SetFontWeight<T>(this T container, FoFontWeight weight) where T : ICanHasText {
            container.FontWeight = weight;
            return container;
        }
        
        public static T SetFontStyle<T>(this T container, FoFontStyle style) where T : ICanHasText {
            container.FontStyle = style;
            return container;
        }

        public static T SetFontSize<T>(this T container, string value) where T : ICanHasText {
            container.FontSize = value;
            return container;
        }
        
        public static T SetLineHeight<T>(this T container, string value) where T : ICanHasText {
            container.LineHeight = value;
            return container;
        }
        
        public static T SetTextAlign<T>(this T element, FoTextAlign value) where T : FoContainer {
            element.TextAlign = value;
            return element;
        }

        public static T SetKeepTogether<T>(this T container, FoKeepTogether keep) where T : FoContainer {
            container.KeepTogether = keep;
            return container;
        }

        public static T SetMargin<T>(this T element, string value) where T : FoContainer {
            element.Margin = value;
            return element;
        }

        public static T SetMarginTop<T>(this T container, string value) where T : FoContainer {
            container.MarginTop = value;
            return container;
        }

        public static T SetMarginRight<T>(this T container, string value) where T : FoContainer {
            container.MarginRight = value;
            return container;
        }

        public static T SetMarginBottom<T>(this T container, string value) where T : FoContainer {
            container.MarginBottom = value;
            return container;
        }

        public static T SetMarginLeft<T>(this T container, string value) where T : FoContainer {
            container.MarginLeft = value;
            return container;
        }

        public static T SetPadding<T>(this T element, string value) where T : FoContainer {
            element.Padding = value;
            return element;
        }

        public static T SetPaddingTop<T>(this T element, string value) where T : FoContainer {
            element.PaddingTop = value;
            return element;
        }

        public static T SetPaddingRight<T>(this T element, string value) where T : FoContainer {
            element.PaddingRight = value;
            return element;
        }

        public static T SetPaddingBottom<T>(this T element, string value) where T : FoContainer {
            element.PaddingBottom = value;
            return element;
        }

        public static T SetPaddingLeft<T>(this T element, string value) where T : FoContainer {
            element.PaddingLeft = value;
            return element;
        }

        public static TElement SetWidth<TElement>(this TElement element, string value) where TElement : FoContainer {
            element.Width = value;
            return element;
        }

        public static TElement SetHeight<TElement>(this TElement element, string value) where TElement : FoContainer {
            element.Height = value;
            return element;
        }

        internal static bool IsDefault(this Enum enumValue) {
            return (int) Convert.ChangeType(enumValue, typeof(int)) == 0;
        }

    }

}