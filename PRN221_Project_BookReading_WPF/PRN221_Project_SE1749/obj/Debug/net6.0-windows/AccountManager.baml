   M S B A M L   `   `   `  ����P  LPRN221_Project_SE1749, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PRN221_Project_SE1749PRN221_Project_SE1749  5   	   *    $PRN221_Project_SE1749.AccountManager   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PRN221_Project_SE1749     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ AccountManager��5   	   $	��450��6    $	��800��6-   
�������.��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0,0,0,10q�6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��* �6#   .+�5      �� $��	Username:��6   $	��Top=�6(   $
��Bold"�6@   $��0,2,0,0q�6R   �� 5      -   5         ��Name$ txtUsername��5      ${�False��6+   $	��Top=�6=   $��
117,6,10,0q�6U   ���	#FFEFEFEF
���   �
�������$��1q�6�   �� 5      $��Email:��6   $	��Top=�6%   $��0,24,0,0q�6=   $
��Bold"�6O   �� 5      -   5        $ txtEmail��5      ${�False��6(   $	��Top=�6:   $��117,28,10,0q�6R   ���	#FFEFEFEF
���   �6~   �� 5      $��
Role Name:��6   $	��Top=�6)   $��0,50,0,0q�6A   $
��Bold"�6S   �� 5      -   5         ��Name$ cbxRoleName��5      $	��Top=�6,   $��117,52,10,0q�6D   ���	#FFEFEFEF
���   �
�������$��1q�6�   �� 5      $��Active:��6   $	��Top=�6&   $��0,79,0,0q�6>   $
��Bold"�6P   �� 5      -   5        $ 	cbxActive��5      $	��Top=�6*   $��117,79,10,0q�6B   ���	#FFEFEFEF
���   �
�������$��1q�6�   � 5       $��1��6   .+�5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $��Search:��6   $��Center=�6.   $
��Bold"�6I   $��0,2,0,0q�6[   �� 5#      -   5        $ 	txtSearch��5#      $��Center=�61   ���	#FFEFEFEF
���   �
�������$	��220��6�   �� 5$      -   5         ��Name$ SearchButton��5$      $��Center=�63   $��Search��6N   
���Gc��
�������$
��Bold"�6�   $��10,0,0,0q�6�   $	��100��6�   5%      5&      5'      � 5(   
   $��1��6   .+�5)      �� $ 
Horizontal=�6   $��Center=�62   .+�5*      �� -   5        $ UpdateButton��5*      $��Update Account��6/   $	��120��6H   $��5q�6T   
�����F�
�������$
��Bold"�6�   6�   �� 5+      -   5        $ LoadAccountButton��5+      $��Load Account��64   $	��120��6K   $��5q�6W   
���**��
�������$
��Bold"�6�   6�   �� 5,      -	   5        $ BookManagerButton��5,      $��Book Manager��64   $	��120��6K   $��5q�6W   
���q�<�
�������$
��Bold"�6�   6�   �� 5-      -
   5        $ SendFeedBackButton��5-      $��Report FeedBack��65   $	��120��6O   $��5q�6[   
���q�<�
�������$
��Bold"�6�   6�   5.      5/      �� 53   
   -   5         ��Name$ 	lvDisplay��53      $��2��6&   $��	0,10,0,20q�6Z   	 �� View	 54      �� 55      .P�56      �� $��User ID��6%   
 �� Width$

 auto��66    �� DisplayMemberBinding 6C   �� *UserId+ �� Mode$ OneWay=��� 57      $��Username��6%   $

 auto��67    6D   �� *
UserName+$ OneWay=��� 58      $��Email��6%   $

 auto��64    6A   �� *Email+$ OneWay=��� 59      $��Address��6%   $

 auto��66    6C   �� *	Address+$ OneWay=��� 5:      $��Phone��6%   $

 auto��64    6A   �� *Phone+$ OneWay=��� 5;      $��	Role Name��6%   $
 70��68    6C   �� *Role.RoleName+$ OneWay=��� 5<      $��Active��6%   $
 50��65    6@   �� *Active+$ OneWay=�5=      5?      5K      5L      