   M S B A M L   `   `   `  ���� F  BOneClickApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OneClickApp.ViewModelOneClickApp.ViewModel      OneClickApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2vm#clr-namespace:OneClickApp.ViewModel     -   $��
mainWindow��  � WindowStartupLocation$  CenterScreen=� � WindowStyle$ SingleBorderWindow=� � AllowsTransparency .  
������  � 
ResizeMode$ NoResize=� � Title$ 	One CLick��$	��650��$	��970��
�������'  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CornerRadius$ 0��   CaptionHeight$ 0Q�	   UseAeroCaptionButtons	 .  
   ResizeBorderThickness$
 7q� � DataContext )   #OneClickApp.ViewModel.MainViewModel  .���� ���#272537 �� CornerRadius$ 30��._��  � RowDefinitions �� $��75 ���  � ColumnDefinitions �� $	��200 ��� $��* �.+��� $��	One Click��$��Medium"�$��22(�
�������$��Center=�$
��Left=�$��20,23,50,22q��� $��-��
������ $��1��$��50��$��	590,0,0,0q�$��30��$��
ExtraBlack"����� *MinimizeButtonCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ����� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��
 �   ��� $��Close��
���  ��$��1��$��50��$��10q�$��Right=�$��Medium"�$��30������ *CloseButtonCommand+���� " ��.���  � ��
 ����� P�  �@J�IsMouseOver . . ���  � ��
 �   ��� $��1��$��10,10,10,10q�.+�	� $
��Home�� d� 	IsChecked$
 TrueY�$��50��
�������$��18(�   RadioButtonTheme#��[  ���� *HomeViewCommand+	� $��Web Page��$��50��
�������$��18(�#��[  ���� *WebPageViewCommand+	� $��Social Media��$��50��
�������$��18(�#��[  ���� *SMViewCommand+�� $��1��$
��Left=�$��Center=�$��5q�  TextBoxTheme#��[ �� $��1��$��1��$��10q����� *CurrentView+