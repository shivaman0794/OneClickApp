   M S B A M L   `   `   `  ����F  BOneClickApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:OneClickApp.MVVM.ViewOneClickApp.MVVM.View  5      =#clr-namespace:OneClickApp.ViewModelOneClickApp.ViewModel  5      &     OneClickApp.MVVM.View.QuickNotes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:OneClickApp.MVVM.View     5      2vm#clr-namespace:OneClickApp.ViewModel     5      $��5q�5	      
�������.��5      ��   �� CornerRadius$  50��6   ._�5   
   ]� $��1q�6   .+�5      o� $	��Top=�6   @�5      m� 5      $
��File��6   $��18(�6J   $��Medium"�6X    � DataContext 6-   �� *File+.@�5      m� $	��New��6#    m� Command 60   �� *
NewCommand+m� 5      $
��Open��6#    61   �� *OpenCommand+m� 5      $
��Save��6#    61   �� *SaveCommand+m� 5      $��
Save as...��6#    67   �� *SaveAsCommand+5      m� 5      $��Format��6   $��18(�6N   $��Medium"�6\    6/   �� *Editor+.@�5      m� $��Format��6#    63   �� *FormatCommand+m� 5      $��	Word wrap��6#    66   �� *WrapCommand+ m� 	IsChecked 6V   �� *Format.isWrapped+5      m� 5      $
��Help��6   $��18(�6J   $��Medium"�6X    6-   �� *Help+.@�5      m� $��About��6#    62   �� *HelpCommand+5      5      ]� 5!      .+�5"      �� $��Bottom=�6    5#      �� *File.Document+��5$      �� *
FilePath+�� 5&      $	��Top=�6    �� AcceptsReturn . 
�������
���   � �� 
AcceptsTab . $��3q�51       �� 
CaretBrush
 ��  � 5'      �� *Editor+��5(      �� *Format.Family+��5)      �� *Format.Size+ �� Mode$ TwoWay=���5*      �� *Format.Style+��5+      �� *Format.Weight+ �� TextWrapping 5,      �� *Format.Wrap+��53      �� *Document.Text+$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�54      55      56      57      