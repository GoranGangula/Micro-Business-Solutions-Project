   M S B A M L   `   `   `  ����D  @LawOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LawOffice	LawOffice  5   	       LawOffice.WindowClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LawOffice     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  WindowClient��5   	   $	��600��5      $	��600��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I    � WindowStyle$
 None=�6n   .��5      �  J� RenderTransformOrigin$ 
0.492,0.31&�6   .+�5   
   �� $	��414��6   $��Bottom=�6!   $��10,0,10,176q�6<    �� RadiusY$ 10��6Q    �� RadiusX$ 10��6^   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGrid1��5         AutoGenerateColumns .   �� IsTextSearchEnabled .   �� IsTextSearchCaseSensitive .  $
��Left=�6�   $	��338��6�   $��	20,23,0,0q�6�   $	��Top=�6�   $	��558��6�      
IsReadOnly .    SelectionMode$ Single=�6
  ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ClientId��6G      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ ClientId�6Y     5      $
 Name��6C    .  6%   �� $
 Name�6Q     5      $ Surname��6F    .  6%   �� $ Surname�6W     5      $ LayerId��6G    .  6%   �� $ LawyerId�6X     5      $ Lawyer��6P    .  6%   �� $ LawyerNameSurname�6`   5      �� 5   
   -   5        $��10,558,457,10q�5      ���	#FF34268A���	#FF34268A.��5      � $	��119��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ PlusBox=�6*   $��Center=�69   $��0,0,0,1q�6T   �� 5      $��Center=�6   $��ADD NEW��69   $��Champagne & Limousines)�6H   $��27,0,18.622,0q�6p   5      5      �� 5    
   -   5        $��220,558,228,10q�5       ���	#FF34268A���	#FF34268A.��5!      � $	��119��6   .+�5"        $ CalendarTask=�6*   $��Center=�6>   �� 5#      $��Center=�6   $��REVIEW TASKS��69   $��Champagne & Limousines)�6M   $��21,0,0,0q�6u   $��98��6�   5$      5%      �� 5&   
   -   5        $��435,558,22,10q�5&      ���	#FF34268A���	#FF34268A.��5'      � $	��119��6   .+�5(        $ 	ArrowBack=�6*   $��Center=�6;   �� 5)      $��Center=�6   $
��BACK��69   $��Champagne & Limousines)�6E   5*      5+      �� 5,   
   -   5         ��Name$ TextBoxName��5,      $��59,471,413,91q�6'   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CLIENT NAME��6>    %  !MaterialDesignFloatingHintTextBox#��[  6k   $��Champagne & Limousines)�6�   $��13(�6�   �� 5-   
   -   5        $ TextBoxSurname��5-      $��235,472,228,90q�6*   $ CLIENT SURNAME��6B   #��[  6r   $��Champagne & Limousines)�6�   $��13(�6�   �� 5.   
   -   5        $ TextBoxSearch��5.      $��381,366,99,196q�6)   $ SEARCH��6A   #��[  6i   $��Champagne & Limousines)�6�   $��13(�6�   6�   �� 5/   
   -   5         ��Name$ ComboBoxLawyer��5/      $��381,471,0,0q�6+   $	��Top=�6@   $	��127��6X   $ LAWYER��6|    & "MaterialDesignFloatingHintComboBox#��[ 6�   $��Champagne & Limousines)�6�   $��13(�6  $��38��6  ��6d   �� 6  �� 50   
   $��INSERT NEW CLIENT:��6   $
��Left=�6-   $��
20,440,0,0q�6H   $	��Top=�6\   $	��128��6t   �� 51   
   -	   5        $��20,378,463,196q�51      ���	#FF34268A���	#FF34268A$
��Auto��6t   .��52      � $��89��6   .+�53        $ Refresh=�6*   $��Center=�69   $��	-12,0,0,0q�6T   $��33��6g   $��15��6r   �� 54      $
��Left=�6   $��REFRESH��67   $��Champagne & Limousines)�6F   $��26,1,0,0q�6n   $��60��6�   55      56      57      58      