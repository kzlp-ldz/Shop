   M S B A M L   `   `   `  ���� ?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop      Shop.ProductPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $localclr-namespace:Shop       N� Title$  ProductPage��.���  � ColumnDefinitions �� $
��109* ��� $
��580* ��� $
��109* � � RowDefinitions �� $��8* ��� $	��22* ��� $��8* �.+��� $��1�� �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -    ��Name$ 
btn_Orders��$��Заказы��$��70��$��40��$	��Top=����#FAB7A4���#AD7261�� -   $ btn_Intakes��$��Поставки��$��70��$��40��$	��Top=����#FAB7A4���#AD7261�� $��1��$��0��$��3��.+��� .+��� $��Center=�$ 
Horizontal=�.+��� -   $��	SortCount��$��50��$��10q�.@��� -   $��Все���� -   $��2���� -   $��3���� -   $��4���� -    ��Name$ SearchNameDescTb��$��25��$	��150���� -	    ��Name$ UnitCb��$
��10 0q�$��25��$	��150���� -
   $ DateCb��$��25�� �� Text$ Dfvvcv��$	��100��.@��� $��Сбросить���� $!��По возрастанию���� $��По убыванию���� -   $ AlfCb��$��25��$
��10 0q�$	��100��.@��� $��Сбросить���� $��от А до Я���� $��от Я до А���� -   $ DateMounthBtn��$��25��.��(&Дата текущего месяца&   System.Windows.Controls.DataGrid  -   $��ProductList��$	��264��   AutoGenerateColumns .  ���#FAB7A4���#AD7261	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$	
 №��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  $
 Фото��   CellTemplate �� .R��� $��60������ *Photo+  $
 Наименование�� �� *Name+  $
 Описание�� �� *Description+  $
 Ед.измерения�� �� *	Unit.Name+  $#
 Дата добавления�� �� *	AddDate+ �� StringFormat$ dd.MM.yy��  -   
lv_country��$
 Страна�� �� .R��� ���� *ProductCountry+���� .R���  ��Name$ 
lb_country��$��30������ *Country.Name+���� *Country.Color+�� $ 
Horizontal=�$��Center=�$��Center=�$��1��$��2��.+��� -   $��BackListBtn��$��5q�$��<��$��40���� -   $ AddBtnt��$��30��$��70�����#FAB7A4���#AD7261$��Добавить���� -   $ EditBtnt��$��30��$�� 10 0q�$��70�����#FAB7A4���#AD7261$��Изменить���� -   $ DelBtnt��$��30��$��70�����#FAB7A4���#AD7261$��Удалить���� -   $��ForwardListBtn��$��5q�$��>��$��40��