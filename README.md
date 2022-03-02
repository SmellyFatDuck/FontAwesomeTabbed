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
      <th colspan="2"><a href="#StandardEntry">StandardEntry</a></th>
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
      <th colspan="2"><a href="#CustomSearchBar">CustomSearchBar</a></th>
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
      <th colspan="2"><a href="#CustomLabel">CustomLabel</a></th>
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
      <th colspan="2"><a href="#StandardCollectionView">StandardCollectionView</a></th>
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

  First and foremost, add the namespace to the root node:

  ```
  xmlns:fa="clr-namespace:FontAwesome"
  ```

  <b>ShellContent Icon</b>

  ```
  <ShellContent Title="About" ContentTemplate="{DataTemplate local:AboutPage}">
    <ShellContent.Icon>
      <FontImageSource FontFamily="FARegular" Glyph="{x:Static fa:FontAwesomeRegular.AddressBook}" />
    </ShellContent.Icon>
  </ShellContent>
  ```
  
  <b>Image</b>
  
  ```
  <Image>
    <Image.Source>
      <FontImageSource FontFamily="FARegular" Glyph="{x:Static fa:FontAwesomeRegular.AddressBook}" />
    </Image.Source>
  </Image>
  ```
  
  <b>Label</b>
  
  ```
  <Label FontFamily="FARegular" Text="{x:Static fa:FontAwesomeRegular.AddressBook}" />
  ```
  
<h3 id="StandardEntry">StandardEntry</h3>
<h3 id="CustomSearchBar">CustomSearchBar</h3>
<h3 id="CustomLabel">CustomLabel</h3>
<h3 id="StandardCollectionView">StandardCollectionView</h3>
