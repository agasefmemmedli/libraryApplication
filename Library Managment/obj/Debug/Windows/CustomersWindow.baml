   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   /    )Library_Managment.Windows.CustomersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  	Customers��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��68   $
��1000��6E    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w   .��5	      � .+�5
   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnAddCustomer��5      $��Add Customer��6-   $
��Left=�6D   $��	28,80,0,0q�6_    $   MaterialDesignRaisedAccentButton#���   6r   $	��Top=�6�   $	��152��6�   $��38��6�   6�   �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��
28,489,0,0q�6R   #���   6f   $	��Top=�6�   $	��152��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5        $ btnUpdateCustomer��5      $y�Hidden=�60   $��Update Customer��6D   $
��Left=�6^   $��	28,80,0,0q�6y   #���   6�   $	��Top=�6�   $	��152��6�   $��38��6�   6�   �� 5      -   5        $ btnDeleteCustomer��5      $y�Hidden=�60   $��Delete Customer��6D   $
��Left=�6^   $��
28,123,0,0q�6y   #���   6�   $	��Top=�6�   $	��152��6�   $��38��6�   6�   5      �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��26��6?   $��
319,75,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��560��6�   �� 5   
   -   5         ��Name$ 	lblSearch��5      $��Search Customer��6#   $
��Left=�6=   $��
214,75,0,0q�6X   $	��Top=�6l   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCustomers��5      $
��Left=�6{   $��214,106,0,4.8q�6�   $	��765��6�   ���	#FFC5D2FF	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     CanUserReorderColumns .   �� SelectedItem 6(   �� *
Customer+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5      $	 300 6%    . $ 	Full Name��6C    6W   �� *
FullName+  5      $ * 6%    . $ Phone Number��6A    6W   �� *PhoneNumber+  5      $ * 6%    . $ Address��6A    6R   �� *	Address+  5      $	 100 6%    . $ Gender��6C    6S   �� *Gender+5      �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��
884,75,0,0q�6P   #���   6d   $	��Top=�6�   $��95��6�   $��26��6�   ���	#FFAEEA006�   �� 5   
   -	   5        $ lblCustomerFullName��5      $��Customer Full Name��6-   $
��Left=�6J   $��	214,8,0,0q�6e   $	��Top=�6x   �� 5   
   -
   5        $ tbCustomerFullName��5      $
��Left=�6.   $��26��6I   $��
214,34,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��270��6�   �� 5   
   -   5        $ lblPhoneNumber��5      $��Phone Number��6(   $
��Left=�6?   $��	500,8,0,0q�6Z   $	��Top=�6m   �� 5   
   -   5        $ tbPhoneNumber��5      $
��Left=�6)   $��26��6D   $��
500,34,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��200��6�   �� 5    
   -   5        $ 
lblAddress��5       $��Address��6$   $
��Left=�66   $��	714,7,0,0q�6Q   $	��Top=�6d   �� 5!   
   -   5        $ 	tbAddress��5!      $
��Left=�6%   $��26��6@   $��
714,34,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��270��6�   5%      5&      