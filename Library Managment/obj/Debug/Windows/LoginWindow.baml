   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Library_ManagmentLibrary_Managment  5   	   "    Library_Managment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   +localclr-namespace:Library_Managment  5   	   -   5          �Name$  LoginWindow��5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5	   	   $��Medium"�5
   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	    � Title$ Library Managment��5   	    � Icon$ ..\Images\ligicon.ico��6#   $	��400��6@   $	��300��6M    � WindowStartupLocation$ CenterScreen=�6Y    � 
ResizeMode$ NoResize=�6~   .��5      � .+�5   
   �� -   5         ��Name$ btnLogin��5      $��Login��6#   $��106,0,106,70q�63    $  MaterialDesignRaisedAccentButton#���  6I   $��32��6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ tbLogin��5      $��26��6#   $��66,139,66,0q�6/    �� TextWrapping$
 Wrap=�6D   $	��Top=�6X   G� 5   
   -   5         G�Name$ 
tbPassword��5      $��66,195,66,0q�6*   $	��Top=�6?   �� 5   
   -   5        	 ��Name$	 lblLogin��5      $��Login��6"   $��121,112,121,0q�62   $	��Top=�6I   
 J� RenderTransformOrigin$
 1.014,1.325&�6a   $��50��6�   �� 5   
   -   5        $	 lblPassword��5      $��Password��6%   $��109,168,109,0q�68   $	��Top=�6O   $
 -0.064,0.497&�6g   $��74��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $	��100��6:   $��	92,10,0,0q�6G   $	��Top=�6Z   $	��100��6r   '  !MaterialDesignThemes.Wpf.PackIcon  5   
   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircleOutline=�6"   $��101,10,101,0q�6>   $��90��6T   $
��Auto��6`   $
 0.488,0.123&�6m   $��Stretch=�6�   G� 5   
   -   5        $ passwordBox��5      $
��Left=�6+   $��
-83,-5,0,0q�6F   $	��Top=�6Z   5      5      