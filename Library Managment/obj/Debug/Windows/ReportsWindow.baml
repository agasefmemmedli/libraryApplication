   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   -    'Library_Managment.Windows.ReportsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  Reports��5   	   $	��550��6    � Icon$ ..\Images\ligicon.ico��6'   $
��1000��6D    � WindowStartupLocation$ CenterScreen=�6Q    � 
ResizeMode$ NoResize=�6v   .��5	      � .+�5
   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnExportToExcell��5      $��Export To Excell��60   $
��Left=�6K   $��	38,80,0,0q�6f    $   MaterialDesignRaisedAccentButton#���   6y   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��
38,489,0,0q�6R   #���   6f   $	��Top=�6�   $	��142��6�   $��38��6�   ���	#FFAEEA006�   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFrom��5      $
��Left=�6%   $��
432,10,0,0q�6@   $	��Top=�6�      SelectedDateFormat$ Short=�6�   $��99��6�     5   
   -   5        $
 dpTo��5      $
��Left=�6#   $��
546,10,0,0q�6>   $	��Top=�6�   $ Short=�6�   $��99��6�   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��
700,10,0,0q�6P   #���   6d   $	��Top=�6�   $��85��6�   $��26��6�   ���	#FFAEEA00 J� RenderTransformOrigin$ -0.185,0.469&�6�   6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgReports��5      $
��Left=�6&   $��
214,50,0,5q�6A   	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     CanUserReorderColumns .  $	��775��6�   ���	#FFC5D2FF   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Id��67      
Visibility$ Hidden=�6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   �� *Id+  5         Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6%    . $ Customer��6C    6U   �� *CustomerFullName+  5      $ * 6%    . $
 Book��6A    6O   �� *
BookName+  5      $ 85 6%    . $ Taking Date��6B    6W   �� *
TakingDate+  5      $ 85 6%    . $ Return Date��6B    6W   �� *
ReturnDate+  5      $ 85 6%    . $ Price��6B    6Q   �� *Price+5      5      5      