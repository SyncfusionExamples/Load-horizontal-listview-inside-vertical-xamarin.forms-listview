# Horizontal ListView inside vertical Listview

The SfListView allows you to layout the items in horizontal list inside the vertical list. You can load the nested SfListView by customizing the [ItemTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~ItemTemplate.html) of outer SfListView.

You should define the size for each inner SfListView or set the [AutoFitMode](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~AutoFitModeProperty.html) of inner SfListView as `Height`, and define the [ItemSize](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~ItemSize.html) for outer SfListView.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
   <ContentPage.BindingContext>
    <local:ListViewModel x:Name="viewModel"/>
  </ContentPage.BindingContext>
    <Grid>
        <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding OuterList}" ItemSize="100">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid>
                        <Label Text="{Binding Label}" />
                        <syncfusion:SfListView ItemsSource="{Binding InnerList}" ItemSize="100" Orientation="Horizontal">
                            <syncfusion:SfListView.ItemTemplate>
                                <DataTemplate>
                                    <Grid>
                                        <Image Source="{Binding Image}"/>
                                    </Grid>
                                </DataTemplate>
                            </syncfusion:SfListView.ItemTemplate>
                        </syncfusion:SfListView>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </Grid>
</ContentPage>
```

To know more about ListView appearance, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/viewappearance?cs-save-lang=1&cs-lang=xaml#horizontal-list-inside-vertical-list).