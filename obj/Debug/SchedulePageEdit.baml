   M S B A M L   `   `   `  ����B  >School1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:School1School1  5          School1.SchedulePageEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:School1     5      $��Center=�5	      $��Center=�6"     N� Title$  SchedulePageEdit��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
Класс��6   $��0��6!   �� 5   
   $��Предмет��6   $��1��6#   �� 5   
   $��Кабинет��6   $��2��6#   �� 5   
   $��Учитель��6   $��3��6#   �� 5    
   -   5        $��CbClass��5        �� DisplayMemberPath$
 Name��6"   $��1��6Z   $��0��6j    �� SelectedItem 6;   �� *Class+6j   �� 5!   
   -   5        $��CbLesson��5!      $ Title��6#   $��1��6]   $��1��6m    6=   �� *Lesson+6m   �� 5"   
   -   5        $��CbClassroom��5"      $ Number��6&   $��1��6d   $��2��6t    6A   �� *	Classroom+6t   �� 5#   
   -   5        $��	CbTeacher��5#      $ Title��6$   $��1��6_   $��3��6o    6>   �� *	Teacher+6o   (  "System.Windows.Controls.DatePicker  5$   
   $��4��63   $��1��6@      SelectedDate 6   �� *Date+6@   �� 5&   
   -   5        $��BtnSave��5&   _   $��Сохранить��6   $��2��6%   $��10��69   $��30��6G   $	��175��6S   $	��0 5q�6�   ���#d4d0d66�   5'      5(      