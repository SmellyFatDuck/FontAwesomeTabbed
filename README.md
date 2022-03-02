<h1>FontAwesomeTabbed</h1>
<p>I developed this as a base template for my iOS and Android apps.</p>
<p><i>If you have any ideas on what else should be included as a standard template, generally something you include in all apps, let me know!</i></p>

<h2>Features</h2>
<h3>Implementations</h3>
<p>
  🌟 <b><a href="#FontAwesome">FontAwesome</a></b><br>
  Source: <a href="https://github.com/matthewrdev/fa2cs">matthewrdev fa2cs</a> <i>(adapted version)</i> and Font Awesome Cheat Sheet <i>(Feb 2022)</i><br>
  Details: includes <code>FontAwesomeRegular.cs</code>, <code>FontAwesomeSolid.cs</code>, and <code>FontAwesomeBrands.cs</code>
</p>
<h3>Controls and Renderers</h3>
<table>
  <thead>
    <tr>
      <th></th>
      <th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#StandardEntry">StandardEntry</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
      <th>&nbsp;&nbsp;&nbsp;<a href="#CustomSearchBar">CustomSearchBar</a>&nbsp;&nbsp;&nbsp;</th>
      <th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#CustomLabel">CustomLabel</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
      <th><a href="#StandardCollectionView">StandardCollectionView</a></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Source</td>
      <td><sup><a href="https://github.com/jesulink2514/XamBooksApp/tree/feature/feat-entry">jesulink2514 XamlBooksApp</a></sup></td>
      <td><sup><a href="https://github.com/jesulink2514/XamBooksApp/tree/feature/feat-entry">jesulink2514 XamlBooksApp</a> <i>(adapted version)</i></sup></td>
      <td></td><td></td>
    </tr>
    <tr>
      <td>Details</td>
      <td>
        <i>int</i> <b>CornerRadius</b><br>
        <i>int</i> <b>BorderThickness</b><br>
        <i>Color</i> <b>BorderColor</b><br>
        <i>Thickness</i> <b>Padding</b>
      </td>
      <td>
        <i>int</i> <b>CornerRadius</b><br>
        <i>int</i> <b>BorderThickness</b><br>
        <i>Color</i> <b>BorderColor</b><br>
        <i>Color</i> <b>IconColor</b>
      </td>
      <td>
        <i>int</i> <b>MinimumFontSize</b><br>
        <i>int</i> <b>MaximumFontSize</b>
      </td>
      <td>
        <i>Icon</i> <b>ScrollToItem</b><br>
        Replace <u>Icon</u> with your object, I haven't attempted changing Icon to Object
      </td>
    </tr>
  </tbody>
</table>

<h2>Usage</h2>
<h3 id="FontAwesome">FontAwesome</h3>

  <b>Tab Icon</b>

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
  
<h3 id="StandardEntry">StandardEntry</h3>
<h3 id="CustomSearchBar">CustomSearchBar</h3>
<h3 id="CustomLabel">CustomLabel</h3>
<h3 id="StandardCollectionView">StandardCollectionView</h3>
