   M S B A M L   `   `   `  ����G  CModernDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ModernDesignModernDesign  5   	   I)clr-namespace:ModernDesign.MVVM.ViewModelModernDesign.MVVM.ViewModel  5   	       ModernDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ModernDesign     5   	   ?	viewModel)clr-namespace:ModernDesign.MVVM.ViewModel     5   	   -   5        $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      /  )ModernDesign.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5       .+�5#      �� $
��UKAD��6   $��Center=�5$      $
��Left=�5%      
�������$��28(�5'      $��20,0,0,0q�5(      $��/Fonts/#Poppins)�5)      �� 5,      $��1��6   .+�5-      	� $
��Home��6   $��50��5.      
�������$��14(�50         MenuButtonTheme#��[  51       d� 	IsChecked$
 TrueY�52      ��53      �� *HomeViewCommand+	� 56      $��	Discovery��6   $��50��57      
�������$��14(�59      #��[  5:      ��5;      �� *DiscoveryViewCommand+	� 5?      $��Featured��6   $��50��5@      
�������$��14(�5B      #��[  5C      5E      �� 5G      $	��250��6   $��40��5H      $��Center=�5I      $
��Left=�5J      $��5q�5K      $��1��5L        ModernTextBox#��[ 5M      �� 5P      $��1��6   $��1��5Q      $��10q�5R      ��5S      �� *CurrentView+5V      5W      5X      