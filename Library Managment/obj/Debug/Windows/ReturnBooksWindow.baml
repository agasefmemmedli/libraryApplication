   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   1    +Library_Managment.Windows.ReturnBooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  Return Books��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��6;   $	��920��6H    � WindowStartupLocation$ CenterScreen=�6T    � 
ResizeMode$ NoResize=�6y   .��5	      � .+�5
   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnSelectCustomer��5      $��Select Customer��60   $
��Left=�6J   $��	38,80,0,0q�6e    $   MaterialDesignRaisedAccentButton#���   6x   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnReturnBook��5      $��Return Book��6,   $
��Left=�6B   $��
38,426,0,0q�6]   #���   6q   $	��Top=�6�   $	��142��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5         ��Name$ lblOrderSummary��5      $��Order Summary��6-   $
��Left=�6E   $��
38,386,0,0q�6`   $	��Top=�6t   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lblOrderSummaryCount��5      $��0��62   $
��Left=�6>   $��146,386,0,0q�6Y   $	��Top=�6n   ���	#FFAEEA00���	#FFAEEA00$��53��6�   �� 5      -   5        $ lblDelay��5      $��Delay ��6&   $
��Left=�67   $��
38,357,0,0q�6R   $	��Top=�6f   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lbldelayCount��5      $��0��6+   $
��Left=�67   $��146,356,0,0q�6R   $	��Top=�6g   ���	#FFAEEA00���	#FFAEEA00$��53��6�   �� 5      -   5        $ lblBookPrice��5      $��
Book Price��6*   $
��Left=�6?   $��
38,325,0,0q�6Z   $	��Top=�6n   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lblBookPriceCount��5      $��0��6/   $
��Left=�6;   $��146,325,0,0q�6V   $	��Top=�6k   ���	#FFAEEA00���	#FFAEEA00 J� RenderTransformOrigin$ 0.262,0.531&�6�   $��53��6�   �� 5      -	   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��38,494,0,21q�6R   #���   6g   $	��142��6�   $
��Auto��6�   ���	#FFAEEA006�   5      �� 5   
   -
   5         ��Name$ tbCustomerName��5      $��Center=�6*   $��26��6G   $��431,27,222.6,0q�6S    �� TextWrapping$
 Wrap=�6k   	 �� 
IsReadOnly	 . $	��Top=�6�   $	��260��6�   $��Center=�6�   �� 5   
   -   5        $ lblCustomerName��5      $��Customer Name��6)   $
��Left=�6A   $��	511,1,0,0q�6\   $	��Top=�6o   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dgCustomerReturnBook��5         CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  $
��Left=�6�   $��214,317,0,6.8q�6�   $	��690��6�   ���	#FFC5D2FF �� SelectedItem 6b   �� *ReturnRentedBookList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5      $ * 6%    . $
 Name��6A    6P   �� *
BookName+  5      $ * 6%    . $ Return Date��6A    6V   �� *
ReturnDate+  5      $	 100 6%    . $ Count��6C    6R   �� *Count+  5      $	 120 6%    . $ New Calc Price��6C    6[   �� *	CalcPrice+  5      $	 100 6%    . $ 
Full Price��6C    6W   �� *Price+5         5!   
   -   5        $
 dgCustomerTackedBook��5!       .   .   .  $
��Left=�6�   $��214,95,0,235.8q�6  $	��690��6  ���	#FFC5D2FF 6j   �� *ReturnRentedBookList+ 5"        5#      $ * 6%    . $ Id��6A    6N   �� *Id+  5$      $ * 6%    . $
 Name��6A    6P   �� *
BookName+  5%      $ * 6%    . $ Return Date��6A    6V   �� *
ReturnDate+  5&      $	 100 6%    . $ Count��6C    6R   �� *Count+  5'      $	 120 6%    . $ 
Calc Price��6C    6W   �� *	CalcPrice+  5(      $	 100 6%    . $ 
Full Price��6C    6W   �� *Price+5*      �� 5+   
   -   5        $ lblRentedBooks��5+      $7��1Rented Books Name , Return Date , Count and Price��6(   $
��Left=�6d   $��
400,69,0,0q�6   $	��Top=�6�   $ 0.521,-0.008&�6�   $	��325��6�   �� 5,   
   -   5        $ lblReturnNow��5,      $��
Return Now��6&   $
��Left=�6;   $��525,288,0,0q�6V   $	��Top=�6k   $��29��6�   5/      50      