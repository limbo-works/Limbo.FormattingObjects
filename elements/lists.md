# Lists

You can create lists using the `fo:list-block` element for the entire list, and `fo:list-item` elements for each item. The `fo:list-item` element then consists of one `fo:list-item-label` element and one `fo:list-item-body` element:

```c#
// Create a new list block
FoListBlock list = new FoListBlock();
parent.Add(list);

// Iterate through each item
foreach (var item in items) {

    // Initialize a new list item
    FoListItem li = new FoListItem {
        Label = new FoListItemLabel(),
        Body = new FoListItemBody()
    };

    // Add the list item to the list block
    list.Add(li);

}
```

You can add any content you wish to both the `fo:list-item-label` the `fo:list-item-body`. For the label, it would typically be sufficient to just add a hypen or similar:

```c#
// Use a simple hyphen for the label
li.Label.Add(new FoBlock("-"));
```

You could also create your own `int` variable in C# and then increment it for each item to create a numbered list instead. For the item body, we could add a new `fo:block` with the name of the item, and show it in bold:

```c#
li.Body.Add(new FoBlock(feature.FeatureName) {
    FontWeight = FoFontWeight.Bold
});
```

