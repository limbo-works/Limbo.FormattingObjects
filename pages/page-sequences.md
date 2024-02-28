---
order: 3
---

# Page Sequences

To add any content to the PDF document, you must add one or more page sequences (as `fo:page-sequence` elements). A page sequence is based on a master page, so pages in a given page sequence follows the size of it's master page.



## Flows

In XSL-FO you don't actually add individual pages - instead you add content to a `fo:flow` element, which represents the main content of the pages. Setting up both the `fo:page-sequence` and `fo:flow` elements could look like this:

```c#
// Initialize a new flow based on the body region
flow = new FoFlow("xsl-region-body");

// Initialize a new page based on the flow
FoPageSequence page = new FoPageSequence("Master", "Master", flow);

// Append the page sequence to the document
document.PageSequences.Add(page);
```



## Static content

The `fo:region-before` element can serve as the header of your pages, and as such you can add it to your page sequence like:

```c#
// Initialize a new static content for the header (before region)
FoStaticContent header = new FoStaticContent("header");
page.StaticContent.Add(header);
```

On the other hand, the `fo:region-after` element represents can serve as the footer of your pages:

```c#
// Initialize a new static content for the footer (after region)
FoStaticContent footer = new FoStaticContent("footer");
page.StaticContent.Add(footer);
```

In both cases, the argument for the `FoStaticContent` constructor refers to the names you specified for your regions of the master page.