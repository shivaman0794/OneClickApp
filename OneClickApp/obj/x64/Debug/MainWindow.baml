   M S B A M L   `   `   `  ����F  BOneClickApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OneClickApp.ViewModelOneClickApp.ViewModel  5   	       OneClickApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2vm#clr-namespace:OneClickApp.ViewModel     5   	   -   5        $��
mainWindow��5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � Title$ 	One CLick��5   	   $	��650��5   	   $	��970��6   
������� � DataContext 5      )   #OneClickApp.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 30��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $��75 �6    �� 5       � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �� $��	One Click��5       $��Medium"�5!      $��22(�5"      
�������$��Center=�5$      $
��Left=�5%      $��20,23,50,22q�5&      �� 5(      $��-��6   
������ $��1��5*      $��50��5+      $��	590,0,0,0q�6    $��30��5,      $��
ExtraBlack"�5-      ��5.      �� *MinimizeButtonCommand+��50      �� 51      	 �� 
TargetType"	 ��6   .�52      �� 
 �� Property
 � �� �� Value
 �����67    �� Triggers 53      P� 54       P� Property �@J�IsMouseOver P� Value . . �56   "   �� 
 � ��
 �   �6?   57      59      5;      �� 5<      $��Close��6   
���  ��$��1��5>      $��50��5?      $��10q�6    $��Right=�6,   $��Medium"�6H   $��30��5@      ��5A      �� *CloseButtonCommand+��5C      �� 5D      "	 ��6   .�5E      �� 
 � ��
 �����67    5F      P� 5G       �@J�IsMouseOver . . �5I   "   �� 
 � ��
 �   �6?   5J      5L      5N      �� 5O      $��1��6   $��10,10,10,10q�6&   .+�5V      	� $
��Home��5W       d� 	IsChecked$
 TrueY�5X      $��50��5Y      
�������$��18(�5[         RadioButtonTheme#��[  5\      ��5]      �� *HomeViewCommand+	� 5`      $��Tools��5a      $��50��5b      
�������$��18(�5d      #��[  5e      ��5f      �� *ToolsViewCommand+	� 5h      $��Web Page��5i      $��50��5j      
�������$��18(�5l      #��[  5m      ��5n      �� *WebPageViewCommand+	� 5p      $��Social Media��5q      $��50��5r      
�������$��18(�5t      #��[  5u      ��5v      �� *SMViewCommand+	� 5x      $��Quick Notes��5y      $��50��5z      
�������$��18(�5|      #��[  5}      ��5~      �� *QuickNotesCommand+5�      �� 5�      $��1��5�      $
��Left=�5�      $��Center=�5�      $��5q�5�        TextBoxTheme#��[ 5�      �� 5�      $��1��6   $��1��6-   $��10q�6:   ��6F   �� *CurrentView+5�      5�      5�      