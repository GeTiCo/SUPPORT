   M S B A M L   `   `   `  ����E  ABubblesTea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BubblesTea.ViewBubblesTea.View  5   	       BubblesTea.View.PayOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BubblesTea.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ PayOrder��5	   	   $	��450��6   $	��800��6'   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��3.5* �6   �� 5      $
��0.5* �6   .+�5   
   � $��0��6   .+�5      �� $��20,0,0,0q�5      $��/res/test.png��5      $
��Left=�5      $��Center=�5      �� 5      $��25(�5      $-��'Подтверждение заказа��5      $��Center=�5      $��Center=�5      �� 5       -   5        $��0,0,20,0q�5!      $	��100��5"      $��50��5#      $��Right=�5$      $��Center=�5%      5&      5'      � 5)   
   $��1��6    5*      �� 5+      $��* �6    �� 5,      $��50 �6    .+�5.      &   System.Windows.Controls.DataGrid  -   5          Name$ SecretOrder��5.   R   $��0��6      AutoGenerateColumns .     
IsReadOnly . $y�Visible=�6g      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6G   �� 
 �� Path$

 Name�  51      $ Цена��6)   $
 0.5* 67   	 6D   �� $

 Cost�  52      $ Кол-во��6)   $
 0.5* 69   	 6F   �� $
 Count�  53      $ 
Итого��6)   $ * 68   	 6B   �� $
 Costing�4  .System.Windows.Controls.DataGridTemplateColumn  54      $ * 6-      CellTemplate 55      �� 56      .R�57   "   ��  �� Orientation$ 
Horizontal=�6-   .+�58   &   �� $
��plus��6-   -   5        .��58   O   +6R   �� 59   &   $��minus��6-   -   5        .��59   P   -6S   �� 5:   &   $��delete��6-   -   5        .��5:   Q   DEL6V   5;   #   5<      5>      5@      �� 5A      -   5        $��clickbuy��5A      $��1��6%   $��5q�62   6=   5B      � 5D   
   $��2��6   .+�5F      �� $��20,0,0,0q�5G      $��Копирайт��5H      $��Center=�5I      $��20(�5J      �� 5L      $ 
Horizontal=�5M      $��Right=�5N      $��Center=�5O      $��0,0,20,0q�5P      .+�5Q      �� $��30��5R      $��30��5S      $��10,0,0,0q�5T      �� 5U      $��30��5V      $��30��5W      $��10,0,0,0q�5X      5Y      5Z      5[      5\      