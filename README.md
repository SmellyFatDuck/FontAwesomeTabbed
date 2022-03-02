<h1>FontAwesomeTabbed</h1>
<p>I developed this as a base template for my iOS and Android apps.</p>
<p><i>If you have any ideas on what else should be included as a standard template, generally something you include in all apps, let me know!</i></p>

<h2>Features</h2>
<h3>Implementations</h3>
<table>
  <thead>
    <tr>
      <th colspan="2">🌟 <b><a href="#FontAwesome">FontAwesome</a></b></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Source</td>
      <td><a href="https://github.com/matthewrdev/fa2cs">matthewrdev/<b>fa2cs</b></a> <i>(adapted version)</i><br>Font Awesome Cheat Sheet <i>(Feb 2022)</i></td>
    </tr>
    <tr>
      <td>Details</td>
      <td>
        Uses <code>FontAwesomeRegular.cs</code>, <code>FontAwesomeSolid.cs</code>, and <code>FontAwesomeBrands.cs</code> to retrieve the FontAwesome glyph from <code>"FARegular"</code>, <code>"FASolid"</code>, or <code>"FABrands"</code>
      </td>
    </tr>
  </tbody>
</table>

<h3>Controls and Renderers</h3>

<table>
  <thead>
    <tr>
      <th colspan="2"><a href="#StandardEntry">StandardEntry</a> : Entry</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Source</td>
      <td><a href="https://github.com/jesulink2514/XamBooksApp/tree/feature/feat-entry">jesulink2514/<b>XamlBooksApp</b></a></td>
    </tr>
    <tr>
      <td>Details</td>
      <td>
        <i>int</i> <b>CornerRadius</b><br>
        <i>int</i> <b>BorderThickness</b><br>
        <i>Color</i> <b>BorderColor</b><br>
        <i>Thickness</i> <b>Padding</b>
      </td>
    </tr>
  </tbody>
</table>

<table>
  <thead>
    <tr>
      <th colspan="2"><a href="#CustomSearchBar">CustomSearchBar</a> : SearchBar</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Source</td>
      <td><a href="https://github.com/jesulink2514/XamBooksApp/tree/feature/feat-entry">jesulink2514/<b>XamlBooksApp</b></a></td>
    </tr>
    <tr>
      <td>Details</td>
      <td>
        <i>int</i> <b>CornerRadius</b><br>
        <i>int</i> <b>BorderThickness</b><br>
        <i>Color</i> <b>BorderColor</b><br>
        <i>Color</i> <b>IconColor</b>
      </td>
    </tr>
  </tbody>
</table>

<table>
  <thead>
    <tr>
      <th colspan="2"><a href="#CustomLabel">CustomLabel</a> : Label</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Details</td>
      <td>
        <i>int</i> <b>MinimumFontSize</b><br>
        <i>int</i> <b>MaximumFontSize</b>
      </td>
    </tr>
  </tbody>
</table>

<table>
  <thead>
    <tr>
      <th colspan="2"><a href="#StandardCollectionView">StandardCollectionView</a> : CollectionView</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Details</td>
      <td>
        <i>Icon</i> <b>ScrollToItem</b><br>
        Replace <u>Icon</u> with your object, I haven't attempted changing Icon to Object
      </td>
    </tr>
  </tbody>
</table>

<h2>Usage</h2>
<h3 id="FontAwesome">FontAwesome</h3>

<blockquote>This version differs to matthewrdev's fa2cs in that it requires the developer to asign the specific class, corresponding to the font family, then allows the developer to freely select the glyph from IntelliSense's suggestions. Whereas with fa2cs, you need to predetermine the glyph and it's corresponding font.</blockquote>

  First and foremost, add the namespace to the root node:

  ```xml
...
  xmlns:fa="clr-namespace:FontAwesome"
...
  ```

  <b>ShellContent Icon</b>

  ```xml
  <ShellContent Title="About" ContentTemplate="{DataTemplate local:AboutPage}">
    <ShellContent.Icon>
      <FontImageSource FontFamily="FARegular" Glyph="{x:Static fa:FontAwesomeRegular.AddressBook}" />
    </ShellContent.Icon>
  </ShellContent>
  ```
  
  <b>Image</b>
  
  ```xml
  <Image>
    <Image.Source>
      <FontImageSource FontFamily="FARegular" Glyph="{x:Static fa:FontAwesomeRegular.AddressBook}" />
    </Image.Source>
  </Image>
  ```
  
  <b>Label</b>
  
  ```xml
  <Label FontFamily="FARegular" Text="{x:Static fa:FontAwesomeRegular.AddressBook}" />
  ```
  
<h3 id="StandardEntry">StandardEntry</h3>

  <blockquote>I don't think I modified the control or renderers in anyway, but it is excellent for virtually all applications. See the original for more information: <a href="https://github.com/jesulink2514/XamBooksApp/tree/feature/feat-entry">jesulink2514/<b>XamlBooksApp</b></a></blockquote>
  
Firstly, add the namespace:

```xml
...
xmlns:controls="clr-namespace:FontAwesomeTabbed.Controls"
...
```
  
```xml
  <controls:StandardEntry
            Padding="20,10,20,10"
            BorderColor="LightGray"
            TextColor="Black"
            BorderThickness="1"
            CornerRadius="20"
            Placeholder="Full Name" />
```
  
<h3 id="CustomSearchBar">CustomSearchBar</h3>

<blockquote>This differs from jesulink2514's XamlBooksApp by having a control but still using the XamlBooksApp SearchBar iOS and Android renderers.</blockquote>

Add the namespace:

```
...
xmlns:controls="clr-namespace:FontAwesomeTabbed.Controls"
...
```

```xml
<controls:CustomSearchBar Text="{Binding SearchText}"
                          SearchCommand="{Binding SearchCommand}"
                          BackgroundColor="White"
                          Placeholder="Search icon..."
                          PlaceholderColor="Gray"
                          TextColor="Black"
                          CornerRadius="30"
                          IconColor="{x:StaticResource Primary}" />
```

<h3 id="CustomLabel">CustomLabel</h3>

Add the namespace:

```
...
xmlns:controls="clr-namespace:FontAwesomeTabbed.Controls"
...
```

```
<controls:StandardLabel HeightRequest="120"
                        Text="This font size will auto fir the container, but make sure you set the HeightRequest"
                        MinimumFontSize="8"
                        MaximumFontSize="24" />
```

<h3 id="StandardCollectionView">StandardCollectionView</h3>

```
...
xmlns:controls="clr-namespace:FontAwesomeTabbed.Controls"
...
```

```
<controls:StandardCollectionView VerticalOptions="StartAndExpand"
                                             ItemsSource="{Binding Icons}"
                                             SelectionMode="None"
                                             ScrollToItem="{Binding ScrollToIcon}"
                                             Margin="5">

                <controls:StandardCollectionView.ItemsLayout>
                    <GridItemsLayout Orientation="Vertical" 
                                     Span="3"
                                     HorizontalItemSpacing="10"
                                     VerticalItemSpacing="10" />
                </controls:StandardCollectionView.ItemsLayout>

                <controls:StandardCollectionView.ItemTemplate>
                    <DataTemplate>
                        <views:IconItemView x:DataType="models:Icon" />
                    </DataTemplate>
                </controls:StandardCollectionView.ItemTemplate>

                <controls:StandardCollectionView.Footer>
                    <StackLayout Padding="0,10,0,0">
                        <Button Text="Scroll to top" 
                                VerticalOptions="End"
                                Command="{Binding ScrollToTopCommand}" />
                    </StackLayout>
                </controls:StandardCollectionView.Footer>
                
            </controls:StandardCollectionView>
            ```
