   M S B A M L   `   `   `  ����C  ?CocoaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CocoaLib.ViewCocoaLib.View  5   	   7 clr-namespace:CocoaLib.ViewModelCocoaLib.ViewModel  5   	   +clr-namespace:CocoaLib.rscCocoaLib.rsc  5   	   ?$clr-namespace:CocoaLib.CustomControlCocoaLib.CustomControl  5	   	       CocoaLib.View.LoginView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CocoaLib.View     5   	   4loginvm clr-namespace:CocoaLib.ViewModel     5   	   /localrscclr-namespace:CocoaLib.rsc     5   	   >customcontrol$clr-namespace:CocoaLib.CustomControl     5	   	     � Title$  	LoginView��5   	   $	��550��6   $	��800��6(    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � 	Resources 5       �� MergedDictionaries �� Source   BooleanToVisibility�� 5   
    5      �� 5      $@ :/CocoaLib;component/rsc/ResourceDictionaryCollections.xaml?�6%   %   &	        �� 5      6+   5       � DataContext 5      '  !CocoaLib.ViewModel.LoginViewModel  5   
   y�5       �� 5!   
    �� Path$ 	IsVisible�6    �� Mode$ TwoWay=�5"      	 �� 	Converter#	 [  5#      .��5&      �� 
 �� CornerRadius$
 14��6   ��5'   
   �� 5(       �� ImageSource$ ./../pics/background1.jpg��6   ._�5+   
   �� $
 12��6   $��4q�5,       J� Opacity$ .8Q�5-      ��51      �� 52       �� 
StartPoint$ .25,0&�6&    �� EndPoint$ .75,1&�69   .��53      �  � Color$ #1ABC9C��6#    � Offset$ 0Q�63   � 54      $ #9B59B6��6#   $	 .25Q�63   � 55      $ #2874A6��6#   $	 .75Q�63   � 56      $ #F5CBA7��6#   $ 1Q�63   57      ��5<      �� 5=      $	 0,0&�6&   $	 1,1&�67   .��5>      � $ #633974��6#   $ 0Q�63   � 5?      $ #1A5276��6#   $ 1Q�63   5@      ._�5D      �  � RowDefinitions 5E      �� 5F      $��30 �6$   �� 5G      $
��auto �6$   .+�5I      �  � ColumnDefinitions 5J      �� 5K      �� 5L      $��25 �6+   �� 5M      $��5 �6+   �� 5N      $��25 �6+   �� 5O      $��5 �6+   .+�5T         CocoaLib.rsc.CustomBtnMenu  $��0��6-   $��1��5U   -   $��-��5V   -   $��20(�5W   -   $��25��5X   -   $��25��5Y   -   $��
UltraBlack"�5Z   -   
����� �   ButtonCornerRadius$ 50��5\   -   
������$��Center=�5^   -      
ColorHover
 ��� �   ColorPressed
 ��d�5`   -     5b      $��0��6-   $��3��5c   -   $��x��5d   -   $��	UltraBold"�5e   -   $��16(�5f   -   $��25��5g   -   $��25��5h   -   $ 25��5i   -   
����p��
 �����
 � E��$��0,0,0,20q�5m   -   5n      �� 5p      $��1��6   $��0��5q      $	��400��5r       �� Orientation$ Vertical=�5s      $��0,20,0,0q�5t      .+�5u      �� $��./../pics/CanvasIcon.png��6   $	��250��5v      $	��400��5w      $ 1Q�5x      �� 5y      $	��250��6!   $ Vertical=�5z   !   .+�5{      �� $��0,5,0,0q�6$   
�������$
��Wrap=�5}       $
��Left=�5~       $��Center=�5       $��Username��5�       �� 5�      -   5         ��Name$ txtUsr��5�   "   $	��250��5�      $��16(�5�      $��Medium"�5�       �� 
CaretBrush
 �����
�������
�����f�$��0,0,0,1q�5�      $��25,0,0,0q�5�      ��5�   "   �� *
Username+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5�   1   ��5�      �� 5�   "   $ ./../pics/user-icon.png��6-    j� Stretch$
 None=�5�   )    j� 
AlignmentX$
 Left=�5�   )   .��5�   2   5�      �� 5�      $��0,15,0,0q�6$   
�������$
��Wrap=�5�   $   $
��Left=�5�   $   $��Center=�5�   $   $��Password��5�   $   0   *CocoaLib.CustomControl.BindablePasswordBox  5�         PassWord 5�      �� *
Password+$ TwoWay=�$ PropertyChanged=��� 5�      ���#D7596D$��12(�5�   $   $��
Montserrat)�5�   $   $��0,0,10,0q�5�   $   $
��Wrap=�5�   $   $
��Left=�5�   $   ��5�   $   �� *
ErrorMsg+5�   $   5�        5�      $��	0,30,0,10q�6-   $	��120��5�   -   $��40��5�   -   $��Log in��5�   -   $��Center=�5�   -   $��Center=�5�   -   $��0,2,0,0q�5�   -   $��25(�5�   -   $��Calibri)�5�   -   $
��Bold"�5�   -   
�������
���q�<�
 ��·�
 �OO/�$ 20��5�   -   ��5�   -   �� *LoginCommand+$ PropertyChanged=�5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   .+�5�      �� $��Forget password?��6$   
�����w�5�   $   �� 5�      $��Reset��6$   
������� � Cursor$
 Hand��5�   $   $
��15,0q�5�   $   5�      5�      5�      5�      5�      5�      