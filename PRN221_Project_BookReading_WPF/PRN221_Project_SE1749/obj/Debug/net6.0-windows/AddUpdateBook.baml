   M S B A M L   `   `   `  ����P  LPRN221_Project_SE1749, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PRN221_Project_SE1749PRN221_Project_SE1749  5   	   )    #PRN221_Project_SE1749.AddUpdateBook   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PRN221_Project_SE1749     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ AddUpdateBook��5   	   $	��550��6   $	��550��6,   ���	#FFB3E5FC.��5	      � $��0,0,10,0q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��20,20,20,20q�6,   .+�5      �� $"��Add/Update Book Information:��6   $
��Bold"�6<   $��18(�6N   $��0,0,0,10q�6\   �� 5      $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5      �� $��Title:��6   $��Center=�6*   $��16(�6E   $��0,0,63,0q�6S   �� 5      -   5         ��Name$ txtTitle��5      $	��350��6,   $��30��68   $��16(�6D   5      �� 5      $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5      �� $��Author:��6   $��Center=�6+   $��16(�6F   $��0,0,45,0q�6T   �� 5      -   5        $ 	txtAuthor��5      $	��350��6-   $��30��69   $��16(�6E   5      �� 5      $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5      �� $��Detail:��6   $��Center=�6+   $��16(�6F   $��0,0,53,0q�6T   �� 5      -   5        $ 	txtDetail��5      $	��400��6-   $	��171��69   $��14(�6F    �� AcceptsReturn$
 True��6T    �� TextWrapping$
 Wrap=�6i   " �� VerticalScrollBarVisibility$
 Auto=�6}   5      �� 5      $ 
Horizontal=�6   $��0,0,0,15q�62   .+�5       �� $��Image(Link):��6   $��Center=�60   $��16(�6K   $��0,0,10,0q�6Y   �� 5!      -   5        $ txtImage��5!      $	��350��6,   $��30��68   $��16(�6D   5"      �� 5$      $ 
Horizontal=�6   .+�5%      �� $��Status:��6   $��Center=�6+   $��16(�6F   $��0,0,50,0q�6T   �� 5&      -   5         ��Name$ cbStatus��5&      $	��250��6-   $��30��69   $��16(�6E   5'      5-      �� 5/   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�50      �� -   5        $
��Save��50      $	��100��6$   $��40��60   $��16(�6<   $��10q�6c   �� 51      -   5        $��Cancel��51      $	��100��6&   $��40��62   $��16(�6>   $��10q�6g   52      53      54      