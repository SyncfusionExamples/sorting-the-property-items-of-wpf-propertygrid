# Sorting the Property Items of WPF PropertyGrid
The PropertyGrid control in WPF is a powerful and convenient way to display and edit the public properties of an object at runtime. By default, properties are shown in the order in which they are declared in the underlying class. While this approach works for simple objects, it can reduce readability and usability when dealing with large or complex data models. Applying sorting helps users quickly locate, understand, and modify properties.
Why Sort Property Items?

## Improves clarity when working with many properties
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