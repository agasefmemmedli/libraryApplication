   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   4    .Library_Managment.Windows.SelectCustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  Select Customer��5   	    � Icon$ ..\Images\ligicon.ico��6"   $	��550��6?   $	��920��6L    � WindowStartupLocation$ CenterScreen=�6X    � 
ResizeMode$ NoResize=�6}   .��5	      � .+�5
   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnSelectCustomer��5      $��Select This Customer��60   $y�Hidden=�6P   $
��Left=�6d   $��
21,421,0,0q�6    $   MaterialDesignRaisedAccentButton#���   6�   $	��Top=�6�   $	��170��6�   $��38��6�   ���	#FFAEEA006  �� 5      -   5         ��Name$ lblSelectsCustomer��5      $��Selected Customer��60   $
��Left=�6L   $��
51,344,0,0q�6g   $	��Top=�6{   ���	#FFAEEA00���	#FFAEEA00$��Center=�6�   �� 5      -   5        $ lblCustomerFullName��5      $
��None��61   $
��Left=�6@   $��
21,366,0,0q�6[   $	��Top=�6o   ���	#FFAEEA00���	#FFAEEA00 J� RenderTransformOrigin$ -1.125,0.578&�6�   $��31��6�   $	��170��6�   $��14(�6�   $��Center=�6  �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��21,490,0,22q�6R   #���   6g   $	��170��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5        $ 
lblComment��5      $"��Click to select the Customer��6(   $��Center=�6O   $��21,129,18,0q�6l   $	��Top=�6�   ���	#FFAEEA00���	#FFAEEA00$��Center=�6�   $	��170��6�   5      �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��
315,10,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6h   $	��465��6�   $��26��6�   �� 5   
   -   5        $ lblCustomerSearch��5      $��Customer Search��6+   $
��Left=�6E   $��
215,10,0,0q�6`   $	��Top=�6t   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgCustomers��5      $
��Left=�6{   
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .  $��214,41,0,4.8q�6�   $	��681��6�   ���	#FFC5D2FF �� SelectedItem 6(   �� *
Customer+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67      Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5       . $ * 67   $ 	Full Name��6A    6U   �� *
FullName+  5       . $	 100 68   $ Phone Number��6D    6Z   �� *PhoneNumber+  5       . $	 100 68   $ Address��6D    6U   �� *	Address+5      �� 5   
   -	   5        $ btnSaveOrder_Copy��5      $��Search��6,   $
��Left=�6=   $��
785,10,0,0q�6X   #���   6l   $	��Top=�6�   $	��110��6�   $��26��6�   ���	#FFAEEA006�   5      5      