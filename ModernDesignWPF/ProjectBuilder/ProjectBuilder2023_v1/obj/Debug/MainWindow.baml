   M S B A M L   `   `   `  ����J  FModernDesign_v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ModernDesign_v2ModernDesign_v2  5   	   O,clr-namespace:ModernDesign_v2.MVVM.ViewModelModernDesign_v2.MVVM.ViewModel  5   	        ModernDesign_v2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ModernDesign_v2     5   	   B	viewModel,clr-namespace:ModernDesign_v2.MVVM.ViewModel     5   	   -   5        $	��600��5	   	   $	��920��5
   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ 	CanResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      2  ,ModernDesign_v2.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 0��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5       $��75 �6    �� 5!      .+�5$      �� $��1��6    �� Orientation$ 
Horizontal=�5%      $��Right=�5&      .+�5(      �� -   5         ��Name$ btnMinimise��5(      $��_��5)      $��40��5*      $��40��5+      
������ 
������ 
�������5/      �� 52      -   5        $ btnMaximise��52      $
��🗖��53      $��40��54      $��40��55      
������ 
������ 
�������59      �� 5<      -   5        $ btnClose��5<      $��X��5=      $��40��5>      $��40��5?      
������ 
������ 
�������5C      5F      �� 5H      $
��UKAD��6   $��Center=�5I      $��Center=�5J      
�������$��50(�5L      $��0q�5M      $��/Fonts/#Poppins)�5N      �� 5Q      $��1��6   .+�5R      	� $
��Home��6   $��50��5S      
�������$��14(�5U         MenuButtonTheme#��[  5V      	 d� 	IsChecked$
	 TrueY�5W      ��5X      �� *HomeViewCommand+	� 5[      $��Project Overview��6   $��50��5\      
�������$��14(�5^      #��[  5_      $
	 TrueY�5`      ��5a      �� *HomeViewCommand+	� 5d      $��Project Checklist��6   $��50��5e      
�������$��14(�5g      #��[  5h      $
	 TrueY�5i      ��5j      �� *HomeViewCommand+	� 5m      $��Document Checklist��6   $��50��5n      
�������$��14(�5p      #��[  5q      $
	 TrueY�5r      ��5s      �� *HomeViewCommand+	� 5v      $��Build Folder Structure��6   $��50��5w      
�������$��14(�5y      #��[  5z      ��5{      �� *DiscoveryViewCommand+	� 5~      $��Build Documents��6   $��50��5      
�������$��14(�5�      #��[  5�      	� 5�      $��Add Aircraft Type��6   $��50��5�      
�������$��14(�5�      #��[  5�      	� 5�      $��Config. Files��6   $��50��5�      
�������$��14(�5�      #��[  5�      	� 5�      $��Create Template��6   $��50��5�      
�������$��14(�5�      #��[  5�      	� 5�      $��Settings...��6   $��50��5�      
�������$��14(�5�      #��[  5�      5�      �� 5�      $	��250��6   $��40��5�      $��Center=�5�      $
��Left=�5�      $��5q�5�      $��1��5�        ModernTextBox#��[ 5�      �� 5�      $��1��6   $��1��5�      $��10q�5�      ��5�      �� *CurrentView+5�      5�      5�      