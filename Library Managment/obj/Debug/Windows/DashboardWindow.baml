   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   /    )Library_Managment.Windows.DashboardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   -   5          �Name$  	Dashboard��5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5	   	   $��14(�5
   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	    � Title$ 	Dashboard��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��68   $
��1000��6E    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w   .��5      � .+�5   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnNewOrder��5      $��
New Orders��6*   $
��Left=�6?   $��	39,61,0,0q�6Z    $  MaterialDesignRaisedAccentButton#���  6m   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ btnReturnBook��5      $��Return Book��6,   $
��Left=�6B   $��
39,131,0,0q�6]   #���  6q   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ btnBooks��5      $��Books��6'   $
��Left=�67   $��
39,201,0,0q�6R   #���  6f   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ btnCustomers��5      $��	Customers��6+   $
��Left=�6?   $��
39,341,0,0q�6Z   #���  6n   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ btnAdmin��5      $��Administrators��6'   $
��Left=�6@   $��
39,271,0,0q�6[   #���  6o   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ 
btnReports��5      $��Reports��6)   $
��Left=�6;   $��
39,411,0,0q�6V   #���  6j   $	��Top=�6�   $	��131��6�   $��38��6�   6�   �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��39,481,0,31q�6R   #���  6g   $	��131��6�   $
��Auto��6�   ���	#FFAEEA006�   5      �� 5   
   -	   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��511��6D   $��	214,0,0,0q�6Q   $	��Top=�6d   $	��770��6|   .@�5      �� -
   5         ��Name$ tabToday��5      $��Return Today��6(   ���	#FFAEEA00
���   ����	#FF673AB7 �� 
IsSelected . .��5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dgToday��5      $��0,0,-5,-5.6q�6Y     MaterialDesignDataGrid#���  6n   
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .  ���	#FFC5D2FF �� SelectedItem 6,   �� *ReturnDashboardList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      
IsReadOnly .    Header$ Id��6I      
Visibility$ Hidden=�6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6i   �� *Id+  5      $ * 6-    . $ Customer FullName��6I    6e   �� *CustomerFullName+  5      $ * 6-    . $ Phone Number��6I    6_   �� *PhoneNumber+  5      $	 150 6-    . $ Books Count��6K    6`   �� *
BooksCount+5!      5"      �� 5#      -   5        $ tabTomorrow��5#      $��Return Tomorrow��6+   ���	#FF673AB7
���   ����	#FFAEEA00.��5$        -   5        $	 
dgTomorrow��5$      $��0,0,-5,-5.6q�6/   #���  6q   
 .   .   .  ���	#FFC5D2FF 6D   �� *ReturnDashboardList+ 5%        5&      $ * 6-    . $ Id��6I   $ Hidden=�6U    6i   �� *Id+  5'      $ * 6-    . $ Customer FullName��6I    6e   �� *CustomerFullName+  5(      $ * 6-    . $ Phone Number��6I    6_   �� *PhoneNumber+  5)      $	 150 6-    . $ Books Count��6K    6`   �� *
BooksCount+5+      5,      �� 5-      -   5        $ tabDelay��5-      $��Delay��6(   $
��Left=�67   $��22��6R   $	��Top=�6^   $��54��6v   ���	#FF673AB7
���   �$��
-2.2,0,0,0q�6�    J� RenderTransformOrigin$ 0.707,0.609&�6�   ���	#FFAEEA00.��5.        -   5        $	 dgDelay��5.      $��0,0,-5,-5.6q�6,   #���  6n   
 .   .   .  ���	#FFC5D2FF 6A   �� *ReturnDashboardList+ 5/        50      $ * 6-    . $ Id��6I   $ Hidden=�6U    6i   �� *Id+  51      $ * 6-    . $ Customer FullName��6I    6e   �� *CustomerFullName+  52      $ * 6-    . $ Phone Number��6I    6_   �� *PhoneNumber+  53      $	 150 6-    . $ Books Count��6K    6`   �� *
BooksCount+55      56      57      59      5:      