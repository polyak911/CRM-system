   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRMCRM  5          CRM.Calendar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:CRM     5      -   5          >�Name$  
p_Calendar��5	      .��5
      � -   5         �Name$ G1��5
       � ColumnDefinitions 5   
   �� 5      $	��240 �6   �� 5      .+�5   
   �� ���	#FF505883$��0,0,0,-4q�6(   $��1��6:   $��2,0,0,0q�6J   �� 5   
    �� Orientation$ 
Horizontal=�6   $��87��6.   $	��Top=�6:   $��1��6R   $��	5,9,-78,0q�6b   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_Calendar��5      $��14,100,12,10q�6)   $��1��6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Менеджер��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6>   .@�5      �� $��1��6    �� Orientation$ 
Horizontal=�6(   $
��Left=�6A   $��177,580,0,0q�6\   $	��Top=�6q   5      5      5      