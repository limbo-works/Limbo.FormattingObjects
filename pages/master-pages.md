---
order: 1
---

# Master Pages

As part of setting up a new document, you should also add at least one master page. A master page can be thought of as a template for your pages. You can add as many master pages as you need.

XSL-FO supports a few different master page types, but `fo:simple-master-page` is probably the only one you'll ever need.

For the master page, you specify a name as the width of the height of the page. For instance in the example below, I've created a new master page for an A4 portrait format. The master page also defines the margins of the page.

```c#
// Initialize the "Master" master page
FoSimpleMasterPage master = new FoSimpleMasterPage("Master", "210mm", "297mm") {
    MarginTop = "1cm",
    MarginBottom = "0.5cm",
    MarginRight = "1.8cm",
    MarginLeft = "1.8cm"
};

// Add the master page to the document
document.LayoutMasterSet.Add(master);
```
