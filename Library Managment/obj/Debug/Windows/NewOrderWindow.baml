   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   (    "Library_Managment.Windows.NewOrder   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   -   5          �Name$  NewOrderWindow��5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5	   	   $��14(�5
   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	    � Title$ 	New Order��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��68   $
��1000��6E    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w   .��5      � $
��Left=�6   .+�5   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ btnSelectCustomer��5      $��Select Customer��60   $
��Left=�6J   $��	23,80,0,0q�6e    $  MaterialDesignRaisedAccentButton#���  6x   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnSelectBooks��5      $��Select Books��6-   $
��Left=�6D   $��
23,150,0,0q�6_   #���  6s   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnSaveOrder��5      $��
Save Order��6+   $
��Left=�6@   $��
24,436,0,0q�6[   #���  6o   $	��Top=�6�   $	��142��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5         ��Name$ lblOrderSummary��5      $��Order Summary��6-   $
��Left=�6E   $��
23,381,0,0q�6`   $	��Top=�6t   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lblPrice��5      $��0��6&   $
��Left=�62   $��140,381,0,0q�6M   $	��Top=�6b   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lblBookCountsSum��5      $��
Book Count��6.   $
��Left=�6C   $��
24,354,0,0q�6^   $	��Top=�6r   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -   5        $ lblBookCount��5      $��0��6*   $
��Left=�66   $��140,354,0,0q�6Q   $	��Top=�6f   ���	#FFAEEA00���	#FFAEEA006�   �� 5      -	   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��
23,502,0,0q�6R   #���  6f   $	��Top=�6�   $	��142��6�   $��38��6�   ���	#FFAEEA006�   5      �� 5   
   -
   5         ��Name$ tbCustomerName��5      $��Center=�6*   $��26��6G   $��395,37,214,0q�6S    �� TextWrapping$
 Wrap=�6i   	 �� 
IsReadOnly	 . $	��Top=�6�   $	��375��6�   $��Center=�6�   �� 5   
   -   5        $ lblCustomerName��5      $��Customer Name��6)   $
��Left=�6A   $��
515,10,0,0q�6\   $	��Top=�6p   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dgCustomerSelectedBook��5      $
��Left=�6Y   $��214,120,0,9.8q�6t   $	��770��6�      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  ���	#FFC5D2FF �� SelectedItem 63   �� *SelectedBook+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5      $ * 6%    . $
 Name��6A    6P   �� *Name+  5      $ * 6%    . $ Hidden=�6A   $ Taking Date��6U    6j   �� *
TakingDate+  5       $	 200 6%    . $ Return Date��6C    6X   �� *
ReturnDate+  5!      $	 100 6%    . $ 
BooksCount��6C    6W   �� *
BooksCount+  5"      $	 100 6%    . $ Price��6C    6R   �� *	CalcPrice+5$      �� 5%   
   -   5        $ lblBooks��5%      $0��*Books Name , Return Date , Count and Price��6"   $
��Left=�6W   $��
214,84,0,0q�6r   $	��Top=�6�   $	��665��6�   5'      5(      