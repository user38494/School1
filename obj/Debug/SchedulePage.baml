   M S B A M L   `   `   `  ����B  >School1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:School1School1  5          School1.SchedulePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:School1     5      -   5          N� Title$  SchedulePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridStudentsPage��5         
IsReadOnly .    AutoGenerateColumns .  $
��auto��6\      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ 
Класс��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
Class.Name+  5      $ * 6%   $ Предмет��6/    6@   �� *Lesson.Title+  5      $ * 6%   $ Кабинет��6/    6@   �� *Classroom.Number+  5      $ * 6%   $ Учитель��6/    6@   �� *Teacher.Title+  5      $ * 6%   $ Дата��6/    6=   �� *Date+	 �� StringFormat$	 dd.MM��4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   ���#d4d0d6$
��Bold"�6g   $��30��6y   5      5      5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5!      �� -   5        $��Filtr��5!      $	��150��6N   $��35��6Z   $��1��6f   $��3��6v   $
��Left=�6�   ���#9463d06�   �� 5"      -   5         ��Name$ Poisk��5"      $��15,0,0,0q�6E   $	��150��6W   $��35��6c   $��Right=�6o   
����·�6�   �� 5#      -   5        $
��Sort��5#      $��0��6L   $��3��6\   $��15,0,0,0q�6i   $	��150��6{   $��35��6�   ���#9463d0$
��Bold"�6�   �� 5$      -   5         ��Name$ BtnAdd��5$   c   $��Добавить��6   $��1��6(   $
��Left=�65   $��	150,5,0,5q�6P   
����·�$
��Bold"�6�   �� 5%      -   5        $ 	BtnDelete��5%   b   $��Удалить��6   $��1��6'   $��Right=�64   $��15,5,0,5q�6P   ���#9463d0$
��Bold"�6�   5&      5'      5(      