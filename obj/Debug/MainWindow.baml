   M S B A M L   `   `   `  ����I  ERestaurantMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:RestaurantMenuRestaurantMenu  5   	       RestaurantMenu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:RestaurantMenu     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      � -   5        ���	#ffeeeeee.+�5
      �� $	��Top=�6   .+�5      � ���	#ff0069c0$��10��6!   � 5      $��5q�6
   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6.   .+�5      �� $
��Menu��6   $��Center=�6   $��20(�68   $��Yu Gothic UI Light)�6F   $
��20 0q�6f   5      �� 5      $ 
Horizontal=�6   $��Right=�6*   $
��10 0q�6F   .+�5      �� -   5         ��Name$ 
btn_basket��5      $��30��6#   $��30��6.   $��0q�6g   
�������$��0 0 10 0q�6�   ��6:   Z� ��6P   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Basket=�6    5      �� 5      -   5        $ ButtonCloseApp��5      $��30��6&   $��30��61   $��0q�6j   
���������6=   Z� ��6S   Z� .��5        $ Power=�6    5      5      5      5      � 5      $��
250 55 0 0q�6	   .+�5      � -   5         �Name$ GridPrincipal��5   
   $��Center=�6!   $��Center=�6>   5      � 5      $	��250��6	   $
��Left=�6   ���	#FF444444.+�5       ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5    )   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6L   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+	   Duration$	 0:0:0.2X�.��5!      � -   5        $ 
GridCursor��5!      $��	0 100 0 0q�6   ���	#ff0069c0$��10��6I   $
��Left=�6T   $��60��6o   $	��Top=�6{   5"      �� 5$      -   5        
 ��Name$
 ListViewMenu��5$      $��0 100q�6$   
�������$��Yu Gothic UI Light)�6J   $��18(�6j    �� SelectedIndex$ 0��6�   .@�5%      �� -   5        $��60��5%      .��5&      �� $ 
Horizontal=�6   .+�5'        $ Pasta=�6    $��30��6-   $��30��68   $��Center=�6D   $��5q�6_   �� 5(      $��Dishes��6   $��26(�6    $��Center=�6.   $
��20 0q�6I   5)      5*      �� 5+      $��60��6   .��5,      �� $ 
Horizontal=�6   .+�5-        $ Pizza=�6    $��30��6-   $��30��68   $��Center=�6D   $��5q�6_   �� 5.      $��Pizza��6   $��26(�6   $��Center=�6-   $
��20 0q�6H   5/      50      �� 51      $��60��6   .��52      �� $ 
Horizontal=�6   .+�53        $ FoodCroissant=�6    $��30��65   $��30��6@   $��Center=�6L   $��5q�6g   �� 54      $��Deserts��6   $��26(�6!   $��Center=�6/   $
��20 0q�6J   55      56      �� 57      $��60��6   .��58      �� $ 
Horizontal=�6   .+�59        $	 Tea=�6    $��30��6+   $��30��66   $��Center=�6B   $��5q�6]   �� 5:      $��
Hot drinks��6   $��26(�6$   $��Center=�62   $
��20 0q�6M   5;      5<      �� 5=      $��60��6   .��5>      �� $ 
Horizontal=�6   .+�5?        $ Drink=�6    $��30��6-   $��30��68   $��Center=�6D   $��5q�6_   �� 5@      $��Cold drinks��6   $��26(�6%   $��Center=�63   $
��20 0q�6N   5A      5B      5C      5D      5E      5F      