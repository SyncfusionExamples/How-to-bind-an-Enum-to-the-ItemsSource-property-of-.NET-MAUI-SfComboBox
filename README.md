# How to bind an Enum to the ItemsSource property of .NET MAUI SfComboBox
This repository contains sample about How to bind an Enum to the ItemsSource property of SfComboBox(.NET MAUI)

##   Getting Started with .NET MAUI ComboBox (SfComboBox)

###  Adding a .NET MAUI ComboBox reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI ComboBox to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Inputs and then install it.

##   Create a Simple .NET MAUI ComboBox
The .NET MAUI ComboBox control is configured entirely in C# code or by using XAML markup. The following steps explain how to create a .NET MAUI ComboBox (SfComboBox) and configure its elements:

###  Adding the .NET MAUI ComboBox control
Step 1: Add the NuGet to the project as discussed in the above reference section.

Step 2: Add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
```

Step 3: Set the control to content in ContentPage.

**[XAML]**

```
<ContentPage.Content>    
    <editors:SfComboBox x:Name="comboBox" />
</ContentPage.Content>
```
##   Bind an Enum to the ItemsSource property of .NET MAUI SfComboBox

**[XAML]**

```
  <ContentPage.BindingContext>
        <local:SocialMediaViewModel />
    </ContentPage.BindingContext>
    
    <editors:SfComboBox x:Name="comboBox" 
                    WidthRequest="250"
                    HeightRequest = "70"
                    BorderColor="Green"
                    ItemsSource="{Binding SocialMedias}" />
```
###  ViewModel

**[C#]**
```
 public class SocialMediaViewModel
    {
        public ObservableCollection<SocialMedia> SocialMedias { get; set; }
        public SocialMediaViewModel()
        {
            this.SocialMedias = new ObservableCollection<SocialMedia>();           
            this.SocialMedias = Enum.GetValues(typeof(SocialMedia)).Cast<SocialMedia>().ToObservableCollection();
        }

       public  enum SocialMedia
       {
            Facebook,
            GooglePlus,
            Instagram,
            LinkedIn,
            Skype,
            Meta
       }
    }
```
## How to run this application?

To run this application, you need to first clone the How-to-bind-an-Enum-to-the-ItemsSource-property-of-.NET-MAUI-SfComboBox repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
