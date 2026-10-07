## Two Useful Tag Helpers for .NET Core

## 1.EasyCheckBoxList - Multi-select checkbox dropdown
Selected values are automatically displayed as buttons in the header.
```csharp
var list1 = new List<TestModel1>();
    list1.Add(new TestModel1 { Name_1 = "Marco", Value_1 = "1000", Info_1 = "i1", Checked_1 = false });
    list1.Add(new TestModel1 { Name_1 = "Peter", Value_1 = "2000", Info_1 = "i2", Checked_1 = false });
    list1.Add(new TestModel1 { Name_1 = "John", Value_1 = "3000", Info_1 = "i3", Checked_1 = false });
    list1.Add(new TestModel1 { Name_1 = "Stephan", Value_1 = "4000", Info_1 = "i4", Checked_1 = false });
```
```html
Basic usage of the `responsive-webpsourceset` Tag Helper:
    <check-box-combo asp-items="List1"
        add-css="true"
        add-javascript="false"
        column-name="Name_1"
        column-value="Value_1"
        column-checked="Checked_1"
        column-info="Info_1"
        asp-title="Example 1">
    </check-box-combo>
```
![srcset](https://raw.githubusercontent.com/dragan171/EasyComponentsSample/main/EasyComponentsSample/wwwroot/images/EasyCheckBoxList.png)


-----------------------------------------------------------------------------------------------------------------


## 2.ResponsiveWebPSourceSet - Automatic WebP Conversion

```html
Basic usage of the `responsive-webpsourceset` Tag Helper:
<responsive-webpsourceset
    Url="/images/photo1.jpg"
    SourceImagePath="@webRootImagePath">
</responsive-webpsourceset>

Basic Usage - Generated HTML (Height and width are automatically set)
<picture>
  <source srcset="/images/photo1-size2500.webp" media="(min-width:1400px)">
  <source srcset="/images/photo1-size1400.webp" media="(min-width:1200px)">
  <source srcset="/images/photo1-size1200.webp" media="(min-width:992px)">
  <source srcset="/images/photo1-size992.webp" media="(min-width:768px)">
  <source srcset="/images/photo1-size768.webp" media="(min-width:576px)">
  <source srcset="/images/photo1-size576.webp" media="(min-width:420px)">
  <img style="max-width:100%; height:auto;" src="/images/photo1.jpg" alt="photo1" width="4800" height="4000" />
</picture>
```
![srcset](https://raw.githubusercontent.com/dragan171/EasyComponentsSample/main/EasyComponentsSample/wwwroot/images/srcset.png)
