   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   4    .Library_Managment.Windows.AdministratorsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  Administrators��5   	    � Icon$ ..\Images\ligicon.ico��6    $	��550��6=   $
��1000��6J    � WindowStartupLocation$ CenterScreen=�6W    � 
ResizeMode$ NoResize=�6|   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��755* �6   �� 5      $
��239* �6   .+�5   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnAddAdministrator��5      $��Add Administrator��62   $
��Left=�6N   $��	20,80,0,0q�6i    $   MaterialDesignRaisedAccentButton#���   6|   $	��Top=�6�   $	��171��6�   $��38��6�   6�   �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��
20,489,0,0q�6R   #���   6f   $	��Top=�6�   $	��171��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5        $ btnUpdateAdministrator��5      $y�Hidden=�65   $��Update Administrator��6J   $
��Left=�6i   $��	20,80,0,0q�6�   #���   6�   $	��Top=�6�   $	��171��6�   $��38��6�   6  �� 5      -   5        $ btnDeleteAdministrator��5      $y�Hidden=�65   $��Delete Administrator��6I   $
��Left=�6h   $��
20,134,0,0q�6�   #���   6�   $	��Top=�6�   $	��171��6�   $��38��6�   6  5      �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��26��6?   $��345,116,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��533��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	lblSearch��5      $��Search Administrator��6#   $
��Left=�6B   $��214,116,0,0q�6]   $��26��6r   $	��Top=�6~   $	��131��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgAdministrator��5      $
��Left=�6�   $��214,147,0,4.8q�6�   $	��765��6�   
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .  ���	#FFC5D2FF$��2��6,   �� SelectedItem 6,   �� *Administrator+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5      $	 200 6%    . $ 	Full Name��6D    6X   �� *
FullName+  5      $ * 6%    . $ Login��6A    6P   �� *Login+  5      $ * 6%    . $ Password��6A    6S   �� *
Password+  5      $ * 6%    . $ Phone Number��6A    6W   �� *PhoneNumber+  5      $ * 6%    . $ Address��6A    6R   �� *	Address+  5      $	 100 6%    . $ Gender��6C    6S   �� *Gender+5       �� 5!   
   -   5        $ 	btnSearch��5!      $��Search��6$   $
��Left=�65   $��129,116,0,0q�6P   #���   6e   $	��Top=�6�   $��95��6�   $��26��6�   ���	#FFAEEA00$��1��6�   �� 5"   
   -	   5        $ lblAdministratorFullName��5"      $��Administrator Full Name��62   $
��Left=�6T   $��	214,3,0,0q�6o   $	��Top=�6�   �� 5#   
   -
   5        $ tbAdministratorFullName��5#       �� 	MaxLength$ 50��63   $
��Left=�6B   $��26��6]   $��
214,29,0,0q�6i   $
 Wrap=�6}   $	��Top=�6�   $	��336��6�   �� 5$   
   -   5        $ lblPhoneNumber��5$      $��Phone Number��6(   $
��Left=�6?   $��
214,59,0,0q�6Z   $	��Top=�6n   �� 5%   
   -   5        $ tbPhoneNumber��5%      $ 15��6)   $
��Left=�68   $��26��6S   $��
214,85,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��213��6�   �� 5&   
   -   5        $ 
lblAddress��5&      $��Adress��6$   $
��Left=�65   $��
432,58,0,0q�6P   $	��Top=�6d   �� 5'   
   -   5        $ 	tbAddress��5'      $
��Left=�6%   $ 50��6@   $��26��6O   $��
432,85,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��547��6�   $��2��6�   �� 5(   
   -   5        $ lblAdministratorLogin��5(      $��Administrator Login��6/   $
��Left=�6M   $��
555,-2,0,0q�6h   $	��Top=�6|   �� 5)   
   -   5        $ tbAdministratorLogin��5)      $ 20��60   $
��Left=�6?   $��26��6Z   $��
555,29,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��200��6�   �� 5*   
   -   5        $ lblAdministratorPassword��5*      $��Administrator Password��62   $
��Left=�6S   $��5,3,0,0q�6n   $	��Top=�6   $��1��6�   G� 5+   
   -   5         G�Name$ tbAdministratorPassword��5+       G� 	MaxLength$ 20��67   $
��Left=�6F   $��26��6a   $��
4.6,29,0,0q�6m   $	��Top=�6�   $	��219��6�   $��1��6�   5.      5/      