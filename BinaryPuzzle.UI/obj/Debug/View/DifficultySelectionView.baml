   M S B A M L   `   `   `  ����J  FBinaryPuzzle.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BinaryPuzzle.UI.ViewBinaryPuzzle.UI.View  5      2    ,BinaryPuzzle.UI.View.DifficultySelectionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BinaryPuzzle.UI.View     5        � 	Resources  5	         NaviItemContainerStyle �� 
TargetType �� Property �� Value  DiffItemTemplate �� 
TargetType �Name �� Triggers P� Property P� Value��%z  &	        &	 m     �� 5
   
   " ��6/   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ 2q�6'   5      �� 5   
   .R�5      �� ���#FFFFFF��6*   �� *DisplayMember+��5      �� *GenerateGameGridCommand+��5      �� 5      " ��6&   .R�5      � $
 grid��6   .+�5      �� #��z��6/   #��z��5   7   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@�Cursor$
 Hand��6;   �� 5   "    � ��$
 Bold"�6?   5      P� 5       � �� . . �5   "   ��  � ��$ Normal"�6?   5      5!      5#      5$      5%      .��5&      � 	 � RowDefinitions	 5'   
   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5+      .+�5.   
   �� ���#FFFFFF$��Difficulty ��6(   .��5/      �� $
��Auto=�6   $
��Auto=�50      .��51      �� #��[  52      #��[ 53      ��51      �� *Difficulties+53      54      55      59      5:      