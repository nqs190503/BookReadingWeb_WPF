   M S B A M L   `   `   `  ����  PRN221_Project_SE1749,    &PRN221_Project_SE1749.ResponseFeedBack   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Response Feedback��5   	   $	��600��6#   $	��900��60    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $"��Response Feedback Management��6!   $��24(�6E   $
��Bold"�6S   $��Center=�6e   $��10q�6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��
10,10,10,5q�6X   .+�5      �� $��Search:��6   $��Center=�6'   $��0,0,5,0q�6B   �� 5      -   5         ��Name$ txtSearchResponse��5      $	��300��61   $��30��6=   $��Center=�6I   �� 5      -   5        $��Search��5      $��80��6&   $��30��61   $��10,0,0,0q�6=   6O   5      � 5   
   $��2��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��2* �6#   .+�5$      &   System.Windows.Controls.DataGrid  -   5          Name$ dgResponseList��5$         AutoGenerateColumns$ False��6/      
IsReadOnly$
 True��6K   	   SelectionMode$	 Single=�6]   $��0��5%      
   Columns
 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ 
ResponseId��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
ResponseId+6\     5(      $
 User��6)   $
 auto 6Y    67   �� *User.UserName+6Y     5)      $ 	Book Name��6)   $
 auto 6b    6<   �� *Report.Book.Title+6b     5*      $ Chapter��6)   $
 auto 6]    6:   �� *Report.Chapter+6]     5+      $ Feedback Content��6)   $
 auto 6|    6C   �� *&$Report.ProblemNavigation.ReportType1+6|     5,      $ Response Detail��6)   $
 auto 6]    6B   �� *Detail+6]     5-      $ Response Time��6)   $
 auto 6a    6@   �� *ResponseTime+6a   5/      5D      �� 5G   
   $��3��6   $ 
Horizontal=�6"   $
��Left=�6;   $��10q�6V   .+�5H      �� -   5        $��Manage Accounts��5H      $	��120��6/   $��30��6;   $��5q�6j   ���	#FF2196F3
�������6�   �� 5I      -   5        $��Manage Books��5I      $	��120��6,   $��30��68   $��5q�6d   ���	#FF2196F3
�������6�   �� 5J      -   5         ��Name$ SendFeedBackButton��5J      $��Report FeedBack��61   $	��120��6K   $��5q�6W   
���q�<�
�������$
��Bold"�6�   6�   5K      5L      5M      