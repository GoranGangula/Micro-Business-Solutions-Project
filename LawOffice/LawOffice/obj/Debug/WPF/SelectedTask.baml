   M S B A M L   `   `   `  ����D  @LawOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LawOffice	LawOffice  5   	       LawOffice.SelectedTask   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LawOffice     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  SelectedTask��5   	   $	��600��5   "   $	��600��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � WindowStyle$
 None=�6v   .��5      �  J� RenderTransformOrigin$ 
0.492,0.31&�6   .+�5   
   �� $	��490��6   $��Bottom=�6!   $��10,0,10,100q�6<    �� RadiusY$ 10��6Q    �� RadiusX$ 10��6^   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGrid1��5         AutoGenerateColumns .   �� IsTextSearchEnabled .   �� IsTextSearchCaseSensitive .  $
��Left=�6�   $	��418��6�   $��	20,23,0,0q�6�   $	��Top=�6�   $	��558��6�      
IsReadOnly .    SelectionMode$ Single=�6
  ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ TaskId��6E      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ TaskId�6U     5      $
 Date��6b    .  6%   �� $
 Date� �� StringFormat$ {0:dd.MM.yyyy}��6p     5      $ Description��6J    .  6%   �� $ Description�6_     5      $ 
Spend Time��6H    .  6%   �� $ 	SpendTime�6\     5      $ Under Case Id��6J    .  6%   �� $ UnderCaseId�6a     5      $ LawyerId��6G    .  6%   �� $ LawyerId�6Y     5      $ Lawyer��6I    .  6%   �� $ 
LawyerName�6Y     5      $ 	UnderCase��6L    .  6%   �� $ UnderCaseName�6_   5      �� 5   
   -   5        $��203,558,254,10q�5      ���	#FF34268A���	#FF34268A.��5      � $	��119��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�6*   $��Center=�6;   �� 5       $��Center=�6   $
��BACK��69   $��Champagne & Limousines)�6E   5!      5"      �� 5#   
   -   5         ��Name$ TextBoxSearch��5#      $��393,446,87,116q�6)   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ SEARCH��6A    %  !MaterialDesignFloatingHintTextBox#��[  6i   $��Champagne & Limousines)�6�   $��13(�6�   6�   5$      5%      