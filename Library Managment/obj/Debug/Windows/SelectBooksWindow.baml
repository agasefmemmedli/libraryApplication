   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   1    +Library_Managment.Windows.SelectBooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  Select Books��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��6;   $	��920��6H    � WindowStartupLocation$ CenterScreen=�6T    � 
ResizeMode$ NoResize=�6y   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��397* �6   .+�5   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6$��2��6�   .+�5      �� -   5         ��Name$ lblSelectsCustomer��5      $��Click to select the book��60   $
��Left=�6S   $��
38,134,0,0q�6n   $	��Top=�6�   ���	#FFAEEA00���	#FFAEEA00$��Center=�6�   �� 5      -   5         ��Name$ btnSelectBooks��5      $y�Hidden=�6-   $��Select This Books��6A   $
��Left=�6]   $��
31,426,0,0q�6x    $   MaterialDesignRaisedAccentButton#���   6�   $	��Top=�6�   $	��150��6�   $��38��6�   ���	#FFAEEA006  �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��31,487,0,25q�6R   #���   6g   $	��150��6�   $��38��6�   ���	#FFAEEA006�   5      �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��
179,75,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6h   $	��506��6�   $��26��6�   $��1��6�   �� 5   
   -   5        $ lblCustomerSearch��5      $��Books Search��6+   $
��Left=�6B   $��	94,75,0,0q�6]   $	��Top=�6p   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgBooks��5      $
��Left=�6o   $��94,106,0,9.8q�6�   $	��690��6�   
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .  ���	#FFC5D2FF$��1��6   �� SelectedItem 6$   �� *Book+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67      Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5       . $ * 67   $
 Name��6A    6P   �� *Name+  5       . $	 150 67   $ Author��6C    6S   �� *Author+  5       . $	 100 67   $ Count��6C   $ Hidden=�6R    6f   �� *Count+  5       . $	 100 67   $ Count��6C    6R   �� *
CountNow+  5       . $	 100 67   $ Price��6C    6R   �� *Price+5      �� 5   
   -   5        $ btnSearchBooks��5      $��Search��6)   $
��Left=�6:   $��
699,75,0,0q�6U   #���   6i   $	��Top=�6�   $��85��6�   $��26��6�   ���	#FFAEEA00 J� RenderTransformOrigin$ -0.185,0.469&�6�   $��1��6  6   �� 5    
   -   5        $ 
tbBookName��5       $��Center=�6&   $��26��6C   $��94,36,429.6,0q�6O   $
 Wrap=�6f    �� 
IsReadOnly . $	��Top=�6�   $	��270��6�   $��Center=�6�   $��1��6�   �� 5!   
   -	   5        $ lblSelectedBookName��5!      $��Selected Book Name��6-   $
��Left=�6J   $��	94,10,0,0q�6e   $	��Top=�6x   $	��121��6�   $��1��6�   �� 5"   
   -
   5         ��Name$ cmbBookCount��5"      $
��Left=�6)   $��
391,36,0,0q�6D   $	��Top=�6X   $	��120��6p   $��25��6|   $��Center=�6�   $��1��6�   �� 5#   
   -   5        $ lblSelectBookCount��5#      $��Select Book Count��6,   $
��Left=�6H   $	��Top=�6d   $	��110��6|   $��
387,10,0,0q�6�   $��1��6�   �� 5$   
   -   5        $ lblSelectReturnDate��5$      $��Select Return Date��6-   $
��Left=�6J   $��
538,10,0,0q�6e   $	��Top=�6y   $	��110��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ dpReturnDate��5%      $
��Left=�6+   $��
545,37,0,0q�6}   $	��Top=�6�      SelectedDateFormat$ Short=�6�   $��92��6�   $��Stretch=�6�   $��1��6�   �� 5&   
   -   5        $ lblBookPrice��5&      $��
Book Price��6&   $
��Left=�6;   $	��Top=�6W   $��71��6o   $��	670,5,0,0q�6z   $��1��6�   �� 5'   
   -   5        $ lblBookPriceCount��5'      $��100.55��6+   $
��Left=�6<   $	��Top=�6X   $��85��6p   $��
670,36,0,0q�6{   $��1��6�   5*      5+      