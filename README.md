# Sorting the Property Items of WPF PropertyGrid

The **PropertyGrid** control in WPF is a powerful tool for displaying and editing object properties. By default, properties appear in the order defined in the class. However, sorting them can improve readability and user experience.

## Why Sort Property Items?

- Enhance clarity in complex objects
- Group related properties
- Improve navigation and editing efficiency

## Sorting Techniques

- **CategoryAttribute**: Group properties under custom categories
- **DisplayNameAttribute**: Influence alphabetical sorting
- **Custom PropertyGrid Model**: Define explicit sort order

## Example

```csharp
[Category("Appearance")]
[DisplayName("Background Color")]
public Color BgColor { get; set; }
