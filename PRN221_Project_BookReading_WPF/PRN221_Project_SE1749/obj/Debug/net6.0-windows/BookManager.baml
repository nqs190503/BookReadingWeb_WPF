   M S B A M L   `   `   `  ����P  LPRN221_Project_SE1749, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PRN221_Project_SE1749PRN221_Project_SE1749  5   	   '    !PRN221_Project_SE1749.BookManager   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PRN221_Project_SE1749     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ BookManager��5   	   $	��600��6   $
��1000��6*   ���	#FFB3E5FC.��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   .+�5      �� $��Book Management��6   $��24(�60   $
��Bold"�6>   $��Center=�6P   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��1.2* �6#   �� 5      $��* �6#   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $��10q�6B   .+�5      �� $��Search: ��6   $��Center=�6,   $
��Bold"�6G   $��20(�6Y   �� 5      -   5         ��Name$ 	txtSearch��5      $	��300��6-   $	��5,0q�69   �� 5      -   5        $��Search��5      $��75��6*   $	��5,0q�65   6B   5      �� 5       $��1��6   $ 
Horizontal=�6)   $��10q�6B   .+�5!      �� $��Book Approve:��6   $��Center=�61   $��0,0,5,0q�6L   $��20(�6]   �� 5"      -   5        $��	cbApprove��5"      $	��200��6,   $��30��68   $��Center=�6D   6_   5#      5$      &   System.Windows.Controls.DataGrid  5?   
   -   5          Name$ BooksDataGrid��5?      $��2��6*      AutoGenerateColumns$ False��67   $��10q�6S      Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Book ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *BookId+ �� Mode$ OneWay=�6^     5B      $	 	Create By��6%   $

 auto 6g    68   �� *User.UserName+$ OneWay=�6g     5C      $	 Title��6%   $

 auto 6[    64   �� *Title+$ OneWay=�6[     5D      $	 Author��6%   $

 auto 6a    65   �� *
AuthorName+$ OneWay=�6a   4  .System.Windows.Controls.DataGridTemplateColumn  5E      $	 Detail��6)   $
 * 69      CellTemplate 5F      �� 5G      .R�5H      �� $
��Auto=�6+   $��Disabled=�6N   $	��150��6w   .��5I   "   �� $
��Wrap=�6Q   $	��Top=�6e   ��6,   �� *Detail+$ OneWay=�6e   5J      5K      5M        5N      $	 Views��6%   $

 auto 6[    64   �� *Views+$ OneWay=�6[     5P      $	 Image��6)   $

 auto 68    5Q      �� 5R      .R�5S      �� $	��100��6H   $	��100��6T   ��6$   �� *Img+$ OneWay=�6T   5T      5V        5W      $	 PublishDate��6%   $

 auto 6�    6:   �� *PublishDate+ �� StringFormat$ 
dd/MM/yyyy��$ OneWay=�6�     5X      $	 Status��6%   $

 auto 6]    65   �� *Status+$ OneWay=�6]     5Y      $	 Approve��6%   $

 auto 6_    66   �� *	Approve+$ OneWay=�6_   5[      �� 5}   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   $��Right=�6G   .+�5~      �� -   5        $��Add Book��5~      $	��100��6(   $��30��64   $��5q�6\   ���	#FF4CAF50
�������6~   �� 5      -   5        $��Update��5      $	��100��6&   $��30��62   $��5q�6Y   ���	#FF2196F3
�������6{   �� 5�      -   5        $��Approved Book��5�      $	��100��6-   $��30��69   $��5q�6b   ���	#FFEF5350
�������6�   �� 5�      -	   5        $��Reject Book��5�      $	��100��6+   $��30��67   $��5q�6^   ���	#FFEF5350
�������6�   �� 5�      -
   5        $��
Load Books��5�      $	��100��6*   $��30��66   $��5q�6`   
����� �
�������6�   5�      �� 5�   
   $ 
Horizontal=�6   $��3��6.   $��10q�6;   $
��Left=�6G   .+�5�      �� -   5        $��Manage Accounts��5�      $	��120��6/   $��30��6;   $��5q�6j   ���	#FF2196F3
�������6�   �� 5�      -   5         ��Name$ SendFeedBackButton��5�      $��Report FeedBack��61   $	��120��6K   $��5q�6W   
���q�<�
�������$
��Bold"�6�   6�   5�      5�      5�      