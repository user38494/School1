   M S B A M L   `   `   `  ����B  >School1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:School1School1  5          School1.ClassPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:School1     5        N� Title$  	ClassPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridClasses��5         
IsReadOnly .    AutoGenerateColumns .  $
��auto��6W      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$
 Name��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Title+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   ���#d4d0d6$
��Bold"�6g   $��30��6y   5      5      5      �� 5   
   
 �� Orientation$
 
Horizontal=�6   $��1��6.   .+�5      �� -   5         ��Name$ BtnAdd��5   P   $��Добавить��6   $��1��6(   $
��Left=�65   $��5 0 5 0q�6u   $	��150��6�   $��35��6�   $
��Bold"�6�   ���#9463d06�   �� 5      -   5        $ 	BtnDelete��5   P   $��Удалить��6   $��1��6'   $��Right=�64   $��5 0 5 0q�6{   $	��150��6�   $��35��6�   $
��Bold"�6�   ���#9463d06�   5      5       5!      