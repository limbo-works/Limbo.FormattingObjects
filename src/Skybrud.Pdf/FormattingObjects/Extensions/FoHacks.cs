using Skybrud.Pdf.FormattingObjects.Pages;
using Skybrud.Pdf.FormattingObjects.Tables;

namespace Skybrud.Pdf.FormattingObjects.Extensions {
    
    public static class FoHacks {

        public static FoTable AppendTo(this FoTable table, FoBlock block) {
            block.Add(table);
            return table;
        }

        public static FoTable AppendTo(this FoTable table, FoBlockContainer container) {
            container.Add(table);
            return table;
        }

        public static FoTable AppendTo(this FoTable table, FoFlow flow) {
            flow.Add(table);
            return table;
        }

        public static FoTableCell Append(this FoTableCell cell, FoElement element) {
            cell.Add(element);
            return cell;
        }

        public static TElement AppendTo<TElement, TParent>(this TElement element, TParent parent) where TElement : FoElement where TParent : FoFlow {
            parent.Add(element);
            return element;
        }

        //public static TParent Append<TParent, TElement>(this TParent parent, TElement element) where TParent : FoContainer<FoContainer> where TElement : FoContainer {
        //    parent.Add(element);
        //    return parent;
        //}

        //public static T AppendTo<T>(this T element, FoContainer<T> parent) where T : FoNode {
        //    parent.Add(element);
        //    return element;
        //}

    }

    public static class FoNodeExtensions {

        public static TNode AppendTo<TNode, TParent>(this TNode node, TParent parent) where TNode : FoNode where TParent : FoContainer<FoNode> {
            parent.Add(node);
            return node;
        }

    }

    //public static class FoElementExtensions {

    //    public static TElement AppendTo<TElement, TParent>(this TElement element, TParent parent) where TElement : FoElement where TParent : FoContainer<FoElement> {
    //        parent.Add(element);
    //        return element;
    //    }

    //}

    public static class FoHacks2 {

        public static TElement AppendTo<TElement, TParent>(this TElement element, TParent parent) where TElement : FoElement where TParent : FoTableCell {
            parent.Add(element);
            return element;
        }

        public static A Append<A, B>(this A element, B child) where A : FoContainer<FoNode> where B : FoNode {
            element.Add(child);
            return element;
        }

    }

}