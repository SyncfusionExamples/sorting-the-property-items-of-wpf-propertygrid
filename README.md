# Sorting the Property Items of WPF PropertyGrid
This repository demonstrates how to sort property items in the Syncfusion WPF PropertyGrid control using the built‑in SortDirection feature.
The sample shows how properties can be displayed in ascending, descending, or unsorted order, helping developers organize and present object properties more effectively in WPF applications.

## Overview
The Syncfusion WPF PropertyGrid allows developers to view and edit the properties of an object at runtime. By default, property items can be sorted based on their property names.
This example illustrates how to:
- Enable property sorting
- Change the sorting direction
- Disable sorting to preserve custom or declared property order

## Why Sort Property Items?
Groups logically related settings together
Enhances navigation and overall editing efficiency
Provides a more professional and user‑friendly UI

## Common Sorting Techniques

CategoryAttribute: Organizes properties into named groups
DisplayNameAttribute: Affects alphabetical ordering and readability
Custom PropertyGrid Models: Allows full control over property order

## Example

```csharp
[Category("Appearance")]
[DisplayName("Background Color")]
public Color BgColor { get; set; }

Using these techniques ensures a cleaner and more intuitive PropertyGrid experience.
