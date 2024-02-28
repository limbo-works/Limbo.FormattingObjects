---
order: 10
---

# Content

Once you have configured a [**page sequence](./page-sequences.md), you can start adding content to either it's `fo:flow` element or one of the `fo:static-content` elements representing a region.

Typically your would start out with either a `fo:block-container` element or a `fo:block` element:

```c#
flow.Add(new FoBlock("Hello World"));
```