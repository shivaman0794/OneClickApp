   M S B A M L   `   `   `  ����F  BOneClickApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OneClickApp.ViewModelOneClickApp.ViewModel  5   	       OneClickApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2vm#clr-namespace:OneClickApp.ViewModel     5   	   -   5        $��
mainWindow��5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � Title$ 	One CLick��5   	   $	��650��5   	   $	��970��6   
�������'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CornerRadius$ 0��6/      CaptionHeight$ 0Q�6@   	   UseAeroCaptionButtons	 .  
   ResizeBorderThickness$
 7q�6p    � DataContext 5      )   #OneClickApp.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 30��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $��75 �6    �� 5       � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       $��* �6#   .+�5"      �� $��	One Click��5#      $��Medium"�5$      $��22(�5%      
�������$��Center=�5'      $
��Left=�5(      $��20,23,50,22q�5)      �� 5+      $��-��6   
������ $��1��5-      $��50��5.      $��	590,0,0,0q�6    $��30��5/      $��
ExtraBlack"�50      ��51      �� *MinimizeButtonCommand+��53      �� 54       �� 
TargetType" ��6   .�55      ��  �� Property � �� �� Value
 �����67    �� Triggers 56      P� 57       P� Property �@J�IsMouseOver P� Value . . �59   "   ��  � ��
 �   �6?   5:      5<      5>      �� 5?      $��Close��6   
���  ��$��1��5A      $��50��5B      $��10q�6    $��Right=�6,   $��Medium"�6H   $��30��5C      ��5D      �� *CloseButtonCommand+��5F      �� 5G      " ��6   .�5H      ��  � ��
 �����67    5I      P� 5J       �@J�IsMouseOver . . �5L   "   ��  � ��
 �   �6?   5M      5O      5Q      �� 5R      $��1��6   $��10,10,10,10q�6&   .+�5S      	� $
��Home��5T       d� 	IsChecked$
 TrueY�5U      $��50��5V      
�������$��18(�5X         RadioButtonTheme#��[  5Y      ��5Z      �� *HomeViewCommand+	� 5\      $��Tools��5]      $��50��5^      
�������$��18(�5`      #��[  5a      ��5b      �� *ToolsViewCommand+	� 5d      $��Web Page��5e      $��50��5f      
�������$��18(�5h      #��[  5i      ��5j      �� *WebPageViewCommand+	� 5l      $��Social Media��5m      $��50��5n      
�������$��18(�5p      #��[  5q      ��5r      �� *SMViewCommand+5t      �� 5u      $��1��5v      $
��Left=�5w      $��Center=�5x      $��5q�5y        TextBoxTheme#��[ 5z      �� 5|      $��1��6   $��1��6-   $��10q�6:   ��6F   �� *CurrentView+5}      5~      5      