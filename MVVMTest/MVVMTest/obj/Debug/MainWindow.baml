   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	    MVVMTest   MVVMTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      ��%    5      .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   .+�5   
   �� $��Zipcode��6   $��Center=�6#   �� 5   
   $��	City name��6   $��1��6%   $��Center=�62   �� 5   
   -   5        $��txtCode��5      $��1��6!   $��5q�62   ��6=   ��  �� Path$
 Code�.��6X   .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ 
MouseEnter��6!   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ClearTextCommand+5      .��5   &   5      �� 5   
   -   5        $��txtCity��5      $��1��6!   $��1��6.   $��5q�6>   ��6I   �� $
 City�.��6d    5        5      $ 
MouseEnter��6!   . 5         6,   �� *ClearText1Command+5       .��5!   &   5"      �� 5#   
   $��2��65   $��1��6B   $��Add new��6R   ��6   �� $ 
AddCommand�6f   �� 5$   
   $��2��6;   $��0��6H   $��Add Sampledata��6X   ��6   �� $ AddSampleCommand�6s   5&      5'      