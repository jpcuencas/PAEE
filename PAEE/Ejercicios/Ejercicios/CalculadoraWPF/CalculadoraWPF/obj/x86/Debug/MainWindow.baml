   M S B A M L   `   `   `  ����  CalculadoraWPF    CalculadoraWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��475��6   $	��524��6)   .��5      � $	��386��6   $	��431��6   '  !System.Windows.VisualStateManager   VisualStateGroups 5      %  System.Windows.VisualStateGroup  5      -   5        estadodesselecionado��   Transitions 5   	   %  System.Windows.VisualTransition  5	   
      GeneratedDuration$ 0D�6   	   To$ VisualState��61      
Storyboard. 5
      �� .��5      T�  �� TargetProperty$- '(Panel.Background).(TileBrush.TileMode)�6*    �� 
TargetName$ btnSiete��6n   ..�5      i�  R� KeyTime$ 0��6$   #  System.Windows.Media.TileMode	   None
 R� Value#
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnOcho��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnNueve��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ 	btnCuatro��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnCinco��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnSeis��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnUno��6n   ..�5      i� $ 0��6$   #
 Z	 60   5      T� 5       $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnDos��6n   ..�5!      i� $ 0��6$   #
 Z	 60   5"      T� 5#      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnTres��6n   ..�5$      i� $ 0��6$   #
 Z	 60   5%      T� 5&      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnPunto��6n   ..�5'      i� $ 0��6$   #
 Z	 60   5(      T� 5)      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnCero��6n   ..�5*      i� $ 0��6$   #
 Z	 60   5+      T� 5,      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnIgual��6n   ..�5-      i� $ 0��6$   #
 Z	 60   5.      T� 5/      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnDiv��6n   ..�50      i� $ 0��6$   #
 Z	 60   51      T� 52      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnMult��6n   ..�53      i� $ 0��6$   #
 Z	 60   54      T� 55      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnMenos��6n   ..�56      i� $ 0��6$   #
 Z	 60   57      T� 58      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnMas��6n   ..�59      i� $ 0��6$   #
 Z	 60   5:      T� 5;      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnRaiz��6n   ..�5<      i� $ 0��6$   #
 Z	 60   5=      T� 5>      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnPotencia��6n   ..�5?      i� $ 0��6$   #
 Z	 60   5@      T� 5A      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ 	btnBorrar��6n   ..�5B      i� $ 0��6$   #
 Z	 60   5C      T� 5D      $- '(Panel.Background).(TileBrush.TileMode)�6*   $ btnBorrarTodo��6n   ..�5E      i� $ 0��6$   #
 Z	 60   5F      U� 5G      $ (UIElement.Opacity)�6*   $ Pantalla��6Z   .\�5H      9  3System.Windows.Media.Animation.EasingDoubleKeyFrame   O� KeyTime$ 0��6"    O� Value$ 1Q�6.   5I      �� 5J      $6 0(TextElement.Foreground).(SolidColorBrush.Color)�6)   $ Pantalla��6v   .g�5K      8  2System.Windows.Media.Animation.EasingColorKeyFrame   �� KeyTime$ 0��6!    �� Value$ 	#FF01010C��6-   5L      �� 5M      $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6)   $ Pantalla��6r   .g�5N        $ 0��6!   $ 	#BF1818C8��6-   5O      �� 5P      $0 *(Panel.Background).(SolidColorBrush.Color)�6)   $ Pantalla��6p   .g�5Q        $ 0��6!   $ 	#00B25B5B��6-   5R      5S      5T         States. 5V   	      System.Windows.VisualState  -   5        VisualState��5V      5W   	    � ColumnDefinitions 5Y   
   �� 5Z      $
��342* �6   �� 5[      $	��88* �6   .+�5]   
   �� -   5        $��Pantalla��5]   W   $��0��6   $��39��6   $
��Left=�6(   $��
25,155,0,0q�6C   $	��Top=�6g   $	��367��6   $��LeftToRight=�6�   ���	#BF0000C4$��5q�6�   $��15(�6�   $��Source Code Pro)�6�   $
��Bold"�6�   $��Normal&�6  $��Right=�6%  $��2��6H  
����d� � ContextMenu 5^      �� 5_      $��Right=�66    � DataContext 6   �� 66   5a      �� 5b   
   -   5        $��btnSiete��5b   X   $��7��6   $��33��6   $
��Left=�6)   $��
34,223,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5c      �� 5d      ��5f      
� 5g      .��5h      �  � Color$ 	#CDA39595��6#    � Offset$ 0.308Q�65   � 5i      $ White��6#   $ 1Q�61   5j      5l      �� 5m   
   -   5        $��btnOcho��5m   Z   $��8��6   $��33��6   $��Right=�6)   $��0,223,190,0q�6E   $	��Top=�6i   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5n      �� 5o      ��5q      
� 5r      .��5s      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5t      $ White��6#   $ 1Q�61   5u      5w      �� 5x   
   -   5        $��btnNueve��5x   Y   $��9��6   $��33��6   $
��Left=�6)   $��158,223,0,0q�6D   $	��Top=�6i   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5y      �� 5z      ��5|      
� 5}      .��5~      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��	btnCuatro��5�   X   $��4��6   $��33��6   $
��Left=�6)   $��
34,262,0,0q�6D   $	��Top=�6i   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnCinco��5�   X   $��5��6   $��33��6   $
��Left=�6)   $��
96,262,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -	   5        $��btnSeis��5�   Y   $��6��6   $��33��6   $
��Left=�6)   $��158,262,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -
   5        $��btnUno��5�   X   $��1��6   $��33��6   $
��Left=�6)   $��
34,302,0,0q�6D   $	��Top=�6f   $��56��6~   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnDos��5�   X   $��2��6   $��33��6   $
��Left=�6)   $��
96,302,0,0q�6D   $	��Top=�6f   $��56��6~   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnTres��5�   Y   $��3��6   $��33��6   $
��Left=�6)   $��158,302,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnPunto��5�   X   $��.��6   $��33��6   $
��Left=�6)   $��
34,341,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnCero��5�   X   $��0��6   $��33��6   $
��Left=�6)   $��
96,341,0,0q�6D   $	��Top=�6g   $��56��6   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnIgual��5�   Y   $��=��6   $��33��6   $
��Left=�6)   $��158,341,0,0q�6D   $	��Top=�6i   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnDiv��5�   Y   $��/��6   $��33��6   $
��Left=�6)   $��255,223,0,0q�6D   $	��Top=�6g   $��56��6   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnMult��5�   Y   $��*��6   $��33��6   $
��Left=�6)   $��255,262,0,0q�6D   $	��Top=�6h   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5�      
� 5�      .��5�      � $ 	#CDA39595��6#   $ 0.308Q�65   � 5�      $ White��6#   $ 1Q�61   5�      5�      �� 5�   
   -   5        $��btnMenos��5�   Y   $��-��6   $��33��6   $
��Left=�6)   $��255,302,0,0q�6D   $	��Top=�6i   $��56��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5�      �� 5�      ��5      
� 5     .��5     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5     $ White��6#   $ 1Q�61   5     5     �� 5  
   -   5        $��btnMas��5  Y   $��+��6   $��33��6   $
��Left=�6)   $��255,341,0,0q�6D   $	��Top=�6g   $��56��6   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5     �� 5	     ��5     
� 5     .��5     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5     $ White��6#   $ 1Q�61   5     5     �� 5  
   -   5        $��btnRaiz��5  \   $
��Sqrt��6   $��33��6    $
��Left=�6,   $��317,223,0,0q�6G   $	��Top=�6k   $��56��6�   $��2��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5     �� 5     ��5     
� 5     .��5     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5     $ White��6#   $ 1Q�61   5     5     �� 5  
   -   5        $��btnPotencia��5  Y   $��^��6   $��33��6   $
��Left=�6)   $��317,262,0,0q�6D   $	��Top=�6l   $��56��6�   $��2��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5     �� 5     ��5!     
� 5"     .��5#     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5$     $ White��6#   $ 1Q�61   5%     5'     �� 5(  
   -   5        $��	btnBorrar��5(  Y   $��C��6   $��33��6   $
��Left=�6)   $��317,302,0,0q�6D   $	��Top=�6j   $��56��6�   $��2��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��5)     �� 5*     ��5,     
� 5-     .��5.     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5/     $ White��6#   $ 1Q�61   50     52     �� 53  
   -   5        $��btnBorrarTodo��53  Z   $��CE��6   $��33��6   $��Right=�6*   $��
0,341,57,0q�6F   $	��Top=�6o   $��56��6�   $��2��6�   $��1q�6�   }�.  $��SimSun)�6�   $��21.333(�6�   |�.  ��54     �� 55     ��57     
� 58     .��59     � $ 	#CDA39595��6#   $ 0.308Q�65   � 5:     $ White��6#   $ 1Q�61   5;     5=     �� 5>  
   -   5        $��TxtbxPantalla��5>  O   $	��128��6   $
��Left=�6!   $��	25,21,0,0q�6<   $��0��6d   $	��Top=�6m   $	��367��6�   $��20(�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�    J� Opacity$	 0.7Q�6�   
��� � � J� 	AllowDrop .  $��2��6�   5?     ��5@     �� 5A  
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5B     � $ Black��6   $ 0Q�6)   � 5C     $ White��6   $ 1Q�6)   5D     5F     