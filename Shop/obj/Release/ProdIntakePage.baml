   M S B A M L   `   `   `  ���� ?  ;Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ShopShop      Shop.ProdIntakePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $localclr-namespace:Shop       N� Title$  ProdIntakePage��.���  � ColumnDefinitions �� �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+��� -    ��Name$ btn_Back��$��
Назад��$��1��$��0��$��Bottom=����	#FFAD7261
�������$��Arial)���Z� �� -   $ btn_Save��$��Сохранение��$��1��$��0��$	��Top=����	#FFAD7261
�������$��Arial)���Z� �� $��Дата��$��0��$��2��$��Center=�$��Center=����	#FFAD7261$��Arial)�(  "System.Windows.Controls.DatePicker  -     Name$ dpDate��$��0��$��3���� $��Поставщик��$��0��$��4��$��Center=�$��Center=����	#FFAD7261$��Arial)��� -    ��Name$ 
cbSupplier��$��60��$��40��$��0��$��5������ *	Suppliers+���� .R��� ���� *Name+��  �� Orientation$ 
Horizontal=�$��0��$��1��$��10q�.+��� -   $ 	cbProduct�� �� SelectedIndex$ 0������ *
Products+���� .R��� ���� *Name+�� -   $ btnAdd��$��Добавить�����	#FFAD7261
�������$��Arial)���Z� &   System.Windows.Controls.DataGrid  -     Name$ gridProducts��$��2��$��2��$��0��$��6������ *IntakeProducts+	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  -   	clProduct��,  &System.Windows.Controls.DataGridColumn
   Header$
 
Товар��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Product.Name+  -	   clPrice��$
 Цена�� �� *Product.Price+  -
   clCount��$
 Количество�� �� *Count+  -   	clSum��$
 
Сумма�� �� *Sum+�� $ 
Horizontal=�$��4��$��1��$��2��.+��� $��
Сумма�����	#FFAD7261$��Arial)��� -    ��Name$ tbSum��$	��100��{�.  $��0��