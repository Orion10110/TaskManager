   M S B A M L   `   `   `  ����O  KAnimatedColorfulMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AnimatedColorfulMenuAnimatedColorfulMenu  5   	   I)clr-namespace:AnimatedColorfulMenu.ModelsAnimatedColorfulMenu.Models  5   	   %    AnimatedColorfulMenu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AnimatedColorfulMenu     5   	   <domain)clr-namespace:AnimatedColorfulMenu.Models     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��600��5	      $
��1080��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Minimized=�6.   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��637* �6   �� 5      $
��437* �6   .+�5   
   �� -   5         ��Name$ listViewProcess��5      $��
0,31,10,36q�6S   $��Right=�6g   $	��617��6�    � DataContext 6,   ��  �� Path$ 	processes� �� View 5      �� 5      .P�5      ��  �� DisplayMemberBinding 6%   �� $ Id�.��6N   ID6R   �� 5      	 �� Width$		 100��6P    6%   �� $
 User�.��6\   User6b   �� 5      $		 100��6P    6%   �� $
 Name�.��6\   Name6b   �� 5      $		 100��6R    6%   �� $ Memory�.��6^   Memory6f   �� 5      $		 100��6T    6%   �� $ Priority�.��6`   
Priority6j   �� 5      $		 100��6S    6%   �� $ Threads�.��6_   	Threads6h   5      5      �� 5   
   -   5        $ listViewThreads��5      $��	10,10,0,0q�6,   $	��373��6?   $	��Top=�6L   $
��Left=�6d   $	��332��6   $��1��6�    5      �� 5      .P�5       �� $		 100��6N    6%   �� $ Id�.��6Z   	Thread ID6e   �� 5!      $		 100��6X    6%   �� $ BasePriority�.��6d   Thread Priority6u   5#      5%      �� 5&   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��Count��6V   $	��Top=�6c   �� 5'   
   -   5        
 ��Name$	
 let��5'   V   $
��Left=�6   $��	47,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6   ��6c   �� $ Count�6   5)      5*      