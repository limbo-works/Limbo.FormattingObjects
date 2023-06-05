using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skybrud.Pdf.FormattingObjects {
    
    public abstract class FoElementContainer : FoContainer {
        public override bool HasChildren { get; }

        public override XElement ToXElement(FoRenderOptions options)
        {
            throw new NotImplementedException();
        }


    }

}
