   M S B A M L   `   `   `  ���� ?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop      Shop.OrderPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $localclr-namespace:Shop       N� Title$  	OrderPage��.���  � ColumnDefinitions �� �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgOrders��$��2��$��0��$��6��$��5�����	#FFFAB7A4
���   �   AutoGenerateColumns .     
IsReadOnly . ���� *Orders+��Z�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  Идентификатор��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ Дата�� �� *Date+	 �� StringFormat$	 d��
 �� ConverterCulture$
 ru-RU��  $  Кол-во товаров�� �� *ProductOrder.Count+  $ Этап�� �� *StatusOrder.Name+  $ Заказчик�� �� *
Client.FIO+  $ Исполнитель�� �� *
Worker.FIO+��  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�$��2��$��7��$��2��.+��� -    ��Name$ 
btn_AddOrd��$��30��$��70��$��Добавить�����	#FFAD7261
�������$��Arial)��� -   $ btn_Back��$��
Назад��$��30��$��70�����	#FFAD7261
�������$��Arial)�