   M S B A M L   `   `   `  ����D  @LawOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LawOffice	LawOffice  5   	       LawOffice.TaskWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LawOffice     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
TaskWindow��5   	   $	��600��5      $	��600��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I    � WindowStyle$
 None=�6n   .��5      �  J� RenderTransformOrigin$ 
0.492,0.31&�6   .+�5   
   �� $	��406��6   $��Bottom=�6!   $��10,0,10,184q�6<    �� RadiusY$ 10��6Q    �� RadiusX$ 10��6^   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGrid1��5         AutoGenerateColumns .   �� IsTextSearchEnabled .   �� IsTextSearchCaseSensitive .  $
��Left=�6�   $	��338��6�   $��	20,23,0,0q�6�   $	��Top=�6�   $	��558��6�      
IsReadOnly .    SelectionMode$ Single=�6
  ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ TaskId��6E      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ TaskId�6U     5      $
 Date��6b    .  6%   �� $
 Date� �� StringFormat$ {0:dd.MM.yyyy}��6p     5      $ Description��6J    .  6%   �� $ Description�6_     5      $ 
Spend Time��6H    .  6%   �� $ 	SpendTime�6\     5      $ UnderCaseId��6J    .  6%   �� $ UnderCaseId�6_     5      $ 	UnderCase��6L    .  6%   �� $ UnderCaseName�6_     5      $ LawyerId��6G    .  6%   �� $ LawyerId�6Y     5      $ Lawyer��6I    .  6%   �� $ 
LawyerName�6Y   5      �� 5   
   -   5        $��47,558,420,10q�5      ���	#FF34268A���	#FF34268A.��5      � $	��110��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ PlusBox=�6*   $��Center=�69   $��0,0,0,1q�6T   �� 5       $��Center=�6   $��ADD NEW��69   $��Champagne & Limousines)�6H   $��27,0,18.622,0q�6p   5!      5"      �� 5#   
   -   5        $��410,558,47,10q�5#      ���	#FF34268A���	#FF34268A.��5$      � $	��119��6   .+�5%        $ 	ArrowBack=�6*   $��Center=�6;   �� 5&      $��Center=�6   $
��BACK��69   $��Champagne & Limousines)�6E   5'      5(      (  "System.Windows.Controls.DatePicker  5)   
   -   5        $��datePicker1��5)   P   $��38��6   $
��Left=�6!   $��
10,462,0,0q�6<   )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$
 DATE��6d    (  $MaterialDesignFloatingHintDatePicker#��[  6�   $	��Top=�6�   $	��109��6�   �� 5*   
   -   5         ��Name$ TextBoxSpendTime��5*      $��138,462,353,100q�6,   $ SPEND TIME (MIN)��6E    % !MaterialDesignFloatingHintTextBox#��[ 6w   $��Champagne & Limousines)�6�   $��13(�6�   �� 5+   
   -   5        $ TextBoxSearch��5+      $��381,366,99,196q�6)   $ SEARCH��6A   #��[ 6i   $��Champagne & Limousines)�6�   $��13(�6�   6�   �� 5,   
   -   5        $ TextBoxDescription��5,      $��268,462,157,100q�6.   $ TASK DESCRIPTION��6G   #��[ 6y   $��Champagne & Limousines)�6�   $��13(�6�   �� 5-   
   -   5         ��Name$ ComboBoxUnderCase��5-      $��463,462,10,0q�6.   $	��Top=�6D   $	��127��6\   $ 	UNDERCASE��6�    & "MaterialDesignFloatingHintComboBox#��[ 6�   $��Champagne & Limousines)�6�   $��13(�6  $��38��6  ��6h   �� 6  �� 5.   
   $��INSERT NEW TASK:��6   $
��Left=�6+   $��
10,431,0,0q�6F   $	��Top=�6Z   $	��128��6r   �� 5/   
   -	   5         ��Name$ ButtonDelete��5/      $��210,558,209,10q�6'   ���	#FF34268A���	#FF34268A.��50      � $	��110��6   .+�51        $ PlusBox=�6*   $��Center=�69   $��	-32,0,0,1q�6T   $��48��6g   �� 52      $��Center=�6   $��DELETE SELECTED��69   $��Champagne & Limousines)�6P   $��
16,0,-31,0q�6x   $	��125��6�   53      54      �� 55   
   -
   5        $��20,378,463,196q�55      ���	#FF34268A���	#FF34268A$
��Auto��6t   .��56      � $��89��6   .+�57        $ Refresh=�6*   $��Center=�69   $��	-12,0,0,0q�6T   $��33��6g   $��15��6r   �� 58      $
��Left=�6   $��REFRESH��67   $��Champagne & Limousines)�6F   $��26,1,0,0q�6n   $��60��6�   59      5:      5;      5<      