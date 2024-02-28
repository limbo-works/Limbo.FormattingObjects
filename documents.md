---
order: 1
---

# Documents

## Initializing a new document

The actual PDF document is in this package represented by the `FoDocument` class. You can create a new instance of it as:

```c#
// Initialize a new document
FoDocument document = new FoDocument();
```

If you're using IBEX for generating the PDF, you can also specify a number of extra properties on the document:

```c#
document.Properties = new IbexProperties {
    Author = "Me",
    Title = "Test PDF document",
    Subject = "Test PDF document",
    Creator = "Skybrud.Pdf",
    Keywords = new []{ "hello", "world" }
};
```