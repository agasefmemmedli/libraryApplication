   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   +    %Library_Managment.Windows.BooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	     � Title$  BooksWindow��5   	    � Icon$ ..\Images\ligicon.ico��6   $	��550��6:   $
��1000��6G    � WindowStartupLocation$ CenterScreen=�6T    � 
ResizeMode$ NoResize=�6y   .��5	      �  J� RenderTransformOrigin$ 0.498,0.528&�6   .+�5
   
   � $
��Left=�6   $	��209��6*   $	��550��66   $��Bottom=�6C   $��0,-29,0,-0.2q�6^   ���	#FF5426A6.+�5      �� -   5         ��Name$ 
btnAddBook��5      $��Add Book��6)   $
��Left=�6<   $��	38,80,0,0q�6W    $   MaterialDesignRaisedAccentButton#���   6j   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnClose��5      $��Close��6'   $
��Left=�67   $��
38,489,0,0q�6R   #���   6f   $	��Top=�6�   $	��142��6�   $��38��6�   ���	#FFAEEA006�   �� 5      -   5        $ btnUpdateBook��5      $y�Hidden=�6,   $��Update Book��6@   $
��Left=�6V   $��	38,80,0,0q�6q   #���   6�   $	��Top=�6�   $	��142��6�   $��38��6�   6�   �� 5      -   5        $ btnDeleteBook��5      $y�Hidden=�6,   $��Delete Book��6@   $
��Left=�6V   $��
38,123,0,0q�6q   #���   6�   $	��Top=�6�   $	��142��6�   $��38��6�   6�   5      �� 5   
   -   5         ��Name$ tbSearch��5      $
��Left=�6$   $��26��6?   $��
301,76,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��549��6�   �� 5   
   -   5         ��Name$ lblSearchBook��5      $��Search Book��6'   $
��Left=�6=   $��
214,75,0,0q�6X   $	��Top=�6l   $��82��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgBooks��5      
   AutoGenerateColumns
 .    CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .  $
��Left=�6�   $��214,107,0,4.8q�6�   $	��765��6  ���	#FFC5D2FF �� SelectedItem 6$   �� *Book+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    Header$ Id��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Id+  5      $	 300 6%    . $
 Name��6C    6R   �� *Name+  5      $ * 6%    . $ Author��6A    6Q   �� *Author+  5      $ * 6%    . $ Count��6A    6P   �� *
CountNow+  5      $	 100 6%    . $ Hidden=�6C   $ Count��6W    6f   �� *Count+  5      $	 100 6%    . $ Price��6C    6R   �� *Price+5      �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��
867,75,0,0q�6P   #���   6d   $	��Top=�6�   $��99��6�   $��26��6�   ���	#FFAEEA00$ 0.354,0.423&�6�   6
  �� 5   
   -	   5        $ lblBookName��5      $��	Book Name��6%   $
��Left=�69   $��
214,10,0,0q�6T   $	��Top=�6h   �� 5   
   -
   5        $ 
tbBookName��5      $
��Left=�6&   $��26��6A   $��
214,36,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��273��6�   �� 5   
   -   5        $ lblAuthorName��5      $��Author Name��6'   $
��Left=�6=   $��
495,10,0,0q�6X   $	��Top=�6l   �� 5    
   -   5        $ tbAuthorName��5       $
��Left=�6(   $��26��6C   $��
495,36,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��250��6�   �� 5!   
   -   5        $ lblBookCount��5!      $��
Book Count��6&   $
��Left=�6;   $��	750,8,0,0q�6V   $	��Top=�6i   $��81��6�   �� 5"   
   -   5        $ tbBookCount��5"      $
��Left=�6'   $��26��6B   $��
750,36,0,0q�6N   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   �� 5#   
   -   5        $ lblPrice��5#      $��Price��6"   $
��Left=�62   $��	850,8,0,0q�6M   $	��Top=�6`   $ 	0.444,0.5&�6x   �� 5$   
   -   5        $ tbPrice��5$      $
��Left=�6#   $��26��6>   $��
850,36,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��116��6�   5'      5(      