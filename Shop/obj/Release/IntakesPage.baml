   M S B A M L   `   `   `  ���� ?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop      Shop.IntakesPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $localclr-namespace:Shop       N� Title$  IntakesPage��.���  � ColumnDefinitions �� �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+�&   System.Windows.Controls.DataGrid  -     Name$ 	DGIntakes��$��2��$��0��$��5��$��6�����	#FFFAB7A4
���   �   AutoGenerateColumns .     
IsReadOnly . ���� *	Intakes+��Z�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ Поставщик�� �� *Supplier.Name+  $ 
Сумма�� �� *TotalAmount+  $ Дата�� �� *Data+	 �� StringFormat$	 d��
 �� ConverterCulture$
 ru-RU��  $ Статус�� �� *StatusIntake.Name+��  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��2��$��7��$��2��.+��� -    ��Name$ 
btn_AddInt��$��70��$��Добавить��$��1��$��0��$	��Top=����	#FFAD7261
�������$��Arial)���Z� �� -   $ btn_Back��$��70��$��
Назад��$��1��$��0��$��Bottom=����	#FFAD7261
�������$��Arial)���Z� 