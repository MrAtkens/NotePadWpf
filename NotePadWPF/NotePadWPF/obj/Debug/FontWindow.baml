   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Media;assembly=PresentationCoreSystem.Windows.Media  5      I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      E ANotePadWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:NotePadWPF
NotePadWPF 5	   	      NotePadWPF.FontWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   Nmedia<clr-namespace:System.Windows.Media;assembly=PresentationCore      5      Fwin6clr-namespace:System.Windows;assembly=PresentationCore      5      6sys&clr-namespace:System;assembly=mscorlib      5      *localclr-namespace:NotePadWPF      5	   	     � Title$  
FontWindow��5   	   $	��300��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         FontFamilyOptions S� 
ObjectType    System.Windows.Media.Fonts S� 
MethodName  FontSizeOptions �� Type  FontWeightOptions  FontStyleOptions��%  &	        &	 B     &	 �     &	 k    S� 5   
   "  5      $ get_SystemFontFamilies��5      �� 5   
   " X�5      .s�5      X�12Q�6   X�5      18Q�6   X�5      26Q�6   X�5      36Q�6   X�5      72Q�6   5      �� 5   
   " #�6,   .s�5      #�
Normal"�6%   #�5      Bold"�6#   #�5      	ExtraBold"�6(   5      �� 5!   
   " %�6+   .s�5"      %�
Normal$�6$   %�5#      
Italic$�6$   %�5$      Oblique$�6%   5%      5&      .��5'      �  � RowDefinitions 5(   
   �� 5)      �� 5*      $
��auto �6    � ColumnDefinitions 5,   
   �� 5-      �� 5.      .+�51   
   ]� $��0��6   $��0��6!   .+�52      �� $	��Top=�6   Font Family6:   �� 53       �� SelectedIndex$ 0��55      ��53      �� 	 �� Source#	 [  
 �� SelectedItem
 54      �� *Family+��56      �� 57      .R�58      �� ��6$   �� ��65   �� 59      5;      5<      ]� 5>   
   $��0��6   $��1��6!   .+�5?      �� $	��Top=�6   	Font Size68   �� 5@      $ 0��5B      ��5@      �� #	 [ 
 5A      �� *Size+5B      5C      �� 5E   
   $��0��6   $��1��6%   .+�5F      �� Font Styles6%   �� 5G      $ 0��5I      ��5G      �� #	 [ 
 5H      �� *Style+5I      5J      �� 5L   
   $��1��6   $��1��6%   .+�5M      �� Font Weight6%   �� 5N      $ 0��5P      ��5N      �� #	 [ 
 5O      �� *Weight+5P      5Q      5R      5S      