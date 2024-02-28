---
order: 2
---

# Regions

A `fo:simple-master-page` consists of one or more regions. Your master page should at least have a "body" region, which is used for the main content of each page. But you can also define `before` and `after` regions which can be used for headers and footer respectively. When adding content, you can refer to a region by it's name.

```c#
// Add a new fo:region-body (required)
master.Regions.Add(new FoRegionBody {
    MarginTop = "1cm",
    MarginBottom = "0cm"
});

// Add a new fo:region-before (optional)
master.Regions.Add(new FoRegionBefore {
    RegionName = "header",
    Extent = "0cm",
    MarginBottom = "35px"
});

// Add a new fo:region-after (optional)
master.Regions.Add(new FoRegionAfter {
    RegionName = "footer",
    Extent = "35px",
});
```

You can use the `MarginTop`, `MarginBottom` and `Extent` properties to control the size of each region.